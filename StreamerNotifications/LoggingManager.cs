using System.IO;
using NLog;
using NLog.Config;
using NLog.Targets;
using NLog.Targets.Wrappers;

namespace StreamerNotifications {

    /// <summary>
    /// Custom configuration and logging.
    /// </summary>
    public static class LoggingManager {

        /// <summary>
        /// Write a log.
        /// </summary>
        public static Logger Log = LogManager.GetLogger(Constants.ApplicationNameFormatted);

        /// <summary>
        /// Setup all the logging targets and rules. Call only once, usually at the start of the program.
        /// </summary>
        public static void Initialize() {
            Directory.CreateDirectory(Constants.LogDirectory);
            LoggingConfiguration loggingConfiguration = new LoggingConfiguration();

            // All messages from Trace to Warn levels write to the general file
            FileTarget fileTarget_General = new FileTarget() {
                Name = Constants.ApplicationNameFormatted,
                FileName = Path.Combine(Constants.LogDirectory, "General.log"),
                Layout = "${longdate} [${pad:padCharacter= :padding=5:fixedLength=true:alignmentOnTruncation=Right:${uppercase:${level}}}] [${callsite:includeNamespace=false}] ${message}",
                ArchiveFileName = Path.Combine(Constants.LogDirectory, "General{#}.Archive.log"),
                ArchiveEvery = FileArchivePeriod.Day,
                ArchiveNumbering = ArchiveNumberingMode.Rolling,
                MaxArchiveFiles = 7,
                ConcurrentWrites = false
            };
            // Limit how often the file will get written to disk.
            // Default: BufferSize = 50 (log events), FlushTimeout = 5000 (milliseconds)
            BufferingTargetWrapper fileAsyncTargetWrapper_General = new BufferingTargetWrapper {
                Name = Constants.ApplicationNameFormatted,
                WrappedTarget = fileTarget_General,
                BufferSize = 50,
                FlushTimeout = 5000,
                SlidingTimeout = false
            };
            loggingConfiguration.AddTarget(fileAsyncTargetWrapper_General);
            loggingConfiguration.AddRule(LogLevel.Trace, LogLevel.Warn, Constants.ApplicationNameFormatted);

            // All messages from Warn to Fatal levels write to the error file with advanced trace information
            FileTarget fileTarget_Error = new FileTarget() {
                Name = Constants.ApplicationNameFormatted,
                FileName = Path.Combine(Constants.LogDirectory, "Error.log"),
                Layout = "${longdate} [${pad:padCharacter= :padding=5:fixedLength=true:alignmentOnTruncation=Right:${uppercase:${level}}}] [${callsite:includeSourcePath=true}:${callsite-linenumber}; ${stacktrace}] ${message}${exception:format=ToString,StackTrace}",
                ArchiveFileName = Path.Combine(Constants.LogDirectory, "Error{#}.Archive.log"),
                ArchiveEvery = FileArchivePeriod.Day,
                ArchiveNumbering = ArchiveNumberingMode.Rolling,
                MaxArchiveFiles = 7,
                ConcurrentWrites = false
            };
            loggingConfiguration.AddTarget(fileTarget_Error);
            loggingConfiguration.AddRule(LogLevel.Error, LogLevel.Fatal, Constants.ApplicationNameFormatted);

            // Apply all the custom configurations to the LogManager
            LogManager.Configuration = loggingConfiguration;

            Log.Info("Logging initialization finished.");
        }

        /// <summary>
        /// Flush any pending log messages.
        /// </summary>
        public static void Flush() => LogManager.Flush();

    }

}
