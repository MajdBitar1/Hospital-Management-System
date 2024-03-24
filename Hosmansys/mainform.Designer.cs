namespace Hosmansys
{
    partial class mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            patientbtn = new Button();
            docbtn = new Button();
            roombtn = new Button();
            employeebtn = new Button();
            SuspendLayout();
            // 
            // patientbtn
            // 
            patientbtn.Location = new Point(82, 50);
            patientbtn.Name = "patientbtn";
            patientbtn.Size = new Size(148, 51);
            patientbtn.TabIndex = 1;
            patientbtn.Text = "Patient";
            patientbtn.UseVisualStyleBackColor = true;
            patientbtn.Click += patientbtn_Click;
            // 
            // docbtn
            // 
            docbtn.Location = new Point(82, 350);
            docbtn.Name = "docbtn";
            docbtn.Size = new Size(148, 51);
            docbtn.TabIndex = 2;
            docbtn.Text = "Doctor";
            docbtn.UseVisualStyleBackColor = true;
            docbtn.Click += docbtn_Click;
            // 
            // roombtn
            // 
            roombtn.Location = new Point(82, 150);
            roombtn.Name = "roombtn";
            roombtn.Size = new Size(148, 51);
            roombtn.TabIndex = 3;
            roombtn.Text = "Rooms";
            roombtn.UseVisualStyleBackColor = true;
            roombtn.Click += roombtn_Click;
            // 
            // employeebtn
            // 
            employeebtn.Location = new Point(82, 250);
            employeebtn.Name = "employeebtn";
            employeebtn.Size = new Size(148, 51);
            employeebtn.TabIndex = 4;
            employeebtn.Text = "Employees";
            employeebtn.UseVisualStyleBackColor = true;
            employeebtn.Click += employeebtn_Click;
            // 
            // mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources.Screenshot_65;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(779, 450);
            Controls.Add(employeebtn);
            Controls.Add(roombtn);
            Controls.Add(docbtn);
            Controls.Add(patientbtn);
            Name = "mainform";
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion
        private Button patientbtn;
        private Button docbtn;
        private Button roombtn;
        private Button employeebtn;
    }
}