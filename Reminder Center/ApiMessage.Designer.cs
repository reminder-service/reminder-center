namespace ReminderCenter
{
    partial class ApiMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApiMessage));
            this.PanelImage = new System.Windows.Forms.Panel();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonReschedule = new System.Windows.Forms.Button();
            this.LabelTimestamp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PanelImage
            // 
            this.PanelImage.BackgroundImage = global::ReminderCenter.Properties.Resources.info;
            this.PanelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelImage.Location = new System.Drawing.Point(12, 12);
            this.PanelImage.Name = "PanelImage";
            this.PanelImage.Size = new System.Drawing.Size(64, 64);
            this.PanelImage.TabIndex = 0;
            // 
            // LabelMessage
            // 
            this.LabelMessage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelMessage.Location = new System.Drawing.Point(98, 39);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(298, 26);
            this.LabelMessage.TabIndex = 102;
            this.LabelMessage.Text = "<Message>";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelTitle.Location = new System.Drawing.Point(98, 12);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(64, 17);
            this.LabelTitle.TabIndex = 103;
            this.LabelTitle.Text = "Reminder";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.ForeColor = System.Drawing.Color.DarkGray;
            this.ButtonClose.Location = new System.Drawing.Point(347, 70);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(49, 22);
            this.ButtonClose.TabIndex = 104;
            this.ButtonClose.Text = "dismiss";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            this.ButtonClose.MouseEnter += new System.EventHandler(this.Button_HoverEnter);
            this.ButtonClose.MouseLeave += new System.EventHandler(this.Button_HoverLeave);
            // 
            // ButtonReschedule
            // 
            this.ButtonReschedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonReschedule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ButtonReschedule.FlatAppearance.BorderSize = 0;
            this.ButtonReschedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ButtonReschedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ButtonReschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReschedule.ForeColor = System.Drawing.Color.DarkGray;
            this.ButtonReschedule.Location = new System.Drawing.Point(301, 70);
            this.ButtonReschedule.Name = "ButtonReschedule";
            this.ButtonReschedule.Size = new System.Drawing.Size(40, 22);
            this.ButtonReschedule.TabIndex = 105;
            this.ButtonReschedule.Text = "later";
            this.ButtonReschedule.UseVisualStyleBackColor = true;
            this.ButtonReschedule.Click += new System.EventHandler(this.ButtonReschedule_Click);
            this.ButtonReschedule.MouseEnter += new System.EventHandler(this.Button_HoverEnter);
            this.ButtonReschedule.MouseLeave += new System.EventHandler(this.Button_HoverLeave);
            // 
            // LabelTimestamp
            // 
            this.LabelTimestamp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimestamp.ForeColor = System.Drawing.Color.DarkGray;
            this.LabelTimestamp.Location = new System.Drawing.Point(98, 70);
            this.LabelTimestamp.Name = "LabelTimestamp";
            this.LabelTimestamp.Size = new System.Drawing.Size(156, 22);
            this.LabelTimestamp.TabIndex = 106;
            this.LabelTimestamp.Text = "<Timestamp>";
            this.LabelTimestamp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(408, 104);
            this.Controls.Add(this.LabelTimestamp);
            this.Controls.Add(this.ButtonReschedule);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.PanelImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Message";
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelImage;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonReschedule;
        private System.Windows.Forms.Label LabelTimestamp;
    }
}