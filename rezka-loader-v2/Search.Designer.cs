namespace rezka_loader_v2
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.searchLabel = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.moviestList = new System.Windows.Forms.ListView();
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downloadBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Courier New", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.searchLabel.Location = new System.Drawing.Point(26, 22);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(116, 31);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "SEARCH";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(471, 22);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 23);
            this.close.TabIndex = 4;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.Black;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.ForeColor = System.Drawing.SystemColors.Window;
            this.searchBox.Location = new System.Drawing.Point(32, 79);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(386, 24);
            this.searchBox.TabIndex = 5;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // findBtn
            // 
            this.findBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.findBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.findBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.findBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findBtn.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.findBtn.Location = new System.Drawing.Point(433, 79);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(66, 24);
            this.findBtn.TabIndex = 6;
            this.findBtn.Text = "FIND";
            this.findBtn.UseVisualStyleBackColor = false;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // moviestList
            // 
            this.moviestList.BackColor = System.Drawing.SystemColors.MenuText;
            this.moviestList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.action});
            this.moviestList.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moviestList.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.moviestList.HideSelection = false;
            this.moviestList.Location = new System.Drawing.Point(32, 130);
            this.moviestList.MultiSelect = false;
            this.moviestList.Name = "moviestList";
            this.moviestList.Size = new System.Drawing.Size(467, 346);
            this.moviestList.TabIndex = 7;
            this.moviestList.UseCompatibleStateImageBehavior = false;
            this.moviestList.View = System.Windows.Forms.View.List;
            // 
            // title
            // 
            this.title.Text = "Movie Title";
            this.title.Width = 400;
            // 
            // action
            // 
            this.action.Text = "Download";
            this.action.Width = 70;
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
            this.downloadBtn.Location = new System.Drawing.Point(32, 493);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(163, 24);
            this.downloadBtn.TabIndex = 8;
            this.downloadBtn.Text = "DOWNLOAD SELECTED";
            this.downloadBtn.UseVisualStyleBackColor = false;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(-5, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 10);
            this.panel1.TabIndex = 9;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(532, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.moviestList);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.close);
            this.Controls.Add(this.searchLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.ListView moviestList;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader action;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Panel panel1;
    }
}