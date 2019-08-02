namespace MHRS_UI
{
    partial class frmGetAnAppointment
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
            this.lblLogOut = new System.Windows.Forms.LinkLabel();
            this.lblMyPreviousAppointments = new System.Windows.Forms.LinkLabel();
            this.btnGetThisAppointment = new System.Windows.Forms.Button();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPoliclinics = new System.Windows.Forms.ComboBox();
            this.cmbHospitals = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button25 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button16 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Location = new System.Drawing.Point(58, 439);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(45, 13);
            this.lblLogOut.TabIndex = 25;
            this.lblLogOut.TabStop = true;
            this.lblLogOut.Text = "Log Out";
            // 
            // lblMyPreviousAppointments
            // 
            this.lblMyPreviousAppointments.AutoSize = true;
            this.lblMyPreviousAppointments.Location = new System.Drawing.Point(366, 43);
            this.lblMyPreviousAppointments.Name = "lblMyPreviousAppointments";
            this.lblMyPreviousAppointments.Size = new System.Drawing.Size(138, 13);
            this.lblMyPreviousAppointments.TabIndex = 24;
            this.lblMyPreviousAppointments.TabStop = true;
            this.lblMyPreviousAppointments.Text = "My Previous Appointment(s)";
            this.lblMyPreviousAppointments.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMyPreviousAppointments_LinkClicked);
            // 
            // btnGetThisAppointment
            // 
            this.btnGetThisAppointment.Location = new System.Drawing.Point(364, 428);
            this.btnGetThisAppointment.Name = "btnGetThisAppointment";
            this.btnGetThisAppointment.Size = new System.Drawing.Size(134, 34);
            this.btnGetThisAppointment.TabIndex = 23;
            this.btnGetThisAppointment.Text = "Get This Appointment";
            this.btnGetThisAppointment.UseVisualStyleBackColor = true;
            this.btnGetThisAppointment.Click += new System.EventHandler(this.btnGetThisAppointment_Click);
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(140, 188);
            this.dtpAppointmentDate.MinDate = new System.DateTime(2019, 5, 6, 0, 0, 0, 0);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(358, 20);
            this.dtpAppointmentDate.TabIndex = 21;
            // 
            // cmbPoliclinics
            // 
            this.cmbPoliclinics.FormattingEnabled = true;
            this.cmbPoliclinics.Location = new System.Drawing.Point(140, 113);
            this.cmbPoliclinics.Name = "cmbPoliclinics";
            this.cmbPoliclinics.Size = new System.Drawing.Size(358, 21);
            this.cmbPoliclinics.TabIndex = 20;
            // 
            // cmbHospitals
            // 
            this.cmbHospitals.FormattingEnabled = true;
            this.cmbHospitals.Location = new System.Drawing.Point(140, 73);
            this.cmbHospitals.Name = "cmbHospitals";
            this.cmbHospitals.Size = new System.Drawing.Size(358, 21);
            this.cmbHospitals.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Policlinic:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hospital:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Centralized Doctor Appointment System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Doctor Name :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(358, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Time :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button25);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button23);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.button22);
            this.panel2.Controls.Add(this.button24);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Location = new System.Drawing.Point(140, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 140);
            this.panel2.TabIndex = 29;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(256, 99);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 23);
            this.button25.TabIndex = 0;
            this.button25.Text = "16:30";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(256, 70);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 0;
            this.button20.Text = "14:30";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(175, 99);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 23);
            this.button23.TabIndex = 0;
            this.button23.Text = "16:00";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(175, 70);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 0;
            this.button21.Text = "14:00";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(13, 99);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 0;
            this.button22.Text = "15:00";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(94, 99);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 0;
            this.button24.Text = "15:30";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(94, 70);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 0;
            this.button19.Text = "13:30";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(13, 70);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 0;
            this.button17.Text = "13:00";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(175, 41);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 0;
            this.button15.Text = "12:00";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(94, 41);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 0;
            this.button14.Text = "11:30";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(13, 41);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 0;
            this.button13.Text = "11:00";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(256, 12);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 0;
            this.button12.Text = "10:30";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(175, 12);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 0;
            this.button11.Text = "10:00";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(94, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 0;
            this.button10.Text = "09:30";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(13, 12);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 0;
            this.button18.Text = "09:00";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(140, 225);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(358, 21);
            this.comboBox2.TabIndex = 30;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(256, 41);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 0;
            this.button16.Text = "12:30";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // frmGetAnAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 488);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.lblMyPreviousAppointments);
            this.Controls.Add(this.btnGetThisAppointment);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.cmbPoliclinics);
            this.Controls.Add(this.cmbHospitals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGetAnAppointment";
            this.Text = "frmGetAnAppointment";
            this.Load += new System.EventHandler(this.frmGetAnAppointment_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblLogOut;
        private System.Windows.Forms.LinkLabel lblMyPreviousAppointments;
        private System.Windows.Forms.Button btnGetThisAppointment;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.ComboBox cmbPoliclinics;
        private System.Windows.Forms.ComboBox cmbHospitals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button16;
    }
}