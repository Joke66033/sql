namespace CScompany
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeCode = new System.Windows.Forms.TextBox();
            this.typeName = new System.Windows.Forms.TextBox();
            this.bNew = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัส";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // typeCode
            // 
            this.typeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCode.Location = new System.Drawing.Point(222, 112);
            this.typeCode.Name = "typeCode";
            this.typeCode.Size = new System.Drawing.Size(147, 28);
            this.typeCode.TabIndex = 2;
            this.typeCode.TextChanged += new System.EventHandler(this.typeCode_TextChanged);
            // 
            // typeName
            // 
            this.typeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeName.Location = new System.Drawing.Point(222, 162);
            this.typeName.Name = "typeName";
            this.typeName.Size = new System.Drawing.Size(292, 28);
            this.typeName.TabIndex = 3;
            this.typeName.TextChanged += new System.EventHandler(this.typeName_TextChanged);
            // 
            // bNew
            // 
            this.bNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNew.Location = new System.Drawing.Point(184, 273);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(99, 49);
            this.bNew.TabIndex = 4;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bInsert
            // 
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsert.Location = new System.Drawing.Point(363, 273);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(89, 49);
            this.bInsert.TabIndex = 5;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // Form1
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeCode;
        private System.Windows.Forms.TextBox typeName;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bInsert;
    }
}

