
namespace TestTask
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
            this.Select_File_button = new System.Windows.Forms.Button();
            this.Form_report_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Select_File_button
            // 
            this.Select_File_button.Location = new System.Drawing.Point(12, 555);
            this.Select_File_button.Name = "Select_File_button";
            this.Select_File_button.Size = new System.Drawing.Size(144, 51);
            this.Select_File_button.TabIndex = 0;
            this.Select_File_button.Text = "Выбрать файл";
            this.Select_File_button.UseVisualStyleBackColor = true;
            this.Select_File_button.Click += new System.EventHandler(this.Select_File_button_Click);
            // 
            // Form_report_button
            // 
            this.Form_report_button.AutoSize = true;
            this.Form_report_button.Location = new System.Drawing.Point(561, 555);
            this.Form_report_button.Name = "Form_report_button";
            this.Form_report_button.Size = new System.Drawing.Size(141, 51);
            this.Form_report_button.TabIndex = 1;
            this.Form_report_button.Text = "Сформировать отчёт";
            this.Form_report_button.UseVisualStyleBackColor = true;
            this.Form_report_button.Click += new System.EventHandler(this.Form_report_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(708, 544);
            this.listBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сортировка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Чтение первого файла: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 573);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Чтение второго файла: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 588);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сортировка:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 618);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Form_report_button);
            this.Controls.Add(this.Select_File_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Select_File_button;
        private System.Windows.Forms.Button Form_report_button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

