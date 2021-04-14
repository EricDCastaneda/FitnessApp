namespace FitnessApp
{
    partial class MainForm
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
            this.cardioButton = new System.Windows.Forms.Button();
            this.bodyExercisesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cardioButton
            // 
            this.cardioButton.Location = new System.Drawing.Point(82, 42);
            this.cardioButton.Name = "cardioButton";
            this.cardioButton.Size = new System.Drawing.Size(126, 37);
            this.cardioButton.TabIndex = 0;
            this.cardioButton.Text = "Cardio";
            this.cardioButton.UseVisualStyleBackColor = true;
            this.cardioButton.Click += new System.EventHandler(this.cardioButton_Click);
            // 
            // bodyExercisesButton
            // 
            this.bodyExercisesButton.Location = new System.Drawing.Point(82, 106);
            this.bodyExercisesButton.Name = "bodyExercisesButton";
            this.bodyExercisesButton.Size = new System.Drawing.Size(126, 42);
            this.bodyExercisesButton.TabIndex = 1;
            this.bodyExercisesButton.Text = "Body Exercises";
            this.bodyExercisesButton.UseVisualStyleBackColor = true;
            this.bodyExercisesButton.Click += new System.EventHandler(this.bodyExercisesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(107, 178);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 31);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 246);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.bodyExercisesButton);
            this.Controls.Add(this.cardioButton);
            this.Name = "MainForm";
            this.Text = "Fitness Record";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cardioButton;
        private System.Windows.Forms.Button bodyExercisesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

