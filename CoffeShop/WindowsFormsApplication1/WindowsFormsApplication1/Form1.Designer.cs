namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.usernamelevel = new System.Windows.Forms.Label();
            this.passwordlevel = new System.Windows.Forms.Label();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // usernamelevel
            // 
            this.usernamelevel.AutoSize = true;
            this.usernamelevel.BackColor = System.Drawing.Color.Transparent;
            this.usernamelevel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.usernamelevel.ForeColor = System.Drawing.Color.White;
            this.usernamelevel.Location = new System.Drawing.Point(107, 66);
            this.usernamelevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernamelevel.Name = "usernamelevel";
            this.usernamelevel.Size = new System.Drawing.Size(110, 24);
            this.usernamelevel.TabIndex = 0;
            this.usernamelevel.Text = "USER NAME";
            this.usernamelevel.Click += new System.EventHandler(this.Usernamelevel_Click);
            // 
            // passwordlevel
            // 
            this.passwordlevel.AutoSize = true;
            this.passwordlevel.BackColor = System.Drawing.Color.Transparent;
            this.passwordlevel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.passwordlevel.ForeColor = System.Drawing.Color.White;
            this.passwordlevel.Location = new System.Drawing.Point(105, 149);
            this.passwordlevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordlevel.Name = "passwordlevel";
            this.passwordlevel.Size = new System.Drawing.Size(106, 24);
            this.passwordlevel.TabIndex = 1;
            this.passwordlevel.Text = "PASSWORD";
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(236, 68);
            this.usernametextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(307, 22);
            this.usernametextbox.TabIndex = 2;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(236, 151);
            this.passwordtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(307, 22);
            this.passwordtextbox.TabIndex = 3;
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.Location = new System.Drawing.Point(293, 201);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(4);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(164, 59);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "LOG IN";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 356);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.passwordlevel);
            this.Controls.Add(this.usernamelevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "LOG IN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamelevel;
        private System.Windows.Forms.Label passwordlevel;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
    }
}

