namespace assment1
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
            this.dyofwktxtbx = new System.Windows.Forms.TextBox();
            this.yeartxtbx = new System.Windows.Forms.TextBox();
            this.dyofmnthtxtbx = new System.Windows.Forms.TextBox();
            this.mnthtextbx = new System.Windows.Forms.TextBox();
            this.dayweek = new System.Windows.Forms.Label();
            this.daymonth = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.exis = new System.Windows.Forms.Button();
            this.claer = new System.Windows.Forms.Button();
            this.lbldataouput = new System.Windows.Forms.Label();
            this.showdata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dyofwktxtbx
            // 
            this.dyofwktxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dyofwktxtbx.Location = new System.Drawing.Point(451, 32);
            this.dyofwktxtbx.Name = "dyofwktxtbx";
            this.dyofwktxtbx.Size = new System.Drawing.Size(198, 26);
            this.dyofwktxtbx.TabIndex = 0;
            // 
            // yeartxtbx
            // 
            this.yeartxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yeartxtbx.Location = new System.Drawing.Point(451, 167);
            this.yeartxtbx.Name = "yeartxtbx";
            this.yeartxtbx.Size = new System.Drawing.Size(198, 26);
            this.yeartxtbx.TabIndex = 1;
            // 
            // dyofmnthtxtbx
            // 
            this.dyofmnthtxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dyofmnthtxtbx.Location = new System.Drawing.Point(451, 119);
            this.dyofmnthtxtbx.Name = "dyofmnthtxtbx";
            this.dyofmnthtxtbx.Size = new System.Drawing.Size(198, 26);
            this.dyofmnthtxtbx.TabIndex = 2;
            // 
            // mnthtextbx
            // 
            this.mnthtextbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mnthtextbx.Location = new System.Drawing.Point(451, 74);
            this.mnthtextbx.Name = "mnthtextbx";
            this.mnthtextbx.Size = new System.Drawing.Size(198, 26);
            this.mnthtextbx.TabIndex = 3;
            // 
            // dayweek
            // 
            this.dayweek.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayweek.Location = new System.Drawing.Point(265, 32);
            this.dayweek.Name = "dayweek";
            this.dayweek.Size = new System.Drawing.Size(180, 42);
            this.dayweek.TabIndex = 4;
            this.dayweek.Text = "enter thedayofweek";
            this.dayweek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dayweek.Click += new System.EventHandler(this.label1_Click);
            // 
            // daymonth
            // 
            this.daymonth.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daymonth.Location = new System.Drawing.Point(220, 109);
            this.daymonth.Name = "daymonth";
            this.daymonth.Size = new System.Drawing.Size(208, 42);
            this.daymonth.TabIndex = 5;
            this.daymonth.Text = "Enter numeric day ofthemonth";
            this.daymonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // month
            // 
            this.month.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.Location = new System.Drawing.Point(220, 65);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(209, 35);
            this.month.TabIndex = 6;
            this.month.Text = "Enter nme month";
            this.month.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(201, 155);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(198, 38);
            this.year.TabIndex = 7;
            this.year.Text = "Enter year";
            this.year.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exis
            // 
            this.exis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exis.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exis.Location = new System.Drawing.Point(573, 274);
            this.exis.Name = "exis";
            this.exis.Size = new System.Drawing.Size(115, 33);
            this.exis.TabIndex = 9;
            this.exis.Text = "end";
            this.exis.UseVisualStyleBackColor = true;
            // 
            // claer
            // 
            this.claer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.claer.Location = new System.Drawing.Point(427, 276);
            this.claer.Name = "claer";
            this.claer.Size = new System.Drawing.Size(108, 33);
            this.claer.TabIndex = 10;
            this.claer.Text = "clear";
            this.claer.UseVisualStyleBackColor = true;
            this.claer.Click += new System.EventHandler(this.claer_Click);
            // 
            // lbldataouput
            // 
            this.lbldataouput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldataouput.Location = new System.Drawing.Point(342, 205);
            this.lbldataouput.Name = "lbldataouput";
            this.lbldataouput.Size = new System.Drawing.Size(330, 45);
            this.lbldataouput.TabIndex = 11;
            // 
            // showdata
            // 
            this.showdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showdata.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showdata.Location = new System.Drawing.Point(301, 276);
            this.showdata.Name = "showdata";
            this.showdata.Size = new System.Drawing.Size(83, 31);
            this.showdata.TabIndex = 12;
            this.showdata.Text = "showdata";
            this.showdata.UseVisualStyleBackColor = true;
            this.showdata.Click += new System.EventHandler(this.showdata_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showdata);
            this.Controls.Add(this.lbldataouput);
            this.Controls.Add(this.claer);
            this.Controls.Add(this.exis);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.daymonth);
            this.Controls.Add(this.dayweek);
            this.Controls.Add(this.mnthtextbx);
            this.Controls.Add(this.dyofmnthtxtbx);
            this.Controls.Add(this.yeartxtbx);
            this.Controls.Add(this.dyofwktxtbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dyofwktxtbx;
        private System.Windows.Forms.TextBox yeartxtbx;
        private System.Windows.Forms.TextBox dyofmnthtxtbx;
        private System.Windows.Forms.TextBox mnthtextbx;
        private System.Windows.Forms.Label dayweek;
        private System.Windows.Forms.Label daymonth;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Button exis;
        private System.Windows.Forms.Button claer;
        private System.Windows.Forms.Label lbldataouput;
        private System.Windows.Forms.Button showdata;
    }
}

