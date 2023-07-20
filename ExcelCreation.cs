using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GemBox.Spreadsheet;

namespace FrigdeDownloadAidV3
{ 
    internal class ExcelCreation
    {
        public static void create_Excel_Sheet()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile workbook = new ExcelFile();
            ExcelWorksheet worksheet = workbook.Worksheets.Add("Sheet1");

            Dictionary<DateTime,string> Errors = AlarmLogDictionary.GetDictionary();

            int ErrorCount = Errors.Count()+1;
            int Row = 1;

            for (int i = ErrorCount - 5; i < ErrorCount; i++)
            {
                ExcelCell ErrorCell = worksheet.Cells[$"A{Row}"];
                ExcelCell ErrorTimeCell = worksheet.Cells[$"B{Row}"];
                ExcelCell ErrorCodeCell = worksheet.Cells[$"C{Row}"];

                DateTime errorKey = AlarmLogDictionary.GetKeyAtInt(i);
                string errorValue = AlarmLogDictionary.GetValueAtInt(i);

                ErrorCell.Value = "Error Code: ";
                ErrorCodeCell.Value = errorKey;
                ErrorTimeCell.Value = errorValue;
                Row++;
            }

            ExcelCell cellA = worksheet.Cells["A6"];
            ExcelCell cellB = worksheet.Cells["B6"];
            ExcelCell cellC = worksheet.Cells["C6"];
            ExcelCell cellD = worksheet.Cells["D6"];
            ExcelCell cellE = worksheet.Cells["E6"];
            ExcelCell cellF = worksheet.Cells["F6"];
            ExcelCell cellG = worksheet.Cells["G6"];
            ExcelCell cellH = worksheet.Cells["H6"];
            ExcelCell cellI = worksheet.Cells["I6"];
            ExcelCell cellJ = worksheet.Cells["J6"];
            ExcelCell cellK = worksheet.Cells["K6"];
            ExcelCell cellL = worksheet.Cells["L6"];
            ExcelCell cellM = worksheet.Cells["M6"];
            ExcelCell cellN = worksheet.Cells["N6"];
            ExcelCell cellO = worksheet.Cells["O6"];
            ExcelCell cellP = worksheet.Cells["P6"];
            ExcelCell cellQ = worksheet.Cells["Q6"];
            ExcelCell cellR = worksheet.Cells["R6"];
            ExcelCell cellS = worksheet.Cells["S6"];
            ExcelCell cellT = worksheet.Cells["T6"];
            ExcelCell cellU = worksheet.Cells["U6"];
            ExcelCell cellV = worksheet.Cells["V6"];
            ExcelCell cellW = worksheet.Cells["W6"];
            ExcelCell cellY = worksheet.Cells["Y6"];
            ExcelCell cellX = worksheet.Cells["X6"];
            ExcelCell cellZ = worksheet.Cells["Z6"];
            ExcelCell cellAA = worksheet.Cells["AA6"];
            ExcelCell cellAB = worksheet.Cells["AB6"];
            ExcelCell cellAC = worksheet.Cells["AC6"];

            cellA.Value = "Date";
            cellB.Value = "Time";
            cellC.Value = "Set";
            cellD.Value = "Box";
            cellE.Value = "Coil";
            cellF.Value = "HP";
            cellG.Value = "LP";
            cellH.Value = "V AC";
            cellI.Value = "V DC";
            cellJ.Value = "AMPS";
            cellK.Value = "SPEED";
            cellL.Value = "SH SET";
            cellM.Value = "SUC LINE";
            cellN.Value = "EVAP T";
            cellO.Value = "SH";
            cellP.Value = "STEPS";
            cellQ.Value = "HP CON";
            cellR.Value = "LP CON";
            cellS.Value = "AMPS CON";
            cellT.Value = "PHASEFLT";
            cellU.Value = "HRS D";
            cellV.Value = "HRS E";
            cellW.Value = "REV";
            cellY.Value = "HOTGAS";
            cellX.Value = "ELEC CON";
            cellZ.Value = "AC TIMER";
            cellAA.Value = "LH DI";
            cellAB.Value = "RUN DI";
            cellAC.Value = "ALL OK";

            cellA.Style.Font.Weight = ExcelFont.BoldWeight;
            cellB.Style.Font.Weight = ExcelFont.BoldWeight;
            cellC.Style.Font.Weight = ExcelFont.BoldWeight;
            cellD.Style.Font.Weight = ExcelFont.BoldWeight;
            cellE.Style.Font.Weight = ExcelFont.BoldWeight;
            cellF.Style.Font.Weight = ExcelFont.BoldWeight;
            cellG.Style.Font.Weight = ExcelFont.BoldWeight;
            cellH.Style.Font.Weight = ExcelFont.BoldWeight;
            cellI.Style.Font.Weight = ExcelFont.BoldWeight;
            cellJ.Style.Font.Weight = ExcelFont.BoldWeight;
            cellK.Style.Font.Weight = ExcelFont.BoldWeight;
            cellL.Style.Font.Weight = ExcelFont.BoldWeight;
            cellM.Style.Font.Weight = ExcelFont.BoldWeight;
            cellN.Style.Font.Weight = ExcelFont.BoldWeight;
            cellO.Style.Font.Weight = ExcelFont.BoldWeight;
            cellP.Style.Font.Weight = ExcelFont.BoldWeight;
            cellQ.Style.Font.Weight = ExcelFont.BoldWeight;
            cellR.Style.Font.Weight = ExcelFont.BoldWeight;
            cellS.Style.Font.Weight = ExcelFont.BoldWeight;
            cellT.Style.Font.Weight = ExcelFont.BoldWeight;
            cellU.Style.Font.Weight = ExcelFont.BoldWeight;
            cellV.Style.Font.Weight = ExcelFont.BoldWeight;
            cellW.Style.Font.Weight = ExcelFont.BoldWeight;
            cellY.Style.Font.Weight = ExcelFont.BoldWeight;
            cellX.Style.Font.Weight = ExcelFont.BoldWeight;
            cellZ.Style.Font.Weight = ExcelFont.BoldWeight;
            cellAA.Style.Font.Weight = ExcelFont.BoldWeight;
            cellAB.Style.Font.Weight = ExcelFont.BoldWeight;
            cellAC.Style.Font.Weight = ExcelFont.BoldWeight;

