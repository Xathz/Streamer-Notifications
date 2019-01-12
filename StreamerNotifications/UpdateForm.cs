using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace StreamerNotifications {

    public partial class UpdateForm : Form {

        private WebClient _WebClient = new WebClient();
        private UpdateFile _UpdateFile;

        // Comparison will fail without this being nested
        private Version _LocalVersion = Version.Parse(Version.Parse(Application.ProductVersion).ToString(3));
        private Version _UpdateVersion;

        public UpdateForm(bool checkForUpdate) {
            InitializeComponent();
            Icon = Properties.Resources.StreamerNotifications_Icon;

            _WebClient.Headers.Add(HttpRequestHeader.UserAgent, Constants.UserAgent);
            if (checkForUpdate) { CheckForUpdate(); }
        }

        public void CheckForUpdate(string updateUrl = Constants.UpdateUrl) {
            try {
                string updateJSON = _WebClient.DownloadString(updateUrl);

                using (StringReader jsonFile = new StringReader(updateJSON)) {
                    JsonSerializer jsonSerializer = new JsonSerializer {
                        DateTimeZoneHandling = DateTimeZoneHandling.Local
                    };

                    _UpdateFile = (UpdateFile)jsonSerializer.Deserialize(jsonFile, typeof(UpdateFile));
                }
                if (_UpdateFile == null) { throw new NullReferenceException("_UpdateFile is null."); }

                _UpdateVersion = Version.Parse(_UpdateFile.CurrentVersion.ToString(3));

                int result = _LocalVersion.CompareTo(_UpdateVersion);
                if (result > 0) { // Current version is greater
                    Dispose();

                } else if (result < 0) { // Update version is greater
                    LoggingManager.Log.Info($"There is an update available: {_UpdateFile.ToString()}");
                    UpdateAvailable();

                } else { // Versions are equal
                    Dispose();

                }

            } catch (Exception ex) {
                LoggingManager.Log.Error(ex);
                Dispose();
            }
        }

        private void UpdateForm_Load(object sender, EventArgs e) { }

        private void CloseButton_Click(object sender, EventArgs e) => Dispose();

        private void WebpageUrlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start(WebpageUrlLinkLabel.Text);

        private void FileUrlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start(FileUrlLinkLabel.Text);

        private void UpdateAvailable() {
            LocalVersionLabel.Text = _LocalVersion.ToString(3);
            UpdateVersionLabel.Text = _UpdateVersion.ToString(3);
            DescriptionTextBox.Text = _UpdateFile.Description;
            ChangesTextBox.Text = string.Join(Environment.NewLine, _UpdateFile.Changes);
            WebpageUrlLinkLabel.Text = _UpdateFile.WebpageUrl;
            FileUrlLinkLabel.Text = _UpdateFile.FileUrl;

            Show();
        }

        private void GenerateUpdateTemplate() {
            UpdateFile updateTemplate = new UpdateFile {
                // Remove the 'revision', 'majorRevision', and 'minorRevision' from the version before using the json output
                CurrentVersion = new Version(1, 2, 3, 4),
                Released = DateTime.Now,
                Required = false,
                Description = "Stuff goes here.",
                Changes = new List<string>() { "Item 1", "Item 2", "Item 3" },
                WebpageUrl = "https://example.com/directory/updateinfo",
                FileUrl = "https://example.com/directory/files/file.zip"
            };

            // ================

            StringBuilder updateJSON = new StringBuilder();

            using (StringWriter streamWriter = new StringWriter(updateJSON))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter)) {
                DefaultContractResolver contractResolver = new DefaultContractResolver {
                    NamingStrategy = new CamelCaseNamingStrategy()
                };

                JsonSerializer jsonSerializer = new JsonSerializer() {
                    ContractResolver = contractResolver,
                    DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                    NullValueHandling = NullValueHandling.Include,
                    Formatting = Formatting.Indented
                };

                jsonSerializer.Serialize(jsonWriter, updateTemplate, typeof(UpdateFile));
            }

            Console.WriteLine(updateJSON.ToString());
        }

        public class UpdateFile {

            public Version CurrentVersion { get; set; }

            public DateTime Released { get; set; }

            public bool Required { get; set; }

            public string Description { get; set; }

            public List<string> Changes { get; set; } = new List<string>();

            public string WebpageUrl { get; set; }

            public string FileUrl { get; set; }

            public override string ToString() => $"v{CurrentVersion.ToString(3)}; {Released}; {Description}; {string.Join(", ", Changes)}; {WebpageUrl}";

        }

    }

}
