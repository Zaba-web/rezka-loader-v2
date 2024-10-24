namespace rezka_loader_v2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.downloadsList = new System.Windows.Forms.ListView();
            this.file = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.downloadClient = new System.Windows.Forms.RadioButton();
            this.downloadClientAlto = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.conVPN = new System.Windows.Forms.Label();
            this.conBlocked = new System.Windows.Forms.Label();
            this.connectionCheck = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(62, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "REZKA LOADER V2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(723, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 23);
            this.close.TabIndex = 3;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(411, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "ADD NEW DOWNLOAD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // downloadsList
            // 
            this.downloadsList.BackColor = System.Drawing.Color.Black;
            this.downloadsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.file,
            this.status});
            this.downloadsList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadsList.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.downloadsList.HideSelection = false;
            this.downloadsList.Location = new System.Drawing.Point(411, 58);
            this.downloadsList.Name = "downloadsList";
            this.downloadsList.Size = new System.Drawing.Size(340, 383);
            this.downloadsList.TabIndex = 5;
            this.downloadsList.UseCompatibleStateImageBehavior = false;
            this.downloadsList.View = System.Windows.Forms.View.Details;
            this.downloadsList.SelectedIndexChanged += new System.EventHandler(this.downloadsList_SelectedIndexChanged);
            this.downloadsList.DoubleClick += new System.EventHandler(this.downloadsList_DoubleClick);
            // 
            // file
            // 
            this.file.Text = "File";
            this.file.Width = 255;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(332, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "alpha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minimize.Location = new System.Drawing.Point(689, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(28, 23);
            this.minimize.TabIndex = 7;
            this.minimize.Text = "-";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 3000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // downloadClient
            // 
            this.downloadClient.AutoSize = true;
            this.downloadClient.Checked = true;
            this.downloadClient.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadClient.Location = new System.Drawing.Point(124, 100);
            this.downloadClient.Name = "downloadClient";
            this.downloadClient.Size = new System.Drawing.Size(67, 18);
            this.downloadClient.TabIndex = 9;
            this.downloadClient.TabStop = true;
            this.downloadClient.Text = "Native";
            this.downloadClient.UseVisualStyleBackColor = true;
            this.downloadClient.Visible = false;
            this.downloadClient.CheckedChanged += new System.EventHandler(this.downloadClient_CheckedChanged);
            // 
            // downloadClientAlto
            // 
            this.downloadClientAlto.AutoSize = true;
            this.downloadClientAlto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadClientAlto.Location = new System.Drawing.Point(197, 100);
            this.downloadClientAlto.Name = "downloadClientAlto";
            this.downloadClientAlto.Size = new System.Drawing.Size(144, 18);
            this.downloadClientAlto.TabIndex = 10;
            this.downloadClientAlto.Text = "Alto [Not stable]";
            this.downloadClientAlto.UseVisualStyleBackColor = true;
            this.downloadClientAlto.Visible = false;
            this.downloadClientAlto.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(610, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "CLEAR HISTORY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(408, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Connection:";
            // 
            // conVPN
            // 
            this.conVPN.AutoSize = true;
            this.conVPN.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conVPN.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.conVPN.Location = new System.Drawing.Point(498, 525);
            this.conVPN.Name = "conVPN";
            this.conVPN.Size = new System.Drawing.Size(56, 14);
            this.conVPN.TabIndex = 13;
            this.conVPN.Text = "Secured";
            this.conVPN.Visible = false;
            // 
            // conBlocked
            // 
            this.conBlocked.AutoSize = true;
            this.conBlocked.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conBlocked.ForeColor = System.Drawing.Color.Red;
            this.conBlocked.Location = new System.Drawing.Point(498, 525);
            this.conBlocked.Name = "conBlocked";
            this.conBlocked.Size = new System.Drawing.Size(56, 14);
            this.conBlocked.TabIndex = 14;
            this.conBlocked.Text = "Blocked";
            this.conBlocked.Visible = false;
            // 
            // connectionCheck
            // 
            this.connectionCheck.Enabled = true;
            this.connectionCheck.Interval = 10000;
            this.connectionCheck.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(783, 574);
            this.Controls.Add(this.conBlocked);
            this.Controls.Add(this.conVPN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.downloadClientAlto);
            this.Controls.Add(this.downloadClient);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.downloadsList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REZKA LOADER";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView downloadsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.ColumnHeader file;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.RadioButton downloadClient;
        private System.Windows.Forms.RadioButton downloadClientAlto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label conVPN;
        private System.Windows.Forms.Label conBlocked;
        private System.Windows.Forms.Timer connectionCheck;
    }
}

