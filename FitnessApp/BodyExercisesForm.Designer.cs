namespace FitnessApp
{
    partial class BodyExercisesForm
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
            this.exerciseLabel = new System.Windows.Forms.Label();
            this.firstSetRepsLabel = new System.Windows.Forms.Label();
            this.secondSetRepsLabel = new System.Windows.Forms.Label();
            this.thirdSetRepsLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.exerciseTextBox = new System.Windows.Forms.TextBox();
            this.firstSetRepsTextBox = new System.Windows.Forms.TextBox();
            this.secondSetRepsTextBox = new System.Windows.Forms.TextBox();
            this.thirdSetRepsTextBox = new System.Windows.Forms.TextBox();
            this.recordButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(62, 40);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date";
            // 
            // exerciseLabel
            // 
            this.exerciseLabel.AutoSize = true;
            this.exerciseLabel.Location = new System.Drawing.Point(62, 83);
            this.exerciseLabel.Name = "exerciseLabel";
            this.exerciseLabel.Size = new System.Drawing.Size(102, 17);
            this.exerciseLabel.TabIndex = 1;
            this.exerciseLabel.Text = "Exercise Name";
            // 
            // firstSetRepsLabel
            // 
            this.firstSetRepsLabel.AutoSize = true;
            this.firstSetRepsLabel.Location = new System.Drawing.Point(62, 119);
            this.firstSetRepsLabel.Name = "firstSetRepsLabel";
            this.firstSetRepsLabel.Size = new System.Drawing.Size(89, 17);
            this.firstSetRepsLabel.TabIndex = 2;
            this.firstSetRepsLabel.Text = "1st Set Reps";
            // 
            // secondSetRepsLabel
            // 
            this.secondSetRepsLabel.AutoSize = true;
            this.secondSetRepsLabel.Location = new System.Drawing.Point(62, 159);
            this.secondSetRepsLabel.Name = "secondSetRepsLabel";
            this.secondSetRepsLabel.Size = new System.Drawing.Size(94, 17);
            this.secondSetRepsLabel.TabIndex = 3;
            this.secondSetRepsLabel.Text = "2nd Set Reps";
            // 
            // thirdSetRepsLabel
            // 
            this.thirdSetRepsLabel.AutoSize = true;
            this.thirdSetRepsLabel.Location = new System.Drawing.Point(62, 198);
            this.thirdSetRepsLabel.Name = "thirdSetRepsLabel";
            this.thirdSetRepsLabel.Size = new System.Drawing.Size(91, 17);
            this.thirdSetRepsLabel.TabIndex = 4;
            this.thirdSetRepsLabel.Text = "3rd Set Reps";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(204, 40);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 22);
            this.dateTextBox.TabIndex = 5;
            // 
            // exerciseTextBox
            // 
            this.exerciseTextBox.Location = new System.Drawing.Point(204, 78);
            this.exerciseTextBox.Name = "exerciseTextBox";
            this.exerciseTextBox.Size = new System.Drawing.Size(182, 22);
            this.exerciseTextBox.TabIndex = 6;
            // 
            // firstSetRepsTextBox
            // 
            this.firstSetRepsTextBox.Location = new System.Drawing.Point(204, 114);
            this.firstSetRepsTextBox.Name = "firstSetRepsTextBox";
            this.firstSetRepsTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstSetRepsTextBox.TabIndex = 7;
            // 
            // secondSetRepsTextBox
            // 
            this.secondSetRepsTextBox.Location = new System.Drawing.Point(204, 159);
            this.secondSetRepsTextBox.Name = "secondSetRepsTextBox";
            this.secondSetRepsTextBox.Size = new System.Drawing.Size(100, 22);
            this.secondSetRepsTextBox.TabIndex = 8;
            // 
            // thirdSetRepsTextBox
            // 
            this.thirdSetRepsTextBox.Location = new System.Drawing.Point(204, 198);
            this.thirdSetRepsTextBox.Name = "thirdSetRepsTextBox";
            this.thirdSetRepsTextBox.Size = new System.Drawing.Size(100, 22);
            this.thirdSetRepsTextBox.TabIndex = 9;
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(149, 257);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(75, 23);
            this.recordButton.TabIndex = 10;
            this.recordButton.Text = "Record";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(149, 313);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // BodyExercisesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 368);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.thirdSetRepsTextBox);
            this.Controls.Add(this.secondSetRepsTextBox);
            this.Controls.Add(this.firstSetRepsTextBox);
            this.Controls.Add(this.exerciseTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.thirdSetRepsLabel);
            this.Controls.Add(this.secondSetRepsLabel);
            this.Controls.Add(this.firstSetRepsLabel);
            this.Controls.Add(this.exerciseLabel);
            this.Controls.Add(this.dateLabel);
            this.Name = "BodyExercisesForm";
            this.Text = "Body Exercise Activity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label exerciseLabel;
        private System.Windows.Forms.Label firstSetRepsLabel;
        private System.Windows.Forms.Label secondSetRepsLabel;
        private System.Windows.Forms.Label thirdSetRepsLabel;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox exerciseTextBox;
        private System.Windows.Forms.TextBox firstSetRepsTextBox;
        private System.Windows.Forms.TextBox secondSetRepsTextBox;
        private System.Windows.Forms.TextBox thirdSetRepsTextBox;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button exitButton;
    }
}