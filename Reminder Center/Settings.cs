using System;
using System.Drawing;
using System.Windows.Forms;
using ReminderCenter.Management;
using ReminderCenter.ApiClient;

namespace ReminderCenter {
	public partial class Settings : Form {
        private int taskbarHeight;

        private MessageReciever messageReciever;
        private string apiUrl;
        private string apiUsername;
        private string apiPassword;
        private string apiIdentifier;

        private ContextMenu trayMenu;

        public Settings()
        {
            MessageHandler.MainForm = this;
            MessageReciever.MainForm = this;

            // Start forms application
            InitializeComponent();
        }

        private void ShowSettings()
        {
            ResetWindowLocation();
            Visible = true;
            TextClientIdentifier.Focus();
        }

        private void ResetWindowLocation()
        {
            StartPosition = FormStartPosition.Manual;
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
			Point location = new Point(resolution.Width - Width, resolution.Height - Height - taskbarHeight);
			Location = location;
		}

        /// <summary>
        /// Tray icon and menu functionality
        /// </summary>
        #region Tray Menu

        private void DismissEnabled(bool enabled)
        {
            trayMenu.MenuItems[2].Enabled = enabled;
            trayMenu.MenuItems[3].Enabled = enabled;
        }

        public void SearchEnabled(bool enabled)
        {
            trayMenu.MenuItems[0].Enabled = enabled;
            if (enabled)
            {
                trayMenu.MenuItems[0].Text = "Search for reminders";
            }
            else
            {
                trayMenu.MenuItems[0].Text = "Search for reminders (Searching)";
            }
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowSettings();
            MessageHandler.RepositionMessages(Height + 5);
        }

        private void MenuDismissAllMessages(object sender, EventArgs e)
        {
            MessageHandler.DismissAllMessages();
        }

        private void MenuRescheduleAllMessages(object sender, EventArgs e)
        {
            MessageHandler.RescheduleAllMessages();
        }

        private void MenuSearchReminders(object sender, EventArgs e)
        {
            messageReciever.Recieve();
        }

        private void MenuOpenSettings(object sender, EventArgs e)
        {
            ShowSettings();
            MessageHandler.RepositionMessages(Height + 5);
        }

        private void MenuExit(object sender, EventArgs e)
        {
			Close();
        }

        #endregion Tray Menu

        /// <summary>
        /// Settings dialog elements
        /// </summary>
        #region Settings Dialog Elements

        private void Settings_Load(object sender, EventArgs e)
        {
            // Create temporary cancel button
            // for handling escape key press
            Button CloseButton = new Button();
            CloseButton.Click += new EventHandler(this.ButtonClose_Click);

            // Set application settings
            LoadProperties();
            messageReciever = new MessageReciever(new ReminderClient(apiUrl, apiUsername, apiPassword), apiIdentifier);
            AcceptButton = ButtonSave;
            CancelButton = CloseButton;
            ShowInTaskbar = false;
            TopMost = true;

            // Set window location
            ShowSettings();

            // Create tray menu
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Search for reminders", MenuSearchReminders);
            trayMenu.MenuItems.Add("-");
            trayMenu.MenuItems.Add("Dismiss all reminders", MenuDismissAllMessages);
            trayMenu.MenuItems.Add("Reschedule all reminders", MenuRescheduleAllMessages);
            trayMenu.MenuItems.Add("-");
            trayMenu.MenuItems.Add("Open Settings", MenuOpenSettings);
            trayMenu.MenuItems.Add("-");
            trayMenu.MenuItems.Add("Close Application", MenuExit);
            TrayIcon.ContextMenu = trayMenu;
            MessageHandler.NotifyIcon = TrayIcon;

            // Start timer
            TimerRecive.Start();

            // Hide application when api is usable
            // and search for messages
            if (apiIdentifier != String.Empty)
            {
                Visible = false;
                DismissEnabled(true);
                messageReciever.Recieve();
            }
            else
            {
                DismissEnabled(false);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
			Visible = false;
            MessageHandler.RepositionMessages();
        }

		private void ButtonClose_HoverEnter(object sender, EventArgs e)
        {
			ButtonClose.BackgroundImage = Properties.Resources.closeActive;
		}

		private void ButtonClose_HoverLeave(object sender, EventArgs e)
        {
			ButtonClose.BackgroundImage = Properties.Resources.closeNormal;
		}

		private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveProperties();

            if (apiIdentifier != String.Empty)
            {
                DismissEnabled(true);
            }
            else
            {
                DismissEnabled(false);
            }

            MessageHandler.RepositionMessages();

            Visible = false;
            TrayIcon.BalloonTipTitle = "Reminder";
            TrayIcon.BalloonTipText = "Settings saved";
            TrayIcon.BalloonTipIcon = ToolTipIcon.Info;
            TrayIcon.ShowBalloonTip(5);
        }

