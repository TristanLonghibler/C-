namespace WindowsFormsApp4
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
            this.label2 = new System.Windows.Forms.Label();
            this.yearEntered = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.listBoxYears = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(148, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter A Year You Would Like To Calculate:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(149, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "**Will Calculate Next 10 Leap Years";
            // 
            // yearEntered
            // 
            this.yearEntered.Location = new System.Drawing.Point(153, 122);
            this.yearEntered.Name = "yearEntered";
            this.yearEntered.Size = new System.Drawing.Size(383, 26);
            this.yearEntered.TabIndex = 2;
            this.yearEntered.TextChanged += new System.EventHandler(this.yearEntered_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(542, 103);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(164, 61);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(153, 212);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(553, 26);
            this.answerBox.TabIndex = 4;
            this.answerBox.TextChanged += new System.EventHandler(this.answerBox_TextChanged);
            // 
            // listBoxYears
            // 
            this.listBoxYears.FormattingEnabled = true;
            this.listBoxYears.ItemHeight = 20;
            this.listBoxYears.Location = new System.Drawing.Point(329, 277);
            this.listBoxYears.Name = "listBoxYears";
            this.listBoxYears.Size = new System.Drawing.Size(207, 484);
            this.listBoxYears.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 792);
            this.Controls.Add(this.listBoxYears);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.yearEntered);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yearEntered;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.ListBox listBoxYears;
    }
}

