using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Shapes;

namespace FrigdeDownloadAidV3
{
    internal class AlarmLogDictionary
    {
        public static Dictionary<DateTime, string> AlarmLog = new Dictionary<DateTime, string>();

        public static Dictionary<DateTime, string> GetDictionary()
        {
            return AlarmLog;
        }

        public static void addToDictionary(DateTime date, string alarm)
        {
            if (alarm != "NO FAULT")
            { 
             AlarmLog.Add(date, alarm);
            }
        }

        public static DateTime GetKeyAtInt(int i)
        {
            int alarmCount = AlarmLog.Count;
            int errorCounter = 0;
            DateTime line = DateTime.MinValue;
            foreach (var lines in AlarmLog )
            {
                errorCounter++;
                if (errorCounter == i)
                {
                    line = lines.Key;
                }
            }
            return line;
        }

        public static string GetValueAtInt(int i)
        {
            int alarmCount = AlarmLog.Count;
            int errorCounter = 0;
            string line = "";
            foreach (var lines in AlarmLog)
            {
                errorCounter++;
                if (errorCounter == i)
                {
                    line = lines.Value;
                }
            }
            return line;
        }
    }
}
