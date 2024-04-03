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
            this.lblempid.Location = new System.Drawing.Point(84, 96);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(76, 22);
            this.lblempid.TabIndex = 0;
            this.lblempid.Text = "Emp_Id";
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempname.Location = new System.Drawing.Point(84, 149);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(61, 22);
            this.lblempname.TabIndex = 1;
            this.lblempname.Text = "Name";
            // 
            // lblpan
            // 
            this.lblpan.AutoSize = true;
            this.lblpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpan.Location = new System.Drawing.Point(84, 210);
            this.lblpan.Name = "lblpan";
            this.lblpan.Size = new System.Drawing.Size(50, 22);
            this.lblpan.TabIndex = 2;
            this.lblpan.Text = "PAN";
            this.lblpan.Click += new System.EventHandler(this.lblpan_Click);
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladd.Location = new System.Drawing.Point(84, 265);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(83, 22);
            this.lbladd.TabIndex = 3;
            this.lbladd.Text = "Address";
            // 
            // lblemailid
            // 
            this.lblemailid.AutoSize = true;
            this.lblemailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemailid.Location = new System.Drawing.Point(84, 325);
            this.lblemailid.Name = "lblemailid";
            this.lblemailid.Size = new System.Drawing.Size(81, 22);
            this.lblemailid.TabIndex = 4;
            this.lblemailid.Text = "Emai_Id";
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontact.Location = new System.Drawing.Point(84, 395);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(115, 22);
            this.lblcontact.TabIndex = 5;
            this.lblcontact.Text = "Contact_No";
            // 
            // txtempid
            // 
            this.txtempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempid.Location = new System.Drawing.Point(214, 96);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(160, 28);
            this.txtempid.TabIndex = 6;
            this.txtempid.Text = "1";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(214, 149);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(184, 28);
            this.txtname.TabIndex = 7;
            // 
            // txtpan
            // 
            this.txtpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpan.Location = new System.Drawing.Point(214, 210);
            this.txtpan.Name = "txtpan";
            this.txtpan.Size = new System.Drawing.Size(184, 28);
            this.txtpan.TabIndex = 8;
            this.txtpan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtemailid
            // 
            this.txtemailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailid.Location = new System.Drawing.Point(214, 325);
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.Size = new System.Drawing.Size(214, 28);
            this.txtemailid.TabIndex = 9;
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(214, 395);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(214, 28);
            this.txtcontact.TabIndex = 10;
            // 
            // txtadd
            // 
            this.txtadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd.Location = new System.Drawing.Point(214, 265);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(214, 28);
            this.txtadd.TabIndex = 11;
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(81, 496);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(133, 40);
            this.btninsert.TabIndex = 12;
            this.btninsert.Text = "INSERT";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(308, 496);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(133, 40);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(520, 496);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(133, 40);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(734, 496);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(133, 40);
            this.btnsearch.TabIndex = 15;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // lblhead
            // 
            this.lblhead.AutoSize = true;
            this.lblhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.Location = new System.Drawing.Point(344, 20);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(204, 22);
            this.lblhead.TabIndex = 17;
            this.lblhead.Text = "EMPLOYEE DETAILS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 642);
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

