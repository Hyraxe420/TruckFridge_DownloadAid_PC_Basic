using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigdeDownloadAidV3
{
    static class Program
    {   
        static void Main(string[] args)
        {
           Read_Alarm(Alarm_File_check());
           Read_Event(Event_File_check());
           ExcelCreation.create_Excel_Sheet();
        }

        static string Alarm_File_check()
        {   /* This funtion will look for the correct file path of the USB with the download on for ALARMLOG.txt
            */
            //var ATestpath = "D:/Test/Test.txt";
            //var ATestpath = "E:/Test/Test.txt";
            //var ATestpath = "F:/Test/Test.txt";
            var AlarmpathD = "D:/ipro/192.168.0.250/log/ALARMLOG.txt";
            var AlarmpathE = "E:/ipro/192.168.0.250/log/ALARMLOG.txt";
            var AlarmpathF = "F:/ipro/192.168.0.250/log/ALARMLOG.txt";

            var path = "";
            /*if (File.Exists(ATestpath))
            {
                path = ATestpath;
            }
            else*/
            if (File.Exists(AlarmpathE))
            {
                path = AlarmpathE;
            }
            else if (File.Exists(AlarmpathD))
            {
                path = AlarmpathD;
            }
            else if (File.Exists(AlarmpathF))
            {
                path = AlarmpathF;
            }
            return path;
        }

        static string Event_File_check()
        {   /* This funtion will look for the correct file path of the USB with the download on for EVENTLOG.txt
            */
             //var ETestpath = "D:/Test/EventTest.txt";
            //var ETestpath = "E:/Test/EventTest.txt";
            //var ETestpath = "F:/Test/EventTest.txt";
            var EventpathD = "D:/ipro/192.168.0.250/log/EVENTLOG.txt";
            var EventpathE = "E:/ipro/192.168.0.250/log/EVENTLOG.txt";
            var EventpathF = "F:/ipro/192.168.0.250/log/EVENTLOG.txt";

            var path = "";
            /*if (File.Exists(ETestpath))
            {
                path = ETestpath;
            }
            else*/
            if (File.Exists(EventpathD))
            {
                path = EventpathD;
            }
            else if (File.Exists(EventpathE))
            {
                path = EventpathE;
            }
            else if (File.Exists(EventpathF))
            {
                path = EventpathF;
            }
            return path;
        }

        static void Read_Alarm(String path)
        {
            /*opens and reads the Alarm txt file and stores the info as Content using the file path
            Then sends the info to the Order_Alarm_list funtion for processing
            */
            string[] content = File.ReadAllLines(path);
            var lines = new List<string> { };
            foreach (string line in content)
            {
                lines.Add(line);
            }
            OrderAlarms.Date_time_Dictonary_creation(lines);
        }

        static void Read_Event(String path)
        {
            /*opens and reads the Event txt file and stores the info as Content using the file path
            Then sends the info to the Order_Event_list funtion for processing
            */
            string[] content = File.ReadAllLines(path);
            var lines = new List<string> { };
            foreach (string line in content)
            {
                lines.Add(line);
            }
            OrderEvents.Order_Event_list(lines);
        }
    }
}
