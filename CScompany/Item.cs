namespace CScompany
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            บาท = new Label();
            pictureBox1 = new PictureBox();
            itemName = new TextBox();
            itemCode = new TextBox();
            typeCode = new TextBox();
            price = new TextBox();
            qty = new TextBox();
            amount = new TextBox();
            New = new Button();
            Insent = new Button();
            Update = new Button();
            Delete = new Button();
            close = new Button();
            Brows = new Button();
            itemType = new ComboBox();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(84, 58);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 0;
            label1.Text = "รหัส";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(84, 114);
            label2.Name = "label2";
            label2.Size = new Size(28, 21);
            label2.TabIndex = 1;
            label2.Text = "ชื่อ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(84, 169);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 2;
            label3.Text = "ประเภท";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(84, 230);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 3;
            label4.Text = "ราคา";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(210, 229);
            label5.Name = "label5";
            label5.Size = new Size(35, 21);
            label5.TabIndex = 4;
            label5.Text = "บาท";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(278, 229);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 5;
            label6.Text = "จำนวน";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(414, 230);
            label7.Name = "label7";
            label7.Size = new Size(53, 21);
            label7.TabIndex = 6;
            label7.Text = "เป็นเงิน";
            // 
            // บาท
            // 
            บาท.AutoSize = true;
            บาท.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            บาท.Location = new Point(553, 230);
            บาท.Name = "บาท";
            บาท.Size = new Size(35, 21);
            บาท.TabIndex = 7;
            บาท.Text = "บาท";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(595, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 142);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // itemName
            // 
            itemName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemName.Location = new Point(148, 56);
            itemName.Name = "itemName";
            itemName.Size = new Size(100, 27);
            itemName.TabIndex = 9;
            // 
            // itemCode
            // 
            itemCode.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemCode.Location = new Point(148, 112);
            itemCode.Name = "itemCode";
            itemCode.Size = new Size(247, 27);
            itemCode.TabIndex = 10;
            itemCode.KeyDown += itemCode_KeyDown;
            // 
            // typeCode
            // 
            typeCode.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeCode.Location = new Point(148, 167);
            typeCode.Name = "typeCode";
            typeCode.Size = new Size(43, 27);
            typeCode.TabIndex = 11;
            // 
            // price
            // 
            price.Location = new Point(130, 227);
            price.Name = "price";
            price.Size = new Size(74, 23);
            price.TabIndex = 12;
            // 
            // qty
            // 
            qty.Location = new Point(336, 227);
            qty.Name = "qty";
            qty.Size = new Size(44, 23);
            qty.TabIndex = 13;
            // 
            // amount
            // 
            amount.Location = new Point(473, 227);
            amount.Name = "amount";
            amount.Size = new Size(74, 23);
            amount.TabIndex = 14;
            // 
            // New
            // 
            New.Font = new Font("Segoe UI", 12F);
            New.Location = new Point(130, 445);
            New.Name = "New";
            New.Size = new Size(82, 30);
            New.TabIndex = 15;
            New.Text = "New";
            New.UseVisualStyleBackColor = true;
            New.Click += button1_Click;
            // 
            // Insent
            // 
            Insent.Font = new Font("Segoe UI", 12F);
            Insent.Location = new Point(244, 445);
            Insent.Name = "Insent";
            Insent.Size = new Size(86, 30);
            Insent.TabIndex = 16;
            Insent.Text = "Insent";
            Insent.UseVisualStyleBackColor = true;
            Insent.Click += Insent_Click;
            // 
            // Update
            // 
            Update.Font = new Font("Segoe UI", 12F);
            Update.Location = new Point(370, 445);
            Update.Name = "Update";
            Update.Size = new Size(76, 30);
            Update.TabIndex = 17;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Delete
            // 
            Delete.Font = new Font("Segoe UI", 12F);
            Delete.Location = new Point(482, 445);
            Delete.Name = "Delete";
            Delete.Size = new Size(77, 30);
            Delete.TabIndex = 18;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // close
            // 
            close.Font = new Font("Segoe UI", 12F);
            close.Location = new Point(595, 445);
            close.Name = "close";
            close.Size = new Size(78, 30);
            close.TabIndex = 19;
            close.Text = "close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // Brows
            // 
            Brows.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Brows.Location = new Point(635, 160);
            Brows.Name = "Brows";
            Brows.Size = new Size(77, 30);
            Brows.TabIndex = 20;
            Brows.Text = "Brows";
            Brows.UseVisualStyleBackColor = true;
            Brows.Click += Brows_Click;
            // 
            // itemType
            // 
            itemType.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemType.FormattingEnabled = true;
            itemType.Location = new Point(219, 167);
            itemType.Name = "itemType";
            itemType.Size = new Size(227, 28);
            itemType.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 268);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(715, 156);
            dataGridView1.TabIndex = 22;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(dataGridView1);
            Controls.Add(itemType);
            Controls.Add(Brows);
            Controls.Add(close);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Insent);
            Controls.Add(New);
            Controls.Add(amount);
            Controls.Add(qty);
            Controls.Add(price);
            Controls.Add(typeCode);
            Controls.Add(itemCode);
            Controls.Add(itemName);
            Controls.Add(pictureBox1);
            Controls.Add(บาท);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label บาท;
        private PictureBox pictureBox1;
        private TextBox itemName;
        private TextBox itemCode;
        private TextBox typeCode;
        private TextBox price;
        private TextBox qty;
        private TextBox amount;
        private Button New;
        private Button Insent;
        private Button Update;
        private Button Delete;
        private Button close;
        private Button Brows;
        private ComboBox itemType;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
        private OpenFileDialog openFileDialog1;
    }
}
