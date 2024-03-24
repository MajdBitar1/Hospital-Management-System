using Hosmansys.Repositorys.Control;
using Hosmansys.Repositorys.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hosmansys
{
    public partial class patientform : Form
    {
        public patientform()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            loadDataAsync();
            this.patientgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.patientgv.SelectionChanged += new EventHandler(patientgv_SelectionChanged);
        }

        private void patientgv_SelectionChanged(object? sender, EventArgs e)
        {
            try
            {
                Patient mypatient = (Patient)this.patientgv.CurrentRow.DataBoundItem;
                if (mypatient != null)
                {
                    this.nametb.Text = mypatient.Pname;
                    this.gendertb.Text = mypatient.Pgender;
                    this.addtb.Text = mypatient.Paddress;
                    this.phonetb.Text = Convert.ToString(mypatient.Pcontactnber);
                    this.admittedtb.Text = Convert.ToString(mypatient.PDateadmitted);
                    this.dischargedtb.Text = Convert.ToString(mypatient.PDatedischarged);
                    this.roomtb.Text = Convert.ToString(mypatient.RoomNber);
                }

            }
            catch (Exception ex) { return; }
        }

        private async Task loadDataAsync()
        {
            this.patientgv.AutoGenerateColumns = true;
            PatientDB mypatientDb = new PatientDB();
            List<Patient> mylist = new List<Patient>();
            mylist = await mypatientDb.GetPatientListAsync();
            patientgv.DataSource = mylist;
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is Button button && button != insertbtn)
                {
                    button.Enabled = false;
                }
            }
            Patient mypatient = new Patient();
            PatientDB mypatientDB = new PatientDB();
            mypatient.Pname = this.nametb.Text;
            mypatient.Pgender = this.gendertb.Text;
            mypatient.Paddress = this.addtb.Text;
            mypatient.Pcontactnber = this.phonetb.Text;
            mypatient.PDateadmitted = Convert.ToDateTime(this.admittedtb.Text);
            mypatient.PDatedischarged = Convert.ToDateTime(this.dischargedtb.Text);
            mypatient.RoomNber = Convert.ToInt16(this.roomtb.Text);

            Task TaskA = mypatientDB.AddPatientAsync(mypatient);
            TaskA.ContinueWith(_ => loadDataAsync(), TaskScheduler.FromCurrentSynchronizationContext());
            foreach (Control control in Controls)
            {
                if (control is Button button && button != insertbtn)
                {
                    button.Enabled = true;
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is Button button && button != deletebtn)
                {
                    button.Enabled = false;
                }
            }
            if (this.patientgv.CurrentRow != null)
            {
                Patient mypatient = (Patient)this.patientgv.CurrentRow.DataBoundItem;
                PatientDB mypatientDB = new PatientDB();

                Task TaskA = mypatientDB.RemovePatientAsync(mypatient);
                TaskA.ContinueWith(_ => loadDataAsync(), TaskScheduler.FromCurrentSynchronizationContext());
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button != deletebtn)
                {
                    button.Enabled = true;
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is Button button && button != updatebtn)
                {
                    button.Enabled = false;
                }
            }
            if (this.patientgv.CurrentRow != null)
            {
                Patient mypatient = (Patient)this.patientgv.CurrentRow.DataBoundItem;
                PatientDB mypatientDB = new PatientDB();
                mypatient.Pname = this.nametb.Text;
                mypatient.Pgender = this.gendertb.Text;
                mypatient.Paddress = this.addtb.Text;
                mypatient.Pcontactnber = this.phonetb.Text;
                mypatient.PDateadmitted = Convert.ToDateTime(this.admittedtb.Text);
                mypatient.PDatedischarged = Convert.ToDateTime(this.dischargedtb.Text);
                mypatient.RoomNber = Convert.ToInt16(this.roomtb.Text);

                Task TaskA = mypatientDB.UpdatePatientAsync(mypatient);
                TaskA.ContinueWith(_ => loadDataAsync(), TaskScheduler.FromCurrentSynchronizationContext());
            }
            foreach (Control control in Controls)
            {
                if (control is Button button && button != updatebtn)
                {
                    button.Enabled = true;
                }
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            _ = loadDataAsync();
        }

        private void patientgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void searchgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            String searchname;
            searchname = this.searchtb.Text.Trim();
            this.searchgv.AutoGenerateColumns = true;
            PatientDB patientDB = new PatientDB();
            List<Patient> mylistbyname = new List<Patient>();
            mylistbyname = patientDB.GetPatientByNameAsParallel(searchname);
            searchgv.DataSource = mylistbyname;
        }
    }
}
