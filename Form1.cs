using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        Thread tacheBot;

        public Form1()
        {
            InitializeComponent();
            InitialiserFenetre();
            if (lireFichier("data")[6] == "0")
            {
                MessageBox.Show("This bot is FREE and OPEN SOURCE, it can be download here : https://github.com/linktag/NeoBot \nIf you bought this programm, pls report the seller to Linktag17 on Nulled.io and ask for a refund", "NeoBot By Linktag for NULLED v2.0");
            }
            else
            {
                m_start.Enabled = false;//On désactive le bouton
                m_start.Text = "Bot is running";
                tacheBot = new Thread(new ThreadStart(BotMain));
                tacheBot.Start();
            }
            
        }

        private void m_button1_Click(object sender, EventArgs e)
        {
            m_start.Enabled = false;//On désactive le bouton
            m_start.Text = "Bot is running";
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
                FirefoxDriver driver = new FirefoxDriver();
                driver.Navigate().GoToUrl("https://www.neobux.com/m/l/?vl=1062F974ABAAB97FF378E7C9964A55B1");//on se rend sur la page

                //On se connecte
                driver.FindElementById("Kf1").SendKeys(infos[0]);//username
                driver.FindElementById("Kf2").SendKeys(infos[1]);//password
                wait(2, 7);
                driver.FindElementById("botao_login").Click();

                //On attend
                wait(10, 15);

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
                        //On commence par attendre
                        int j = 0;

                        if (Int32.TryParse(infos[2], out j))//On convertit en int
                        {
                            //Puis on clique

                            if (!estPresent(driver, By.XPath("//div[@id='da" + i.ToString() + "a']/div[@class='ad0']")))//Si l'annonce n'est pas de type "transparent" (quelle n'a aps déja été vue)
                            {
                                wait(j, j);
                                //On clique
                                clicker(driver, ("da" + i.ToString() + "a"), ("//span[@id='da" + i.ToString() + "c']/a[1]"), "//table[@id='o1'][@style='display:none;']", Int32.Parse(infos[2]));

                                //On voit pour une pause
                                if (infos[4] == "1")
                                { pause(); }
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

                //On a finit !
                m_start.Text = "Finnished !";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void pause()
        {

        }

        private void clicker(FirefoxDriver driver, string id, string id_rouge, string bouton_final_absent, int speed)
        {
            //On va reperer le lien qui nous mene vers une nouvelle feetre
            string currentHandle = driver.CurrentWindowHandle;
            if (id_rouge != "0")//Si l'on s'occupe d'une pub normal
            {
                driver.FindElementById(id).Click();//On clique sur l'annonce
                wait(0, 3);
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
            wait(1 + speed, 1 + speed);
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
            //on vérifie déja si le temps n'est pas fix
            if (min == max)
            {
                System.Threading.Thread.Sleep(min * 1000);
            }
            else
            {
                Random rnd = new Random();
                System.Threading.Thread.Sleep(rnd.Next(min, max + 1) * 1000);
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
            //On doit enregistrer dans le fichier les settings
            string ligne = this.t_username.Text + "\n" + this.t_password.Text + "\n" + this.t_speed.Value + "\n";

            if (this.c_adprize.Checked)
            { ligne += "1\n"; }
            else
            { ligne += "0\n"; }

            ligne += "1\n2\n";

            if (this.c_auto.Checked)
            { ligne += "1\n"; }
            else
            { ligne += "0\n"; }

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
            if (infos[1] == "1")
            { this.r_chrome.Checked = true; }
            else
            { this.r_firefox.Checked = true; }
            if (infos[6] == "1")
            { this.c_auto.Checked = true; }
            else
            { this.c_auto.Checked = false; }
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
    }
}
