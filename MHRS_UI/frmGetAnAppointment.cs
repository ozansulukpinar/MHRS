using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHRS_BLL;
using MHRS_DTO_;
using MHRS_Entity;

namespace MHRS_UI
{
    public partial class frmGetAnAppointment : Form
    {
        Patient patient;
        HospitalController hospitalController;
        PoliclinicController policlinicController;
        DoctorController doctorController;
        AppointmentController appointmentController;
        HourController hourController;
        Guid patientId;

        public frmGetAnAppointment(Guid patientID)
        {
            InitializeComponent();
            hourController = new HourController();
            patient = new Patient();
            hospitalController = new HospitalController();
            policlinicController = new PoliclinicController();
            doctorController = new DoctorController();
            appointmentController = new AppointmentController();
            patientId = patientID;
            //id yi bu şekilde çekme imkanımız oluyor
        }



        private void frmGetAnAppointment_Load(object sender, EventArgs e)
        {
            ViewHospitalCombobox();
            ViewPoliclinicCombobox();
            ViewDoctorCombobox();
            ViewHoursCombobox();
        }

        void ViewHospitalCombobox()
        {
            cmbHospitals.DisplayMember = "HospitalName";
            cmbHospitals.ValueMember = "HospitalID";
            cmbHospitals.DataSource = hospitalController.GetHospitals();
        }

        void ViewHoursCombobox()
        {
            comboBox2.DisplayMember = "HourName";
            comboBox2.ValueMember = "HourID";
            comboBox2.DataSource = hourController.GetAllHours();
        }

        void ViewPoliclinicCombobox()
        {
            cmbPoliclinics.DisplayMember = "PoliclinicName";
            cmbPoliclinics.ValueMember = "PoliclinicID";
            cmbPoliclinics.DataSource = policlinicController.GetPoliclinics();
        }

        void ViewDoctorCombobox()
        {
            comboBox1.DisplayMember = "DoctorName";
            comboBox1.ValueMember = "DoctorID";
            comboBox1.DataSource = doctorController.GetDoctors();
        }

        private void btnGetThisAppointment_Click(object sender, EventArgs e)
        {
            Appointment newAppointment = new Appointment();
            newAppointment.DoctorID = Convert.ToInt32(comboBox1.SelectedValue);
            newAppointment.PatientID = patient.PatientID;
            newAppointment.AppointmentDate = dtpAppointmentDate.Value.Date;
            newAppointment.HospitalID = Convert.ToInt32(cmbHospitals.SelectedValue);
            newAppointment.PoliclinicID = Convert.ToInt32(cmbPoliclinics.SelectedValue);
            newAppointment.AppointmentTime = Convert.ToInt32(comboBox2.SelectedValue);

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    button18.BackColor = Color.Red;
                    button18.Enabled = false;
                    break;
                case 1:
                    button10.BackColor = Color.Red;
                    button10.Enabled = false;
                    break;
                case 2:
                    button11.BackColor = Color.Red;
                    button11.Enabled = false;
                    break;
                case 3:
                    button12.BackColor = Color.Red;
                    button12.Enabled = false;
                    break;
                case 4:
                    button13.BackColor = Color.Red;
                    button13.Enabled = false;
                    break;
                case 5:
                    button14.BackColor = Color.Red;
                    button14.Enabled = false;
                    break;
                case 6:
                    button15.BackColor = Color.Red;
                    button15.Enabled = false;
                    break;
                case 7:
                    button16.BackColor = Color.Red;
                    button16.Enabled = false;
                    break;
                case 8:
                    button17.BackColor = Color.Red;
                    button17.Enabled = false;
                    break;
                case 9:
                    button19.BackColor = Color.Red;
                    button19.Enabled = false;
                    break;
                case 10:
                    button21.BackColor = Color.Red;
                    button21.Enabled = false;
                    break;
                case 11:
                    button20.BackColor = Color.Red;
                    button20.Enabled = false;
                    break;
                case 12:
                    button22.BackColor = Color.Red;
                    button22.Enabled = false;
                    break;
                case 13:
                    button24.BackColor = Color.Red;
                    button24.Enabled = false;
                    break;
                case 14:
                    button23.BackColor = Color.Red;
                    button23.Enabled = false;
                    break;
                case 15:
                    button25.BackColor = Color.Red;
                    button25.Enabled = false;
                    break;
            }

            bool result = false;

            try
            {
                result = appointmentController.AddAppointmentController(newAppointment);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(result ? "Registration Successful" : "Registration Failed");
        }

        private void lblMyPreviousAppointments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPreviousAppointment frmPreviousAppointment = new frmPreviousAppointment(patientId);
            frmPreviousAppointment.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
