
namespace WindowsFormsApp6Final
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(748, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 98);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play Sound";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label1.Location = new System.Drawing.Point(398, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1293, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bellow Are Five Animals. If You Click On Any Of Them, The Animal Will Play Its Re" +
    "spected Sound:";
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.FormattingEnabled = true;
            this.listBoxAnimals.ItemHeight = 25;
            this.listBoxAnimals.Location = new System.Drawing.Point(404, 363);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(288, 304);
            this.listBoxAnimals.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2320, 774);
            this.Controls.Add(this.listBoxAnimals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAnimals;
    }
}

