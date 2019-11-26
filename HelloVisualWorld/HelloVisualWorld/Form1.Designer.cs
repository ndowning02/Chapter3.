namespace HelloVisualWorld
{
    partial class HelloVisualWorld
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
            this.button1 = new System.Windows.Forms.Button();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.btn_goodBye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click Me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(223, 136);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(93, 13);
            this.HelloLabel.TabIndex = 1;
            this.HelloLabel.Text = "Hello Visual World";
            this.HelloLabel.Click += new System.EventHandler(this.HelloLabel_Click);
            // 
            // btn_goodBye
            // 
            this.btn_goodBye.Location = new System.Drawing.Point(226, 349);
            this.btn_goodBye.Name = "btn_goodBye";
            this.btn_goodBye.Size = new System.Drawing.Size(75, 23);
            this.btn_goodBye.TabIndex = 2;
            this.btn_goodBye.Text = "Good Bye!";
            this.btn_goodBye.UseVisualStyleBackColor = true;
            this.btn_goodBye.Click += new System.EventHandler(this.btn_goodBye_Click);
            // 
            // HelloVisualWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.btn_goodBye);
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.button1);
            this.Name = "HelloVisualWorld";
            this.Text = "Hello Visual World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button btn_goodBye;
    }
}

