using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models.Contracts
{
    public interface IPathManagment
    {
        string CurrDirectoryPath { get; }
        string CurrFilePath { get; }
        string GetCurrentPath();
        void EnsureDirectoryAndFileExists();
    }
}
