
namespace Personnel
{
    partial class Personal
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
            this.components = new System.ComponentModel.Container();
            this.loadButton_Click = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HourlyPayRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourlyPayRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelDataSet = new Personnel.PersonnelDataSet();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new Personnel.PersonnelDataSetTableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // loadButton_Click
            // 
            this.loadButton_Click.Location = new System.Drawing.Point(88, 336);
            this.loadButton_Click.Name = "loadButton_Click";
            this.loadButton_Click.Size = new System.Drawing.Size(75, 23);
            this.loadButton_Click.TabIndex = 0;
            this.loadButton_Click.Text = "Load Data";
            this.loadButton_Click.UseVisualStyleBackColor = true;
            this.loadButton_Click.Click += new System.EventHandler(this.loadButton_Click_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(657, 336);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Position,
            this.HourlyPayRate,
            this.employeeIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.hourlyPayRateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(191, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 263);
            this.dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            // 
            // HourlyPayRate
            // 
            this.HourlyPayRate.HeaderText = "HourlyPayRate";
            this.HourlyPayRate.Name = "HourlyPayRate";
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // hourlyPayRateDataGridViewTextBoxColumn
            // 
            this.hourlyPayRateDataGridViewTextBoxColumn.DataPropertyName = "HourlyPayRate";
            this.hourlyPayRateDataGridViewTextBoxColumn.HeaderText = "HourlyPayRate";
            this.hourlyPayRateDataGridViewTextBoxColumn.Name = "hourlyPayRateDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.personnelDataSet;
            // 
            // personnelDataSet
            // 
            this.personnelDataSet.DataSetName = "PersonnelDataSet";
            this.personnelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(253, 335);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(398, 335);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(532, 336);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton_Click);
            this.Name = "Personal";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadButton_Click;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourlyPayRate;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private PersonnelDataSet personnelDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private PersonnelDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourlyPayRateDataGridViewTextBoxColumn;
    }
}

