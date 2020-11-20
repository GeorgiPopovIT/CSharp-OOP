
using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using System;

namespace Logger.Models.Error
{
    public class Error : IError
    {
        public Error(DateTime dateTime,string message, Level level)
        {
            DateTime = dateTime;
            Message = message;
            Level = level;
        }
        public DateTime DateTime { get; }

        public string Message { get; }

        public Level Level { get; }
    }
}
