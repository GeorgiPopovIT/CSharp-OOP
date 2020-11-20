using Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logger.Models.PathManagment
{
    public class PathManager : IPathManager
    {
        private const string PATH_DELIMITER = "\\";


        private readonly string currentPath;
        private readonly string folderName;
        private readonly string fileName;
        private PathManager()
        {
            this.currentPath = this.GetCurrentPath();
        }
        public PathManager(string folderName, string fileName)
            : this()
        {
            this.folderName = folderName;
            this.fileName = fileName;
        }
        public string CurrDirectoryPath => this.currentPath + PATH_DELIMITER + this.folderName;

        public string CurrFilePath => this.CurrDirectoryPath + PATH_DELIMITER + this.fileName;

        public void EnsureDirectoryAndFileExists()
        {
            if (!Directory.Exists(CurrDirectoryPath))
            {
                Directory.CreateDirectory(CurrDirectoryPath);
            }
            File.AppendAllText(this.CurrFilePath, String.Empty);
        }

        public string GetCurrentPath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}
