namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.m_start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.m_username = new System.Windows.Forms.Label();
            this.t_username = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.m_password = new System.Windows.Forms.Label();
            this.t_password = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.m_speed = new System.Windows.Forms.Label();
            this.t_speed = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.t_op_min = new System.Windows.Forms.NumericUpDown();
            this.t_op_max = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.t_break_min = new System.Windows.Forms.NumericUpDown();
            this.t_break_max = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.t_settings = new System.Windows.Forms.Label();
            this.c_auto = new System.Windows.Forms.CheckBox();
            this.c_adprize = new System.Windows.Forms.CheckBox();
            this.c_break = new System.Windows.Forms.CheckBox();
            this.c_close = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.m_browser = new System.Windows.Forms.Label();
            this.r_firefox = new System.Windows.Forms.RadioButton();
            this.r_chrome = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.m_save = new System.Windows.Forms.Button();
            this.m_reset = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_speed)).BeginInit();
            this.flowLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_op_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_op_max)).BeginInit();
            this.flowLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_break_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_break_max)).BeginInit();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_start
            // 
            this.m_start.Font = new System.Drawing.Font("Arial", 14F);
            this.m_start.Location = new System.Drawing.Point(3, 192);
            this.m_start.Name = "m_start";
            this.m_start.Size = new System.Drawing.Size(170, 51);
            this.m_start.TabIndex = 0;
            this.m_start.Text = "Start !";
            this.m_start.UseVisualStyleBackColor = true;
            this.m_start.Click += new System.EventHandler(this.m_button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Neobot2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 183);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.m_start);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(179, 252);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.progressBar);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(490, 373);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel11);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(188, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(295, 332);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.m_username);
            this.flowLayoutPanel4.Controls.Add(this.t_username);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(292, 27);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // m_username
            // 
            this.m_username.AutoSize = true;
            this.m_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_username.Location = new System.Drawing.Point(3, 0);
            this.m_username.Name = "m_username";
            this.m_username.Size = new System.Drawing.Size(81, 17);
            this.m_username.TabIndex = 0;
            this.m_username.Text = "Username :";
            this.m_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // t_username
            // 
            this.t_username.Location = new System.Drawing.Point(90, 3);
            this.t_username.Name = "t_username";
            this.t_username.Size = new System.Drawing.Size(139, 20);
            this.t_username.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.m_password);
            this.flowLayoutPanel5.Controls.Add(this.t_password);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 36);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(292, 30);
            this.flowLayoutPanel5.TabIndex = 1;
            // 
            // m_password
            // 
            this.m_password.AutoSize = true;
            this.m_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_password.Location = new System.Drawing.Point(3, 0);
            this.m_password.Name = "m_password";
            this.m_password.Size = new System.Drawing.Size(77, 17);
            this.m_password.TabIndex = 0;
            this.m_password.Text = "Password :";
            // 
            // t_password
            // 
            this.t_password.Location = new System.Drawing.Point(86, 3);
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(143, 20);
            this.t_password.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.m_speed);
            this.flowLayoutPanel6.Controls.Add(this.t_speed);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 72);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(292, 26);
            this.flowLayoutPanel6.TabIndex = 2;
            // 
            // m_speed
            // 
            this.m_speed.AutoSize = true;
            this.m_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_speed.Location = new System.Drawing.Point(3, 0);
            this.m_speed.Name = "m_speed";
            this.m_speed.Size = new System.Drawing.Size(93, 17);
            this.m_speed.TabIndex = 0;
            this.m_speed.Text = "Speed (in s) :";
            this.m_speed.Click += new System.EventHandler(this.m_speed_Click);
            // 
            // t_speed
            // 
            this.t_speed.Location = new System.Drawing.Point(102, 3);
            this.t_speed.Name = "t_speed";
            this.t_speed.Size = new System.Drawing.Size(127, 20);
            this.t_speed.TabIndex = 1;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.label1);
            this.flowLayoutPanel9.Controls.Add(this.t_op_min);
            this.flowLayoutPanel9.Controls.Add(this.t_op_max);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(3, 104);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(292, 27);
            this.flowLayoutPanel9.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rand opening time";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // t_op_min
            // 
            this.t_op_min.Location = new System.Drawing.Point(136, 3);
            this.t_op_min.Name = "t_op_min";
            this.t_op_min.Size = new System.Drawing.Size(44, 20);
            this.t_op_min.TabIndex = 7;
            this.t_op_min.Maximum = 9999;
            this.t_op_min.Minimum = 0;
            // 
            // t_op_max
            // 
            this.t_op_max.Location = new System.Drawing.Point(186, 3);
            this.t_op_max.Name = "t_op_max";
            this.t_op_max.Size = new System.Drawing.Size(43, 20);
            this.t_op_max.TabIndex = 8;
            this.t_op_max.Maximum = 9999;
            this.t_op_max.Minimum = 0;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.label2);
            this.flowLayoutPanel10.Controls.Add(this.t_break_min);
            this.flowLayoutPanel10.Controls.Add(this.t_break_max);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(3, 137);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(292, 29);
            this.flowLayoutPanel10.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rand break time    ";
            // 
            // t_break_min
            // 
            this.t_break_min.Location = new System.Drawing.Point(137, 3);
            this.t_break_min.Name = "t_break_min";
            this.t_break_min.Size = new System.Drawing.Size(43, 20);
            this.t_break_min.TabIndex = 1;
            this.t_break_min.Maximum = 9999;
            this.t_break_min.Minimum = 0;
            // 
            // t_break_max
            // 
            this.t_break_max.Location = new System.Drawing.Point(186, 3);
            this.t_break_max.Name = "t_break_max";
            this.t_break_max.Size = new System.Drawing.Size(43, 20);
            this.t_break_max.TabIndex = 2;
            this.t_break_max.Maximum = 9999;
            this.t_break_max.Minimum = 0;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.t_settings);
            this.flowLayoutPanel8.Controls.Add(this.c_auto);
            this.flowLayoutPanel8.Controls.Add(this.c_adprize);
            this.flowLayoutPanel8.Controls.Add(this.c_break);
            this.flowLayoutPanel8.Controls.Add(this.c_close);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 172);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(109, 110);
            this.flowLayoutPanel8.TabIndex = 4;
            // 
            // t_settings
            // 
            this.t_settings.AutoSize = true;
            this.t_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.t_settings.Location = new System.Drawing.Point(3, 0);
            this.t_settings.Name = "t_settings";
            this.t_settings.Size = new System.Drawing.Size(67, 17);
            this.t_settings.TabIndex = 0;
            this.t_settings.Text = "Settings :";
            // 
            // c_auto
            // 
            this.c_auto.AutoSize = true;
            this.c_auto.Location = new System.Drawing.Point(3, 20);
            this.c_auto.Name = "c_auto";
            this.c_auto.Size = new System.Drawing.Size(86, 17);
            this.c_auto.TabIndex = 2;
            this.c_auto.Text = "Full Auto Bot";
            this.c_auto.UseVisualStyleBackColor = true;
            // 
            // c_adprize
            // 
            this.c_adprize.AutoSize = true;
            this.c_adprize.Enabled = false;
            this.c_adprize.Location = new System.Drawing.Point(3, 43);
            this.c_adprize.Name = "c_adprize";
            this.c_adprize.Size = new System.Drawing.Size(66, 17);
            this.c_adprize.TabIndex = 1;
            this.c_adprize.Text = "Adprizes";
            this.c_adprize.UseVisualStyleBackColor = true;
            // 
            // c_break
            // 
            this.c_break.AutoSize = true;
            this.c_break.Location = new System.Drawing.Point(3, 66);
            this.c_break.Name = "c_break";
            this.c_break.Size = new System.Drawing.Size(54, 17);
            this.c_break.TabIndex = 3;
            this.c_break.Text = "Break";
            this.c_break.UseVisualStyleBackColor = true;
            // 
            // c_close
            // 
            this.c_close.AutoSize = true;
            this.c_close.Location = new System.Drawing.Point(3, 89);
            this.c_close.Name = "c_close";
            this.c_close.Size = new System.Drawing.Size(93, 17);
            this.c_close.TabIndex = 4;
            this.c_close.Text = "Close Browser";
            this.c_close.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.m_browser);
            this.flowLayoutPanel7.Controls.Add(this.r_firefox);
            this.flowLayoutPanel7.Controls.Add(this.r_chrome);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(118, 172);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(114, 89);
            this.flowLayoutPanel7.TabIndex = 3;
            // 
            // m_browser
            // 
            this.m_browser.AutoSize = true;
            this.m_browser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_browser.Location = new System.Drawing.Point(3, 0);
            this.m_browser.Name = "m_browser";
            this.m_browser.Size = new System.Drawing.Size(67, 17);
            this.m_browser.TabIndex = 0;
            this.m_browser.Text = "Browser :";
            // 
            // r_firefox
            // 
            this.r_firefox.AutoSize = true;
            this.r_firefox.Location = new System.Drawing.Point(3, 20);
            this.r_firefox.Name = "r_firefox";
            this.r_firefox.Size = new System.Drawing.Size(56, 17);
            this.r_firefox.TabIndex = 1;
            this.r_firefox.TabStop = true;
            this.r_firefox.Text = "Firefox";
            this.r_firefox.UseVisualStyleBackColor = true;
            // 
            // r_chrome
            // 
            this.r_chrome.AutoSize = true;
            this.r_chrome.Enabled = false;
            this.r_chrome.Location = new System.Drawing.Point(3, 43);
            this.r_chrome.Name = "r_chrome";
            this.r_chrome.Size = new System.Drawing.Size(98, 17);
            this.r_chrome.TabIndex = 2;
            this.r_chrome.TabStop = true;
            this.r_chrome.Text = "Google Chrome";
            this.r_chrome.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(this.m_save);
            this.flowLayoutPanel11.Controls.Add(this.m_reset);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(3, 288);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(292, 42);
            this.flowLayoutPanel11.TabIndex = 9;
            // 
            // m_save
            // 
            this.m_save.Location = new System.Drawing.Point(3, 3);
            this.m_save.Name = "m_save";
            this.m_save.Size = new System.Drawing.Size(105, 33);
            this.m_save.TabIndex = 5;
            this.m_save.Text = "Save Settings";
            this.m_save.UseVisualStyleBackColor = true;
            this.m_save.Click += new System.EventHandler(this.m_save_Click);
            // 
            // m_reset
            // 
            this.m_reset.Location = new System.Drawing.Point(114, 3);
            this.m_reset.Name = "m_reset";
            this.m_reset.Size = new System.Drawing.Size(115, 33);
            this.m_reset.TabIndex = 4;
            this.m_reset.Text = "Reset Settings";
            this.m_reset.UseVisualStyleBackColor = true;
            this.m_reset.Click += new System.EventHandler(this.m_reset_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 341);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(417, 26);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 4;
            // 
            // Form1
            // 
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form1_Closing);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 395);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NeoBot 2.1 (By Linktag)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_speed)).EndInit();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_op_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_op_max)).EndInit();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_break_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_break_max)).EndInit();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label m_username;
        private System.Windows.Forms.TextBox t_username;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label m_password;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label m_speed;
        private System.Windows.Forms.NumericUpDown t_speed;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label t_settings;
        private System.Windows.Forms.CheckBox c_adprize;
        private System.Windows.Forms.Button m_save;
        private System.Windows.Forms.CheckBox c_auto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox c_break;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.NumericUpDown t_op_min;
        private System.Windows.Forms.NumericUpDown t_op_max;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown t_break_min;
        private System.Windows.Forms.NumericUpDown t_break_max;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label m_browser;
        private System.Windows.Forms.RadioButton r_firefox;
        private System.Windows.Forms.RadioButton r_chrome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.Button m_reset;
        private System.Windows.Forms.CheckBox c_close;
    }
}

