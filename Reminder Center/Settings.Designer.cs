namespace ReminderCenter {
	partial class Settings {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.TextClientIdentifier = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.PanelClientIdentifier = new System.Windows.Forms.Panel();
            this.LabelClientIdentifier = new System.Windows.Forms.Label();
            this.LabelApplicationTitle = new System.Windows.Forms.Label();
            this.LabelUpdateRate = new System.Windows.Forms.Label();
            this.NumUpdateSeconds = new System.Windows.Forms.NumericUpDown();
            this.NumUpdateMinutes = new System.Windows.Forms.NumericUpDown();
            this.NumUpdateHours = new System.Windows.Forms.NumericUpDown();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.ButtonClose = new System.Windows.Forms.Panel();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimerRecive = new System.Windows.Forms.Timer(this.components);
            this.LabelApiUsername = new System.Windows.Forms.Label();
            this.PanelApiUsername = new System.Windows.Forms.Panel();
            this.TextApiUsername = new System.Windows.Forms.TextBox();
            this.PanelSpacing = new System.Windows.Forms.Panel();
            this.PanelSeperator01 = new System.Windows.Forms.Panel();
            this.LabelApiPassword = new System.Windows.Forms.Label();
            this.PanelApiPassword = new System.Windows.Forms.Panel();
            this.TextApiPassword = new System.Windows.Forms.TextBox();
            this.LabelApiUrl = new System.Windows.Forms.Label();
            this.PanelApiUrl = new System.Windows.Forms.Panel();
            this.TextApiUrl = new System.Windows.Forms.TextBox();
            this.PanelSeperator02 = new System.Windows.Forms.Panel();
            this.NumRescheduleHours = new System.Windows.Forms.NumericUpDown();
            this.NumRescheduleMinutes = new System.Windows.Forms.NumericUpDown();
            this.NumRescheduleSeconds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerReschedule = new System.Windows.Forms.Timer(this.components);
            this.PanelClientIdentifier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpdateSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpdateMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpdateHours)).BeginInit();
            this.PanelTitle.SuspendLayout();
            this.PanelApiUsername.SuspendLayout();
            this.PanelApiPassword.SuspendLayout();
            this.PanelApiUrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumRescheduleHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRescheduleMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRescheduleSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // TextClientIdentifier
            // 
            this.TextClientIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextClientIdentifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.TextClientIdentifier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextClientIdentifier.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TextClientIdentifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TextClientIdentifier.Location = new System.Drawing.Point(2, 2);
            this.TextClientIdentifier.Name = "TextClientIdentifier";
            this.TextClientIdentifier.Size = new System.Drawing.Size(215, 15);
            this.TextClientIdentifier.TabIndex = 0;
            // 
            // ButtonSave
            // 
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ButtonSave.Location = new System.Drawing.Point(303, 326);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(94, 23);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "Save Settings";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // PanelClientIdentifier
            // 
            this.PanelClientIdentifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.PanelClientIdentifier.Controls.Add(this.TextClientIdentifier);
            this.PanelClientIdentifier.Location = new System.Drawing.Point(175, 50);
            this.PanelClientIdentifier.Name = "PanelClientIdentifier";
            this.PanelClientIdentifier.Size = new System.Drawing.Size(221, 19);
            this.PanelClientIdentifier.TabIndex = 0;
            // 
            // LabelClientIdentifier
            // 
            this.LabelClientIdentifier.AutoSize = true;
            this.LabelClientIdentifier.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClientIdentifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelClientIdentifier.Location = new System.Drawing.Point(12, 54);
            this.LabelClientIdentifier.Name = "LabelClientIdentifier";
            this.LabelClientIdentifier.Size = new System.Drawing.Size(90, 13);
            this.LabelClientIdentifier.TabIndex = 100;
            this.LabelClientIdentifier.Text = "Client Identifier:";
            // 
            // LabelApplicationTitle
            // 
            this.LabelApplicationTitle.AutoSize = true;
            this.LabelApplicationTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApplicationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelApplicationTitle.Location = new System.Drawing.Point(12, 5);
            this.LabelApplicationTitle.Name = "LabelApplicationTitle";
            this.LabelApplicationTitle.Size = new System.Drawing.Size(114, 17);
            this.LabelApplicationTitle.TabIndex = 100;
            this.LabelApplicationTitle.Text = "Reminder Settings";
            this.LabelApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUpdateRate
            // 
            this.LabelUpdateRate.AutoSize = true;
            this.LabelUpdateRate.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LabelUpdateRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelUpdateRate.Location = new System.Drawing.Point(12, 91);
            this.LabelUpdateRate.Name = "LabelUpdateRate";
            this.LabelUpdateRate.Size = new System.Drawing.Size(137, 13);
            this.LabelUpdateRate.TabIndex = 100;
            this.LabelUpdateRate.Text = "Update Rate (HH:MM:SS):";
            // 
            // NumUpdateSeconds
            // 
            this.NumUpdateSeconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.NumUpdateSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumUpdateSeconds.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NumUpdateSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumUpdateSeconds.Location = new System.Drawing.Point(327, 91);
            this.NumUpdateSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NumUpdateSeconds.Name = "NumUpdateSeconds";
            this.NumUpdateSeconds.Size = new System.Drawing.Size(70, 18);
            this.NumUpdateSeconds.TabIndex = 3;
            this.NumUpdateSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumUpdateMinutes
            // 
            this.NumUpdateMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.NumUpdateMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumUpdateMinutes.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NumUpdateMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumUpdateMinutes.Location = new System.Drawing.Point(251, 91);
            this.NumUpdateMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NumUpdateMinutes.Name = "NumUpdateMinutes";
            this.NumUpdateMinutes.Size = new System.Drawing.Size(70, 18);
            this.NumUpdateMinutes.TabIndex = 2;
            this.NumUpdateMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUpdateMinutes.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // NumUpdateHours
            // 
            this.NumUpdateHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.NumUpdateHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumUpdateHours.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NumUpdateHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumUpdateHours.Location = new System.Drawing.Point(175, 91);
            this.NumUpdateHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NumUpdateHours.Name = "NumUpdateHours";
            this.NumUpdateHours.Size = new System.Drawing.Size(70, 18);
            this.NumUpdateHours.TabIndex = 1;
            this.NumUpdateHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelTitle
            // 
            this.PanelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelTitle.Controls.Add(this.ButtonClose);
            this.PanelTitle.Controls.Add(this.LabelApplicationTitle);
            this.PanelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(408, 30);
            this.PanelTitle.TabIndex = 100;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackgroundImage = global::ReminderCenter.Properties.Resources.closeNormal;
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonClose.Location = new System.Drawing.Point(383, 8);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(14, 14);
            this.ButtonClose.TabIndex = 100;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            this.ButtonClose.MouseEnter += new System.EventHandler(this.ButtonClose_HoverEnter);
            this.ButtonClose.MouseLeave += new System.EventHandler(this.ButtonClose_HoverLeave);
            // 
            // TrayIcon
            // 
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Reminder Center";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // TimerRecive
            // 
            this.TimerRecive.Tick += new System.EventHandler(this.TimerReciveMessages_Tick);
            // 
            // LabelApiUsername
            // 
            this.LabelApiUsername.AutoSize = true;
            this.LabelApiUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApiUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelApiUsername.Location = new System.Drawing.Point(12, 197);
            this.LabelApiUsername.Name = "LabelApiUsername";
            this.LabelApiUsername.Size = new System.Drawing.Size(80, 13);
            this.LabelApiUsername.TabIndex = 100;
            this.LabelApiUsername.Text = "API Username:";
            // 
            // PanelApiUsername
            // 
            this.PanelApiUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.PanelApiUsername.Controls.Add(this.TextApiUsername);
            this.PanelApiUsername.Location = new System.Drawing.Point(175, 195);
            this.PanelApiUsername.Name = "PanelApiUsername";
            this.PanelApiUsername.Size = new System.Drawing.Size(221, 19);
            this.PanelApiUsername.TabIndex = 4;
            // 
            // TextApiUsername
            // 
            this.TextApiUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextApiUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.TextApiUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextApiUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TextApiUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TextApiUsername.Location = new System.Drawing.Point(2, 2);
            this.TextApiUsername.Name = "TextApiUsername";
            this.TextApiUsername.Size = new System.Drawing.Size(215, 15);
            this.TextApiUsername.TabIndex = 0;
            // 
            // PanelSpacing
            // 
            this.PanelSpacing.Location = new System.Drawing.Point(371, 155);
            this.PanelSpacing.Name = "PanelSpacing";
            this.PanelSpacing.Size = new System.Drawing.Size(26, 10);
            this.PanelSpacing.TabIndex = 100;
            // 
            // PanelSeperator01
            // 
            this.PanelSeperator01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelSeperator01.Location = new System.Drawing.Point(0, 171);
            this.PanelSeperator01.Name = "PanelSeperator01";
            this.PanelSeperator01.Size = new System.Drawing.Size(408, 2);
            this.PanelSeperator01.TabIndex = 100;
            // 
            // LabelApiPassword
            // 
            this.LabelApiPassword.AutoSize = true;
            this.LabelApiPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApiPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelApiPassword.Location = new System.Drawing.Point(12, 238);
            this.LabelApiPassword.Name = "LabelApiPassword";
            this.LabelApiPassword.Size = new System.Drawing.Size(78, 13);
            this.LabelApiPassword.TabIndex = 100;
            this.LabelApiPassword.Text = "API Password:";
            // 
            // PanelApiPassword
            // 
            this.PanelApiPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.PanelApiPassword.Controls.Add(this.TextApiPassword);
            this.PanelApiPassword.Location = new System.Drawing.Point(175, 236);
            this.PanelApiPassword.Name = "PanelApiPassword";
            this.PanelApiPassword.Size = new System.Drawing.Size(221, 19);
            this.PanelApiPassword.TabIndex = 5;
            // 
            // TextApiPassword
            // 
            this.TextApiPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextApiPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.TextApiPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextApiPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TextApiPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TextApiPassword.Location = new System.Drawing.Point(2, 2);
            this.TextApiPassword.Name = "TextApiPassword";
            this.TextApiPassword.Size = new System.Drawing.Size(215, 15);
            this.TextApiPassword.TabIndex = 0;
            // 
            // LabelApiUrl
            // 
            this.LabelApiUrl.AutoSize = true;
            this.LabelApiUrl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApiUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelApiUrl.Location = new System.Drawing.Point(12, 279);
            this.LabelApiUrl.Name = "LabelApiUrl";
            this.LabelApiUrl.Size = new System.Drawing.Size(44, 13);
            this.LabelApiUrl.TabIndex = 100;
            this.LabelApiUrl.Text = "API Url:";
            // 
            // PanelApiUrl
            // 
            this.PanelApiUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.PanelApiUrl.Controls.Add(this.TextApiUrl);
            this.PanelApiUrl.Location = new System.Drawing.Point(175, 277);
            this.PanelApiUrl.Name = "PanelApiUrl";
            this.PanelApiUrl.Size = new System.Drawing.Size(221, 19);
            this.PanelApiUrl.TabIndex = 6;
            // 
            // TextApiUrl
            // 
            this.TextApiUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextApiUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.TextApiUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextApiUrl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TextApiUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TextApiUrl.Location = new System.Drawing.Point(2, 2);
            this.TextApiUrl.Name = "TextApiUrl";
            this.TextApiUrl.Size = new System.Drawing.Size(215, 15);
            this.TextApiUrl.TabIndex = 0;
            // 
            // PanelSeperator02
            // 
            this.PanelSeperator02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelSeperator02.Location = new System.Drawing.Point(0, 318);
            this.PanelSeperator02.Name = "PanelSeperator02";
            this.PanelSeperator02.Size = new System.Drawing.Size(408, 2);
            this.PanelSeperator02.TabIndex = 100;
            // 
            // NumRescheduleHours
            // 
            this.NumRescheduleHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.NumRescheduleHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumRescheduleHours.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NumRescheduleHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumRescheduleHours.Location = new System.Drawing.Point(175, 131);
            this.NumRescheduleHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NumRescheduleHours.Name = "NumRescheduleHours";
            this.NumRescheduleHours.Size = new System.Drawing.Size(70, 18);
            this.NumRescheduleHours.TabIndex = 101;
            this.NumRescheduleHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumRescheduleHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumRescheduleMinutes
            // 
            this.NumRescheduleMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.NumRescheduleMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumRescheduleMinutes.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NumRescheduleMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumRescheduleMinutes.Location = new System.Drawing.Point(251, 131);
            this.NumRescheduleMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NumRescheduleMinutes.Name = "NumRescheduleMinutes";
            this.NumRescheduleMinutes.Size = new System.Drawing.Size(70, 18);
            this.NumRescheduleMinutes.TabIndex = 102;
            this.NumRescheduleMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumRescheduleSeconds
            // 
            this.NumRescheduleSeconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.NumRescheduleSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumRescheduleSeconds.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NumRescheduleSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumRescheduleSeconds.Location = new System.Drawing.Point(327, 131);
            this.NumRescheduleSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NumRescheduleSeconds.Name = "NumRescheduleSeconds";
            this.NumRescheduleSeconds.Size = new System.Drawing.Size(70, 18);
            this.NumRescheduleSeconds.TabIndex = 103;
            this.NumRescheduleSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Reschedule Rate (HH:MM:SS):";
            // 
            // TimerReschedule
            // 
            this.TimerReschedule.Tick += new System.EventHandler(this.TimerReschedule_Tick);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(408, 356);
            this.Controls.Add(this.NumRescheduleHours);
            this.Controls.Add(this.NumRescheduleMinutes);
            this.Controls.Add(this.NumRescheduleSeconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelSeperator02);
            this.Controls.Add(this.LabelApiUrl);
            this.Controls.Add(this.LabelApiPassword);
            this.Controls.Add(this.PanelApiUrl);
            this.Controls.Add(this.PanelSeperator01);
            this.Controls.Add(this.PanelApiPassword);
            this.Controls.Add(this.PanelSpacing);
            this.Controls.Add(this.LabelApiUsername);
            this.Controls.Add(this.PanelApiUsername);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.NumUpdateHours);
            this.Controls.Add(this.NumUpdateMinutes);
            this.Controls.Add(this.NumUpdateSeconds);
            this.Controls.Add(this.LabelUpdateRate);
            this.Controls.Add(this.LabelClientIdentifier);
            this.Controls.Add(this.PanelClientIdentifier);
            this.Controls.Add(this.ButtonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.PanelClientIdentifier.ResumeLayout(false);
            this.PanelClientIdentifier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpdateSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpdateMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpdateHours)).EndInit();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.PanelApiUsername.ResumeLayout(false);
            this.PanelApiUsername.PerformLayout();
            this.PanelApiPassword.ResumeLayout(false);
            this.PanelApiPassword.PerformLayout();
            this.PanelApiUrl.ResumeLayout(false);
            this.PanelApiUrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumRescheduleHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRescheduleMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRescheduleSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox TextClientIdentifier;
		private System.Windows.Forms.Button ButtonSave;
		private System.Windows.Forms.Panel PanelClientIdentifier;
		private System.Windows.Forms.Label LabelClientIdentifier;
		private System.Windows.Forms.Label LabelApplicationTitle;
		private System.Windows.Forms.Label LabelUpdateRate;
		private System.Windows.Forms.NumericUpDown NumUpdateSeconds;
		private System.Windows.Forms.NumericUpDown NumUpdateMinutes;
		private System.Windows.Forms.NumericUpDown NumUpdateHours;
		private System.Windows.Forms.Panel PanelTitle;
		private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.Timer TimerRecive;
        private System.Windows.Forms.Panel ButtonClose;
        private System.Windows.Forms.Label LabelApiUsername;
        private System.Windows.Forms.Panel PanelApiUsername;
        private System.Windows.Forms.TextBox TextApiUsername;
        private System.Windows.Forms.Panel PanelSpacing;
        private System.Windows.Forms.Panel PanelSeperator01;
        private System.Windows.Forms.Label LabelApiPassword;
        private System.Windows.Forms.Panel PanelApiPassword;
        private System.Windows.Forms.TextBox TextApiPassword;
        private System.Windows.Forms.Label LabelApiUrl;
        private System.Windows.Forms.Panel PanelApiUrl;
        private System.Windows.Forms.TextBox TextApiUrl;
        private System.Windows.Forms.Panel PanelSeperator02;
        private System.Windows.Forms.NumericUpDown NumRescheduleHours;
        private System.Windows.Forms.NumericUpDown NumRescheduleMinutes;
        private System.Windows.Forms.NumericUpDown NumRescheduleSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerReschedule;
    }
}

