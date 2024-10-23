namespace GuessWhatNumber
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
            this.title = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.guessOutput = new System.Windows.Forms.Label();
            this.guessInput = new System.Windows.Forms.TextBox();
            this.tutourial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(63, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(241, 29);
            this.title.TabIndex = 0;
            this.title.Text = "Guess What Number!";
            // 
            // guessButton
            // 
            this.guessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessButton.Location = new System.Drawing.Point(92, 143);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(183, 61);
            this.guessButton.TabIndex = 1;
            this.guessButton.Text = "Guess!";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // guessOutput
            // 
            this.guessOutput.AutoSize = true;
            this.guessOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessOutput.Location = new System.Drawing.Point(88, 207);
            this.guessOutput.Name = "guessOutput";
            this.guessOutput.Size = new System.Drawing.Size(10, 24);
            this.guessOutput.TabIndex = 3;
            this.guessOutput.Text = "\r\n";
            // 
            // guessInput
            // 
            this.guessInput.Location = new System.Drawing.Point(106, 79);
            this.guessInput.Name = "guessInput";
            this.guessInput.Size = new System.Drawing.Size(155, 20);
            this.guessInput.TabIndex = 4;
            // 
            // tutourial
            // 
            this.tutourial.AutoSize = true;
            this.tutourial.Location = new System.Drawing.Point(93, 118);
            this.tutourial.Name = "tutourial";
            this.tutourial.Size = new System.Drawing.Size(182, 26);
            this.tutourial.TabIndex = 5;
            this.tutourial.Text = "Guess a number between 1 and 100!\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 278);
            this.Controls.Add(this.tutourial);
            this.Controls.Add(this.guessInput);
            this.Controls.Add(this.guessOutput);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Guess What Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label guessOutput;
        private System.Windows.Forms.TextBox guessInput;
        private System.Windows.Forms.Label tutourial;
    }
}

