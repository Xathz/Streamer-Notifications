using System;
using System.IO;
using System.Windows.Forms;
using StreamerNotifications.Settings;

namespace StreamerNotifications {

    static class Program {

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Directory.CreateDirectory(Constants.WorkingDirectory);
            Directory.CreateDirectory(Constants.LogDirectory);

            LoggingManager.Initialize();
            SettingsManager.Load();

            if (SettingsManager.Configuration.FirstRun) {
                SetupForm setupForm = new SetupForm();
                setupForm.ShowDialog();

                SettingsManager.Configuration.FirstRun = false;
                SettingsManager.Save();

                LoggingManager.Log.Info("First run setup complete.");
            }

            Application.Run(new MainForm());
        }

    }

}
