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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.openMap = new System.Windows.Forms.OpenFileDialog();
            this.menuButtons = new System.Windows.Forms.Panel();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNGame = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.toolFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLoadMap = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.gamePlace = new System.Windows.Forms.PictureBox();
            this.tableList_Menu = new System.Windows.Forms.TableLayoutPanel();
            this.topList = new System.Windows.Forms.RichTextBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.menuButtons.SuspendLayout();
            this.tableButtons.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.mainTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlace)).BeginInit();
            this.tableList_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // openMap
            // 
            this.openMap.DefaultExt = "map";
            this.openMap.Filter = "\"Snake game map file | *.snake.map";
            // 
            // menuButtons
            // 
            this.menuButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuButtons.Controls.Add(this.tableButtons);
            this.menuButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuButtons.Location = new System.Drawing.Point(10, 222);
            this.menuButtons.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.menuButtons.Name = "menuButtons";
            this.menuButtons.Size = new System.Drawing.Size(192, 193);
            this.menuButtons.TabIndex = 3;
            // 
            // tableButtons
            // 
            this.tableButtons.ColumnCount = 1;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtons.Controls.Add(this.buttonNGame, 0, 0);
            this.tableButtons.Controls.Add(this.buttonPause, 0, 1);
            this.tableButtons.Controls.Add(this.buttonExit, 0, 3);
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableButtons.Location = new System.Drawing.Point(0, 0);
            this.tableButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.Padding = new System.Windows.Forms.Padding(5);
            this.tableButtons.RowCount = 4;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableButtons.Size = new System.Drawing.Size(188, 189);
            this.tableButtons.TabIndex = 3;
            // 
            // buttonNGame
            // 
            this.buttonNGame.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonNGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNGame.ForeColor = System.Drawing.Color.Black;
            this.buttonNGame.Location = new System.Drawing.Point(10, 10);
            this.buttonNGame.Margin = new System.Windows.Forms.Padding(5);
            this.buttonNGame.Name = "buttonNGame";
            this.buttonNGame.Size = new System.Drawing.Size(168, 34);
            this.buttonNGame.TabIndex = 0;
            this.buttonNGame.Text = "Новая игра";
            this.buttonNGame.UseVisualStyleBackColor = false;
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.ForeColor = System.Drawing.Color.Black;
            this.buttonPause.Location = new System.Drawing.Point(10, 54);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(168, 34);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.Text = "Пауза";
            this.buttonPause.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(10, 142);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(168, 37);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.PaleGreen;
            this.mainMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.itemLoadMap,
            this.itemExit});
            this.toolFile.Name = "toolFile";
            this.toolFile.Size = new System.Drawing.Size(49, 20);
            this.toolFile.Text = "Файл";
            // 
            // itemLoadMap
            // 
            this.itemLoadMap.BackColor = System.Drawing.Color.PaleGreen;
            this.itemLoadMap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemLoadMap.ForeColor = System.Drawing.Color.Black;
            this.itemLoadMap.Name = "itemLoadMap";
            this.itemLoadMap.Size = new System.Drawing.Size(163, 22);
            this.itemLoadMap.Text = "Загрузить карту";
            this.itemLoadMap.Click += new System.EventHandler(this.itemLoadMap_Click);
            // 
            // itemExit
            // 
            this.itemExit.BackColor = System.Drawing.Color.PaleGreen;
            this.itemExit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemExit.ForeColor = System.Drawing.Color.Black;
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(163, 22);
            this.itemExit.Text = "Выход";
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
            // gamePlace
            // 
            this.gamePlace.BackColor = System.Drawing.Color.Transparent;
            this.gamePlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamePlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePlace.Location = new System.Drawing.Point(10, 10);
            this.gamePlace.Margin = new System.Windows.Forms.Padding(10);
            this.gamePlace.Name = "gamePlace";
            this.gamePlace.Size = new System.Drawing.Size(408, 405);
            this.gamePlace.TabIndex = 0;
            this.gamePlace.TabStop = false;
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
            // topList
            // 
            this.topList.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.topList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topList.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topList.ForeColor = System.Drawing.Color.Black;
            this.topList.Location = new System.Drawing.Point(10, 10);
            this.topList.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.topList.Name = "topList";
            this.topList.ReadOnly = true;
            this.topList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.topList.Size = new System.Drawing.Size(192, 192);
            this.topList.TabIndex = 4;
            this.topList.Text = "Топ-5 игроков:";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 500;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(640, 449);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainWindow";
            this.Text = "SnakeTheGame";
            this.menuButtons.ResumeLayout(false);
            this.tableButtons.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gamePlace)).EndInit();
            this.tableList_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openMap;
        private System.Windows.Forms.PictureBox gamePlace;
        private System.Windows.Forms.Panel menuButtons;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonNGame;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolFile;
        private System.Windows.Forms.ToolStripMenuItem itemLoadMap;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.TableLayoutPanel tableList_Menu;
        private System.Windows.Forms.RichTextBox topList;
        private System.Windows.Forms.Timer gameTimer;
    }
}

