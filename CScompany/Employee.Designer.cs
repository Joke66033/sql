namespace CScompany
{
    partial class Employee
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.departmentType = new System.Windows.Forms.ComboBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.departmentCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.employeeCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 160);
            this.dataGridView1.TabIndex = 69;
            // 
            // departmentType
            // 
            this.departmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentType.FormattingEnabled = true;
            this.departmentType.Location = new System.Drawing.Point(314, 180);
            this.departmentType.Name = "departmentType";
            this.departmentType.Size = new System.Drawing.Size(267, 30);
            this.departmentType.TabIndex = 68;
            this.departmentType.SelectedIndexChanged += new System.EventHandler(this.departmentType_SelectedIndexChanged);
            // 
            // salary
            // 
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.Location = new System.Drawing.Point(209, 240);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(117, 28);
            this.salary.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 22);
            this.label5.TabIndex = 61;
            this.label5.Text = "บาท";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 60;
            this.label4.Text = "เงินเดือน";
            // 
            // depantmentCode
            // 
            this.departmentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentCode.Location = new System.Drawing.Point(209, 180);
            this.departmentCode.Name = "depantmentCode";
            this.departmentCode.Size = new System.Drawing.Size(89, 28);
            this.departmentCode.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 58;
            this.label3.Text = "แผนก";
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(632, 477);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(89, 49);
            this.bClose.TabIndex = 57;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(494, 477);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(89, 49);
            this.bDelete.TabIndex = 56;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Location = new System.Drawing.Point(352, 477);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(89, 49);
            this.bUpdate.TabIndex = 55;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bInsert
            // 
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsert.Location = new System.Drawing.Point(211, 477);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(89, 49);
            this.bInsert.TabIndex = 54;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bNew
            // 
            this.bNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNew.Location = new System.Drawing.Point(68, 477);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(99, 49);
            this.bNew.TabIndex = 53;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // employeeName
            // 
            this.employeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName.Location = new System.Drawing.Point(209, 124);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(292, 28);
            this.employeeName.TabIndex = 52;
            // 
            // employeeCode
            // 
            this.employeeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeCode.Location = new System.Drawing.Point(209, 74);
            this.employeeCode.Name = "employeeCode";
            this.employeeCode.Size = new System.Drawing.Size(147, 28);
            this.employeeCode.TabIndex = 51;
            this.employeeCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.employeeCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 50;
            this.label2.Text = "ชื่อพนักงาน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "รหัสพนักงาน";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.departmentType);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.departmentCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.employeeCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox departmentType;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox departmentCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.TextBox employeeCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}