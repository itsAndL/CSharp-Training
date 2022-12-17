namespace MicrosoftEmployeesUI
{
    partial class microsoftEmployees
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.fullNameText = new System.Windows.Forms.TextBox();
            this.departmentText = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.jobText = new System.Windows.Forms.TextBox();
            this.jobLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addEmployee = new System.Windows.Forms.Button();
            this.allEmployeesGroupBox = new System.Windows.Forms.GroupBox();
            this.nameAllEmployesLabel = new System.Windows.Forms.Label();
            this.nameAllEmployeesDropdown = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.allEmployeesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuStrip,
            this.helpMenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1194, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuStrip
            // 
            this.fileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuStrip});
            this.fileMenuStrip.Name = "fileMenuStrip";
            this.fileMenuStrip.Size = new System.Drawing.Size(46, 24);
            this.fileMenuStrip.Text = "&File";
            // 
            // exitMenuStrip
            // 
            this.exitMenuStrip.Name = "exitMenuStrip";
            this.exitMenuStrip.Size = new System.Drawing.Size(116, 26);
            this.exitMenuStrip.Text = "&Exit";
            this.exitMenuStrip.Click += new System.EventHandler(this.exitMenuStrip_Click);
            // 
            // helpMenuStrip
            // 
            this.helpMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuStrip});
            this.helpMenuStrip.Name = "helpMenuStrip";
            this.helpMenuStrip.Size = new System.Drawing.Size(55, 24);
            this.helpMenuStrip.Text = "&Help";
            // 
            // aboutMenuStrip
            // 
            this.aboutMenuStrip.Name = "aboutMenuStrip";
            this.aboutMenuStrip.Size = new System.Drawing.Size(133, 26);
            this.aboutMenuStrip.Text = "&About";
            this.aboutMenuStrip.Click += new System.EventHandler(this.aboutMenuStrip_Click);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(22, 66);
            this.fullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(178, 35);
            this.fullNameLabel.TabIndex = 1;
            this.fullNameLabel.Text = "Full Name";
            // 
            // fullNameText
            // 
            this.fullNameText.Location = new System.Drawing.Point(250, 63);
            this.fullNameText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.Size = new System.Drawing.Size(406, 42);
            this.fullNameText.TabIndex = 2;
            // 
            // departmentText
            // 
            this.departmentText.Location = new System.Drawing.Point(250, 134);
            this.departmentText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.departmentText.Name = "departmentText";
            this.departmentText.Size = new System.Drawing.Size(406, 42);
            this.departmentText.TabIndex = 4;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(22, 138);
            this.departmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(207, 35);
            this.departmentLabel.TabIndex = 3;
            this.departmentLabel.Text = "Department";
            // 
            // jobText
            // 
            this.jobText.Location = new System.Drawing.Point(250, 210);
            this.jobText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jobText.Name = "jobText";
            this.jobText.Size = new System.Drawing.Size(406, 42);
            this.jobText.TabIndex = 6;
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(22, 213);
            this.jobLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(71, 35);
            this.jobLabel.TabIndex = 5;
            this.jobLabel.Text = "Job";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(250, 278);
            this.emailText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(406, 42);
            this.emailText.TabIndex = 8;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(22, 281);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(109, 35);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email";
            // 
            // addEmployee
            // 
            this.addEmployee.Location = new System.Drawing.Point(129, 398);
            this.addEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(292, 60);
            this.addEmployee.TabIndex = 9;
            this.addEmployee.Text = "Add Employee";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // allEmployeesGroupBox
            // 
            this.allEmployeesGroupBox.BackColor = System.Drawing.Color.Aquamarine;
            this.allEmployeesGroupBox.Controls.Add(this.nameAllEmployesLabel);
            this.allEmployeesGroupBox.Controls.Add(this.nameAllEmployeesDropdown);
            this.allEmployeesGroupBox.Location = new System.Drawing.Point(708, 105);
            this.allEmployeesGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allEmployeesGroupBox.Name = "allEmployeesGroupBox";
            this.allEmployeesGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allEmployeesGroupBox.Size = new System.Drawing.Size(455, 190);
            this.allEmployeesGroupBox.TabIndex = 10;
            this.allEmployeesGroupBox.TabStop = false;
            this.allEmployeesGroupBox.Text = "All Employees";
            // 
            // nameAllEmployesLabel
            // 
            this.nameAllEmployesLabel.AutoSize = true;
            this.nameAllEmployesLabel.Location = new System.Drawing.Point(24, 69);
            this.nameAllEmployesLabel.Name = "nameAllEmployesLabel";
            this.nameAllEmployesLabel.Size = new System.Drawing.Size(107, 35);
            this.nameAllEmployesLabel.TabIndex = 1;
            this.nameAllEmployesLabel.Text = "Name";
            // 
            // nameAllEmployeesDropdown
            // 
            this.nameAllEmployeesDropdown.DisplayMember = "FullName";
            this.nameAllEmployeesDropdown.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nameAllEmployeesDropdown.FormattingEnabled = true;
            this.nameAllEmployeesDropdown.Items.AddRange(new object[] {
            "Full Name",
            "Department",
            "Job",
            "Email"});
            this.nameAllEmployeesDropdown.Location = new System.Drawing.Point(149, 77);
            this.nameAllEmployeesDropdown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameAllEmployeesDropdown.Name = "nameAllEmployeesDropdown";
            this.nameAllEmployeesDropdown.Size = new System.Drawing.Size(262, 29);
            this.nameAllEmployeesDropdown.TabIndex = 0;
            // 
            // microsoftEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 560);
            this.Controls.Add(this.allEmployeesGroupBox);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.jobText);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.departmentText);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.fullNameText);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "microsoftEmployees";
            this.Text = "Microsoft Employees";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.allEmployeesGroupBox.ResumeLayout(false);
            this.allEmployeesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileMenuStrip;
        private ToolStripMenuItem exitMenuStrip;
        private ToolStripMenuItem helpMenuStrip;
        private ToolStripMenuItem aboutMenuStrip;
        private Label fullNameLabel;
        private TextBox fullNameText;
        private Label departmentLabel;
        private TextBox departmentText;
        private TextBox jobText;
        private Label jobLabel;
        private TextBox emailText;
        private Label emailLabel;
        private Button addEmployee;
        private GroupBox allEmployeesGroupBox;
        private ComboBox nameAllEmployeesDropdown;
        private Label nameAllEmployesLabel;
    }
}
