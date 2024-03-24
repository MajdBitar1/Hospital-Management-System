namespace Hosmansys
{
    partial class employeeform
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
            salarytb = new TextBox();
            phonetb = new TextBox();
            jobtb = new TextBox();
            employeegv = new DataGridView();
            eidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            egenderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            esalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ephonenberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ejobDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeBindingSource = new BindingSource(components);
            employeesearchgv = new DataGridView();
            searchtb = new TextBox();
            searchbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)employeegv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeesearchgv).BeginInit();
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
            // nametb
            // 
            nametb.Location = new Point(60, 12);
            nametb.Name = "nametb";
            nametb.Size = new Size(100, 23);
            nametb.TabIndex = 4;
            // 
            // gendertb
            // 
            gendertb.Location = new Point(60, 41);
            gendertb.Name = "gendertb";
            gendertb.Size = new Size(100, 23);
            gendertb.TabIndex = 5;
            // 
            // salarytb
            // 
            salarytb.Location = new Point(60, 70);
            salarytb.Name = "salarytb";
            salarytb.Size = new Size(100, 23);
            salarytb.TabIndex = 6;
            // 
            // phonetb
            // 
            phonetb.Location = new Point(60, 99);
            phonetb.Name = "phonetb";
            phonetb.Size = new Size(100, 23);
            phonetb.TabIndex = 7;
            // 
            // jobtb
            // 
            jobtb.Location = new Point(60, 128);
            jobtb.Name = "jobtb";
            jobtb.Size = new Size(100, 23);
            jobtb.TabIndex = 8;
            // 
            // employeegv
            // 
            employeegv.AutoGenerateColumns = false;
            employeegv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeegv.Columns.AddRange(new DataGridViewColumn[] { eidDataGridViewTextBoxColumn, enameDataGridViewTextBoxColumn, egenderDataGridViewTextBoxColumn, esalaryDataGridViewTextBoxColumn, ephonenberDataGridViewTextBoxColumn, ejobDataGridViewTextBoxColumn });
            employeegv.DataSource = employeeBindingSource;
            employeegv.Location = new Point(255, 12);
            employeegv.Name = "employeegv";
            employeegv.RowTemplate.Height = 25;
            employeegv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeegv.Size = new Size(644, 232);
            employeegv.TabIndex = 9;
            employeegv.CellContentClick += employeegv_CellContentClick;
            // 
            // eidDataGridViewTextBoxColumn
            // 
            eidDataGridViewTextBoxColumn.DataPropertyName = "Eid";
            eidDataGridViewTextBoxColumn.HeaderText = "Eid";
            eidDataGridViewTextBoxColumn.Name = "eidDataGridViewTextBoxColumn";
            // 
            // enameDataGridViewTextBoxColumn
            // 
            enameDataGridViewTextBoxColumn.DataPropertyName = "Ename";
            enameDataGridViewTextBoxColumn.HeaderText = "Ename";
            enameDataGridViewTextBoxColumn.Name = "enameDataGridViewTextBoxColumn";
            // 
            // egenderDataGridViewTextBoxColumn
            // 
            egenderDataGridViewTextBoxColumn.DataPropertyName = "Egender";
            egenderDataGridViewTextBoxColumn.HeaderText = "Egender";
            egenderDataGridViewTextBoxColumn.Name = "egenderDataGridViewTextBoxColumn";
            // 
            // esalaryDataGridViewTextBoxColumn
            // 
            esalaryDataGridViewTextBoxColumn.DataPropertyName = "Esalary";
            esalaryDataGridViewTextBoxColumn.HeaderText = "Esalary";
            esalaryDataGridViewTextBoxColumn.Name = "esalaryDataGridViewTextBoxColumn";
            // 
            // ephonenberDataGridViewTextBoxColumn
            // 
            ephonenberDataGridViewTextBoxColumn.DataPropertyName = "Ephonenber";
            ephonenberDataGridViewTextBoxColumn.HeaderText = "Ephonenber";
            ephonenberDataGridViewTextBoxColumn.Name = "ephonenberDataGridViewTextBoxColumn";
            // 
            // ejobDataGridViewTextBoxColumn
            // 
            ejobDataGridViewTextBoxColumn.DataPropertyName = "Ejob";
            ejobDataGridViewTextBoxColumn.HeaderText = "Ejob";
            ejobDataGridViewTextBoxColumn.Name = "ejobDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Repositorys.Models.Employee);
            // 
            // employeesearchgv
            // 
            employeesearchgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeesearchgv.Location = new Point(255, 250);
            employeesearchgv.Name = "employeesearchgv";
            employeesearchgv.RowTemplate.Height = 25;
            employeesearchgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeesearchgv.Size = new Size(644, 150);
            employeesearchgv.TabIndex = 10;
            employeesearchgv.CellContentClick += employeesearchgv_CellContentClick;
            // 
            // searchtb
            // 
            searchtb.Location = new Point(60, 271);
            searchtb.Name = "searchtb";
            searchtb.Size = new Size(100, 23);
            searchtb.TabIndex = 11;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(60, 309);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 12;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
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
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 15;
            label3.Text = "Salary:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 107);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 16;
            label4.Text = "Phone:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 136);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 17;
            label5.Text = "Job:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 274);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 18;
            label6.Text = "Search:";
            // 
            // employeeform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 453);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchbtn);
            Controls.Add(searchtb);
            Controls.Add(employeesearchgv);
            Controls.Add(employeegv);
            Controls.Add(jobtb);
            Controls.Add(phonetb);
            Controls.Add(salarytb);
            Controls.Add(gendertb);
            Controls.Add(nametb);
            Controls.Add(refreshbtn);
            Controls.Add(updatebtn);
            Controls.Add(deletebtn);
            Controls.Add(insertbtn);
            Name = "employeeform";
            Text = "employeeform";
            ((System.ComponentModel.ISupportInitialize)employeegv).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeesearchgv).EndInit();
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
        private TextBox salarytb;
        private TextBox phonetb;
        private TextBox jobtb;
        private DataGridView employeegv;
        private DataGridViewTextBoxColumn eidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egenderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn esalaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ephonenberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ejobDataGridViewTextBoxColumn;
        private BindingSource employeeBindingSource;
        private DataGridView employeesearchgv;
        private TextBox searchtb;
        private Button searchbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}