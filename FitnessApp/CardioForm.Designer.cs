namespace FitnessApp
{
    partial class CardioForm
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.exerciseLabel = new System.Windows.Forms.Label();
            this.exerciseTextBox = new System.Windows.Forms.TextBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.recordButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(63, 52);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(209, 49);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 22);
            this.dateTextBox.TabIndex = 1;
            // 
            // exerciseLabel
            // 
            this.exerciseLabel.AutoSize = true;
            this.exerciseLabel.Location = new System.Drawing.Point(63, 96);
            this.exerciseLabel.Name = "exerciseLabel";
            this.exerciseLabel.Size = new System.Drawing.Size(102, 17);
            this.exerciseLabel.TabIndex = 2;
            this.exerciseLabel.Text = "Exercise Name";
            // 
            // exerciseTextBox
            // 
            this.exerciseTextBox.Location = new System.Drawing.Point(209, 93);
            this.exerciseTextBox.Name = "exerciseTextBox";
            this.exerciseTextBox.Size = new System.Drawing.Size(100, 22);
            this.exerciseTextBox.TabIndex = 3;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(63, 146);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(130, 17);
            this.durationLabel.TabIndex = 4;
            this.durationLabel.Text = "Duration in Minutes";
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(209, 143);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 22);
            this.durationTextBox.TabIndex = 5;
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(150, 194);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(75, 23);
            this.recordButton.TabIndex = 6;
            this.recordButton.Text = "Record";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(150, 256);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CardioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 336);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.exerciseTextBox);
            this.Controls.Add(this.exerciseLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.dateLabel);
            this.Name = "CardioForm";
            this.Text = "Cardio Activity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label exerciseLabel;
        private System.Windows.Forms.TextBox exerciseTextBox;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button exitButton;
    }
}