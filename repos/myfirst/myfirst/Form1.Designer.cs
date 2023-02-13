namespace myfirst
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbnExit = new System.Windows.Forms.Button();
            this.tbnView = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.texboxaddress = new System.Windows.Forms.TextBox();
            this.texboxname = new System.Windows.Forms.TextBox();
            this.texboxdate = new System.Windows.Forms.TextBox();
            this.texboxsex = new System.Windows.Forms.TextBox();
            this.texboxage = new System.Windows.Forms.TextBox();
            this.texboxid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.tbnExit);
            this.panel1.Controls.Add(this.tbnView);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(11, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 464);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(339, 198);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 60);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(319, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(439, 198);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbnExit
            // 
            this.tbnExit.Location = new System.Drawing.Point(419, 127);
            this.tbnExit.Name = "tbnExit";
            this.tbnExit.Size = new System.Drawing.Size(78, 60);
            this.tbnExit.TabIndex = 4;
            this.tbnExit.Text = "Exit";
            this.tbnExit.UseVisualStyleBackColor = true;
            this.tbnExit.Click += new System.EventHandler(this.tbnExit_Click);
            // 
            // tbnView
            // 
            this.tbnView.Location = new System.Drawing.Point(335, 127);
            this.tbnView.Name = "tbnView";
            this.tbnView.Size = new System.Drawing.Size(78, 60);
            this.tbnView.TabIndex = 3;
            this.tbnView.Text = "view";
            this.tbnView.UseVisualStyleBackColor = true;
            this.tbnView.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Location = new System.Drawing.Point(23, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 61);
            this.panel3.TabIndex = 2;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(335, 37);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(158, 60);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.texboxaddress);
            this.panel2.Controls.Add(this.texboxname);
            this.panel2.Controls.Add(this.texboxdate);
            this.panel2.Controls.Add(this.texboxsex);
            this.panel2.Controls.Add(this.texboxage);
            this.panel2.Controls.Add(this.texboxid);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(23, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 365);
            this.panel2.TabIndex = 0;
            // 
            // texboxaddress
            // 
            this.texboxaddress.Location = new System.Drawing.Point(86, 149);
            this.texboxaddress.Name = "texboxaddress";
            this.texboxaddress.Size = new System.Drawing.Size(100, 23);
            this.texboxaddress.TabIndex = 11;
            // 
            // texboxname
            // 
            this.texboxname.Location = new System.Drawing.Point(86, 94);
            this.texboxname.Name = "texboxname";
            this.texboxname.Size = new System.Drawing.Size(100, 23);
            this.texboxname.TabIndex = 10;
            // 
            // texboxdate
            // 
            this.texboxdate.Location = new System.Drawing.Point(86, 304);
            this.texboxdate.Name = "texboxdate";
            this.texboxdate.Size = new System.Drawing.Size(100, 23);
            this.texboxdate.TabIndex = 9;
            // 
            // texboxsex
            // 
            this.texboxsex.Location = new System.Drawing.Point(86, 252);
            this.texboxsex.Name = "texboxsex";
            this.texboxsex.Size = new System.Drawing.Size(100, 23);
            this.texboxsex.TabIndex = 8;
            // 
            // texboxage
            // 
            this.texboxage.Location = new System.Drawing.Point(86, 193);
            this.texboxage.Name = "texboxage";
            this.texboxage.Size = new System.Drawing.Size(100, 23);
            this.texboxage.TabIndex = 7;
            // 
            // texboxid
            // 
            this.texboxid.Location = new System.Drawing.Point(86, 49);
            this.texboxid.Name = "texboxid";
            this.texboxid.Size = new System.Drawing.Size(100, 23);
            this.texboxid.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(499, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 60);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 485);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "My First";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox texboxaddress;
        private TextBox texboxname;
        private TextBox texboxdate;
        private TextBox texboxsex;
        private TextBox texboxage;
        private TextBox texboxid;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnadd;
        private Button tbnExit;
        private Button tbnView;
        private Panel panel3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private DataGridView dataGridView1;
        private Button btnUpdate;
        private Button btnDelete;
    }
}