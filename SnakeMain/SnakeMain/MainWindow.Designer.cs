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
            this.openMap = new System.Windows.Forms.OpenFileDialog();
            this.gamePlace = new System.Windows.Forms.PictureBox();
            this.topList = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlace)).BeginInit();
            this.SuspendLayout();
            // 
            // openMap
            // 
            this.openMap.DefaultExt = "map";
            this.openMap.Filter = "Map | *.map";
            // 
            // gamePlace
            // 
            this.gamePlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gamePlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamePlace.Location = new System.Drawing.Point(12, 12);
            this.gamePlace.Name = "gamePlace";
            this.gamePlace.Size = new System.Drawing.Size(445, 456);
            this.gamePlace.TabIndex = 0;
            this.gamePlace.TabStop = false;
            // 
            // topList
            // 
            this.topList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topList.Location = new System.Drawing.Point(476, 12);
            this.topList.Multiline = true;
            this.topList.Name = "topList";
            this.topList.Size = new System.Drawing.Size(152, 177);
            this.topList.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.topList);
            this.Controls.Add(this.gamePlace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "SnakeTheGame";
            ((System.ComponentModel.ISupportInitialize)(this.gamePlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openMap;
        private System.Windows.Forms.PictureBox gamePlace;
        private System.Windows.Forms.TextBox topList;
    }
}

