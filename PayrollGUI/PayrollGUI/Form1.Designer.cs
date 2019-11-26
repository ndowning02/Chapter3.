namespace PayrollGUI
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
            this.txtEntry1 = new System.Windows.Forms.TextBox();
            this.btcCalculate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your current salary";
            // 
            // txtEntry1
            // 
            this.txtEntry1.Location = new System.Drawing.Point(100, 110);
            this.txtEntry1.Name = "txtEntry1";
            this.txtEntry1.Size = new System.Drawing.Size(100, 20);
            this.txtEntry1.TabIndex = 1;
            // 
            // btcCalculate
            // 
            this.btcCalculate.Location = new System.Drawing.Point(91, 154);
            this.btcCalculate.Name = "btcCalculate";
            this.btcCalculate.Size = new System.Drawing.Size(121, 23);
            this.btcCalculate.TabIndex = 2;
            this.btcCalculate.Text = "Calculate New Salary";
            this.btcCalculate.UseVisualStyleBackColor = true;
            this.btcCalculate.Click += new System.EventHandler(this.btcCalculate_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(100, 203);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 3;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 348);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btcCalculate);
            this.Controls.Add(this.txtEntry1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntry1;
        private System.Windows.Forms.Button btcCalculate;
        private System.Windows.Forms.TextBox txtResult;
    }
}

