namespace WifiCat
{
    partial class FormInstallNetwork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstallNetwork));
            this.tb_username = new System.Windows.Forms.TextBox();
            this.b_install_network = new System.Windows.Forms.Button();
            this.l_user = new System.Windows.Forms.Label();
            this.l_password = new System.Windows.Forms.Label();
            this.b_about = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l_wifiinterface = new System.Windows.Forms.Label();
            this.cb_wifiinterface = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.AccessibleDescription = "Textbox";
            this.tb_username.AccessibleName = "Username Textbox";
            this.tb_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_username.Location = new System.Drawing.Point(108, 155);
            this.tb_username.Name = "tb_username";
            this.tb_username.ShortcutsEnabled = false;
            this.tb_username.Size = new System.Drawing.Size(163, 20);
            this.tb_username.TabIndex = 1;
            this.tb_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_username_KeyDown);
            // 
            // b_install_network
            // 
            this.b_install_network.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_install_network.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_install_network.Location = new System.Drawing.Point(12, 254);
            this.b_install_network.Name = "b_install_network";
            this.b_install_network.Size = new System.Drawing.Size(260, 23);
            this.b_install_network.TabIndex = 3;
            this.b_install_network.Text = "&Install Network";
            this.b_install_network.UseVisualStyleBackColor = true;
            this.b_install_network.Click += new System.EventHandler(this.b_install_network_Click);
            // 
            // l_user
            // 
            this.l_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_user.AutoSize = true;
            this.l_user.Location = new System.Drawing.Point(12, 158);
            this.l_user.Name = "l_user";
            this.l_user.Size = new System.Drawing.Size(55, 13);
            this.l_user.TabIndex = 4;
            this.l_user.Text = "Username";
            // 
            // l_password
            // 
            this.l_password.AccessibleDescription = "";
            this.l_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_password.AutoSize = true;
            this.l_password.Location = new System.Drawing.Point(11, 185);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(53, 13);
            this.l_password.TabIndex = 5;
            this.l_password.Text = "Password";
            // 
            // b_about
            // 
            this.b_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_about.Location = new System.Drawing.Point(244, 284);
            this.b_about.Name = "b_about";
            this.b_about.Size = new System.Drawing.Size(27, 23);
            this.b_about.TabIndex = 0;
            this.b_about.TabStop = false;
            this.b_about.Text = "&?";
            this.b_about.UseVisualStyleBackColor = true;
            // 
            // b_close
            // 
            this.b_close.AccessibleDescription = "Button";
            this.b_close.AccessibleName = "Exit Button";
            this.b_close.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.b_close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_close.Location = new System.Drawing.Point(12, 284);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(226, 23);
            this.b_close.TabIndex = 4;
            this.b_close.Text = "E&xit";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // tb_password
            // 
            this.tb_password.AccessibleDescription = "Textbox";
            this.tb_password.AccessibleName = "Password Textbox";
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password.Location = new System.Drawing.Point(108, 182);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.ShortcutsEnabled = false;
            this.tb_password.Size = new System.Drawing.Size(163, 20);
            this.tb_password.TabIndex = 2;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_password_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WifiCat.Properties.Resources.wifi_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // l_wifiinterface
            // 
            this.l_wifiinterface.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_wifiinterface.AutoSize = true;
            this.l_wifiinterface.Location = new System.Drawing.Point(12, 230);
            this.l_wifiinterface.Name = "l_wifiinterface";
            this.l_wifiinterface.Size = new System.Drawing.Size(70, 13);
            this.l_wifiinterface.TabIndex = 6;
            this.l_wifiinterface.Text = "Wifi Interface";
            // 
            // cb_wifiinterface
            // 
            this.cb_wifiinterface.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_wifiinterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_wifiinterface.FormattingEnabled = true;
            this.cb_wifiinterface.Location = new System.Drawing.Point(109, 227);
            this.cb_wifiinterface.Name = "cb_wifiinterface";
            this.cb_wifiinterface.Size = new System.Drawing.Size(162, 21);
            this.cb_wifiinterface.TabIndex = 7;
            // 
            // FormInstallNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 313);
            this.Controls.Add(this.cb_wifiinterface);
            this.Controls.Add(this.l_wifiinterface);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.b_about);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.l_user);
            this.Controls.Add(this.b_install_network);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInstallNetwork";
            this.Text = "Wifi CAT";
            this.Load += new System.EventHandler(this.FormInstallNetwork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button b_install_network;
        private System.Windows.Forms.Label l_user;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Button b_about;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label l_wifiinterface;
        private System.Windows.Forms.ComboBox cb_wifiinterface;
    }
}

