using ReminderCenter.Management;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReminderCenter
{
    public partial class ApiMessage : Form
    {
       
        private static int taskbarHeight = Properties.Settings.Default.TaskbarHeight;
        private static int margin = 5;

        public string Id { get; set; }

        public string Message
        {
            get { return LabelMessage.Text; }
            set { LabelMessage.Text = value; }
        }

        public string Timestamp
        {
            get { return LabelTimestamp.Text; }
            set { LabelTimestamp.Text = value; }
        }

        public ApiMessage()
        {
            Init();
        }

        public ApiMessage(string message)
        {
            Init();
            LabelTitle.Text = "Error";
            PanelImage.BackgroundImage = Properties.Resources.error;

            StartPosition = FormStartPosition.Manual;
            ShowInTaskbar = false;
            Id = "0";
            Message = message;
            Timestamp = DateTime.Now.ToString();
        }

        private void Init()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            ShowInTaskbar = false;

            AcceptButton = ButtonClose;
            CancelButton = ButtonClose;
            TopMost = true;
        }

        public void SetPosition(int index, int modifier = 0)
        {
            int positionModifier = (Height * index) + (margin * index) + modifier;
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            Location = new Point(resolution.Width - Width, resolution.Height - Height - taskbarHeight - positionModifier);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            MessageHandler.DismissMessage(this);
        }

        private void ButtonReschedule_Click(object sender, EventArgs e)
        {
            MessageHandler.RescheduleMessage(this);
        }

        private void Button_HoverEnter(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            senderButton.ForeColor = Color.White;
        }

        private void Button_HoverLeave(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            senderButton.ForeColor = Color.DarkGray;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (this.GetHashCode() == obj.GetHashCode())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = (int)2166136261;
                hash = (hash * 16777619) ^ Timestamp.GetHashCode();
                hash = (hash * 16777619) ^ Id.GetHashCode();
                hash = (hash * 16777619) ^ Message.GetHashCode();
                return hash;
            }
        }
    }
}
