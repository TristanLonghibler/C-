namespace Project1
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelCharges = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalValue = new System.Windows.Forms.Label();
            this.textBoxCharges = new System.Windows.Forms.TextBox();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(388, 286);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(244, 44);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelCharges
            // 
            this.labelCharges.AutoSize = true;
            this.labelCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharges.Location = new System.Drawing.Point(80, 24);
            this.labelCharges.Name = "labelCharges";
            this.labelCharges.Size = new System.Drawing.Size(160, 42);
            this.labelCharges.TabIndex = 1;
            this.labelCharges.Text = "Charges";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.Location = new System.Drawing.Point(80, 79);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(81, 42);
            this.labelTax.TabIndex = 2;
            this.labelTax.Text = "Tax";
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip.Location = new System.Drawing.Point(80, 140);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(70, 42);
            this.labelTip.TabIndex = 3;
            this.labelTip.Text = "Tip";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(80, 190);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(101, 42);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Total";
            // 
            // labelTotalValue
            // 
            this.labelTotalValue.AutoSize = true;
            this.labelTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalValue.Location = new System.Drawing.Point(381, 190);
            this.labelTotalValue.Name = "labelTotalValue";
            this.labelTotalValue.Size = new System.Drawing.Size(197, 42);
            this.labelTotalValue.TabIndex = 7;
            this.labelTotalValue.Text = "TotalValue";
            // 
            // textBoxCharges
            // 
            this.textBoxCharges.Location = new System.Drawing.Point(388, 24);
            this.textBoxCharges.Name = "textBoxCharges";
            this.textBoxCharges.Size = new System.Drawing.Size(246, 31);
            this.textBoxCharges.TabIndex = 8;
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(388, 79);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.Size = new System.Drawing.Size(246, 31);
            this.textBoxTax.TabIndex = 9;
            // 
            // textBoxTip
            // 
            this.textBoxTip.Location = new System.Drawing.Point(388, 128);
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(246, 31);
            this.textBoxTip.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTip);
            this.Controls.Add(this.textBoxTax);
            this.Controls.Add(this.textBoxCharges);
            this.Controls.Add(this.labelTotalValue);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelCharges);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "Form1";
            this.Text = "Total Tax and Tip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelCharges;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalValue;
        private System.Windows.Forms.TextBox textBoxCharges;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.TextBox textBoxTip;
    }
}

