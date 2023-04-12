namespace Assignment3
{
    partial class Form3
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
            this.labelExampleInformation = new System.Windows.Forms.Label();
            this.labelFormat = new System.Windows.Forms.Label();
            this.labelExample = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            this.buttonAddNewTeam = new System.Windows.Forms.Button();
            this.textBoxPlayerInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelExampleInformation
            // 
            this.labelExampleInformation.AutoSize = true;
            this.labelExampleInformation.Location = new System.Drawing.Point(154, 107);
            this.labelExampleInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExampleInformation.Name = "labelExampleInformation";
            this.labelExampleInformation.Size = new System.Drawing.Size(54, 19);
            this.labelExampleInformation.TabIndex = 8;
            this.labelExampleInformation.Text = "label1";
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormat.Location = new System.Drawing.Point(154, 74);
            this.labelFormat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(56, 19);
            this.labelFormat.TabIndex = 7;
            this.labelFormat.Text = "format";
            // 
            // labelExample
            // 
            this.labelExample.AutoSize = true;
            this.labelExample.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExample.Location = new System.Drawing.Point(154, 126);
            this.labelExample.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(68, 19);
            this.labelExample.TabIndex = 6;
            this.labelExample.Text = "Exemple";
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.Location = new System.Drawing.Point(154, 55);
            this.labelInformation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(100, 19);
            this.labelInformation.TabIndex = 5;
            this.labelInformation.Text = "INformation";
            // 
            // buttonAddNewTeam
            // 
            this.buttonAddNewTeam.Location = new System.Drawing.Point(432, 493);
            this.buttonAddNewTeam.Name = "buttonAddNewTeam";
            this.buttonAddNewTeam.Size = new System.Drawing.Size(358, 131);
            this.buttonAddNewTeam.TabIndex = 9;
            this.buttonAddNewTeam.Text = "Add New Team";
            this.buttonAddNewTeam.UseVisualStyleBackColor = true;
            this.buttonAddNewTeam.Click += new System.EventHandler(this.buttonAddNewTeam_Click);
            // 
            // textBoxPlayerInfo
            // 
            this.textBoxPlayerInfo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerInfo.Location = new System.Drawing.Point(158, 161);
            this.textBoxPlayerInfo.Name = "textBoxPlayerInfo";
            this.textBoxPlayerInfo.Size = new System.Drawing.Size(807, 26);
            this.textBoxPlayerInfo.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 712);
            this.Controls.Add(this.textBoxPlayerInfo);
            this.Controls.Add(this.buttonAddNewTeam);
            this.Controls.Add(this.labelExampleInformation);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.labelExample);
            this.Controls.Add(this.labelInformation);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Add a new team in system";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExampleInformation;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.Label labelExample;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Button buttonAddNewTeam;
        private System.Windows.Forms.TextBox textBoxPlayerInfo;
    }
}