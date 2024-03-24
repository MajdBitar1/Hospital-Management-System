namespace Hosmansys
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void patientbtn_Click(object sender, EventArgs e)
        {
            patientform PF = new patientform();
            PF.StartPosition = FormStartPosition.Manual;
            PF.Show();
        }

        private void docbtn_Click(object sender, EventArgs e)
        {
            doctorform DF = new doctorform();
            DF.StartPosition = FormStartPosition.Manual;
            DF.Show();
        }

        private void roombtn_Click(object sender, EventArgs e)
        {
            roomform RF = new roomform();
            RF.StartPosition = FormStartPosition.Manual;
            RF.Show();
        }

        private void employeebtn_Click(object sender, EventArgs e)
        {
            employeeform EF = new employeeform();
            EF.StartPosition = FormStartPosition.Manual;
            EF.Show();
        }
    }
}