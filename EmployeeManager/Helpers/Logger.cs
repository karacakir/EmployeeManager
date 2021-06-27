using System.IO;

namespace EmployeeManager.Helpers
{
    static class Logger
    {
        private static object locker = new object();
        public static void Log(string text)
        {
            lock (locker)
            {
                try
                {
                    File.AppendAllText("Log.txt", text);
                }
                catch
                {
                    //ignore
                }
            }
        }
    }
}
