namespace Hosmansys
{
    partial class roomform
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
            components = new System.ComponentModel.Container();
            insertbtn = new Button();
            deletebtn = new Button();
            updatebtn = new Button();
            refreshbtn = new Button();
            typetb = new TextBox();
            periodtb = new TextBox();
            roomgv = new DataGridView();
            ridDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rtypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rperiodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            searchgv = new DataGridView();
            searchbtn = new Button();
            searchtb = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)roomgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchgv).BeginInit();
            SuspendLayout();
            // 
            // insertbtn
            // 
            insertbtn.Location = new Point(713, 415);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(75, 23);
            insertbtn.TabIndex = 0;
            insertbtn.Text = "Insert";
            insertbtn.UseVisualStyleBackColor = true;
            insertbtn.Click += insertbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(632, 415);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(75, 23);
            deletebtn.TabIndex = 1;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(551, 415);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(75, 23);
            updatebtn.TabIndex = 2;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // refreshbtn
            // 
            refreshbtn.Location = new Point(470, 415);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(75, 23);
            refreshbtn.TabIndex = 3;
            refreshbtn.Text = "Refresh";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // typetb
            // 
            typetb.Location = new Point(106, 34);
            typetb.Name = "typetb";
            typetb.Size = new Size(100, 23);
            typetb.TabIndex = 4;
            // 
            // periodtb
            // 
            periodtb.Location = new Point(106, 63);
            periodtb.Name = "periodtb";
            periodtb.Size = new Size(100, 23);
            periodtb.TabIndex = 5;
            // 
            // roomgv
            // 
            roomgv.AutoGenerateColumns = false;
            roomgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomgv.Columns.AddRange(new DataGridViewColumn[] { ridDataGridViewTextBoxColumn, rtypeDataGridViewTextBoxColumn, rperiodDataGridViewTextBoxColumn });
            roomgv.DataSource = roomBindingSource;
            roomgv.Location = new Point(265, 12);
            roomgv.Name = "roomgv";
            roomgv.RowTemplate.Height = 25;
            roomgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roomgv.Size = new Size(523, 233);
            roomgv.TabIndex = 6;
            roomgv.CellContentClick += roomgv_CellContentClick;
            // 
            // ridDataGridViewTextBoxColumn
            // 
            ridDataGridViewTextBoxColumn.DataPropertyName = "Rid";
            ridDataGridViewTextBoxColumn.HeaderText = "Rid";
            ridDataGridViewTextBoxColumn.Name = "ridDataGridViewTextBoxColumn";
            // 
            // rtypeDataGridViewTextBoxColumn
            // 
            rtypeDataGridViewTextBoxColumn.DataPropertyName = "Rtype";
            rtypeDataGridViewTextBoxColumn.HeaderText = "Rtype";
            rtypeDataGridViewTextBoxColumn.Name = "rtypeDataGridViewTextBoxColumn";
            // 
            // rperiodDataGridViewTextBoxColumn
            // 
            rperiodDataGridViewTextBoxColumn.DataPropertyName = "Rperiod";
            rperiodDataGridViewTextBoxColumn.HeaderText = "Rperiod";
            rperiodDataGridViewTextBoxColumn.Name = "rperiodDataGridViewTextBoxColumn";
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(Repositorys.Models.Room);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 37);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 7;
            label1.Text = "Room Type:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 66);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 8;
            label2.Text = "Room Period:";
            // 
            // searchgv
            // 
            searchgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchgv.Location = new Point(265, 251);
            searchgv.Name = "searchgv";
            searchgv.RowTemplate.Height = 25;
            searchgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchgv.Size = new Size(523, 150);
            searchgv.TabIndex = 9;
            searchgv.CellContentClick += dataGridView1_CellContentClick;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(106, 334);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 10;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // searchtb
            // 
            searchtb.Location = new Point(106, 305);
            searchtb.Name = "searchtb";
            searchtb.Size = new Size(100, 23);
            searchtb.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 308);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 12;
            label3.Text = "Type Search:";
            label3.Click += label3_Click;
            // 
            // roomform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(searchtb);
            Controls.Add(searchbtn);
            Controls.Add(searchgv);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(roomgv);
            Controls.Add(periodtb);
            Controls.Add(typetb);
            Controls.Add(refreshbtn);
            Controls.Add(updatebtn);
            Controls.Add(deletebtn);
            Controls.Add(insertbtn);
            Name = "roomform";
            Text = "roomform";
            ((System.ComponentModel.ISupportInitialize)roomgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button insertbtn;
        private Button deletebtn;
        private Button updatebtn;
        private Button refreshbtn;
        private TextBox typetb;
        private TextBox periodtb;
        private DataGridView roomgv;
        private DataGridViewTextBoxColumn ridDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rtypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rperiodDataGridViewTextBoxColumn;
        private BindingSource roomBindingSource;
        private Label label1;
        private Label label2;
        private DataGridView searchgv;
        private Button searchbtn;
        private TextBox searchtb;
        private Label label3;
    }
}