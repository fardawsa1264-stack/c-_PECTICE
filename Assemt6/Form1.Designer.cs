namespace assemt6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblpn = new System.Windows.Forms.Label();
            this.lblpage = new System.Windows.Forms.Label();
            this.labelnumeroftickets = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassengerName = new System.Windows.Forms.TextBox();
            this.txtpassengerAge = new System.Windows.Forms.TextBox();
            this.txtnumberoftickets = new System.Windows.Forms.TextBox();
            this.txtBaggaggeweight = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rfirtsclss = new System.Windows.Forms.RadioButton();
            this.rnormalclass = new System.Windows.Forms.RadioButton();
            this.rbussinclass = new System.Windows.Forms.RadioButton();
            this.gAditional = new System.Windows.Forms.GroupBox();
            this.chekedaddTIN = new System.Windows.Forms.CheckBox();
            this.bcalculate = new System.Windows.Forms.Button();
            this.bclear = new System.Windows.Forms.Button();
            this.bexit = new System.Windows.Forms.Button();
            this.listBookingDetail = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gAditional.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtBaggaggeweight);
            this.groupBox1.Controls.Add(this.txtnumberoftickets);
            this.groupBox1.Controls.Add(this.txtpassengerAge);
            this.groupBox1.Controls.Add(this.txtpassengerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelnumeroftickets);
            this.groupBox1.Controls.Add(this.lblpage);
            this.groupBox1.Controls.Add(this.lblpn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblpn
            // 
            this.lblpn.AutoSize = true;
            this.lblpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpn.Location = new System.Drawing.Point(60, 57);
            this.lblpn.Name = "lblpn";
            this.lblpn.Size = new System.Drawing.Size(190, 25);
            this.lblpn.TabIndex = 4;
            this.lblpn.Text = "Passenger Name :";
            // 
            // lblpage
            // 
            this.lblpage.AutoSize = true;
            this.lblpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpage.Location = new System.Drawing.Point(57, 97);
            this.lblpage.Name = "lblpage";
            this.lblpage.Size = new System.Drawing.Size(173, 25);
            this.lblpage.TabIndex = 5;
            this.lblpage.Text = "Passenger Age :";
            // 
            // labelnumeroftickets
            // 
            this.labelnumeroftickets.AutoSize = true;
            this.labelnumeroftickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumeroftickets.Location = new System.Drawing.Point(52, 145);
            this.labelnumeroftickets.Name = "labelnumeroftickets";
            this.labelnumeroftickets.Size = new System.Drawing.Size(198, 25);
            this.labelnumeroftickets.TabIndex = 6;
            this.labelnumeroftickets.Text = "Number OF tickets:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Baggage Weight(kg) :";
            // 
            // txtpassengerName
            // 
            this.txtpassengerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassengerName.Location = new System.Drawing.Point(290, 50);
            this.txtpassengerName.Name = "txtpassengerName";
            this.txtpassengerName.Size = new System.Drawing.Size(203, 32);
            this.txtpassengerName.TabIndex = 8;
            // 
            // txtpassengerAge
            // 
            this.txtpassengerAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassengerAge.Location = new System.Drawing.Point(290, 94);
            this.txtpassengerAge.Name = "txtpassengerAge";
            this.txtpassengerAge.Size = new System.Drawing.Size(203, 32);
            this.txtpassengerAge.TabIndex = 9;
            // 
            // txtnumberoftickets
            // 
            this.txtnumberoftickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumberoftickets.Location = new System.Drawing.Point(290, 142);
            this.txtnumberoftickets.Name = "txtnumberoftickets";
            this.txtnumberoftickets.Size = new System.Drawing.Size(203, 32);
            this.txtnumberoftickets.TabIndex = 10;
            // 
            // txtBaggaggeweight
            // 
            this.txtBaggaggeweight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBaggaggeweight.Location = new System.Drawing.Point(290, 192);
            this.txtBaggaggeweight.Name = "txtBaggaggeweight";
            this.txtBaggaggeweight.Size = new System.Drawing.Size(203, 32);
            this.txtBaggaggeweight.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbussinclass);
            this.groupBox2.Controls.Add(this.rnormalclass);
            this.groupBox2.Controls.Add(this.rfirtsclss);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Travel Class";
            // 
            // rfirtsclss
            // 
            this.rfirtsclss.AutoSize = true;
            this.rfirtsclss.Location = new System.Drawing.Point(9, 51);
            this.rfirtsclss.Name = "rfirtsclss";
            this.rfirtsclss.Size = new System.Drawing.Size(140, 29);
            this.rfirtsclss.TabIndex = 0;
            this.rfirtsclss.TabStop = true;
            this.rfirtsclss.Text = "First Class";
            this.rfirtsclss.UseVisualStyleBackColor = true;
            // 
            // rnormalclass
            // 
            this.rnormalclass.AutoSize = true;
            this.rnormalclass.Location = new System.Drawing.Point(170, 51);
            this.rnormalclass.Name = "rnormalclass";
            this.rnormalclass.Size = new System.Drawing.Size(168, 29);
            this.rnormalclass.TabIndex = 1;
            this.rnormalclass.TabStop = true;
            this.rnormalclass.Text = "Normal cLass";
            this.rnormalclass.UseVisualStyleBackColor = true;
            // 
            // rbussinclass
            // 
            this.rbussinclass.AutoSize = true;
            this.rbussinclass.Location = new System.Drawing.Point(360, 51);
            this.rbussinclass.Name = "rbussinclass";
            this.rbussinclass.Size = new System.Drawing.Size(163, 29);
            this.rbussinclass.TabIndex = 2;
            this.rbussinclass.TabStop = true;
            this.rbussinclass.Text = "Bussin Class";
            this.rbussinclass.UseVisualStyleBackColor = true;
            // 
            // gAditional
            // 
            this.gAditional.Controls.Add(this.chekedaddTIN);
            this.gAditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gAditional.Location = new System.Drawing.Point(10, 384);
            this.gAditional.Name = "gAditional";
            this.gAditional.Size = new System.Drawing.Size(531, 100);
            this.gAditional.TabIndex = 2;
            this.gAditional.TabStop = false;
            this.gAditional.Text = "Aditional Option";
            // 
            // chekedaddTIN
            // 
            this.chekedaddTIN.AutoSize = true;
            this.chekedaddTIN.Location = new System.Drawing.Point(50, 48);
            this.chekedaddTIN.Name = "chekedaddTIN";
            this.chekedaddTIN.Size = new System.Drawing.Size(393, 29);
            this.chekedaddTIN.TabIndex = 0;
            this.chekedaddTIN.Text = "Add tralvel  insurance($25 per ticket)";
            this.chekedaddTIN.UseVisualStyleBackColor = true;
            // 
            // bcalculate
            // 
            this.bcalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcalculate.Location = new System.Drawing.Point(20, 501);
            this.bcalculate.Name = "bcalculate";
            this.bcalculate.Size = new System.Drawing.Size(118, 70);
            this.bcalculate.TabIndex = 3;
            this.bcalculate.Text = "Calculate";
            this.bcalculate.UseVisualStyleBackColor = true;
            this.bcalculate.Click += new System.EventHandler(this.bcalculate_Click);
            // 
            // bclear
            // 
            this.bclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bclear.Location = new System.Drawing.Point(223, 501);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(118, 70);
            this.bclear.TabIndex = 4;
            this.bclear.Text = "Clear";
            this.bclear.UseVisualStyleBackColor = true;
            this.bclear.Click += new System.EventHandler(this.bclear_Click);
            // 
            // bexit
            // 
            this.bexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bexit.Location = new System.Drawing.Point(423, 501);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(118, 70);
            this.bexit.TabIndex = 5;
            this.bexit.Text = "Exit";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // listBookingDetail
            // 
            this.listBookingDetail.FormattingEnabled = true;
            this.listBookingDetail.ItemHeight = 20;
            this.listBookingDetail.Location = new System.Drawing.Point(607, 53);
            this.listBookingDetail.Name = "listBookingDetail";
            this.listBookingDetail.Size = new System.Drawing.Size(257, 364);
            this.listBookingDetail.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 599);
            this.Controls.Add(this.listBookingDetail);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.bcalculate);
            this.Controls.Add(this.gAditional);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gAditional.ResumeLayout(false);
            this.gAditional.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblpn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelnumeroftickets;
        private System.Windows.Forms.Label lblpage;
        private System.Windows.Forms.TextBox txtBaggaggeweight;
        private System.Windows.Forms.TextBox txtnumberoftickets;
        private System.Windows.Forms.TextBox txtpassengerAge;
        private System.Windows.Forms.TextBox txtpassengerName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbussinclass;
        private System.Windows.Forms.RadioButton rnormalclass;
        private System.Windows.Forms.RadioButton rfirtsclss;
        private System.Windows.Forms.GroupBox gAditional;
        private System.Windows.Forms.CheckBox chekedaddTIN;
        private System.Windows.Forms.Button bcalculate;
        private System.Windows.Forms.Button bclear;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.ListBox listBookingDetail;
    }
}

