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
    public partial class roomform : Form
    {
        public roomform()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            loadDataAsync();
            this.roomgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.roomgv.SelectionChanged += new EventHandler(roomgv_SelectionChanged);
        }

        private void roomgv_SelectionChanged(object? sender, EventArgs e)
        {
            try
            {
                Room myroom = (Room)this.roomgv.CurrentRow.DataBoundItem;
                if (myroom != null)
                {
                    this.typetb.Text = myroom.Rtype;
                    this.periodtb.Text = myroom.Rperiod;
                }

            }
            catch (Exception ex) { return; }
        }

        private async Task loadDataAsync()
        {
            this.roomgv.AutoGenerateColumns = true;
            RoomDB myroomDb = new RoomDB();
            List<Room> mylist = new List<Room>();
            mylist = await myroomDb.GetRoomListAsync();
            roomgv.DataSource = mylist;
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
            Room myRoom = new Room();
            RoomDB myRoomDB = new RoomDB();
            myRoom.Rtype = this.typetb.Text;
            myRoom.Rperiod = this.periodtb.Text;

            Task TaskA = myRoomDB.AddRoomAsync(myRoom);
            TaskA.ContinueWith(_ => loadDataAsync(), TaskScheduler.FromCurrentSynchronizationContext());
            //myRoomDB.AddRoomAsync(myRoom);
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
            if (this.roomgv.CurrentRow != null)
            {
                Room myRoom = (Room)this.roomgv.CurrentRow.DataBoundItem;
                RoomDB myRoomDB = new RoomDB();

                Task TaskA = myRoomDB.RemoveRoomAsync(myRoom);
                TaskA.ContinueWith(_ => loadDataAsync(), TaskScheduler.FromCurrentSynchronizationContext());
            }
            //_ = myRoomDB.RemoveRoomAsync(myRoom);
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
            if (this.roomgv.CurrentRow != null)
            {
                Room myRoom = (Room)this.roomgv.CurrentRow.DataBoundItem;
                RoomDB myRoomDB = new RoomDB();
                myRoom.Rtype = this.typetb.Text;
                myRoom.Rperiod = this.periodtb.Text;

                Task TaskA = myRoomDB.UpdateRoomAsync(myRoom);
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

        private void roomgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            String searchname;
            searchname = this.searchtb.Text.Trim();
            this.searchgv.AutoGenerateColumns = true;
            RoomDB RoomDB = new RoomDB();
            List<Room> mylistbyname = new List<Room>();
            mylistbyname = RoomDB.GetRoomByNameAsParallel(searchname);
            searchgv.DataSource = mylistbyname;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
