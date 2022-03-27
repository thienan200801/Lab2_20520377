namespace Lab2_20520377
{
    partial class Bai5
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
            this.Path = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btn_browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // Path
            // 
            this.Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Path.Location = new System.Drawing.Point(74, 16);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(756, 27);
            this.Path.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(973, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(105, 37);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(1, 59);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1110, 497);
            this.webBrowser.TabIndex = 4;
            // 
            // btn_browse
            // 
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Location = new System.Drawing.Point(858, 12);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(109, 37);
            this.btn_browse.TabIndex = 5;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 561);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.label1);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btn_browse;
    }
}