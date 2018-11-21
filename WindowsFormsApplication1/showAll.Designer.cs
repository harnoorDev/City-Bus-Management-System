namespace CityBusManagement
{
    partial class showAll
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
            this.btn_show = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtBox_busNo = new System.Windows.Forms.TextBox();
            this.Bus_No = new System.Windows.Forms.Label();
            this.textBox_details = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(261, 13);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 1;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(54, 67);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(237, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // txtBox_busNo
            // 
            this.txtBox_busNo.Location = new System.Drawing.Point(85, 13);
            this.txtBox_busNo.Name = "txtBox_busNo";
            this.txtBox_busNo.Size = new System.Drawing.Size(100, 20);
            this.txtBox_busNo.TabIndex = 3;
            // 
            // Bus_No
            // 
            this.Bus_No.AutoSize = true;
            this.Bus_No.Location = new System.Drawing.Point(12, 18);
            this.Bus_No.Name = "Bus_No";
            this.Bus_No.Size = new System.Drawing.Size(45, 13);
            this.Bus_No.TabIndex = 4;
            this.Bus_No.Text = "Bus No.";
            // 
            // textBox_details
            // 
            this.textBox_details.Location = new System.Drawing.Point(27, 96);
            this.textBox_details.Multiline = true;
            this.textBox_details.Name = "textBox_details";
            this.textBox_details.ReadOnly = true;
            this.textBox_details.Size = new System.Drawing.Size(300, 600);
            this.textBox_details.TabIndex = 5;
            this.textBox_details.Text = "\r\n";
            this.textBox_details.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // showAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 328);
            this.Controls.Add(this.textBox_details);
            this.Controls.Add(this.Bus_No);
            this.Controls.Add(this.txtBox_busNo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_show);
            this.Name = "showAll";
            this.Text = "showAll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtBox_busNo;
        private System.Windows.Forms.Label Bus_No;
        private System.Windows.Forms.TextBox textBox_details;
    }
}