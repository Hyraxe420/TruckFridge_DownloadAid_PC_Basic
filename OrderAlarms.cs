using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigdeDownloadAidV3
{
    internal class OrderAlarms
    {
        public static string String_Date_Time_convertion(string date_time_sequecne)
        { /*
             This function takes the date_time_sequence from the AlarmLog and creates a more readable format.
            */
            string date_time = "";
            string date = "";
            string time = "";

            if (date_time_sequecne[2] == '0')
            {
                date = $"20{date_time_sequecne[0]}{date_time_sequecne[1]}/{date_time_sequecne[3]}/{date_time_sequecne[4]}{date_time_sequecne[5]}";
            }
            else
            {
                date = $"20{date_time_sequecne[0]}{date_time_sequecne[1]}/{date_time_sequecne[2]}{date_time_sequecne[3]}/{date_time_sequecne[4]}{date_time_sequecne[5]}";
            }


            if (date_time_sequecne[8] == '0' && date_time_sequecne[6] == '0')
            {
                time = $"{date_time_sequecne[7]}:{date_time_sequecne[9]}:{date_time_sequecne[10]}{date_time_sequecne[11]}";
            }
            else if (date_time_sequecne[6] == '0')
            {
                time = $"{date_time_sequecne[7]}:{date_time_sequecne[8]}{date_time_sequecne[9]}:{date_time_sequecne[10]}{date_time_sequecne[11]}";
            }
            else if (date_time_sequecne[8] == '0')
            {
                time = $"{date_time_sequecne[6]}{date_time_sequecne[7]}:{date_time_sequecne[9]}:{date_time_sequecne[10]}{date_time_sequecne[11]}";
            }
            else
            {
                time = $"{date_time_sequecne[6]}{date_time_sequecne[7]}:{date_time_sequecne[8]}{date_time_sequecne[9]}:{date_time_sequecne[10]}{date_time_sequecne[11]}";
            }

            date_time = $"{date} {time}";
            return date_time;
        }

        public static void Date_time_Dictonary_creation(List<string> content_list)
        {   /*
             This funtion will filter out all the unnessary Events from the EventLog data.
            */
            content_list.RemoveAt(0);

            foreach (string line in content_list)
            {
                string[] alarms = line.Split(',');

                var date_time = String_Date_Time_convertion(alarms[0]);
                if (Valid_Error_code_check(alarms[1]))
                {
                    DateTime date = DateTime_Convertion(date_time);
                    AlarmLogDictionary.addToDictionary(date, alarms[1]);
                }
            }
        }

        public static DateTime DateTime_Convertion(string date_time)
        {
            DateTime date = DateTime.Parse(date_time);
            return date;
        }

        public static bool Valid_Error_code_check(string error_code)
        {   /* This funtion filters out all the Alarm code's that are blank/unnessary 
            */
            if (error_code == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
