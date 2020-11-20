using Logger.Contracts;
using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Logger.Models.Files
{
    public class LogFile : IFile
    {
        private readonly IPathManager pathManager;
        public LogFile(IPathManager pathManager)
        {
            this.pathManager = pathManager;
            this.pathManager.EnsureDirectoryAndFileExists();
        }
        public string Path => this.pathManager.CurrFilePath;

        public long Size => this.CalculateFileSize();

        public string Write(ILayout layout, IError error)
        {
            string format = layout.Format;

            DateTime dateTime = error.DateTime;
            string message = error.Message;
            Level level = error.Level;

            string formattedMessage = String.Format(format,
                dateTime.ToString(format: "G"), level.ToString()
                , message);

            return formattedMessage;
        }
        private long CalculateFileSize()
        {
            string fileText = File.ReadAllText(Path);

            return fileText.ToCharArray().Sum(c => c);
        }
    }
}
