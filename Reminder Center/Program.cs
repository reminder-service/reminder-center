using System;
using System.Windows.Forms;

namespace ReminderCenter {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            Settings settingsForm = new Settings()
            {
                Visible = false
            };
			Application.Run(settingsForm);
		}
	}
}
