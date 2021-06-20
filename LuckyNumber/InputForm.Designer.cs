namespace LuckyNumber
{
    partial class InputForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.siblingsBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.errorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Your Lucky Number!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Day of birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year of birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of siblings:";
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(201, 115);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(100, 20);
            this.dayBox.TabIndex = 4;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(201, 180);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(100, 20);
            this.yearBox.TabIndex = 5;
            // 
            // siblingsBox
            // 
            this.siblingsBox.Location = new System.Drawing.Point(201, 242);
            this.siblingsBox.Name = "siblingsBox";
            this.siblingsBox.Size = new System.Drawing.Size(100, 20);
            this.siblingsBox.TabIndex = 6;
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(201, 327);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(149, 23);
            this.findButton.TabIndex = 7;
            this.findButton.Text = "Find Number!";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.ForeColor = System.Drawing.Color.DarkRed;
            this.errorText.Location = new System.Drawing.Point(207, 300);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(134, 13);
            this.errorText.TabIndex = 8;
            this.errorText.Text = "Please enter valid numbers";
            this.errorText.Visible = false;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 408);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.siblingsBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "InputForm";
            this.Text = "Lucky Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox siblingsBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label errorText;
    }
}

