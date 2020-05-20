namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.usrntextbox = new System.Windows.Forms.TextBox();
            this.passtextbox = new System.Windows.Forms.TextBox();
            this.plabel = new System.Windows.Forms.Label();
            this.positiontextbox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.usrgridview = new System.Windows.Forms.DataGridView();
            this.remove = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.gotoitemtable = new System.Windows.Forms.Button();
            this.gotoselltable = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usrgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = " UNIQUE ID(AUTO GENERATE)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "USER NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(268, 59);
            this.idtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(237, 22);
            this.idtextbox.TabIndex = 3;
            // 
            // usrntextbox
            // 
            this.usrntextbox.Location = new System.Drawing.Point(141, 126);
            this.usrntextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usrntextbox.Name = "usrntextbox";
            this.usrntextbox.Size = new System.Drawing.Size(364, 22);
            this.usrntextbox.TabIndex = 4;
            // 
            // passtextbox
            // 
            this.passtextbox.Location = new System.Drawing.Point(141, 188);
            this.passtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passtextbox.Name = "passtextbox";
            this.passtextbox.Size = new System.Drawing.Size(364, 22);
            this.passtextbox.TabIndex = 5;
            // 
            // plabel
            // 
            this.plabel.AutoSize = true;
            this.plabel.BackColor = System.Drawing.Color.Transparent;
            this.plabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.plabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plabel.Location = new System.Drawing.Point(16, 249);
            this.plabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plabel.Name = "plabel";
            this.plabel.Size = new System.Drawing.Size(80, 21);
            this.plabel.TabIndex = 6;
            this.plabel.Text = "POSITION";
            // 
            // positiontextbox
            // 
            this.positiontextbox.Location = new System.Drawing.Point(141, 245);
            this.positiontextbox.Margin = new System.Windows.Forms.Padding(4);
            this.positiontextbox.Name = "positiontextbox";
            this.positiontextbox.Size = new System.Drawing.Size(364, 22);
            this.positiontextbox.TabIndex = 7;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(141, 449);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(200, 47);
            this.add.TabIndex = 8;
            this.add.Text = "ADD USER";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.update.Location = new System.Drawing.Point(415, 449);
            this.update.Margin = new System.Windows.Forms.Padding(4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(200, 47);
            this.update.TabIndex = 8;
            this.update.Text = "UPDATE USER";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.button3_Click);
            // 
            // usrgridview
            // 
            this.usrgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usrgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usrgridview.Location = new System.Drawing.Point(547, 15);
            this.usrgridview.Margin = new System.Windows.Forms.Padding(4);
            this.usrgridview.Name = "usrgridview";
            this.usrgridview.Size = new System.Drawing.Size(876, 394);
            this.usrgridview.TabIndex = 11;
            this.usrgridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.usrgridview_CellMouseClick);
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.remove.Location = new System.Drawing.Point(679, 449);
            this.remove.Margin = new System.Windows.Forms.Padding(4);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(200, 47);
            this.remove.TabIndex = 8;
            this.remove.Text = "REMOVE USER";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.button4_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.clear.Location = new System.Drawing.Point(932, 502);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(200, 47);
            this.clear.TabIndex = 8;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button5_Click);
            // 
            // gotoitemtable
            // 
            this.gotoitemtable.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.gotoitemtable.Location = new System.Drawing.Point(141, 553);
            this.gotoitemtable.Margin = new System.Windows.Forms.Padding(4);
            this.gotoitemtable.Name = "gotoitemtable";
            this.gotoitemtable.Size = new System.Drawing.Size(200, 47);
            this.gotoitemtable.TabIndex = 8;
            this.gotoitemtable.Text = "CHECK ITEM";
            this.gotoitemtable.UseVisualStyleBackColor = true;
            this.gotoitemtable.Click += new System.EventHandler(this.gotoitemtable_Click);
            // 
            // gotoselltable
            // 
            this.gotoselltable.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.gotoselltable.Location = new System.Drawing.Point(410, 553);
            this.gotoselltable.Margin = new System.Windows.Forms.Padding(4);
            this.gotoselltable.Name = "gotoselltable";
            this.gotoselltable.Size = new System.Drawing.Size(200, 47);
            this.gotoselltable.TabIndex = 8;
            this.gotoselltable.Text = "CHECK SELL";
            this.gotoselltable.UseVisualStyleBackColor = true;
            this.gotoselltable.Click += new System.EventHandler(this.gotoselltable_Click);
            // 
            // backbutton
            // 
            this.backbutton.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.backbutton.Location = new System.Drawing.Point(679, 553);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(200, 47);
            this.backbutton.TabIndex = 8;
            this.backbutton.Text = "LOG OUT";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.top_view_photo_of_coffee_near_tablet_1749303;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1468, 721);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.gotoselltable);
            this.Controls.Add(this.gotoitemtable);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.usrgridview);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.positiontextbox);
            this.Controls.Add(this.plabel);
            this.Controls.Add(this.passtextbox);
            this.Controls.Add(this.usrntextbox);
            this.Controls.Add(this.idtextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usrgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.TextBox usrntextbox;
        private System.Windows.Forms.TextBox passtextbox;
        private System.Windows.Forms.Label plabel;
        private System.Windows.Forms.TextBox positiontextbox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView usrgridview;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button gotoitemtable;
        private System.Windows.Forms.Button gotoselltable;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label1;
    }
}