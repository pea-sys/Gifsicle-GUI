namespace Gifsicle_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.beforeSizeValueLabel = new System.Windows.Forms.Label();
            this.compressCountValuelabel = new System.Windows.Forms.Label();
            this.compressButton = new System.Windows.Forms.Button();
            this.compressCountTitlelabel = new System.Windows.Forms.Label();
            this.afterSizeValueLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.afterSizeTitleLabel = new System.Windows.Forms.Label();
            this.beforeSizeTitleLabel = new System.Windows.Forms.Label();
            this.guidanceLabel = new System.Windows.Forms.Label();
            this.dropPointLabel = new System.Windows.Forms.Label();
            this.settingPage = new System.Windows.Forms.TabPage();
            this.MinCompressionRatioValuepDown1 = new System.Windows.Forms.NumericUpDown();
            this.MinCompressionRatioTitleLabel = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.settingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinCompressionRatioValuepDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainPage);
            this.tabControl.Controls.Add(this.settingPage);
            this.tabControl.Location = new System.Drawing.Point(2, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(289, 191);
            this.tabControl.TabIndex = 13;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.beforeSizeValueLabel);
            this.mainPage.Controls.Add(this.compressCountValuelabel);
            this.mainPage.Controls.Add(this.compressButton);
            this.mainPage.Controls.Add(this.compressCountTitlelabel);
            this.mainPage.Controls.Add(this.afterSizeValueLabel);
            this.mainPage.Controls.Add(this.progressBar);
            this.mainPage.Controls.Add(this.afterSizeTitleLabel);
            this.mainPage.Controls.Add(this.beforeSizeTitleLabel);
            this.mainPage.Controls.Add(this.guidanceLabel);
            this.mainPage.Controls.Add(this.dropPointLabel);
            this.mainPage.Location = new System.Drawing.Point(4, 24);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(281, 163);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Main";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // beforeSizeValueLabel
            // 
            this.beforeSizeValueLabel.BackColor = System.Drawing.Color.White;
            this.beforeSizeValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.beforeSizeValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beforeSizeValueLabel.ForeColor = System.Drawing.Color.Black;
            this.beforeSizeValueLabel.Location = new System.Drawing.Point(74, 66);
            this.beforeSizeValueLabel.Name = "beforeSizeValueLabel";
            this.beforeSizeValueLabel.Size = new System.Drawing.Size(70, 18);
            this.beforeSizeValueLabel.TabIndex = 7;
            this.beforeSizeValueLabel.Text = "999999999999";
            this.beforeSizeValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // compressCountValuelabel
            // 
            this.compressCountValuelabel.BackColor = System.Drawing.Color.White;
            this.compressCountValuelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.compressCountValuelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compressCountValuelabel.ForeColor = System.Drawing.Color.Black;
            this.compressCountValuelabel.Location = new System.Drawing.Point(74, 50);
            this.compressCountValuelabel.Name = "compressCountValuelabel";
            this.compressCountValuelabel.Size = new System.Drawing.Size(70, 18);
            this.compressCountValuelabel.TabIndex = 11;
            this.compressCountValuelabel.Text = "999999999999";
            this.compressCountValuelabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // compressButton
            // 
            this.compressButton.Enabled = false;
            this.compressButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.compressButton.FlatAppearance.BorderSize = 3;
            this.compressButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.compressButton.Location = new System.Drawing.Point(11, 15);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(106, 32);
            this.compressButton.TabIndex = 0;
            this.compressButton.Text = "Compress";
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Click += new System.EventHandler(this.compressButton_Click);
            // 
            // compressCountTitlelabel
            // 
            this.compressCountTitlelabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.compressCountTitlelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.compressCountTitlelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compressCountTitlelabel.ForeColor = System.Drawing.Color.Black;
            this.compressCountTitlelabel.Location = new System.Drawing.Point(12, 50);
            this.compressCountTitlelabel.Name = "compressCountTitlelabel";
            this.compressCountTitlelabel.Size = new System.Drawing.Size(66, 18);
            this.compressCountTitlelabel.TabIndex = 10;
            this.compressCountTitlelabel.Text = "Compress";
            // 
            // afterSizeValueLabel
            // 
            this.afterSizeValueLabel.BackColor = System.Drawing.Color.White;
            this.afterSizeValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.afterSizeValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afterSizeValueLabel.ForeColor = System.Drawing.Color.Black;
            this.afterSizeValueLabel.Location = new System.Drawing.Point(74, 84);
            this.afterSizeValueLabel.Name = "afterSizeValueLabel";
            this.afterSizeValueLabel.Size = new System.Drawing.Size(70, 18);
            this.afterSizeValueLabel.TabIndex = 9;
            this.afterSizeValueLabel.Text = "999999999999";
            this.afterSizeValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(11, 138);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(239, 15);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            // 
            // afterSizeTitleLabel
            // 
            this.afterSizeTitleLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.afterSizeTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.afterSizeTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afterSizeTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.afterSizeTitleLabel.Location = new System.Drawing.Point(12, 84);
            this.afterSizeTitleLabel.Name = "afterSizeTitleLabel";
            this.afterSizeTitleLabel.Size = new System.Drawing.Size(66, 18);
            this.afterSizeTitleLabel.TabIndex = 8;
            this.afterSizeTitleLabel.Text = "AfterByte";
            // 
            // beforeSizeTitleLabel
            // 
            this.beforeSizeTitleLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.beforeSizeTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.beforeSizeTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beforeSizeTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.beforeSizeTitleLabel.Location = new System.Drawing.Point(12, 66);
            this.beforeSizeTitleLabel.Name = "beforeSizeTitleLabel";
            this.beforeSizeTitleLabel.Size = new System.Drawing.Size(66, 18);
            this.beforeSizeTitleLabel.TabIndex = 6;
            this.beforeSizeTitleLabel.Text = "BeforeByte";
            // 
            // guidanceLabel
            // 
            this.guidanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.guidanceLabel.Location = new System.Drawing.Point(7, 121);
            this.guidanceLabel.Name = "guidanceLabel";
            this.guidanceLabel.Size = new System.Drawing.Size(173, 23);
            this.guidanceLabel.TabIndex = 5;
            this.guidanceLabel.Text = "1234567890123456789012345678";
            // 
            // dropPointLabel
            // 
            this.dropPointLabel.AllowDrop = true;
            this.dropPointLabel.Image = ((System.Drawing.Image)(resources.GetObject("dropPointLabel.Image")));
            this.dropPointLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dropPointLabel.Location = new System.Drawing.Point(2, 1);
            this.dropPointLabel.Name = "dropPointLabel";
            this.dropPointLabel.Size = new System.Drawing.Size(278, 163);
            this.dropPointLabel.TabIndex = 4;
            this.dropPointLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropPointLabel_DragDrop);
            this.dropPointLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropPointLabel_DragEnter);
            // 
            // settingPage
            // 
            this.settingPage.Controls.Add(this.MinCompressionRatioValuepDown1);
            this.settingPage.Controls.Add(this.MinCompressionRatioTitleLabel);
            this.settingPage.Location = new System.Drawing.Point(4, 24);
            this.settingPage.Name = "settingPage";
            this.settingPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingPage.Size = new System.Drawing.Size(281, 163);
            this.settingPage.TabIndex = 1;
            this.settingPage.Text = "Settings";
            this.settingPage.UseVisualStyleBackColor = true;
            // 
            // MinCompressionRatioValuepDown1
            // 
            this.MinCompressionRatioValuepDown1.Location = new System.Drawing.Point(155, 13);
            this.MinCompressionRatioValuepDown1.Name = "MinCompressionRatioValuepDown1";
            this.MinCompressionRatioValuepDown1.Size = new System.Drawing.Size(50, 23);
            this.MinCompressionRatioValuepDown1.TabIndex = 13;
            this.MinCompressionRatioValuepDown1.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // MinCompressionRatioTitleLabel
            // 
            this.MinCompressionRatioTitleLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MinCompressionRatioTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MinCompressionRatioTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinCompressionRatioTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.MinCompressionRatioTitleLabel.Location = new System.Drawing.Point(7, 14);
            this.MinCompressionRatioTitleLabel.Name = "MinCompressionRatioTitleLabel";
            this.MinCompressionRatioTitleLabel.Size = new System.Drawing.Size(149, 22);
            this.MinCompressionRatioTitleLabel.TabIndex = 12;
            this.MinCompressionRatioTitleLabel.Text = "MinCompressionRatio(%)";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 191);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Gifsicle_GUI";
            this.tabControl.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.settingPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinCompressionRatioValuepDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage mainPage;
        private Label beforeSizeValueLabel;
        private Label compressCountValuelabel;
        private Button compressButton;
        private Label compressCountTitlelabel;
        private Label afterSizeValueLabel;
        private ProgressBar progressBar;
        private Label afterSizeTitleLabel;
        private Label beforeSizeTitleLabel;
        private Label guidanceLabel;
        private Label dropPointLabel;
        private TabPage settingPage;
        private NumericUpDown MinCompressionRatioValuepDown1;
        private Label MinCompressionRatioTitleLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}