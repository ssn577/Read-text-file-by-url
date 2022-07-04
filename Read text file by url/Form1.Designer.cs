
namespace Read_text_file_by_url
{
    partial class frm_read_text_by_url
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
            this.text_read = new System.Windows.Forms.TextBox();
            this.get = new System.Windows.Forms.Button();
            this.btn_creator = new System.Windows.Forms.Button();
            this.text_url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_read
            // 
            this.text_read.Location = new System.Drawing.Point(67, 32);
            this.text_read.Multiline = true;
            this.text_read.Name = "text_read";
            this.text_read.Size = new System.Drawing.Size(248, 120);
            this.text_read.TabIndex = 6;
            // 
            // get
            // 
            this.get.Location = new System.Drawing.Point(321, 129);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(93, 23);
            this.get.TabIndex = 2;
            this.get.Text = "Receive";
            this.get.UseVisualStyleBackColor = true;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // btn_creator
            // 
            this.btn_creator.Location = new System.Drawing.Point(321, 100);
            this.btn_creator.Name = "btn_creator";
            this.btn_creator.Size = new System.Drawing.Size(93, 23);
            this.btn_creator.TabIndex = 3;
            this.btn_creator.Text = "Creator";
            this.btn_creator.UseVisualStyleBackColor = true;
            this.btn_creator.Click += new System.EventHandler(this.btn_creator_Click);
            // 
            // text_url
            // 
            this.text_url.Location = new System.Drawing.Point(67, 6);
            this.text_url.Name = "text_url";
            this.text_url.Size = new System.Drawing.Size(248, 20);
            this.text_url.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message :";
            // 
            // frm_read_text_by_url
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 157);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_url);
            this.Controls.Add(this.btn_creator);
            this.Controls.Add(this.get);
            this.Controls.Add(this.text_read);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_read_text_by_url";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read Text file by URL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_read;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.Button btn_creator;
        private System.Windows.Forms.TextBox text_url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

