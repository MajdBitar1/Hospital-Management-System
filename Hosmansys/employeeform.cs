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
    public partial class employeeform : Form
    {
        public employeeform()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            loadDataAsync();
            this.employeegv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.employeegv.SelectionChanged += new EventHandler(employeegv_SelectionChanged);
        }

        private void employeegv_SelectionChanged(object? sender, EventArgs e)
        {
            try
            {
                Employee myEmployee = (Employee)this.employeegv.CurrentRow.DataBoundItem;
                if (myEmployee != null)
                {
                    this.nametb.Text = myEmployee.Ename;
                    this.gendertb.Text = myEmployee.Egender;
                    this.salarytb.Text = Convert.ToString(myEmployee.Esalary);
                    this.phonetb.Text = Convert.ToString(myEmployee.Ephonenber);
                    this.jobtb.Text = Convert.ToString(myEmployee.Ejob);
                }

            }
            catch (Exception ex) { return; }
        }

        private async Task loadDataAsync()
        {
            this.employeegv.AutoGenerateColumns = true;
            EmployeeDB myEmployeeDb = new EmployeeDB();
            List<Employee> mylist = new List<Employee>();
            mylist = await myEmployeeDb.GetEmployeeListAsync();
            employeegv.DataSource = mylist;
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
            Employee myEmployee = new Employee();
            EmployeeDB myEmployeeDB = new EmployeeDB();
            myEmployee.Ename = this.nametb.Text;
            myEmployee.Egender = this.gendertb.Text;
            myEmployee.Ephonenber = this.phonetb.Text;
            myEmployee.Esalary = this.salarytb.Text;
            myEmployee.Ejob = this.jobtb.Text;
            Task TaskA = myEmployeeDB.AddEmployeeAsync(myEmployee);
            TaskA.ContinueWith(_ => loadDataAsync(), TaskScheduler.FromCurrentSynchronizationContext());
            //myEmployeeDB.AddEmployeeAsync(myEmployee);
            //loadDataAsync();
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
            if (this.employeegv.CurrentRow != null)
            {
                Employee myEmployee = (Employee)this.employeegv.CurrentRow.DataBoundItem;
                EmployeeDB myEmployeeDB = new EmployeeDB();
                Task TaskA = myEmployeeDB.RemoveEmployeeAsync(myEmployee);
                TaskA.ContinueWith(_ => loadDataAsync(), TaskScheduler.FromCurrentSynchronizationContext());
            }
            //_ = myEmployeeDB.RemoveEmployeeAsync(myEmployee);
            //_ = loadDataAsync();
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
            if (this.employeegv.CurrentRow != null)
            {
                Employee myEmployee = (Employee)this.employeegv.CurrentRow.DataBoundItem;
                EmployeeDB myEmployeeDB = new EmployeeDB();
                myEmployee.Ename = this.nametb.Text;
                myEmployee.Egender = this.gendertb.Text;
                myEmployee.Ephonenber = this.phonetb.Text;
                myEmployee.Esalary = this.salarytb.Text;
                myEmployee.Ejob = this.jobtb.Text;

                Task TaskA = myEmployeeDB.UpdateEmployeeAsync(myEmployee);
                TaskA.ContinueWith(_ => loadDataAsync(), TaskScheduler.FromCurrentSynchronizationContext());
            }
            //_ = myEmployeeDB.UpdateEmployeeAsync(myEmployee);
            //_ = loadDataAsync();
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

        private void employeegv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            String searchname;
            searchname = this.searchtb.Text.Trim();
            this.employeesearchgv.AutoGenerateColumns = true;
            EmployeeDB employeeDB = new EmployeeDB();
            List<Employee> mylistbyname = new List<Employee>();
            mylistbyname = employeeDB.GetEmployeeByNameAsParallel(searchname);
            employeesearchgv.DataSource = mylistbyname;
        }

        private void employeesearchgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
