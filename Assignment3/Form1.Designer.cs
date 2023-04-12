namespace Assignment3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.myOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlayersWTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTeamsWithPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.listViewPlayers = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPlayersName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTeams = new System.Windows.Forms.ListView();
            this.columnHeaderTeamsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddNewPlayer = new System.Windows.Forms.Button();
            this.buttonAddNewTeam = new System.Windows.Forms.Button();
            this.buttonSearchAge = new System.Windows.Forms.Button();
            this.buttonBirthOfPlace = new System.Windows.Forms.Button();
            this.buttonSignPlayer = new System.Windows.Forms.Button();
            this.textBoxBirthOfPlace = new System.Windows.Forms.TextBox();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartPlayerHeightWeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPlayerAgeGroup = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlayerHeightWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlayerAgeGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // myOpenFileDialog
            // 
            this.myOpenFileDialog.FileName = "openFileDialog";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1189, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfPlayersToolStripMenuItem,
            this.listOfTeamsToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // listOfPlayersToolStripMenuItem
            // 
            this.listOfPlayersToolStripMenuItem.Name = "listOfPlayersToolStripMenuItem";
            this.listOfPlayersToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.listOfPlayersToolStripMenuItem.Text = "List of Players";
            this.listOfPlayersToolStripMenuItem.Click += new System.EventHandler(this.listOfPlayersToolStripMenuItem_Click);
            // 
            // listOfTeamsToolStripMenuItem
            // 
            this.listOfTeamsToolStripMenuItem.Name = "listOfTeamsToolStripMenuItem";
            this.listOfTeamsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.listOfTeamsToolStripMenuItem.Text = "List of Teams";
            this.listOfTeamsToolStripMenuItem.Click += new System.EventHandler(this.listOfTeamsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePlayersToolStripMenuItem,
            this.saveTeamsToolStripMenuItem,
            this.savePlayersWTeamsToolStripMenuItem,
            this.saveTeamsWithPlayersToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // savePlayersToolStripMenuItem
            // 
            this.savePlayersToolStripMenuItem.Name = "savePlayersToolStripMenuItem";
            this.savePlayersToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.savePlayersToolStripMenuItem.Text = "Save Players";
            this.savePlayersToolStripMenuItem.Click += new System.EventHandler(this.savePlayersToolStripMenuItem_Click);
            // 
            // saveTeamsToolStripMenuItem
            // 
            this.saveTeamsToolStripMenuItem.Name = "saveTeamsToolStripMenuItem";
            this.saveTeamsToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.saveTeamsToolStripMenuItem.Text = "Save Teams";
            this.saveTeamsToolStripMenuItem.Click += new System.EventHandler(this.saveTeamsToolStripMenuItem_Click);
            // 
            // savePlayersWTeamsToolStripMenuItem
            // 
            this.savePlayersWTeamsToolStripMenuItem.Name = "savePlayersWTeamsToolStripMenuItem";
            this.savePlayersWTeamsToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.savePlayersWTeamsToolStripMenuItem.Text = "Save Players with Teams";
            this.savePlayersWTeamsToolStripMenuItem.Click += new System.EventHandler(this.savePlayersWTeamsToolStripMenuItem_Click);
            // 
            // saveTeamsWithPlayersToolStripMenuItem
            // 
            this.saveTeamsWithPlayersToolStripMenuItem.Name = "saveTeamsWithPlayersToolStripMenuItem";
            this.saveTeamsWithPlayersToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.saveTeamsWithPlayersToolStripMenuItem.Text = "Save Teams with Players";
            this.saveTeamsWithPlayersToolStripMenuItem.Click += new System.EventHandler(this.saveTeamsWithPlayersToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // listViewPlayers
            // 
            this.listViewPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderPlayersName});
            this.listViewPlayers.FullRowSelect = true;
            this.listViewPlayers.GridLines = true;
            this.listViewPlayers.HideSelection = false;
            this.listViewPlayers.Location = new System.Drawing.Point(35, 99);
            this.listViewPlayers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewPlayers.Name = "listViewPlayers";
            this.listViewPlayers.Size = new System.Drawing.Size(279, 371);
            this.listViewPlayers.TabIndex = 1;
            this.listViewPlayers.UseCompatibleStateImageBehavior = false;
            this.listViewPlayers.View = System.Windows.Forms.View.Details;
            this.listViewPlayers.SelectedIndexChanged += new System.EventHandler(this.listViewPlayers_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 40;
            // 
            // columnHeaderPlayersName
            // 
            this.columnHeaderPlayersName.Text = "Name";
            this.columnHeaderPlayersName.Width = 230;
            // 
            // listViewTeams
            // 
            this.listViewTeams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTeamsName});
            this.listViewTeams.FullRowSelect = true;
            this.listViewTeams.GridLines = true;
            this.listViewTeams.HideSelection = false;
            this.listViewTeams.Location = new System.Drawing.Point(374, 99);
            this.listViewTeams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewTeams.Name = "listViewTeams";
            this.listViewTeams.Size = new System.Drawing.Size(243, 371);
            this.listViewTeams.TabIndex = 2;
            this.listViewTeams.UseCompatibleStateImageBehavior = false;
            this.listViewTeams.View = System.Windows.Forms.View.Details;
            this.listViewTeams.SelectedIndexChanged += new System.EventHandler(this.listViewTeams_SelectedIndexChanged);
            // 
            // columnHeaderTeamsName
            // 
            this.columnHeaderTeamsName.Text = "Name";
            this.columnHeaderTeamsName.Width = 240;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teams";
            // 
            // buttonAddNewPlayer
            // 
            this.buttonAddNewPlayer.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewPlayer.Location = new System.Drawing.Point(35, 489);
            this.buttonAddNewPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddNewPlayer.Name = "buttonAddNewPlayer";
            this.buttonAddNewPlayer.Size = new System.Drawing.Size(209, 68);
            this.buttonAddNewPlayer.TabIndex = 5;
            this.buttonAddNewPlayer.Text = "Add new player";
            this.buttonAddNewPlayer.UseVisualStyleBackColor = true;
            this.buttonAddNewPlayer.Click += new System.EventHandler(this.buttonAddNewPlayer_Click);
            // 
            // buttonAddNewTeam
            // 
            this.buttonAddNewTeam.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewTeam.Location = new System.Drawing.Point(374, 489);
            this.buttonAddNewTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddNewTeam.Name = "buttonAddNewTeam";
            this.buttonAddNewTeam.Size = new System.Drawing.Size(209, 68);
            this.buttonAddNewTeam.TabIndex = 6;
            this.buttonAddNewTeam.Text = "Add new team";
            this.buttonAddNewTeam.UseVisualStyleBackColor = true;
            this.buttonAddNewTeam.Click += new System.EventHandler(this.buttonAddNewTeam_Click);
            // 
            // buttonSearchAge
            // 
            this.buttonSearchAge.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchAge.Location = new System.Drawing.Point(383, 689);
            this.buttonSearchAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearchAge.Name = "buttonSearchAge";
            this.buttonSearchAge.Size = new System.Drawing.Size(76, 25);
            this.buttonSearchAge.TabIndex = 7;
            this.buttonSearchAge.Text = "Search";
            this.buttonSearchAge.UseVisualStyleBackColor = true;
            this.buttonSearchAge.Click += new System.EventHandler(this.buttonSearchAge_Click);
            // 
            // buttonBirthOfPlace
            // 
            this.buttonBirthOfPlace.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBirthOfPlace.Location = new System.Drawing.Point(542, 746);
            this.buttonBirthOfPlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBirthOfPlace.Name = "buttonBirthOfPlace";
            this.buttonBirthOfPlace.Size = new System.Drawing.Size(75, 24);
            this.buttonBirthOfPlace.TabIndex = 8;
            this.buttonBirthOfPlace.Text = "Search";
            this.buttonBirthOfPlace.UseVisualStyleBackColor = true;
            this.buttonBirthOfPlace.Click += new System.EventHandler(this.buttonBirthOfPlace_Click);
            // 
            // buttonSignPlayer
            // 
            this.buttonSignPlayer.Location = new System.Drawing.Point(36, 582);
            this.buttonSignPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSignPlayer.Name = "buttonSignPlayer";
            this.buttonSignPlayer.Size = new System.Drawing.Size(209, 79);
            this.buttonSignPlayer.TabIndex = 9;
            this.buttonSignPlayer.Text = "Sign a player to a team";
            this.buttonSignPlayer.UseVisualStyleBackColor = true;
            this.buttonSignPlayer.Click += new System.EventHandler(this.buttonSignPlayer_Click);
            // 
            // textBoxBirthOfPlace
            // 
            this.textBoxBirthOfPlace.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBirthOfPlace.Location = new System.Drawing.Point(275, 746);
            this.textBoxBirthOfPlace.Name = "textBoxBirthOfPlace";
            this.textBoxBirthOfPlace.Size = new System.Drawing.Size(226, 24);
            this.textBoxBirthOfPlace.TabIndex = 11;
            this.textBoxBirthOfPlace.Text = "Enter place name";
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(190, 690);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(158, 24);
            this.numericUpDownAge.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 689);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search player by age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 746);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Search player by his birth of place";
            // 
            // chartPlayerHeightWeight
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPlayerHeightWeight.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPlayerHeightWeight.Legends.Add(legend3);
            this.chartPlayerHeightWeight.Location = new System.Drawing.Point(753, 99);
            this.chartPlayerHeightWeight.Name = "chartPlayerHeightWeight";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartPlayerHeightWeight.Series.Add(series3);
            this.chartPlayerHeightWeight.Size = new System.Drawing.Size(300, 300);
            this.chartPlayerHeightWeight.TabIndex = 15;
            this.chartPlayerHeightWeight.Text = "chart1";
            // 
            // chartPlayerAgeGroup
            // 
            chartArea4.Name = "ChartArea1";
            this.chartPlayerAgeGroup.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPlayerAgeGroup.Legends.Add(legend4);
            this.chartPlayerAgeGroup.Location = new System.Drawing.Point(753, 452);
            this.chartPlayerAgeGroup.Name = "chartPlayerAgeGroup";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartPlayerAgeGroup.Series.Add(series4);
            this.chartPlayerAgeGroup.Size = new System.Drawing.Size(300, 300);
            this.chartPlayerAgeGroup.TabIndex = 16;
            this.chartPlayerAgeGroup.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 807);
            this.Controls.Add(this.chartPlayerAgeGroup);
            this.Controls.Add(this.chartPlayerHeightWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.textBoxBirthOfPlace);
            this.Controls.Add(this.buttonSignPlayer);
            this.Controls.Add(this.buttonBirthOfPlace);
            this.Controls.Add(this.buttonSearchAge);
            this.Controls.Add(this.buttonAddNewTeam);
            this.Controls.Add(this.buttonAddNewPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewTeams);
            this.Controls.Add(this.listViewPlayers);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Player manegement system";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlayers_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlayerHeightWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlayerAgeGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog myOpenFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog mySaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem savePlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePlayersWTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTeamsWithPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfTeamsToolStripMenuItem;
        private System.Windows.Forms.ListView listViewPlayers;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderPlayersName;
        private System.Windows.Forms.ListView listViewTeams;
        private System.Windows.Forms.ColumnHeader columnHeaderTeamsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddNewPlayer;
        private System.Windows.Forms.Button buttonAddNewTeam;
        private System.Windows.Forms.Button buttonSearchAge;
        private System.Windows.Forms.Button buttonBirthOfPlace;
        private System.Windows.Forms.Button buttonSignPlayer;
        private System.Windows.Forms.TextBox textBoxBirthOfPlace;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPlayerHeightWeight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPlayerAgeGroup;
    }
}

