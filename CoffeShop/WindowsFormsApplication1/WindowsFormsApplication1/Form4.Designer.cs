namespace WindowsFormsApplication1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selleridtextbox = new System.Windows.Forms.TextBox();
            this.itemnumtextbox = new System.Windows.Forms.TextBox();
            this.quantitytextbox = new System.Windows.Forms.TextBox();
            this.discounttextbox = new System.Windows.Forms.TextBox();
            this.totalbilltextbox = new System.Windows.Forms.TextBox();
            this.sellgridview = new System.Windows.Forms.DataGridView();
            this.selldetailsgridview = new System.Windows.Forms.DataGridView();
            this.additem = new System.Windows.Forms.Button();
            this.deleteitem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.showbillbutton = new System.Windows.Forms.Button();
            this.ordernumbertextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.finishorder = new System.Windows.Forms.Button();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selldetailsgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(883, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELLER ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(883, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ITEM NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(883, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "QUANTITY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(883, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "DISCOUNT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(883, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "TOTAL BILL";
            // 
            // selleridtextbox
            // 
            this.selleridtextbox.Location = new System.Drawing.Point(1011, 68);
            this.selleridtextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selleridtextbox.Name = "selleridtextbox";
            this.selleridtextbox.Size = new System.Drawing.Size(255, 22);
            this.selleridtextbox.TabIndex = 5;
            // 
            // itemnumtextbox
            // 
            this.itemnumtextbox.Location = new System.Drawing.Point(1011, 148);
            this.itemnumtextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemnumtextbox.Name = "itemnumtextbox";
            this.itemnumtextbox.Size = new System.Drawing.Size(255, 22);
            this.itemnumtextbox.TabIndex = 6;
            // 
            // quantitytextbox
            // 
            this.quantitytextbox.Location = new System.Drawing.Point(1011, 228);
            this.quantitytextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantitytextbox.Name = "quantitytextbox";
            this.quantitytextbox.Size = new System.Drawing.Size(255, 22);
            this.quantitytextbox.TabIndex = 7;
            // 
            // discounttextbox
            // 
            this.discounttextbox.Location = new System.Drawing.Point(1011, 271);
            this.discounttextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.discounttextbox.Name = "discounttextbox";
            this.discounttextbox.Size = new System.Drawing.Size(255, 22);
            this.discounttextbox.TabIndex = 8;
            // 
            // totalbilltextbox
            // 
            this.totalbilltextbox.Location = new System.Drawing.Point(1011, 311);
            this.totalbilltextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalbilltextbox.Name = "totalbilltextbox";
            this.totalbilltextbox.Size = new System.Drawing.Size(255, 22);
            this.totalbilltextbox.TabIndex = 9;
            // 
            // sellgridview
            // 
            this.sellgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellgridview.Location = new System.Drawing.Point(41, 28);
            this.sellgridview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sellgridview.Name = "sellgridview";
            this.sellgridview.Size = new System.Drawing.Size(664, 265);
            this.sellgridview.TabIndex = 10;
            this.sellgridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sellgridview_CellMouseClick);
            // 
            // selldetailsgridview
            // 
            this.selldetailsgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selldetailsgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selldetailsgridview.Location = new System.Drawing.Point(41, 431);
            this.selldetailsgridview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selldetailsgridview.Name = "selldetailsgridview";
            this.selldetailsgridview.Size = new System.Drawing.Size(1507, 238);
            this.selldetailsgridview.TabIndex = 11;
            this.selldetailsgridview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selldetailsgridview_CellMouseClick);
            // 
            // additem
            // 
            this.additem.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.additem.Location = new System.Drawing.Point(820, 356);
            this.additem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.additem.Name = "additem";
            this.additem.Size = new System.Drawing.Size(188, 49);
            this.additem.TabIndex = 12;
            this.additem.Text = "ADD ORDER";
            this.additem.UseVisualStyleBackColor = true;
            this.additem.Click += new System.EventHandler(this.additem_Click);
            // 
            // deleteitem
            // 
            this.deleteitem.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.deleteitem.Location = new System.Drawing.Point(1042, 356);
            this.deleteitem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteitem.Name = "deleteitem";
            this.deleteitem.Size = new System.Drawing.Size(188, 49);
            this.deleteitem.TabIndex = 13;
            this.deleteitem.Text = "CANCEL ORDER";
            this.deleteitem.UseVisualStyleBackColor = true;
            this.deleteitem.Click += new System.EventHandler(this.deleteitem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(883, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "DATE TIME";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1011, 108);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // showbillbutton
            // 
            this.showbillbutton.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.showbillbutton.Location = new System.Drawing.Point(1410, 28);
            this.showbillbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showbillbutton.Name = "showbillbutton";
            this.showbillbutton.Size = new System.Drawing.Size(155, 31);
            this.showbillbutton.TabIndex = 16;
            this.showbillbutton.Text = "LOG OUT";
            this.showbillbutton.UseVisualStyleBackColor = true;
            this.showbillbutton.Click += new System.EventHandler(this.showbillbutton_Click);
            // 
            // ordernumbertextbox
            // 
            this.ordernumbertextbox.Location = new System.Drawing.Point(1011, 28);
            this.ordernumbertextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ordernumbertextbox.Name = "ordernumbertextbox";
            this.ordernumbertextbox.Size = new System.Drawing.Size(255, 22);
            this.ordernumbertextbox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(820, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "ORDER NO(auto generate)";
            // 
            // finishorder
            // 
            this.finishorder.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Bold);
            this.finishorder.Location = new System.Drawing.Point(1264, 356);
            this.finishorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finishorder.Name = "finishorder";
            this.finishorder.Size = new System.Drawing.Size(188, 49);
            this.finishorder.TabIndex = 19;
            this.finishorder.Text = "NEW ORDER";
            this.finishorder.UseVisualStyleBackColor = true;
            this.finishorder.Click += new System.EventHandler(this.finishorder_Click);
            // 
            // pricetextbox
            // 
            this.pricetextbox.Location = new System.Drawing.Point(1011, 188);
            this.pricetextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(255, 22);
            this.pricetextbox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(883, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "PRICE";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1588, 682);
            this.Controls.Add(this.pricetextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.finishorder);
            this.Controls.Add(this.ordernumbertextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.showbillbutton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteitem);
            this.Controls.Add(this.additem);
            this.Controls.Add(this.selldetailsgridview);
            this.Controls.Add(this.sellgridview);
            this.Controls.Add(this.totalbilltextbox);
            this.Controls.Add(this.discounttextbox);
            this.Controls.Add(this.quantitytextbox);
            this.Controls.Add(this.itemnumtextbox);
            this.Controls.Add(this.selleridtextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "EMPLOYEE SELL RECORD";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selldetailsgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox selleridtextbox;
        private System.Windows.Forms.TextBox itemnumtextbox;
        private System.Windows.Forms.TextBox quantitytextbox;
        private System.Windows.Forms.TextBox discounttextbox;
        private System.Windows.Forms.TextBox totalbilltextbox;
        private System.Windows.Forms.DataGridView sellgridview;
        private System.Windows.Forms.DataGridView selldetailsgridview;
        private System.Windows.Forms.Button additem;
        private System.Windows.Forms.Button deleteitem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button showbillbutton;
        private System.Windows.Forms.TextBox ordernumbertextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button finishorder;
        private System.Windows.Forms.TextBox pricetextbox;
        private System.Windows.Forms.Label label8;
    }
}