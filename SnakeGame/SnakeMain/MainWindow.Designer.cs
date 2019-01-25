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
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableList_Menu = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlace)).BeginInit();
            this.menuButtons.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.mainTable.SuspendLayout();
            this.tableList_Menu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "map";
            this.openFile.Filter = "\"Map file | *.map| Game file |*.game\"";
            // 
            // gamePlace
            // 
            this.gamePlace.BackColor = System.Drawing.Color.RoyalBlue;
            this.gamePlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamePlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePlace.Location = new System.Drawing.Point(10, 10);
            this.gamePlace.Margin = new System.Windows.Forms.Padding(10);
            this.gamePlace.Name = "gamePlace";
            this.gamePlace.Size = new System.Drawing.Size(408, 405);
            this.gamePlace.TabIndex = 0;
            this.gamePlace.TabStop = false;
            this.gamePlace.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePlace_Paint);
            // 
            // topList
            // 
            this.topList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topList.Location = new System.Drawing.Point(10, 10);
            this.topList.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.topList.Multiline = true;
            this.topList.Name = "topList";
            this.topList.ReadOnly = true;
            this.topList.Size = new System.Drawing.Size(192, 192);
            this.topList.TabIndex = 1;
            this.topList.TabStop = false;
            // 
            // menuButtons
            // 
            this.menuButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuButtons.Controls.Add(this.tableLayoutPanel1);
            this.menuButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuButtons.Location = new System.Drawing.Point(10, 222);
            this.menuButtons.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.menuButtons.Name = "menuButtons";
            this.menuButtons.Size = new System.Drawing.Size(192, 193);
            this.menuButtons.TabIndex = 3;
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.Location = new System.Drawing.Point(10, 142);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(168, 37);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonPause
            // 
            this.buttonPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPause.Location = new System.Drawing.Point(10, 54);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(168, 34);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.Text = "Пауза";
            this.buttonPause.UseVisualStyleBackColor = true;
            // 
            // buttonNGame
            // 
            this.buttonNGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNGame.Location = new System.Drawing.Point(10, 10);
            this.buttonNGame.Margin = new System.Windows.Forms.Padding(5);
            this.buttonNGame.Name = "buttonNGame";
            this.buttonNGame.Size = new System.Drawing.Size(168, 34);
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
            this.itemLoadFile.Size = new System.Drawing.Size(180, 22);
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
            this.itemExit.Size = new System.Drawing.Size(180, 22);
            this.itemExit.Text = "Выход";
            // 
            // saveGame
            // 
            this.saveGame.DefaultExt = "game";
            this.saveGame.Filter = "\"Game file | *.game\"";
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 2;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.mainTable.Controls.Add(this.gamePlace, 0, 0);
            this.mainTable.Controls.Add(this.tableList_Menu, 1, 0);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 24);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 1;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Size = new System.Drawing.Size(640, 425);
            this.mainTable.TabIndex = 5;
            // 
            // tableList_Menu
            // 
            this.tableList_Menu.ColumnCount = 1;
            this.tableList_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableList_Menu.Controls.Add(this.menuButtons, 0, 1);
            this.tableList_Menu.Controls.Add(this.topList, 0, 0);
            this.tableList_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableList_Menu.Location = new System.Drawing.Point(428, 0);
            this.tableList_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.tableList_Menu.Name = "tableList_Menu";
            this.tableList_Menu.Padding = new System.Windows.Forms.Padding(10);
            this.tableList_Menu.RowCount = 2;
            this.tableList_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableList_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableList_Menu.Size = new System.Drawing.Size(212, 425);
            this.tableList_Menu.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonNGame, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPause, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonExit, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(188, 189);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(640, 449);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.mainMenu;
            this.MaximumSize = new System.Drawing.Size(656, 488);
            this.MinimumSize = new System.Drawing.Size(656, 488);
            this.Name = "MainWindow";
            this.Text = "SnakeTheGame";
            ((System.ComponentModel.ISupportInitialize)(this.gamePlace)).EndInit();
            this.menuButtons.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainTable.ResumeLayout(false);
            this.tableList_Menu.ResumeLayout(false);
            this.tableList_Menu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.TableLayoutPanel tableList_Menu;
    }
}

