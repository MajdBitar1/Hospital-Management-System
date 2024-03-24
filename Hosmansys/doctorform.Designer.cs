namespace Hosmansys
{
    partial class doctorform
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
            departmenttb = new TextBox();
            salarytb = new TextBox();
            phonetb = new TextBox();
            docgv = new DataGridView();
            docIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            docnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            docgenderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            docdepartmentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            docsalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            docphonenbDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            doctorBindingSource = new BindingSource(components);
            searchgv = new DataGridView();
            searchbt = new Button();
            searchtb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)docgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchgv).BeginInit();
            SuspendLayout();
            // 
            // insertbtn
            // 
            insertbtn.Location = new Point(786, 415);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(75, 23);
            insertbtn.TabIndex = 0;
            insertbtn.Text = "Insert";
            insertbtn.UseVisualStyleBackColor = true;
            insertbtn.Click += insertbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(705, 415);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(75, 23);
            deletebtn.TabIndex = 1;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(624, 415);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(75, 23);
            updatebtn.TabIndex = 2;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // refreshbtn
            // 
            refreshbtn.Location = new Point(543, 415);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(75, 23);
            refreshbtn.TabIndex = 3;
            refreshbtn.Text = "Refresh";
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // nametb
            // 
            nametb.Location = new Point(66, 12);
            nametb.Name = "nametb";
            nametb.Size = new Size(100, 23);
            nametb.TabIndex = 4;
            // 
            // gendertb
            // 
            gendertb.Location = new Point(66, 41);
            gendertb.Name = "gendertb";
            gendertb.Size = new Size(100, 23);
            gendertb.TabIndex = 5;
            // 
            // departmenttb
            // 
            departmenttb.Location = new Point(66, 70);
            departmenttb.Name = "departmenttb";
            departmenttb.Size = new Size(100, 23);
            departmenttb.TabIndex = 6;
            // 
            // salarytb
            // 
            salarytb.Location = new Point(66, 99);
            salarytb.Name = "salarytb";
            salarytb.Size = new Size(100, 23);
            salarytb.TabIndex = 7;
            // 
            // phonetb
            // 
            phonetb.Location = new Point(66, 128);
            phonetb.Name = "phonetb";
            phonetb.Size = new Size(100, 23);
            phonetb.TabIndex = 8;
            // 
            // docgv
            // 
            docgv.AutoGenerateColumns = false;
            docgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            docgv.Columns.AddRange(new DataGridViewColumn[] { docIdDataGridViewTextBoxColumn, docnameDataGridViewTextBoxColumn, docgenderDataGridViewTextBoxColumn, docdepartmentDataGridViewTextBoxColumn, docsalaryDataGridViewTextBoxColumn, docphonenbDataGridViewTextBoxColumn });
            docgv.DataSource = doctorBindingSource;
            docgv.Location = new Point(220, 12);
            docgv.Name = "docgv";
            docgv.RowTemplate.Height = 25;
            docgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            docgv.Size = new Size(644, 218);
            docgv.TabIndex = 9;
            docgv.CellContentClick += docgv_CellContentClick;
            // 
            // docIdDataGridViewTextBoxColumn
            // 
            docIdDataGridViewTextBoxColumn.DataPropertyName = "DocId";
            docIdDataGridViewTextBoxColumn.HeaderText = "DocId";
            docIdDataGridViewTextBoxColumn.Name = "docIdDataGridViewTextBoxColumn";
            // 
            // docnameDataGridViewTextBoxColumn
            // 
            docnameDataGridViewTextBoxColumn.DataPropertyName = "Docname";
            docnameDataGridViewTextBoxColumn.HeaderText = "Docname";
            docnameDataGridViewTextBoxColumn.Name = "docnameDataGridViewTextBoxColumn";
            // 
            // docgenderDataGridViewTextBoxColumn
            // 
            docgenderDataGridViewTextBoxColumn.DataPropertyName = "Docgender";
            docgenderDataGridViewTextBoxColumn.HeaderText = "Docgender";
            docgenderDataGridViewTextBoxColumn.Name = "docgenderDataGridViewTextBoxColumn";
            // 
            // docdepartmentDataGridViewTextBoxColumn
            // 
            docdepartmentDataGridViewTextBoxColumn.DataPropertyName = "Docdepartment";
            docdepartmentDataGridViewTextBoxColumn.HeaderText = "Docdepartment";
            docdepartmentDataGridViewTextBoxColumn.Name = "docdepartmentDataGridViewTextBoxColumn";
            // 
            // docsalaryDataGridViewTextBoxColumn
            // 
            docsalaryDataGridViewTextBoxColumn.DataPropertyName = "Docsalary";
            docsalaryDataGridViewTextBoxColumn.HeaderText = "Docsalary";
            docsalaryDataGridViewTextBoxColumn.Name = "docsalaryDataGridViewTextBoxColumn";
            // 
            // docphonenbDataGridViewTextBoxColumn
            // 
            docphonenbDataGridViewTextBoxColumn.DataPropertyName = "Docphonenb";
            docphonenbDataGridViewTextBoxColumn.HeaderText = "Docphonenb";
            docphonenbDataGridViewTextBoxColumn.Name = "docphonenbDataGridViewTextBoxColumn";
            // 
            // doctorBindingSource
            // 
            doctorBindingSource.DataSource = typeof(Repositorys.Models.Doctor);
            // 
            // searchgv
            // 
            searchgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchgv.Location = new Point(220, 236);
            searchgv.Name = "searchgv";
            searchgv.RowTemplate.Height = 25;
            searchgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchgv.Size = new Size(644, 156);
            searchgv.TabIndex = 10;
            searchgv.CellContentClick += searchgv_CellContentClick;
            // 
            // searchbt
            // 
            searchbt.Location = new Point(66, 291);
            searchbt.Name = "searchbt";
            searchbt.Size = new Size(75, 23);
            searchbt.TabIndex = 11;
            searchbt.Text = "Search";
            searchbt.UseVisualStyleBackColor = true;
            searchbt.Click += searchbt_Click;
            // 
            // searchtb
            // 
            searchtb.Location = new Point(66, 262);
            searchtb.Name = "searchtb";
            searchtb.Size = new Size(100, 23);
            searchtb.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 13;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 14;
            label2.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 15;
            label3.Text = "Depart:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 102);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 16;
            label4.Text = "Salary:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 136);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 131);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 18;
            label6.Text = "Phone:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 265);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 19;
            label7.Text = "Search:";
            // 
            // doctorform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchtb);
            Controls.Add(searchbt);
            Controls.Add(searchgv);
            Controls.Add(docgv);
            Controls.Add(phonetb);
            Controls.Add(salarytb);
            Controls.Add(departmenttb);
            Controls.Add(gendertb);
            Controls.Add(nametb);
            Controls.Add(refreshbtn);
            Controls.Add(updatebtn);
            Controls.Add(deletebtn);
            Controls.Add(insertbtn);
            Name = "doctorform";
            Text = "doctorform";
            ((System.ComponentModel.ISupportInitialize)docgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorBindingSource).EndInit();
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
        private TextBox departmenttb;
        private TextBox salarytb;
        private TextBox phonetb;
        private DataGridView docgv;
        private DataGridViewTextBoxColumn docIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn docnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn docgenderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn docdepartmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn docsalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn docphonenbDataGridViewTextBoxColumn;
        private BindingSource doctorBindingSource;
        private DataGridView searchgv;
        private Button searchbt;
        private TextBox searchtb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}