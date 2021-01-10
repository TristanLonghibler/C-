namespace WindowsFormsApp2
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
            this.userGuessBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Guess:";
            // 
            // userGuessBox
            // 
            this.userGuessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGuessBox.Location = new System.Drawing.Point(434, 105);
            this.userGuessBox.Name = "userGuessBox";
            this.userGuessBox.Size = new System.Drawing.Size(235, 44);
            this.userGuessBox.TabIndex = 1;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(173, 205);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(244, 74);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(173, 325);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(859, 44);
            this.textBoxAnswer.TabIndex = 3;
            this.textBoxAnswer.Text = "Welcome, please enter a number 1-100 above.";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.Location = new System.Drawing.Point(434, 205);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(235, 74);
            this.buttonRestart.TabIndex = 4;
            this.buttonRestart.Text = "RESTART";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 466);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.userGuessBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hot Or Cold";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userGuessBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonRestart;
    }
}