            add_content(worksheet);

            string file_name = get_file_save_name();
            string user = get_user_save_path();

            // Console.WriteLine($"Rows: {Row_counter}");
            workbook.Save($"C:/Users/{user}/Desktop/{file_name}.xlsx");
        }

        public static string get_file_save_name()
        {
            Console.WriteLine("What would you like to save the file as : ");
            string file_name = Console.ReadLine();
            return file_name;

        }
        
        public static string get_user_save_path()
        {
            Console.WriteLine("Example : C:\\Users\\James\\Desktop");
            Console.WriteLine("                     /\\");
            Console.WriteLine("                    /  \\");
            Console.WriteLine("                     ||");
            Console.WriteLine("                     ||");
            Console.WriteLine("Check your username using file explorer, it will look sorta like this in the file path.");
            Console.WriteLine("Device User name: ");
            string file_path_name = Console.ReadLine();
            return file_path_name;
        }

        public static void add_content(ExcelWorksheet sheet)
        {
            Dictionary<DateTime, events> dic = EventLogDictionary.GetDictionary();

            int cell_counter = 7;

            foreach (var line in dic.Keys)
            {
                ExcelCell cellA = sheet.Cells[$"A{cell_counter}"];
                ExcelCell cellB = sheet.Cells[$"B{cell_counter}"];
                ExcelCell cellC = sheet.Cells[$"C{cell_counter}"];
                ExcelCell cellD = sheet.Cells[$"D{cell_counter}"];
                ExcelCell cellE = sheet.Cells[$"E{cell_counter}"];
                ExcelCell cellF = sheet.Cells[$"F{cell_counter}"];
                ExcelCell cellG = sheet.Cells[$"G{cell_counter}"];
                ExcelCell cellH = sheet.Cells[$"H{cell_counter}"];
                ExcelCell cellI = sheet.Cells[$"I{cell_counter}"];
                ExcelCell cellJ = sheet.Cells[$"J{cell_counter}"];
                ExcelCell cellK = sheet.Cells[$"K{cell_counter}"];
                ExcelCell cellL = sheet.Cells[$"L{cell_counter}"];
                ExcelCell cellM = sheet.Cells[$"M{cell_counter}"];
                ExcelCell cellN = sheet.Cells[$"N{cell_counter}"];
                ExcelCell cellO = sheet.Cells[$"O{cell_counter}"];
                ExcelCell cellP = sheet.Cells[$"P{cell_counter}"];
                ExcelCell cellQ = sheet.Cells[$"Q{cell_counter}"];
                ExcelCell cellR = sheet.Cells[$"R{cell_counter}"];
                ExcelCell cellS = sheet.Cells[$"S{cell_counter}"];
                ExcelCell cellT = sheet.Cells[$"T{cell_counter}"];
                ExcelCell cellU = sheet.Cells[$"U{cell_counter}"];
                ExcelCell cellV = sheet.Cells[$"V{cell_counter}"];
                ExcelCell cellW = sheet.Cells[$"W{cell_counter}"];
                ExcelCell cellY = sheet.Cells[$"Y{cell_counter}"];
                ExcelCell cellX = sheet.Cells[$"X{cell_counter}"];
                ExcelCell cellZ = sheet.Cells[$"Z{cell_counter}"];
                ExcelCell cellAA = sheet.Cells[$"AA{cell_counter}"];
                ExcelCell cellAB = sheet.Cells[$"AB{cell_counter}"];
                ExcelCell cellAC = sheet.Cells[$"AC{cell_counter}"];

                cellA.Value = dic[line].date;
                cellB.Value = dic[line].time;
                cellC.Value = dic[line].set;
                cellD.Value = dic[line].box;
                cellD.Style.Font.Color = SpreadsheetColor.FromName(ColorName.Red);
                cellE.Value = dic[line].coil;
                cellE.Style.Font.Color = SpreadsheetColor.FromName(ColorName.Blue);
                cellF.Value = dic[line].Hp;
                cellG.Value = dic[line].Lp;
                cellH.Value = dic[line].V_AC;
                cellI.Value = dic[line].V_DC;
                cellJ.Value = dic[line].AMPS;
                cellK.Value = dic[line].Speed;
                cellL.Value = dic[line].SH_set;
                cellM.Value = dic[line].Suc_line;
                cellN.Value = dic[line].Evap_T;
                cellO.Value = dic[line].Sh;
                cellP.Value = dic[line].Steps;
                cellQ.Value = dic[line].Hp_con;
                cellR.Value = dic[line].Lp_con;
                cellS.Value = dic[line].Amps_con;
                cellT.Value = dic[line].Phaseflt;
                cellU.Value = dic[line].Hr_D;
                cellV.Value = dic[line].Hr_E;
                cellW.Value = dic[line].Rev;
                cellY.Value = dic[line].Hot_gas;
                cellX.Value = dic[line].El_con;
                cellZ.Value = dic[line].Ac_timer;
                cellAA.Value = dic[line].LH_DI;
                cellAB.Value = dic[line].Run_DI;
                cellAC.Value = dic[line].All_ok;

                cell_counter++;
            }

        }
    }
}
