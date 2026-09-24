namespace assment2
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdeparment = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Deparment = new System.Windows.Forms.Label();
            this.semester = new System.Windows.Forms.Label();
            this.lbouput = new System.Windows.Forms.Label();
            this.showinfo = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.nexit = new System.Windows.Forms.Button();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(534, 107);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(198, 28);
            this.txtname.TabIndex = 0;
            // 
            // txtdeparment
            // 
            this.txtdeparment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdeparment.Location = new System.Drawing.Point(534, 203);
            this.txtdeparment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdeparment.Name = "txtdeparment";
            this.txtdeparment.Size = new System.Drawing.Size(198, 28);
            this.txtdeparment.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(534, 153);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(198, 28);
            this.txtID.TabIndex = 3;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(219, 94);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(308, 39);
            this.name.TabIndex = 4;
            this.name.Text = "Enter the Student Name:\r\n";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(199, 142);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(308, 39);
            this.ID.TabIndex = 5;
            this.ID.Text = "Enter the Student ID:\r\n\r\n";
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Deparment
            // 
            this.Deparment.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deparment.Location = new System.Drawing.Point(199, 191);
            this.Deparment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Deparment.Name = "Deparment";
            this.Deparment.Size = new System.Drawing.Size(329, 39);
            this.Deparment.TabIndex = 6;
            this.Deparment.Text = "Enter the Department:\r\n";
            this.Deparment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Deparment.Click += new System.EventHandler(this.label3_Click);
            // 
            // semester
            // 
            this.semester.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester.Location = new System.Drawing.Point(218, 245);
            this.semester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(268, 41);
            this.semester.TabIndex = 7;
            this.semester.Text = "Enter the Semester :\r\n\r\n\r\n\r\n\r\n";
            this.semester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.semester.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbouput
            // 
            this.lbouput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbouput.Location = new System.Drawing.Point(256, 309);
            this.lbouput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbouput.Name = "lbouput";
            this.lbouput.Size = new System.Drawing.Size(536, 53);
            this.lbouput.TabIndex = 8;
            // 
            // showinfo
            // 
            this.showinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showinfo.Location = new System.Drawing.Point(224, 394);
            this.showinfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showinfo.Name = "showinfo";
            this.showinfo.Size = new System.Drawing.Size(216, 45);
            this.showinfo.TabIndex = 9;
            this.showinfo.Text = "show information";
            this.showinfo.UseVisualStyleBackColor = true;
            this.showinfo.Click += new System.EventHandler(this.showinfo_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(446, 394);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(181, 45);
            this.clear.TabIndex = 11;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // nexit
            // 
            this.nexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nexit.Location = new System.Drawing.Point(636, 394);
            this.nexit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nexit.Name = "nexit";
            this.nexit.Size = new System.Drawing.Size(181, 45);
            this.nexit.TabIndex = 12;
            this.nexit.Text = "exit";
            this.nexit.UseVisualStyleBackColor = true;
            // 
            // txtsemester
            // 
            this.txtsemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsemester.Location = new System.Drawing.Point(534, 245);
            this.txtsemester.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(198, 28);
            this.txtsemester.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 495);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.nexit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.showinfo);
            this.Controls.Add(this.lbouput);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.Deparment);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.name);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtdeparment);
            this.Controls.Add(this.txtname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdeparment;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Deparment;
        private System.Windows.Forms.Label semester;
        private System.Windows.Forms.Label lbouput;
        private System.Windows.Forms.Button showinfo;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button nexit;
        private System.Windows.Forms.TextBox txtsemester;
    }
}

