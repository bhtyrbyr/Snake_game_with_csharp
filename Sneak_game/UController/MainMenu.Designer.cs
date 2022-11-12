namespace Sneak_game.UController
{
    partial class MainMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameStartBtn = new System.Windows.Forms.Button();
            this.DifficultSelect = new System.Windows.Forms.TrackBar();
            this.DifficultTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DifficultSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // GameStartBtn
            // 
            this.GameStartBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.GameStartBtn.FlatAppearance.BorderSize = 3;
            this.GameStartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameStartBtn.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameStartBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GameStartBtn.Location = new System.Drawing.Point(67, 161);
            this.GameStartBtn.Name = "GameStartBtn";
            this.GameStartBtn.Size = new System.Drawing.Size(315, 57);
            this.GameStartBtn.TabIndex = 0;
            this.GameStartBtn.Text = "Start";
            this.GameStartBtn.UseVisualStyleBackColor = false;
            this.GameStartBtn.Click += new System.EventHandler(this.GameStartBtn_Click);
            // 
            // DifficultSelect
            // 
            this.DifficultSelect.BackColor = System.Drawing.Color.White;
            this.DifficultSelect.Location = new System.Drawing.Point(67, 278);
            this.DifficultSelect.Maximum = 5;
            this.DifficultSelect.Minimum = 1;
            this.DifficultSelect.Name = "DifficultSelect";
            this.DifficultSelect.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.DifficultSelect.Size = new System.Drawing.Size(45, 315);
            this.DifficultSelect.TabIndex = 1;
            this.DifficultSelect.Value = 1;
            this.DifficultSelect.ValueChanged += new System.EventHandler(this.DifficultSelect_ValueChanged);
            // 
            // DifficultTitle
            // 
            this.DifficultTitle.AutoSize = true;
            this.DifficultTitle.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DifficultTitle.Location = new System.Drawing.Point(118, 563);
            this.DifficultTitle.Name = "DifficultTitle";
            this.DifficultTitle.Size = new System.Drawing.Size(238, 30);
            this.DifficultTitle.TabIndex = 2;
            this.DifficultTitle.Text = "Difficulty : Child";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Sneak_game.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.DifficultTitle);
            this.Controls.Add(this.DifficultSelect);
            this.Controls.Add(this.GameStartBtn);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.DifficultSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GameStartBtn;
        private TrackBar DifficultSelect;
        private Label DifficultTitle;
    }
}
