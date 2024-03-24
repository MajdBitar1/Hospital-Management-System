namespace Hosmansys
{
    partial class patientform
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
            nametb = new TextBox();
            gendertb = new TextBox();
            addtb = new TextBox();
            phonetb = new TextBox();
            dischargedtb = new TextBox();
            admittedtb = new TextBox();
            patientgv = new DataGridView();
            pidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pgenderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pcontactnberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pDateadmittedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pDatedischargedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            RoomNber = new DataGridViewTextBoxColumn();
            patientBindingSource1 = new BindingSource(components);
            patientBindingSource = new BindingSource(components);
            roomtb = new TextBox();
            searchgv = new DataGridView();
            searchtb = new TextBox();
            searchbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)patientgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).BeginInit();
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
            refreshbtn.Text = "refresh";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // nametb
            // 
            nametb.Location = new Point(91, 12);
            nametb.Name = "nametb";
            nametb.Size = new Size(100, 23);
            nametb.TabIndex = 4;
            // 
            // gendertb
            // 
            gendertb.Location = new Point(91, 41);
            gendertb.Name = "gendertb";
            gendertb.Size = new Size(100, 23);
            gendertb.TabIndex = 5;
            // 
            // addtb
            // 
            addtb.Location = new Point(91, 70);
            addtb.Name = "addtb";
            addtb.Size = new Size(100, 23);
            addtb.TabIndex = 6;
            // 
            // phonetb
            // 
            phonetb.Location = new Point(91, 99);
            phonetb.Name = "phonetb";
            phonetb.Size = new Size(100, 23);
            phonetb.TabIndex = 7;
            // 
            // dischargedtb
            // 
            dischargedtb.Location = new Point(91, 157);
            dischargedtb.Name = "dischargedtb";
            dischargedtb.Size = new Size(100, 23);
            dischargedtb.TabIndex = 8;
            // 
            // admittedtb
            // 
            admittedtb.Location = new Point(91, 128);
            admittedtb.Name = "admittedtb";
            admittedtb.Size = new Size(100, 23);
            admittedtb.TabIndex = 9;
            // 
            // patientgv
            // 
            patientgv.AutoGenerateColumns = false;
            patientgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientgv.Columns.AddRange(new DataGridViewColumn[] { pidDataGridViewTextBoxColumn, pnameDataGridViewTextBoxColumn, pgenderDataGridViewTextBoxColumn, paddressDataGridViewTextBoxColumn, pcontactnberDataGridViewTextBoxColumn, pDateadmittedDataGridViewTextBoxColumn, pDatedischargedDataGridViewTextBoxColumn, RoomNber });
            patientgv.DataSource = patientBindingSource1;
            patientgv.Location = new Point(209, 12);
            patientgv.Name = "patientgv";
            patientgv.RowTemplate.Height = 25;
            patientgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            patientgv.Size = new Size(845, 228);
            patientgv.TabIndex = 10;
            patientgv.CellContentClick += patientgv_CellContentClick;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            pidDataGridViewTextBoxColumn.DataPropertyName = "Pid";
            pidDataGridViewTextBoxColumn.HeaderText = "Pid";
            pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            pnameDataGridViewTextBoxColumn.DataPropertyName = "Pname";
            pnameDataGridViewTextBoxColumn.HeaderText = "Pname";
            pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            // 
            // pgenderDataGridViewTextBoxColumn
            // 
            pgenderDataGridViewTextBoxColumn.DataPropertyName = "Pgender";
            pgenderDataGridViewTextBoxColumn.HeaderText = "Pgender";
            pgenderDataGridViewTextBoxColumn.Name = "pgenderDataGridViewTextBoxColumn";
            // 
            // paddressDataGridViewTextBoxColumn
            // 
            paddressDataGridViewTextBoxColumn.DataPropertyName = "Paddress";
            paddressDataGridViewTextBoxColumn.HeaderText = "Paddress";
            paddressDataGridViewTextBoxColumn.Name = "paddressDataGridViewTextBoxColumn";
            // 
            // pcontactnberDataGridViewTextBoxColumn
            // 
            pcontactnberDataGridViewTextBoxColumn.DataPropertyName = "Pcontactnber";
            pcontactnberDataGridViewTextBoxColumn.HeaderText = "Pcontactnber";
            pcontactnberDataGridViewTextBoxColumn.Name = "pcontactnberDataGridViewTextBoxColumn";
            // 
            // pDateadmittedDataGridViewTextBoxColumn
            // 
            pDateadmittedDataGridViewTextBoxColumn.DataPropertyName = "PDateadmitted";
            pDateadmittedDataGridViewTextBoxColumn.HeaderText = "PDateadmitted";
            pDateadmittedDataGridViewTextBoxColumn.Name = "pDateadmittedDataGridViewTextBoxColumn";
            // 
            // pDatedischargedDataGridViewTextBoxColumn
            // 
            pDatedischargedDataGridViewTextBoxColumn.DataPropertyName = "PDatedischarged";
            pDatedischargedDataGridViewTextBoxColumn.HeaderText = "PDatedischarged";
            pDatedischargedDataGridViewTextBoxColumn.Name = "pDatedischargedDataGridViewTextBoxColumn";
            // 
            // RoomNber
            // 
            RoomNber.DataPropertyName = "RoomNber";
            RoomNber.HeaderText = "RoomNber";
            RoomNber.Name = "RoomNber";
            // 
            // patientBindingSource1
            // 
            patientBindingSource1.DataSource = typeof(Repositorys.Models.Patient);
            // 
            // patientBindingSource
            // 
            patientBindingSource.DataSource = typeof(Repositorys.Models.Patient);
            // 
            // roomtb
            // 
            roomtb.Location = new Point(91, 186);
            roomtb.Name = "roomtb";
            roomtb.Size = new Size(100, 23);
            roomtb.TabIndex = 11;
            // 
            // searchgv
            // 
            searchgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchgv.Location = new Point(209, 246);
            searchgv.Name = "searchgv";
            searchgv.RowTemplate.Height = 25;
            searchgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchgv.Size = new Size(845, 125);
            searchgv.TabIndex = 12;
            searchgv.CellContentClick += searchgv_CellContentClick;
            // 
            // searchtb
            // 
            searchtb.Location = new Point(91, 267);
            searchtb.Name = "searchtb";
            searchtb.Size = new Size(100, 23);
            searchtb.TabIndex = 13;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(91, 313);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 14;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 15;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 49);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 16;
            label2.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 107);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 17;
            label3.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 78);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 17;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 136);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 18;
            label5.Text = "Admit Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 160);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 19;
            label6.Text = "Dischar Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 189);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 20;
            label7.Text = "Room N:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 270);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 21;
            label8.Text = "Search:";
            // 
            // patientform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 454);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchbtn);
            Controls.Add(searchtb);
            Controls.Add(searchgv);
            Controls.Add(roomtb);
            Controls.Add(patientgv);
            Controls.Add(admittedtb);
            Controls.Add(dischargedtb);
            Controls.Add(phonetb);
            Controls.Add(addtb);
            Controls.Add(gendertb);
            Controls.Add(nametb);
            Controls.Add(refreshbtn);
            Controls.Add(updatebtn);
            Controls.Add(deletebtn);
            Controls.Add(insertbtn);
            Name = "patientform";
            Text = "patientform";
            ((System.ComponentModel.ISupportInitialize)patientgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button insertbtn;
        private Button deletebtn;
        private Button updatebtn;
        private Button refreshbtn;
        private TextBox nametb;
        private TextBox gendertb;
        private TextBox addtb;
        private TextBox phonetb;
        private TextBox dischargedtb;
        private TextBox admittedtb;
        private DataGridView patientgv;
        private BindingSource patientBindingSource;
        private TextBox roomtb;
        private DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pgenderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pcontactnberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pDateadmittedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pDatedischargedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn RoomNber;
        private BindingSource patientBindingSource1;
        private DataGridView searchgv;
        private TextBox searchtb;
        private Button searchbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}