namespace CScompany
{
    partial class Item
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
            this.bClose = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.itemName = new System.Windows.Forms.TextBox();
            this.itemCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.itemType = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(632, 453);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(89, 49);
            this.bClose.TabIndex = 35;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(494, 453);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(89, 49);
            this.bDelete.TabIndex = 34;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Location = new System.Drawing.Point(352, 453);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(89, 49);
            this.bUpdate.TabIndex = 33;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bInsert
            // 
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsert.Location = new System.Drawing.Point(211, 453);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(89, 49);
            this.bInsert.TabIndex = 32;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bNew
            // 
            this.bNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNew.Location = new System.Drawing.Point(68, 453);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(99, 49);
            this.bNew.TabIndex = 31;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // itemName
            // 
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(209, 100);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(292, 28);
            this.itemName.TabIndex = 30;
            // 
            // itemCode
            // 
            this.itemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCode.Location = new System.Drawing.Point(209, 50);
            this.itemCode.Name = "itemCode";
            this.itemCode.Size = new System.Drawing.Size(147, 28);
            this.itemCode.TabIndex = 29;
            this.itemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "ชื่อ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "รหัส";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "ประเภท";
            // 
            // typeCode
            // 
            this.typeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCode.Location = new System.Drawing.Point(209, 156);
            this.typeCode.Name = "typeCode";
            this.typeCode.Size = new System.Drawing.Size(89, 28);
            this.typeCode.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "ราคา";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 22);
            this.label5.TabIndex = 39;
            this.label5.Text = "บาท";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 40;
            this.label6.Text = "จำนวน";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(517, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 22);
            this.label8.TabIndex = 42;
            this.label8.Text = "เป็นเงิน";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(714, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 22);
            this.label9.TabIndex = 43;
            this.label9.Text = "บาท";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(134, 216);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(89, 28);
            this.price.TabIndex = 44;
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(403, 216);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(89, 28);
            this.qty.TabIndex = 45;
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(612, 216);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(89, 28);
            this.amount.TabIndex = 46;
            // 
            // itemType
            // 
            this.itemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemType.FormattingEnabled = true;
            this.itemType.Location = new System.Drawing.Point(314, 156);
            this.itemType.Name = "itemType";
            this.itemType.Size = new System.Drawing.Size(267, 30);
            this.itemType.TabIndex = 47;
            this.itemType.SelectedIndexChanged += new System.EventHandler(this.itemType_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 160);
            this.dataGridView1.TabIndex = 48;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.itemType);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.itemCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Item";
            this.Text = "Item";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.TextBox itemCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox typeCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.ComboBox itemType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}