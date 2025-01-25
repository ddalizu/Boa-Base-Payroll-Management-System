namespace PayrollManagementSystem
{
    partial class Employees
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
            this.employeeList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addEmployee = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.metrics = new System.Windows.Forms.Button();
            this.modifyEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeList
            // 
            this.employeeList.AllowUserToAddRows = false;
            this.employeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.firstName,
            this.lastName,
            this.baseSalary,
            this.department,
            this.phoneNumber});
            this.employeeList.Location = new System.Drawing.Point(29, 156);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(645, 196);
            this.employeeList.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            // 
            // baseSalary
            // 
            this.baseSalary.HeaderText = "Base Salary";
            this.baseSalary.Name = "baseSalary";
            // 
            // department
            // 
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Phone No.";
            this.phoneNumber.Name = "phoneNumber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee List";
            // 
            // addEmployee
            // 
            this.addEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee.Location = new System.Drawing.Point(99, 466);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(148, 31);
            this.addEmployee.TabIndex = 3;
            this.addEmployee.Text = "Add Employee";
            this.addEmployee.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(78, 33);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(46, 23);
            this.home.TabIndex = 6;
            this.home.Text = "home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(26, 34);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(46, 23);
            this.back.TabIndex = 7;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            // 
            // metrics
            // 
            this.metrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metrics.Location = new System.Drawing.Point(566, 466);
            this.metrics.Name = "metrics";
            this.metrics.Size = new System.Drawing.Size(136, 31);
            this.metrics.TabIndex = 8;
            this.metrics.Text = "Reports";
            this.metrics.UseVisualStyleBackColor = true;
            // 
            // modifyEmployee
            // 
            this.modifyEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyEmployee.Location = new System.Drawing.Point(774, 141);
            this.modifyEmployee.Name = "modifyEmployee";
            this.modifyEmployee.Size = new System.Drawing.Size(161, 44);
            this.modifyEmployee.TabIndex = 9;
            this.modifyEmployee.Text = "Modify Employee";
            this.modifyEmployee.UseVisualStyleBackColor = true;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 684);
            this.Controls.Add(this.modifyEmployee);
            this.Controls.Add(this.metrics);
            this.Controls.Add(this.back);
            this.Controls.Add(this.home);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeList);
            this.Name = "Employees";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.employeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button metrics;
        private System.Windows.Forms.Button modifyEmployee;
    }
}