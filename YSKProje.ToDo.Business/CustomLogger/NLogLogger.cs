using NLog;
using YSKProje.ToDo.Business.Interfaces;

namespace YSKProje.ToDo.Business.CustomLogger
{
    public class NLogLogger : ICustomLogger
    {
        public void LogError(string message)
        {
            var logger = LogManager.GetLogger("loggerFile");
            logger.Log(LogLevel.Error, message);
        }
    }
}
