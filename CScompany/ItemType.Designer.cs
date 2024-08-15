namespace CScompany
{
    partial class ItemType
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
            this.bInsert = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.typeName = new System.Windows.Forms.TextBox();
            this.typeCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bInsert
            // 
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsert.Location = new System.Drawing.Point(393, 263);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(89, 49);
            this.bInsert.TabIndex = 11;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            // 
            // bNew
            // 
            this.bNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNew.Location = new System.Drawing.Point(214, 263);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(99, 49);
            this.bNew.TabIndex = 10;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // typeName
            // 
            this.typeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeName.Location = new System.Drawing.Point(252, 152);
            this.typeName.Name = "typeName";
            this.typeName.Size = new System.Drawing.Size(292, 28);
            this.typeName.TabIndex = 9;
            // 
            // typeCode
            // 
            this.typeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCode.Location = new System.Drawing.Point(252, 102);
            this.typeCode.Name = "typeCode";
            this.typeCode.Size = new System.Drawing.Size(147, 28);
            this.typeCode.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "ชื่อ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "รหัส";
            // 
            // ItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.typeName);
            this.Controls.Add(this.typeCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ItemType";
            this.Text = "ItemType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.TextBox typeName;
        private System.Windows.Forms.TextBox typeCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}