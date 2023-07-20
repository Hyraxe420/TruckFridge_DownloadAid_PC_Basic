using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigdeDownloadAidV3
{
    class events
    {
        public string date { get; set; }
        public string time { get; set; }
        public string set { get; set; }
        public string box { get; set; }
        public string coil { get; set; }
        public string Hp { get; set; }
        public string Lp { get; set; }
        public string V_AC { get; set; }
        public string V_DC { get; set; }
        public string AMPS { get; set; }
        public string Speed { get; set; }
        public string SH_set { get; set; }
        public string Suc_line { get; set; }
        public string Evap_T { get; set; }
        public string Sh { get; set; }
        public string Steps { get; set; }
        public string Hp_con { get; set; }
        public string Lp_con { get; set; }
        public string Amps_con { get; set; }
        public string Phaseflt { get; set; }
        public string Hr_D { get; set; }
        public string Hr_E { get; set; }
        public string Rev { get; set; }
        public string Hot_gas { get; set; }
        public string El_con { get; set; }
        public string Ac_timer { get; set; }
        public string LH_DI { get; set; }
        public string Run_DI { get; set; }
        public string All_ok { get; set; }
    }

    internal class EventLogDictionary
    {
        public static Dictionary<DateTime, events> EventLog = new Dictionary<DateTime, events>();

        public static Dictionary<DateTime, events> GetDictionary()
        {
            return EventLog;
        }

        public static void addToDictionary(string date, string time, DateTime date_time, string set, string box, string coil, string Hp, string Lp, string V_AC, string V_DC, string AMPS, string Speed, string SH_set, string Suc_Line, string Evap_T, string SH, string Steps, string HP_Con, string LP_Con, string Amps_con, string phaseflt, string Hrs_D, string Hrs_E, string Rev, string Hot_Gas, string Elec_Con, string Ac_Timer, string LH_DI, string Run_Di, string All_Ok)
        {
            EventLog.Add(date_time, new events { date = date, time = time, set = set, box = box, coil = coil, Hp = Hp, Lp = Lp, V_AC = V_AC, V_DC = V_DC, AMPS = AMPS, Speed = Speed, SH_set = SH_set, Suc_line = Suc_Line, Evap_T = Evap_T, Sh = SH, Steps = Steps, Hp_con = HP_Con, Lp_con = LP_Con, Amps_con = Amps_con, Phaseflt = phaseflt, Hr_D = Hrs_D, Hr_E = Hrs_E, Rev = Rev, Hot_gas = Hot_Gas, El_con = Elec_Con, Ac_timer = Ac_Timer, LH_DI = LH_DI, Run_DI = Run_Di, All_ok = All_Ok });
        }
    }
}