        private void TimerReciveMessages_Tick(object sender, EventArgs e)
        {
            messageReciever.Recieve();
        }

        private void TimerReschedule_Tick(object sender, EventArgs e)
        {
            //@TODO
        }

        #endregion Settings Dialog Elements

        /// <summary>
        /// Loading and saving of Settings properties
        /// </summary>
        #region Properties

        private void LoadProperties()
        {
            // System
            taskbarHeight = Properties.Settings.Default.TaskbarHeight;

            // API
            apiUrl = Properties.Settings.Default.ApiUrl;
            TextApiUrl.Text = apiUrl;

            apiUsername = Properties.Settings.Default.ApiUsername;
            TextApiUsername.Text = apiUsername;

            apiPassword = Properties.Settings.Default.ApiPassword;
            TextApiPassword.Text = apiPassword;

            apiIdentifier = Properties.Settings.Default.ClientIdentifier;
            TextClientIdentifier.Text = apiIdentifier;

            // Update Rate
            TimeSpan updateRate = Properties.Settings.Default.UpdateRate;
            TimerRecive.Interval = (int)updateRate.TotalMilliseconds;
            NumUpdateHours.Value = updateRate.Hours;
            NumUpdateMinutes.Value = updateRate.Minutes;
            NumUpdateSeconds.Value = updateRate.Seconds;

            // Reschedule Rate
            TimeSpan rescheduleRate = Properties.Settings.Default.RescheduleRate;
            TimerReschedule.Interval = (int)rescheduleRate.TotalMilliseconds;
            NumRescheduleHours.Value = rescheduleRate.Hours;
            NumRescheduleMinutes.Value = rescheduleRate.Minutes;
            NumRescheduleSeconds.Value = rescheduleRate.Seconds;
        }

        private void SaveProperties()
        {
            // System
            //Properties.Settings.Default.TaskbarHeight = taskbarHeight;

            // API
            Properties.Settings.Default.ApiUrl = TextApiUrl.Text;
            apiUrl = TextApiUrl.Text;

            Properties.Settings.Default.ApiUsername = TextApiUsername.Text;
            apiUsername = TextApiUsername.Text;

            Properties.Settings.Default.ApiPassword = TextApiPassword.Text;
            apiPassword = TextApiPassword.Text;

            Properties.Settings.Default.ClientIdentifier = TextClientIdentifier.Text;
            apiIdentifier = TextClientIdentifier.Text;

            // Update Rate
            TimeSpan updateRate = new TimeSpan((int)NumUpdateHours.Value, (int)NumUpdateMinutes.Value, (int)NumUpdateSeconds.Value);
            if (updateRate.TotalMinutes >= 5)
            {
                Properties.Settings.Default.UpdateRate = updateRate;
                TimerRecive.Interval = (int)updateRate.TotalMilliseconds;
            }
            else
            {
                updateRate = new TimeSpan(0, 5, 0);
                NumUpdateHours.Value = updateRate.Hours;
                NumUpdateMinutes.Value = updateRate.Minutes;
                NumUpdateSeconds.Value = updateRate.Seconds;
                Properties.Settings.Default.UpdateRate = updateRate;
                TimerRecive.Interval = (int)updateRate.TotalMilliseconds;
            }

            // Reschedule Rate
            TimeSpan rescheduleRate = new TimeSpan((int)NumRescheduleHours.Value, (int)NumRescheduleMinutes.Value, (int)NumRescheduleSeconds.Value);

            Properties.Settings.Default.RescheduleRate = rescheduleRate;
            TimerReschedule.Interval = (int)rescheduleRate.TotalMilliseconds;
            
            if (rescheduleRate.TotalMinutes >= 5)
            {
                Properties.Settings.Default.RescheduleRate = rescheduleRate;
                TimerReschedule.Interval = (int)rescheduleRate.TotalMilliseconds;
            }
            else
            {
                rescheduleRate = new TimeSpan(0, 5, 0);
                NumRescheduleHours.Value = rescheduleRate.Hours;
                NumRescheduleMinutes.Value = rescheduleRate.Minutes;
                NumRescheduleSeconds.Value = rescheduleRate.Seconds;
                Properties.Settings.Default.RescheduleRate = rescheduleRate;
                TimerReschedule.Interval = (int)rescheduleRate.TotalMilliseconds;
            }

            // Save
            messageReciever.ApiConnection = new ReminderClient(apiUrl, apiUsername, apiPassword);
            messageReciever.ApiIdentifier = apiIdentifier;
            Properties.Settings.Default.Save();
        }

        #endregion Properties
    }
}
