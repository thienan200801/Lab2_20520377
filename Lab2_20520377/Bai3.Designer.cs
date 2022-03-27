namespace Lab2_20520377
{
    partial class Bai3
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
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.readFromFile = new System.Windows.Forms.RichTextBox();
            this.writeToFile = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(78, 32);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(148, 40);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Đọc";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(354, 32);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(148, 40);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Tính";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(614, 32);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(148, 40);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Ghi";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // readFromFile
            // 
            this.readFromFile.Location = new System.Drawing.Point(-2, 134);
            this.readFromFile.Name = "readFromFile";
            this.readFromFile.ReadOnly = true;
            this.readFromFile.Size = new System.Drawing.Size(431, 354);
            this.readFromFile.TabIndex = 3;
            this.readFromFile.Text = "";
            // 
            // writeToFile
            // 
            this.writeToFile.BackColor = System.Drawing.SystemColors.Control;
            this.writeToFile.Location = new System.Drawing.Point(425, 134);
            this.writeToFile.Name = "writeToFile";
            this.writeToFile.ReadOnly = true;
            this.writeToFile.Size = new System.Drawing.Size(450, 354);
            this.writeToFile.TabIndex = 4;
            this.writeToFile.Text = "";
//            this.writeToFile.TextChanged += new System.EventHandler(this.writeToFile_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "(Dữ liệu trong file chỉ chứa chuỗi các toán hạng và toán tử phân cách bằng khoảng" +
    " trắng)";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.writeToFile);
            this.Controls.Add(this.readFromFile);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnRead);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.RichTextBox readFromFile;
        private System.Windows.Forms.RichTextBox writeToFile;
        private System.Windows.Forms.Label label1;
    }
}