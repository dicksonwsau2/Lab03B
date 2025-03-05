namespace Lab03B
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
            lblAmount = new Label();
            txtAmount = new TextBox();
            txtRate = new TextBox();
            lblRate = new Label();
            btnCalculate = new Button();
            lblValue10Years = new Label();
            txtValue = new Label();
            txtMillion = new Label();
            lblMillion = new Label();
            SuspendLayout();
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(73, 60);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(213, 57);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 1;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(213, 121);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 3;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(64, 124);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(122, 15);
            lblRate.TabIndex = 2;
            lblRate.Text = " Interest Rate (annual)";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(72, 197);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(241, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Start Calculation";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblValue10Years
            // 
            lblValue10Years.AutoSize = true;
            lblValue10Years.Location = new Point(64, 279);
            lblValue10Years.Name = "lblValue10Years";
            lblValue10Years.Size = new Size(107, 15);
            lblValue10Years.TabIndex = 5;
            lblValue10Years.Text = "Value after 10 years";
            // 
            // txtValue
            // 
            txtValue.BorderStyle = BorderStyle.Fixed3D;
            txtValue.Location = new Point(196, 278);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(117, 23);
            txtValue.TabIndex = 6;
            // 
            // txtMillion
            // 
            txtMillion.BorderStyle = BorderStyle.Fixed3D;
            txtMillion.Location = new Point(196, 328);
            txtMillion.Name = "txtMillion";
            txtMillion.Size = new Size(117, 23);
            txtMillion.TabIndex = 8;
            // 
            // lblMillion
            // 
            lblMillion.AutoSize = true;
            lblMillion.Location = new Point(64, 329);
            lblMillion.Name = "lblMillion";
            lblMillion.Size = new Size(106, 15);
            lblMillion.TabIndex = 7;
            lblMillion.Text = "Years to reach $1M";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMillion);
            Controls.Add(lblMillion);
            Controls.Add(txtValue);
            Controls.Add(lblValue10Years);
            Controls.Add(btnCalculate);
            Controls.Add(txtRate);
            Controls.Add(lblRate);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Name = "Form1";
            Text = "Amount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAmount;
        private TextBox txtAmount;
        private TextBox txtRate;
        private Label lblRate;
        private Button btnCalculate;
        private Label lblValue10Years;
        private Label txtValue;
        private Label txtMillion;
        private Label lblMillion;
    }
}
