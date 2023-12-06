namespace rezka_loader_v2
{
    partial class DownloadConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadConfigurationForm));
            this.searchLabel = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.translationSelector = new System.Windows.Forms.ComboBox();
            this.seasonSelector = new System.Windows.Forms.ComboBox();
            this.episodeSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.qualityList = new System.Windows.Forms.ComboBox();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Courier New", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.searchLabel.Location = new System.Drawing.Point(25, 19);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(235, 31);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "CONFIGURATION";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(374, 19);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 23);
            this.close.TabIndex = 5;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // translationSelector
            // 
            this.translationSelector.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.translationSelector.FormattingEnabled = true;
            this.translationSelector.Location = new System.Drawing.Point(30, 92);
            this.translationSelector.Name = "translationSelector";
            this.translationSelector.Size = new System.Drawing.Size(121, 22);
            this.translationSelector.TabIndex = 6;
            // 
            // seasonSelector
            // 
            this.seasonSelector.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seasonSelector.FormattingEnabled = true;
            this.seasonSelector.Location = new System.Drawing.Point(157, 92);
            this.seasonSelector.Name = "seasonSelector";
            this.seasonSelector.Size = new System.Drawing.Size(121, 22);
            this.seasonSelector.TabIndex = 7;
            // 
            // episodeSelector
            // 
            this.episodeSelector.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.episodeSelector.FormattingEnabled = true;
            this.episodeSelector.Location = new System.Drawing.Point(284, 92);
            this.episodeSelector.Name = "episodeSelector";
            this.episodeSelector.Size = new System.Drawing.Size(121, 22);
            this.episodeSelector.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "TRANSLATOR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(156, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "SEASON:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(283, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "EPISODE:";
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nextBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.nextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextBtn.Location = new System.Drawing.Point(284, 149);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(118, 24);
            this.nextBtn.TabIndex = 12;
            this.nextBtn.Text = "NEXT";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qualityLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.qualityLabel.Location = new System.Drawing.Point(28, 129);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(71, 16);
            this.qualityLabel.TabIndex = 14;
            this.qualityLabel.Text = "QUALITY:";
            this.qualityLabel.Visible = false;
            // 
            // qualityList
            // 
            this.qualityList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qualityList.FormattingEnabled = true;
            this.qualityList.Location = new System.Drawing.Point(30, 151);
            this.qualityList.Name = "qualityList";
            this.qualityList.Size = new System.Drawing.Size(121, 22);
            this.qualityList.TabIndex = 13;
            this.qualityList.Visible = false;
            // 
            // downloadBtn
            // 
            this.downloadBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.downloadBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.downloadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.downloadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.downloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadBtn.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.downloadBtn.Location = new System.Drawing.Point(284, 149);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(118, 24);
            this.downloadBtn.TabIndex = 15;
            this.downloadBtn.Text = "DOWNLOAD";
            this.downloadBtn.UseVisualStyleBackColor = false;
            this.downloadBtn.Visible = false;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(-4, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 10);
            this.panel1.TabIndex = 16;
            // 
            // DownloadConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(435, 204);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.qualityLabel);
            this.Controls.Add(this.qualityList);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.episodeSelector);
            this.Controls.Add(this.seasonSelector);
            this.Controls.Add(this.translationSelector);
            this.Controls.Add(this.close);
            this.Controls.Add(this.searchLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DownloadConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DownloadConfigurationForm";
            this.Load += new System.EventHandler(this.DownloadConfigurationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ComboBox translationSelector;
        private System.Windows.Forms.ComboBox seasonSelector;
        private System.Windows.Forms.ComboBox episodeSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.ComboBox qualityList;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Panel panel1;
    }
}