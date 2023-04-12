namespace Assignment3
{
    partial class Form2
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
            this.labelInformation = new System.Windows.Forms.Label();
            this.buttonBackMainPage = new System.Windows.Forms.Button();
            this.labelExample = new System.Windows.Forms.Label();
            this.labelFormat = new System.Windows.Forms.Label();
            this.labelExampleInformation = new System.Windows.Forms.Label();
            this.textBoxPlayerInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.Location = new System.Drawing.Point(146, 56);
            this.labelInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(100, 19);
            this.labelInformation.TabIndex = 0;
            this.labelInformation.Text = "INformation";
            // 
            // buttonBackMainPage
            // 
            this.buttonBackMainPage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBackMainPage.Location = new System.Drawing.Point(456, 565);
            this.buttonBackMainPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBackMainPage.Name = "buttonBackMainPage";
            this.buttonBackMainPage.Size = new System.Drawing.Size(243, 70);
            this.buttonBackMainPage.TabIndex = 1;
            this.buttonBackMainPage.Text = "Add new player";
            this.buttonBackMainPage.UseVisualStyleBackColor = true;
            this.buttonBackMainPage.Click += new System.EventHandler(this.buttonBackMainPage_Click);
            // 
            // labelExample
            // 
            this.labelExample.AutoSize = true;
            this.labelExample.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExample.Location = new System.Drawing.Point(146, 131);
            this.labelExample.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(68, 19);
            this.labelExample.TabIndex = 2;
            this.labelExample.Text = "Exemple";
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormat.Location = new System.Drawing.Point(146, 75);
            this.labelFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(56, 19);
            this.labelFormat.TabIndex = 3;
            this.labelFormat.Text = "format";
            // 
            // labelExampleInformation
            // 
            this.labelExampleInformation.AutoSize = true;
            this.labelExampleInformation.Location = new System.Drawing.Point(146, 112);
            this.labelExampleInformation.Name = "labelExampleInformation";
            this.labelExampleInformation.Size = new System.Drawing.Size(54, 19);
            this.labelExampleInformation.TabIndex = 4;
            this.labelExampleInformation.Text = "label1";
            // 
            // textBoxPlayerInfo
            // 
            this.textBoxPlayerInfo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerInfo.Location = new System.Drawing.Point(150, 174);
            this.textBoxPlayerInfo.Name = "textBoxPlayerInfo";
            this.textBoxPlayerInfo.Size = new System.Drawing.Size(864, 26);
            this.textBoxPlayerInfo.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 712);
            this.Controls.Add(this.textBoxPlayerInfo);
            this.Controls.Add(this.labelExampleInformation);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.labelExample);
            this.Controls.Add(this.buttonBackMainPage);
            this.Controls.Add(this.labelInformation);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Add a new player in system";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Button buttonBackMainPage;
        private System.Windows.Forms.Label labelExample;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.Label labelExampleInformation;
        private System.Windows.Forms.TextBox textBoxPlayerInfo;
    }
}