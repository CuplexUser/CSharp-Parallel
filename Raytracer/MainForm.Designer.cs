namespace Raytracer
{
    partial class MainForm
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
            this._isParallelCheckBox = new System.Windows.Forms.CheckBox();
            this._startButton = new System.Windows.Forms.Button();
            this._renderedImage = new System.Windows.Forms.PictureBox();
            this._showThreadsCheckBox = new System.Windows.Forms.CheckBox();
            this._numberOfProcsTrackBar = new System.Windows.Forms.TrackBar();
            this._numberOfProcsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._renderedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numberOfProcsTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // _isParallelCheckBox
            // 
            this._isParallelCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._isParallelCheckBox.AutoSize = true;
            this._isParallelCheckBox.Location = new System.Drawing.Point(126, 574);
            this._isParallelCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._isParallelCheckBox.Name = "_isParallelCheckBox";
            this._isParallelCheckBox.Size = new System.Drawing.Size(64, 19);
            this._isParallelCheckBox.TabIndex = 20;
            this._isParallelCheckBox.Text = "Parallel";
            this._isParallelCheckBox.UseVisualStyleBackColor = true;
            this._isParallelCheckBox.CheckedChanged += new System.EventHandler(this.OnIsParallelCheckBoxChanged);
            // 
            // _startButton
            // 
            this._startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._startButton.Location = new System.Drawing.Point(15, 567);
            this._startButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._startButton.Name = "_startButton";
            this._startButton.Size = new System.Drawing.Size(103, 27);
            this._startButton.TabIndex = 19;
            this._startButton.Text = "Start";
            this._startButton.UseVisualStyleBackColor = true;
            this._startButton.Click += new System.EventHandler(this.OnStartButtonClick);
            // 
            // _renderedImage
            // 
            this._renderedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._renderedImage.BackColor = System.Drawing.Color.Black;
            this._renderedImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._renderedImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._renderedImage.Location = new System.Drawing.Point(15, 17);
            this._renderedImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._renderedImage.Name = "_renderedImage";
            this._renderedImage.Size = new System.Drawing.Size(702, 542);
            this._renderedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._renderedImage.TabIndex = 18;
            this._renderedImage.TabStop = false;
            // 
            // _showThreadsCheckBox
            // 
            this._showThreadsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._showThreadsCheckBox.AutoSize = true;
            this._showThreadsCheckBox.Enabled = false;
            this._showThreadsCheckBox.Location = new System.Drawing.Point(203, 574);
            this._showThreadsCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._showThreadsCheckBox.Name = "_showThreadsCheckBox";
            this._showThreadsCheckBox.Size = new System.Drawing.Size(99, 19);
            this._showThreadsCheckBox.TabIndex = 21;
            this._showThreadsCheckBox.Text = "Show Threads";
            this._showThreadsCheckBox.UseVisualStyleBackColor = true;
            // 
            // _numberOfProcsTrackBar
            // 
            this._numberOfProcsTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._numberOfProcsTrackBar.Enabled = false;
            this._numberOfProcsTrackBar.Location = new System.Drawing.Point(511, 567);
            this._numberOfProcsTrackBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._numberOfProcsTrackBar.Maximum = 24;
            this._numberOfProcsTrackBar.Minimum = 1;
            this._numberOfProcsTrackBar.Name = "_numberOfProcsTrackBar";
            this._numberOfProcsTrackBar.Size = new System.Drawing.Size(208, 45);
            this._numberOfProcsTrackBar.TabIndex = 22;
            this._numberOfProcsTrackBar.Value = 1;
            this._numberOfProcsTrackBar.ValueChanged += new System.EventHandler(this.OnNumberOfProcsTrackBarChanged);
            // 
            // _numberOfProcsLabel
            // 
            this._numberOfProcsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._numberOfProcsLabel.AutoSize = true;
            this._numberOfProcsLabel.Enabled = false;
            this._numberOfProcsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._numberOfProcsLabel.Location = new System.Drawing.Point(500, 578);
            this._numberOfProcsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._numberOfProcsLabel.Name = "_numberOfProcsLabel";
            this._numberOfProcsLabel.Size = new System.Drawing.Size(14, 13);
            this._numberOfProcsLabel.TabIndex = 23;
            this._numberOfProcsLabel.Text = "1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this._numberOfProcsLabel);
            this.Controls.Add(this._numberOfProcsTrackBar);
            this.Controls.Add(this._showThreadsCheckBox);
            this.Controls.Add(this._isParallelCheckBox);
            this.Controls.Add(this._startButton);
            this.Controls.Add(this._renderedImage);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.Text = "Ray Tracer";
            this.Load += new System.EventHandler(this.OnMainFormLoaded);
            ((System.ComponentModel.ISupportInitialize)(this._renderedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numberOfProcsTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox _isParallelCheckBox;
        private System.Windows.Forms.Button _startButton;
        private System.Windows.Forms.PictureBox _renderedImage;
        internal System.Windows.Forms.CheckBox _showThreadsCheckBox;
        private System.Windows.Forms.TrackBar _numberOfProcsTrackBar;
        private System.Windows.Forms.Label _numberOfProcsLabel;
    }
}

