namespace SnakeMain
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.gamePlace = new System.Windows.Forms.PictureBox();
            this.topList = new System.Windows.Forms.TextBox();
            this.menuButtons = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonNGame = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.toolFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSaveGame = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGame = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlace)).BeginInit();
            this.menuButtons.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "map";
            this.openFile.Filter = "\"Map file | *.map| Game file |*.game\"";
            // 
            // gamePlace
            // 
            this.gamePlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gamePlace.BackColor = System.Drawing.Color.RoyalBlue;
            this.gamePlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamePlace.Location = new System.Drawing.Point(12, 38);
            this.gamePlace.MinimumSize = new System.Drawing.Size(400, 400);
            this.gamePlace.Name = "gamePlace";
            this.gamePlace.Size = new System.Drawing.Size(400, 400);
            this.gamePlace.TabIndex = 0;
            this.gamePlace.TabStop = false;
            this.gamePlace.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePlace_Paint);
            // 
            // topList
            // 
            this.topList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topList.Enabled = false;
            this.topList.Location = new System.Drawing.Point(450, 38);
            this.topList.Multiline = true;
            this.topList.Name = "topList";
            this.topList.Size = new System.Drawing.Size(152, 180);
            this.topList.TabIndex = 1;
            this.topList.TabStop = false;
            // 
            // menuButtons
            // 
            this.menuButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuButtons.Controls.Add(this.buttonExit);
            this.menuButtons.Controls.Add(this.buttonPause);
            this.menuButtons.Controls.Add(this.buttonNGame);
            this.menuButtons.Location = new System.Drawing.Point(450, 257);
            this.menuButtons.Name = "menuButtons";
            this.menuButtons.Size = new System.Drawing.Size(152, 180);
            this.menuButtons.TabIndex = 3;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(34, 141);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(34, 42);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.Text = "Пауза";
            this.buttonPause.UseVisualStyleBackColor = true;
            // 
            // buttonNGame
            // 
            this.buttonNGame.Location = new System.Drawing.Point(34, 13);
            this.buttonNGame.Name = "buttonNGame";
            this.buttonNGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNGame.TabIndex = 0;
            this.buttonNGame.Text = "Новая игра";
            this.buttonNGame.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFile});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(640, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "menuStrip1";
            // 
            // toolFile
            // 
            this.toolFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemLoadFile,
            this.itemSaveGame,
            this.itemExit});
            this.toolFile.Name = "toolFile";
            this.toolFile.Size = new System.Drawing.Size(48, 20);
            this.toolFile.Text = "Файл";
            // 
            // itemLoadFile
            // 
            this.itemLoadFile.Name = "itemLoadFile";
            this.itemLoadFile.Size = new System.Drawing.Size(160, 22);
            this.itemLoadFile.Text = "Открыть...";
            this.itemLoadFile.Click += new System.EventHandler(this.itemLoadFile_Click);
            // 
            // itemSaveGame
            // 
            this.itemSaveGame.Name = "itemSaveGame";
            this.itemSaveGame.Size = new System.Drawing.Size(180, 22);
            this.itemSaveGame.Text = "Сохранить игру";
            this.itemSaveGame.Click += new System.EventHandler(this.itemSaveGame_Click);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(160, 22);
            this.itemExit.Text = "Выход";
            // 
            // saveGame
            // 
            this.saveGame.DefaultExt = "game";
            this.saveGame.Filter = "\"Game file | *.game\"";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(640, 449);
            this.Controls.Add(this.menuButtons);
            this.Controls.Add(this.topList);
            this.Controls.Add(this.gamePlace);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mainMenu;
            this.MaximumSize = new System.Drawing.Size(656, 488);
            this.MinimumSize = new System.Drawing.Size(656, 488);
            this.Name = "MainWindow";
            this.Text = "SnakeTheGame";
            ((System.ComponentModel.ISupportInitialize)(this.gamePlace)).EndInit();
            this.menuButtons.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.PictureBox gamePlace;
        private System.Windows.Forms.TextBox topList;
        private System.Windows.Forms.Panel menuButtons;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonNGame;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolFile;
        private System.Windows.Forms.ToolStripMenuItem itemLoadFile;
        private System.Windows.Forms.ToolStripMenuItem itemSaveGame;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.SaveFileDialog saveGame;
    }
}

