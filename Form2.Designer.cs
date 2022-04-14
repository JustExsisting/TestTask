
namespace TestTask
{
    partial class Form2
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
            this.SortByName = new System.Windows.Forms.Button();
            this.SortByRKK = new System.Windows.Forms.Button();
            this.SortByAppeal = new System.Windows.Forms.Button();
            this.SortByTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SortByName
            // 
            this.SortByName.Location = new System.Drawing.Point(9, 12);
            this.SortByName.Name = "SortByName";
            this.SortByName.Size = new System.Drawing.Size(162, 49);
            this.SortByName.TabIndex = 0;
            this.SortByName.Text = "По фамилии ответственного исполнителя";
            this.SortByName.UseVisualStyleBackColor = true;
            this.SortByName.Click += new System.EventHandler(this.SortByName_Click);
            // 
            // SortByRKK
            // 
            this.SortByRKK.Location = new System.Drawing.Point(177, 12);
            this.SortByRKK.Name = "SortByRKK";
            this.SortByRKK.Size = new System.Drawing.Size(162, 49);
            this.SortByRKK.TabIndex = 1;
            this.SortByRKK.Text = "По количеству РКК";
            this.SortByRKK.UseVisualStyleBackColor = true;
            this.SortByRKK.Click += new System.EventHandler(this.SortByRKK_Click);
            // 
            // SortByAppeal
            // 
            this.SortByAppeal.Location = new System.Drawing.Point(9, 67);
            this.SortByAppeal.Name = "SortByAppeal";
            this.SortByAppeal.Size = new System.Drawing.Size(162, 49);
            this.SortByAppeal.TabIndex = 2;
            this.SortByAppeal.Text = "По количеству обращений";
            this.SortByAppeal.UseVisualStyleBackColor = true;
            this.SortByAppeal.Click += new System.EventHandler(this.SortByAppeal_Click);
            // 
            // SortByTotal
            // 
            this.SortByTotal.Location = new System.Drawing.Point(177, 67);
            this.SortByTotal.Name = "SortByTotal";
            this.SortByTotal.Size = new System.Drawing.Size(162, 49);
            this.SortByTotal.TabIndex = 3;
            this.SortByTotal.Text = "По общему количеству документов ";
            this.SortByTotal.UseVisualStyleBackColor = true;
            this.SortByTotal.Click += new System.EventHandler(this.SortByTotal_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 127);
            this.Controls.Add(this.SortByTotal);
            this.Controls.Add(this.SortByAppeal);
            this.Controls.Add(this.SortByRKK);
            this.Controls.Add(this.SortByName);
            this.Name = "Form2";
            this.Text = "Сортировка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SortByName;
        private System.Windows.Forms.Button SortByRKK;
        private System.Windows.Forms.Button SortByAppeal;
        private System.Windows.Forms.Button SortByTotal;
    }
}