using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigdeDownloadAidV3
{
    internal class OrderEvents
    {
        public static void Order_Event_list(List<string> content_list)
        {/* Takes the info sent to it from the Read_Event funtion and processes it into a more 
              managable lit for the out put in Excel in a later funtion
            */

            content_list.RemoveAt(0);
            char[] breakpoint = { '\t' };
            string[] temp_list = { };
            int content_count = content_list.Count;
            for (int i = content_count - 20; i < content_count; i++)
            {
                temp_list = content_list[i].Split(breakpoint);

                var date_time = $"{temp_list[0]} {temp_list[1]}";
                var date = temp_list[0];
                var time = temp_list[1];
                var set = temp_list[2];
                var box = temp_list[3];
                var coil = temp_list[4];
                var Hp = temp_list[5];
                var Lp = temp_list[6];
                var V_AC = temp_list[7];
                var V_DC = temp_list[8];
                var AMPS = temp_list[9];
                var Speed = temp_list[10];
                var SH_set = temp_list[11];
                var Suc_Line = temp_list[12];
                var Evap_T = temp_list[13];
                var SH = temp_list[14];
                var Steps = temp_list[15];
                var HP_Con = temp_list[16];
                var LP_Con = temp_list[17];
                var Amps_con = temp_list[18];
                var phaseflt = temp_list[19];
                var Hrs_D = temp_list[20];
                var Hrs_E = temp_list[21];
                var Rev = temp_list[22];
                var Hot_Gas = temp_list[23];
                var Elec_Con = temp_list[24];
                var Ac_Timer = temp_list[25];
                var LH_DI = temp_list[26];
                var Run_Di = temp_list[27];
                var All_Ok = temp_list[28];

                Final_dictionary(date, time, date_time, set, box, coil, Hp, Lp, V_AC, V_DC, AMPS, Speed, SH_set, Suc_Line, Evap_T, SH, Steps, HP_Con, LP_Con, Amps_con, phaseflt, Hrs_D, Hrs_E, Rev, Hot_Gas, Elec_Con, Ac_Timer, LH_DI, Run_Di, All_Ok);
            }
            // Console.WriteLine($"EventLog Size = {Dictionary.GetDictionary().Count}");
        }
        public static void Final_dictionary(string date, string time, string date_and_time, string set, string box, string coil, string Hp, string Lp, string V_AC, string V_DC, string AMPS, string Speed, string SH_set, string Suc_Line, string Evap_T, string SH, string Steps, string HP_Con, string LP_Con, string Amps_con, string phaseflt, string Hrs_D, string Hrs_E, string Rev, string Hot_Gas, string Elec_Con, string Ac_Timer, string LH_DI, string Run_Di, string All_Ok)
        {
            /* takes the information that has been processed by the Order_list functions and finalises
             * them ito a dictionary by date and time.
             */

            DateTime date_time = Date_time_Convertion(date_and_time);
            EventLogDictionary.addToDictionary(date, time, date_time, set, box, coil, Hp, Lp, V_AC, V_DC, AMPS, Speed, SH_set, Suc_Line, Evap_T, SH, Steps, HP_Con, LP_Con, Amps_con, phaseflt, Hrs_D, Hrs_E, Rev, Hot_Gas, Elec_Con, Ac_Timer, LH_DI, Run_Di, All_Ok);
        }
        public static DateTime Date_time_Convertion(string date_time)
        {
            DateTime date = DateTime.Parse(date_time);
            return date;
        }
    }
}