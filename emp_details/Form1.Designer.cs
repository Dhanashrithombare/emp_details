namespace emp_details
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
            this.lblempid = new System.Windows.Forms.Label();
            this.lblempname = new System.Windows.Forms.Label();
            this.lblpan = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.lblemailid = new System.Windows.Forms.Label();
            this.lblcontact = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpan = new System.Windows.Forms.TextBox();
            this.txtemailid = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lblhead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempid.Location = new System.Drawing.Point(63, 78);
            this.lblempid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(64, 18);
            this.lblempid.TabIndex = 0;
            this.lblempid.Text = "Emp_Id";
            this.lblempid.Click += new System.EventHandler(this.lblempid_Click);
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempname.Location = new System.Drawing.Point(63, 121);
            this.lblempname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(52, 18);
            this.lblempname.TabIndex = 1;
            this.lblempname.Text = "Name";
            this.lblempname.Click += new System.EventHandler(this.lblempname_Click);
            // 
            // lblpan
            // 
            this.lblpan.AutoSize = true;
            this.lblpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpan.Location = new System.Drawing.Point(63, 171);
            this.lblpan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpan.Name = "lblpan";
            this.lblpan.Size = new System.Drawing.Size(41, 18);
            this.lblpan.TabIndex = 2;
            this.lblpan.Text = "PAN";
            this.lblpan.Click += new System.EventHandler(this.lblpan_Click);
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.Location = new System.Drawing.Point(63, 215);
            this.lbladd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(69, 18);
            this.lbladd.TabIndex = 3;
            this.lbladd.Text = "Address";
            this.lbladd.Click += new System.EventHandler(this.lbladd_Click);
            // 
            // lblemailid
            // 
            this.lblemailid.AutoSize = true;
            this.lblemailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemailid.Location = new System.Drawing.Point(63, 264);
            this.lblemailid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemailid.Name = "lblemailid";
            this.lblemailid.Size = new System.Drawing.Size(68, 18);
            this.lblemailid.TabIndex = 4;
            this.lblemailid.Text = "Emai_Id";
            this.lblemailid.Click += new System.EventHandler(this.lblemailid_Click);
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontact.Location = new System.Drawing.Point(63, 321);
            this.lblcontact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(98, 18);
            this.lblcontact.TabIndex = 5;
            this.lblcontact.Text = "Contact_No";
            this.lblcontact.Click += new System.EventHandler(this.lblcontact_Click);
            // 
            // txtempid
            // 
            this.txtempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempid.Location = new System.Drawing.Point(160, 78);
            this.txtempid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(121, 24);
            this.txtempid.TabIndex = 6;
            this.txtempid.TextChanged += new System.EventHandler(this.txtempid_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(160, 121);
            this.txtname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(139, 24);
            this.txtname.TabIndex = 7;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtpan
            // 
            this.txtpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpan.Location = new System.Drawing.Point(160, 171);
            this.txtpan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpan.Name = "txtpan";
            this.txtpan.Size = new System.Drawing.Size(139, 24);
            this.txtpan.TabIndex = 8;
            this.txtpan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtemailid
            // 
            this.txtemailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailid.Location = new System.Drawing.Point(160, 264);
            this.txtemailid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.Size = new System.Drawing.Size(162, 24);
            this.txtemailid.TabIndex = 9;
            this.txtemailid.TextChanged += new System.EventHandler(this.txtemailid_TextChanged);
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(160, 321);
            this.txtcontact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(162, 24);
            this.txtcontact.TabIndex = 10;
            this.txtcontact.TextChanged += new System.EventHandler(this.txtcontact_TextChanged);
            // 
            // txtadd
            // 
            this.txtadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd.Location = new System.Drawing.Point(160, 215);
            this.txtadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(162, 24);
            this.txtadd.TabIndex = 11;
            this.txtadd.TextChanged += new System.EventHandler(this.txtadd_TextChanged);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(61, 403);
            this.btninsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(100, 32);
            this.btninsert.TabIndex = 12;
            this.btninsert.Text = "INSERT";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(231, 403);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 32);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(390, 403);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 32);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(550, 403);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(100, 32);
            this.btnsearch.TabIndex = 15;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lblhead
            // 
            this.lblhead.AutoSize = true;
            this.lblhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.Location = new System.Drawing.Point(258, 16);
            this.lblhead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(170, 18);
            this.lblhead.TabIndex = 17;
            this.lblhead.Text = "EMPLOYEE DETAILS";
            this.lblhead.Click += new System.EventHandler(this.lblhead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 522);
            this.Controls.Add(this.lblhead);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtemailid);
            this.Controls.Add(this.txtpan);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.lblemailid);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.lblpan);
            this.Controls.Add(this.lblempname);
            this.Controls.Add(this.lblempid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "EMP_DETAILS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lblpan;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.Label lblemailid;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpan;
        private System.Windows.Forms.TextBox txtemailid;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lblhead;
    }
}

