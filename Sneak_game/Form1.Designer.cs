namespace Sneak_game
{
    partial class SnakeGameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MainScane = new System.Windows.Forms.Panel();
            this.GameTimeManager = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MainScane
            // 
            this.MainScane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainScane.Location = new System.Drawing.Point(0, 0);
            this.MainScane.Name = "MainScane";
            this.MainScane.Size = new System.Drawing.Size(1280, 720);
            this.MainScane.TabIndex = 0;
            // 
            // GameTimeManager
            // 
            this.GameTimeManager.Interval = 1000;
            this.GameTimeManager.Tick += new System.EventHandler(this.GameTimeManager_Tick);
            // 
            // SnakeGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MainScane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SnakeGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retro Snake";
            this.Load += new System.EventHandler(this.SnakeGameForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel MainScane;
        public System.Windows.Forms.Timer GameTimeManager;
    }
}