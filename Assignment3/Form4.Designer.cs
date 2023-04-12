namespace Assignment3
{
    partial class Form4
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
            this.labelSignPlayer = new System.Windows.Forms.Label();
            this.textBoxSignPlayer = new System.Windows.Forms.TextBox();
            this.labelSignTeam = new System.Windows.Forms.Label();
            this.textBoxSignTeam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSignPlayer
            // 
            this.labelSignPlayer.AutoSize = true;
            this.labelSignPlayer.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignPlayer.Location = new System.Drawing.Point(142, 48);
            this.labelSignPlayer.Name = "labelSignPlayer";
            this.labelSignPlayer.Size = new System.Drawing.Size(345, 19);
            this.labelSignPlayer.TabIndex = 0;
            this.labelSignPlayer.Text = "Enter the full name of player you want to sign";
            // 
            // textBoxSignPlayer
            // 
            this.textBoxSignPlayer.Location = new System.Drawing.Point(146, 70);
            this.textBoxSignPlayer.Name = "textBoxSignPlayer";
            this.textBoxSignPlayer.Size = new System.Drawing.Size(314, 21);
            this.textBoxSignPlayer.TabIndex = 1;
            // 
            // labelSignTeam
            // 
            this.labelSignTeam.AutoSize = true;
            this.labelSignTeam.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignTeam.Location = new System.Drawing.Point(142, 130);
            this.labelSignTeam.Name = "labelSignTeam";
            this.labelSignTeam.Size = new System.Drawing.Size(307, 19);
            this.labelSignTeam.TabIndex = 2;
            this.labelSignTeam.Text = "Enter the name of team you want to sign";
            // 
            // textBoxSignTeam
            // 
            this.textBoxSignTeam.Location = new System.Drawing.Point(146, 163);
            this.textBoxSignTeam.Name = "textBoxSignTeam";
            this.textBoxSignTeam.Size = new System.Drawing.Size(303, 21);
            this.textBoxSignTeam.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(320, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 68);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign the player to the team";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSignTeam);
            this.Controls.Add(this.labelSignTeam);
            this.Controls.Add(this.textBoxSignPlayer);
            this.Controls.Add(this.labelSignPlayer);
            this.Name = "Form4";
            this.Text = "Sign a player to a team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSignPlayer;
        private System.Windows.Forms.TextBox textBoxSignPlayer;
        private System.Windows.Forms.Label labelSignTeam;
        private System.Windows.Forms.TextBox textBoxSignTeam;
        private System.Windows.Forms.Button button1;
    }
}