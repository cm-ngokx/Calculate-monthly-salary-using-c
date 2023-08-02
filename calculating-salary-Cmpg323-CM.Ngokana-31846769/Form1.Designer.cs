namespace calculating_salary_Cmpg323_CM.Ngokana_31846769
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
            this.btnSalary = new System.Windows.Forms.Button();
            this.lbHrsWorked = new System.Windows.Forms.Label();
            this.txtHW = new System.Windows.Forms.TextBox();
            this.lbHRate = new System.Windows.Forms.Label();
            this.txtHRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalary
            // 
            this.btnSalary.Location = new System.Drawing.Point(284, 288);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(249, 23);
            this.btnSalary.TabIndex = 0;
            this.btnSalary.Text = "Calculate salary";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // lbHrsWorked
            // 
            this.lbHrsWorked.AutoSize = true;
            this.lbHrsWorked.Location = new System.Drawing.Point(101, 90);
            this.lbHrsWorked.Name = "lbHrsWorked";
            this.lbHrsWorked.Size = new System.Drawing.Size(102, 13);
            this.lbHrsWorked.TabIndex = 1;
            this.lbHrsWorked.Text = "Enter hours worked:";
            // 
            // txtHW
            // 
            this.txtHW.Location = new System.Drawing.Point(257, 90);
            this.txtHW.Name = "txtHW";
            this.txtHW.Size = new System.Drawing.Size(100, 20);
            this.txtHW.TabIndex = 2;
            this.txtHW.TextChanged += new System.EventHandler(this.txtHW_TextChanged);
            // 
            // lbHRate
            // 
            this.lbHRate.AutoSize = true;
            this.lbHRate.Location = new System.Drawing.Point(101, 158);
            this.lbHRate.Name = "lbHRate";
            this.lbHRate.Size = new System.Drawing.Size(116, 13);
            this.lbHRate.TabIndex = 3;
            this.lbHRate.Text = "Enter the rate per hour:";
            // 
            // txtHRate
            // 
            this.txtHRate.Location = new System.Drawing.Point(257, 151);
            this.txtHRate.Name = "txtHRate";
            this.txtHRate.Size = new System.Drawing.Size(100, 20);
            this.txtHRate.TabIndex = 4;
            this.txtHRate.TextChanged += new System.EventHandler(this.txtHRate_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHRate);
            this.Controls.Add(this.lbHRate);
            this.Controls.Add(this.txtHW);
            this.Controls.Add(this.lbHrsWorked);
            this.Controls.Add(this.btnSalary);
            this.Name = "Form1";
            this.Text = "Salary Calculater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Label lbHrsWorked;
        private System.Windows.Forms.TextBox txtHW;
        private System.Windows.Forms.Label lbHRate;
        private System.Windows.Forms.TextBox txtHRate;
    }
}

