namespace WindowsFormsApplication1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemnumber = new System.Windows.Forms.TextBox();
            this.itemname = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.TextBox();
            this.itemgridview = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.updateitem = new System.Windows.Forms.Button();
            this.deleteitem = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM NUMBER(AUTO GENERATE)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ITEM NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRICE ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "DISCOUNT";
            // 
            // itemnumber
            // 
            this.itemnumber.Location = new System.Drawing.Point(319, 49);
            this.itemnumber.Margin = new System.Windows.Forms.Padding(4);
            this.itemnumber.Name = "itemnumber";
            this.itemnumber.Size = new System.Drawing.Size(125, 22);
            this.itemnumber.TabIndex = 4;
            // 
            // itemname
            // 
            this.itemname.Location = new System.Drawing.Point(213, 107);
            this.itemname.Margin = new System.Windows.Forms.Padding(4);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(231, 22);
            this.itemname.TabIndex = 5;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(213, 172);
            this.price.Margin = new System.Windows.Forms.Padding(4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(231, 22);
            this.price.TabIndex = 6;
            // 
            // discount
            // 
            this.discount.Location = new System.Drawing.Point(213, 225);
            this.discount.Margin = new System.Windows.Forms.Padding(4);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(231, 22);
            this.discount.TabIndex = 7;
            // 
            // itemgridview
            // 
            this.itemgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemgridview.Location = new System.Drawing.Point(528, 15);
            this.itemgridview.Margin = new System.Windows.Forms.Padding(4);
            this.itemgridview.Name = "itemgridview";
            this.itemgridview.Size = new System.Drawing.Size(821, 345);
            this.itemgridview.TabIndex = 8;
            this.itemgridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.itemgridview_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(59, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "INSERT ITEM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateitem
            // 
            this.updateitem.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.updateitem.Location = new System.Drawing.Point(273, 330);
            this.updateitem.Margin = new System.Windows.Forms.Padding(4);
            this.updateitem.Name = "updateitem";
            this.updateitem.Size = new System.Drawing.Size(145, 66);
            this.updateitem.TabIndex = 10;
            this.updateitem.Text = "UPDATE ITEM";
            this.updateitem.UseVisualStyleBackColor = true;
            this.updateitem.Click += new System.EventHandler(this.updateitem_Click);
            // 
            // deleteitem
            // 
            this.deleteitem.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.deleteitem.Location = new System.Drawing.Point(59, 448);
            this.deleteitem.Margin = new System.Windows.Forms.Padding(4);
            this.deleteitem.Name = "deleteitem";
            this.deleteitem.Size = new System.Drawing.Size(145, 66);
            this.deleteitem.TabIndex = 11;
            this.deleteitem.Text = "REMOVE ITEM";
            this.deleteitem.UseVisualStyleBackColor = true;
            this.deleteitem.Click += new System.EventHandler(this.deleteitem_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.clearbutton.Location = new System.Drawing.Point(273, 448);
            this.clearbutton.Margin = new System.Windows.Forms.Padding(4);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(145, 66);
            this.clearbutton.TabIndex = 12;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.logout.Location = new System.Drawing.Point(273, 561);
            this.logout.Margin = new System.Windows.Forms.Padding(4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(145, 66);
            this.logout.TabIndex = 13;
            this.logout.Text = "LOG OUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // backbutton
            // 
            this.backbutton.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.backbutton.Location = new System.Drawing.Point(59, 561);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(145, 66);
            this.backbutton.TabIndex = 14;
            this.backbutton.Text = "GO BACK";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fresh_coffee_beans_brewing_4017496;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1365, 682);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.deleteitem);
            this.Controls.Add(this.updateitem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.itemgridview);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.price);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.itemnumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "ITEMS";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemnumber;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.DataGridView itemgridview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateitem;
        private System.Windows.Forms.Button deleteitem;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button backbutton;
    }
}