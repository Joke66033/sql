namespace CScompany
{
    partial class Department
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bClose = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.departmentName = new System.Windows.Forms.TextBox();
            this.departmentCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(157, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(495, 163);
            this.dataGridView1.TabIndex = 47;
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(638, 350);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(89, 49);
            this.bClose.TabIndex = 46;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(500, 350);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(89, 49);
            this.bDelete.TabIndex = 45;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Location = new System.Drawing.Point(358, 350);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(89, 49);
            this.bUpdate.TabIndex = 44;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bInsert
            // 
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsert.Location = new System.Drawing.Point(217, 350);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(89, 49);
            this.bInsert.TabIndex = 43;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bNew
            // 
            this.bNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNew.Location = new System.Drawing.Point(74, 350);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(99, 49);
            this.bNew.TabIndex = 42;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // departmentName
            // 
            this.departmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentName.Location = new System.Drawing.Point(260, 102);
            this.departmentName.Name = "departmentName";
            this.departmentName.Size = new System.Drawing.Size(292, 28);
            this.departmentName.TabIndex = 41;
            // 
            // departmentCode
            // 
            this.departmentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentCode.Location = new System.Drawing.Point(260, 52);
            this.departmentCode.Name = "departmentCode";
            this.departmentCode.Size = new System.Drawing.Size(147, 28);
            this.departmentCode.TabIndex = 40;
            this.departmentCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.departmentCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "ชื่อแผนก";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "รหัสแผนก";
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.departmentName);
            this.Controls.Add(this.departmentCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Department";
            this.Text = "Department";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.TextBox departmentName;
        private System.Windows.Forms.TextBox departmentCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}