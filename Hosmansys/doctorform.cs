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
    public partial class doctorform : Form
    {
        public doctorform()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            loadDataAsync();
            this.docgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.docgv.SelectionChanged += new EventHandler(docgv_SelectionChanged);
        }

        private void docgv_SelectionChanged(object? sender, EventArgs e)
        {
            try
            {
                Doctor mydoctor = (Doctor)this.docgv.CurrentRow.DataBoundItem;
                if (mydoctor != null)
                {
                    this.nametb.Text = mydoctor.Docname;
                    this.gendertb.Text = mydoctor.Docgender;
                    this.departmenttb.Text = mydoctor.Docdepartment;
                    this.salarytb.Text = Convert.ToString(mydoctor.Docsalary);
                    this.phonetb.Text = Convert.ToString(mydoctor.Docphonenb);
                }

            }
            catch (Exception ex) { return; }
        }

        private async Task loadDataAsync()
        {
            this.docgv.AutoGenerateColumns = true;
            DocDB myDoctorDb = new DocDB();
            List<Doctor> mylist = new List<Doctor>();
            mylist = await myDoctorDb.GetDoctorListAsync();
            docgv.DataSource = mylist;
        }
        private void insertbtn_Click(object sender, EventArgs e)
        {
            //deletebtn.Enabled = false;
            //updatebtn.Enabled = false;

            foreach (Control control in Controls)
            {
                if (control is Button button && button != insertbtn)
                {
                    button.Enabled = false;
                }
            }
            Doctor myDoctor = new Doctor();
            DocDB myDoctorDB = new DocDB();
            myDoctor.Docname = this.nametb.Text;
            myDoctor.Docgender = this.gendertb.Text;
            myDoctor.Docdepartment = this.departmenttb.Text;
            myDoctor.Docphonenb = this.phonetb.Text;
            myDoctor.Docsalary = this.salarytb.Text;
            Task addDoctorTask = myDoctorDB.AddDoctorAsync(myDoctor);
            addDoctorTask.ContinueWith(_ => loadDataAsync(), TaskScheduler.FromCurrentSynchronizationContext());

            foreach (Control control in Controls)
            {
                if (control is Button button && button != insertbtn)
                {
                    button.Enabled = true;
                }
            }
            //deletebtn.Enabled = true;
            //updatebtn.Enabled = true;
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
            if (this.docgv.CurrentRow != null)
            {
                Doctor myDoctor = (Doctor)this.docgv.CurrentRow.DataBoundItem;
                DocDB myDoctorDB = new DocDB();
                Task addDoctorTask = myDoctorDB.RemoveDoctorAsync(myDoctor);
                addDoctorTask.ContinueWith(_ => loadDataAsync(), TaskScheduler.FromCurrentSynchronizationContext());
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
            if (this.docgv.CurrentRow != null)
            {
                Doctor myDoctor = (Doctor)this.docgv.CurrentRow.DataBoundItem;
                DocDB myDoctorDB = new DocDB();
                myDoctor.Docname = this.nametb.Text;
                myDoctor.Docgender = this.gendertb.Text;
                myDoctor.Docdepartment = this.departmenttb.Text;
                myDoctor.Docphonenb = this.phonetb.Text;
                myDoctor.Docsalary = this.salarytb.Text;
                Task addDoctorTask = myDoctorDB.UpdateDoctorAsync(myDoctor);
                addDoctorTask.ContinueWith(_ => loadDataAsync(), TaskScheduler.FromCurrentSynchronizationContext());
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

        private void docgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbt_Click(object sender, EventArgs e)
        {
            String searchname;
            searchname = this.searchtb.Text.Trim();
            this.searchgv.AutoGenerateColumns = true;
            DocDB DoctorDB = new DocDB();
            List<Doctor> mylistbyname = new List<Doctor>();
            mylistbyname = DoctorDB.GetDoctorByNameAsParallel(searchname);
            searchgv.DataSource = mylistbyname;
        }

        private void searchgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
