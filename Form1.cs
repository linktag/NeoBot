using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private Thread tacheBot;
        private List<int> listAlea;

        public Form1()
        {
            InitializeComponent();
            InitialiserFenetre();
            listAlea = new List<int>();
            tacheBot = new Thread(new ThreadStart(BotMain));

            if (lireFichier("data")[6] == "0")
            {
                MessageBox.Show("This bot is FREE and OPEN SOURCE, it can be download here : https://github.com/linktag/NeoBot \nIf you bought this programm, pls report the seller to Linktag17 on Nulled.io and ask for a refund", "NeoBot By Linktag for NULLED v2.0");
            }
            else
            {
                m_start.Enabled = false;//On désactive le bouton
                m_start.Text = "Waiting opening time";
                tacheBot.Start();
            }
            
        }

        private void m_button1_Click(object sender, EventArgs e)
        {
            //On attend

            m_start.Enabled = false;//On désactive le bouton
            m_start.Text = "Waiting opening time";
            tacheBot = new Thread(new ThreadStart(BotMain));
            tacheBot.Start();
        }

        private void BotMain()
        {
            try
            {
                List<string> infos = lireFichier("data");//On récupère les données
                if (infos[0] == "Erreur")
                { return; }
                //On attend
                wait(Int32.Parse(infos[9]), Int32.Parse(infos[10]));
                this.m_start.Text = "Bot is running";

                FirefoxDriver driver = new FirefoxDriver();
                driver.Navigate().GoToUrl("https://www.neobux.com/m/l/?vl=1062F974ABAAB97FF378E7C9964A55B1");//on se rend sur la page

                //On se connecte
                driver.FindElementById("Kf1").SendKeys(infos[0]);//username
                driver.FindElementById("Kf2").SendKeys(infos[1]);//password
                wait(10, 10);
                driver.FindElementById("botao_login").Click();

                //On attend
                wait(10, 10);

                //On va sur la page des pubs
                driver.FindElementByXPath("//td[@valign='bottom']/table/tbody/tr/td/a[@class='button green'][1]").Click();

                //On comtpe les pubs
                int nbAdds = 0;
                for (int i = 1; i != 0; i++)
                {
                    if (estPresent(driver, By.Id("da" + i.ToString() + "a")))
                    { nbAdds += 1; }
                    else
                    { break; }
                }

                //On adapte notre bar
                this.progressBar.Maximum = nbAdds;


                //On peut commencer
                if (nbAdds != 0)//Si il y a des pubs
                {
                    for (int i = 1; i <= nbAdds; i++)
                    {
                        
                        int j = 0;

                        if (Int32.TryParse(infos[2], out j))//On convertit en int
                        {

                            if (!estPresent(driver, By.XPath("//div[@id='da" + i.ToString() + "a']/div[@class='ad0']")))//Si l'annonce n'est pas de type "transparent" (quelle n'a aps déja été vue)
                            {
                                //On commence par attendre
                                if (j < 1)
                                { wait(0, j + 1); }
                                else
                                { wait(j - 1, j + 1); }

                                //On clique
                                clicker(driver, ("da" + i.ToString() + "a"), ("//span[@id='da" + i.ToString() + "c']/a[1]"), "//table[@id='o1'][@style='display:none;']", Int32.Parse(infos[2]));

                                //On voit pour une pause
                                if (infos[7] == "1")
                                { pause(infos); }
                            }
                        }
                        else
                        { erreur("ERROR : The speed in DATA file does not correspond."); return; }

                        //On a fait un tour de boucle, on augmente notre Barre de progression
                        progressBar.PerformStep();
                    }
                }

                //On en a finit avec les pubs on passe aux addprizes

                driver.Navigate().Refresh();

                if (estPresent(driver, By.XPath("//a[@class='button small2 blue']/span[1]")) && infos[3]=="1")
                {
                    driver.FindElementByXPath("//a[@class='button small2 blue']/span[1]");
                    int nb_adprize = Int32.Parse(driver.FindElementByXPath("//span[@id='ap_hct']/a[1]").Text);

                    this.progressBar.Value = 0;
                    this.progressBar.Maximum = nb_adprize;

                    for (int i = 1; i <= nb_adprize; i++)
                    {
                        clicker(driver, "ap_hct", "0", "//table[@id='prm0'][@style='padding-bottom:5px;display:none;']", Int32.Parse(infos[2]));
                        this.progressBar.PerformStep();
                    }
                }

                //On ferme les navigateurs

                driver.Close();


                if (infos[8] == "1")
                {
                    Process[] AllProcesses = Process.GetProcesses();
                    foreach (var process in AllProcesses)
                    {
                        if (process.MainWindowTitle != "")
                        {
                            string s = process.ProcessName.ToLower();
                            if (s == "firefox")
                                { process.Kill(); }
                        }
                    }
                }

                //On a finit !
                m_start.Text = "Finnished !";

                //On ferme si nécessaire
                if (infos[6] == "1")
                {
                    Application.Exit();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void pause(List<string> infos)
        {
            //on tente de faire une pause
            Random rnd = new Random();
            if(rnd.Next(20) == 17)
            { wait(Int32.Parse(infos[11]), Int32.Parse(infos[12])); }

        }

        private void clicker(FirefoxDriver driver, string id, string id_rouge, string bouton_final_absent, int speed)
        {
            //On va reperer le lien qui nous mene vers une nouvelle feetre
            string currentHandle = driver.CurrentWindowHandle;
            if (id_rouge != "0")//Si l'on s'occupe d'une pub normal
            {
                driver.FindElementById(id).Click();//On clique sur l'annonce
                wait(1, 3);
                IWebElement element = driver.FindElementByXPath(id_rouge);
                PopupWindowFinder finder = new PopupWindowFinder(driver);
                string popupWindowHandle = finder.Click(element);
                driver.SwitchTo().Window(popupWindowHandle);
            }
            else //Si c'est une adprize
            {
                IWebElement element = driver.FindElementById(id);
                PopupWindowFinder finder = new PopupWindowFinder(driver);
                string popupWindowHandle = finder.Click(element);
                driver.SwitchTo().Window(popupWindowHandle);
            }
            
            //On fait une boucle pour ne pas attendre plus de 3 mins (si la pub a crash)
            DateTime startingTime = DateTime.Now;
            wait(1, 3);
            bool pubVue = false;

            while (!three_minuts(startingTime) && !pubVue)
            {
                if (!estPresent(driver, By.XPath(bouton_final_absent)))
                {
                    driver.FindElementByCssSelector("a.button.small2.orange").Click();
                    pubVue = true;
                }
                else
                {
                    wait(1, 3);
                }
            }

            //On reveient a la fenetre d'origine
            driver.SwitchTo().Window(currentHandle);
        }

        private bool three_minuts(DateTime startingtime)
        {
            TimeSpan tempsEcoule = DateTime.Now.Subtract(startingtime);

            if (tempsEcoule.TotalSeconds > (3 * 60))
            { return true; }
            else
            { return false; }
        }

        private void wait(int min, int max)
        {
            //On convertit en milissecondes
            min = min * 1000;
            max = max * 1000;

            //On les tries
            if (min > max)
            {
                int i = min;
                min = max;
                max = i;
            }

            //on vérifie déja si le temps n'est pas fix
            if (min == max)
            {
                System.Threading.Thread.Sleep(min);
            }  
            else
            {
                string test = "";
                //On vérifie si la liste est celle qui existe déja, si non on la créer
                if (listAlea.FirstOrDefault() != min | listAlea.LastOrDefault() != max)
                {
                    listAlea.Clear();
                    //Dans ce cas on doit réécrire la liste
                    int milieu = (min + max) / 2;
                    int x = 5;

                    for (int i = min; i<= max; i++)
                    {
                        if (i<=milieu)
                        {
                            x = x + 1;
                            for (int j = 0; j <= (Math.Round(Math.Pow(x,(1/3)))*100); j++)
                            {
                                listAlea.Add(i);
                            }
                        }
                        else
                        {
                            x = x -1;
                            for (int j = 0; j <= (Math.Round(Math.Pow(x, (1 / 3))) *100); j++)
                            {
                                listAlea.Add(i);
                            }
                        }
                        test += i.ToString();
                    }
                    
                }

                //On a plu qu'a tirer un nombre au hasard dans cette liste

                Random rnd = new Random();

                var index = rnd.Next(0,(listAlea.Count-1));//On tire une position au hasard
                System.Threading.Thread.Sleep((listAlea[index]));//On attend autant de temps
            }
        }

        private bool estPresent(FirefoxDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private void erreur(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private List<string> lireFichier(string file)
        {
            string allData = "";
            List<string> infos = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(@file))
                {
                    allData = reader.ReadToEnd();
                    string[] mots = allData.Split('\n');

                    foreach (string i in mots)
                    {
                        infos.Add(i);
                    }
                }
            }
            catch (Exception ex)
            {
                erreur("Some datas are missing on data file : \n\n" + ex);
                infos.Add("Erreur");
            }
            return infos;
        }

        private void m_save_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            //On doit enregistrer dans le fichier les settings
            string ligne = this.t_username.Text + "\n" + this.t_password.Text + "\n" + this.t_speed.Value + "\n";

            if (this.c_adprize.Checked)//adprize
            { ligne += "1\n"; }
            else
            { ligne += "0\n"; }

            ligne += "1\n2\n";

            if (this.c_auto.Checked)//Auto
            { ligne += "1\n"; }
            else
            { ligne += "0\n"; }

            if (this.c_break.Checked)//Break
            { ligne += "1\n"; }
            else
            { ligne += "0\n"; }

            if (this.c_close.Checked)//Close
            { ligne += "1\n"; }
            else
            { ligne += "0\n"; }

            ligne += this.t_op_min.Value + "\n" + this.t_op_max.Value + "\n" + this.t_break_min.Value + "\n" + this.t_break_max.Value + "\n";

            //On ecrit
            try
            {
                using (StreamWriter writer = new StreamWriter("data"))
                {
                    writer.Write(ligne);
                    MessageBox.Show("Settings saved !");
                }
            }
            catch (Exception ex)
            {
                erreur("Cannot write in data file : \n\n" + ex);
            }
        }

        private void InitialiserFenetre()
        {
            List<string> infos = lireFichier("data");

            this.t_username.Text = infos[0];
            this.t_password.Text = infos[1];
            this.t_speed.Value = Int32.Parse(infos[2]);
            //See adprize
            //Make pause
            if (infos[5] == "1")
            { this.r_chrome.Checked = true; }
            else
            { this.r_firefox.Checked = true; }

            if (infos[6] == "1")//Auto
            { this.c_auto.Checked = true; }
            else
            { this.c_auto.Checked = false; }

            if (infos[7] == "1")//Break
            { this.c_break.Checked = true; }
            else
            { this.c_break.Checked = false; }

            if (infos[8] == "1")//Close
            { this.c_close.Checked = true; }
            else
            { this.c_close.Checked = false; }

            this.t_op_min.Value = Int32.Parse(infos[9]);
            this.t_op_max.Value = Int32.Parse(infos[10]);
            this.t_break_min.Value = Int32.Parse(infos[11]);
            this.t_break_max.Value = Int32.Parse(infos[12]);
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void m_speed_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        public void form1_Closing(Object sender, FormClosingEventArgs e)
        {
            try
            {
                if (tacheBot.IsAlive)
                {
                    tacheBot.Abort();
                }
            }
            catch (Exception ex)
            {

            }
            
        }

        private void m_reset_Click(object sender, EventArgs e)
        {
            //On reset les settings
            this.t_username.Text = "Linktag";
            this.t_password.Text = "Password";
            this.t_speed.Value = 2;
            this.r_firefox.Checked = true;
            this.c_auto.Checked = false;
            this.c_break.Checked = true;
            this.c_close.Checked = false;
            this.t_op_min.Value = 0;
            this.t_op_max.Value = 5*60;
            this.t_break_min.Value = 30;
            this.t_break_max.Value = 2*60;

            //On enregistre
            save();
        }
    }
}
