using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Stratton
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static Globals _globals;
        //private const string JsonAllQuotesFile = @"Data\quotes.json";
        [STAThread]

        static void Main()
        {
            _globals = new Globals();
            //ReadFromJsonFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //MessageBox.Show("passing _globals to Main");
            Application.Run(new MainMenu(_globals));
           
        }
        //private static void AddQuoteToList(DeskQuote deskQuote)
        //{
        //    _globals.AllQuotes.Add(deskQuote);
        //    SaveToJsonFile();
        //}
        //private static void SaveToJsonFile()
        //{
        //    if (File.Exists(JsonAllQuotesFile))
        //    {
        //        try
        //        {
        //            var jsonData = JsonConvert.SerializeObject(_globals.AllQuotes, Formatting.Indented);
        //            File.WriteAllText(JsonAllQuotesFile, jsonData);
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error: Could not find JSON File");
        //    }
        //    return to menu ?
        //}
        //private static void ReadFromJsonFile()
        //{
        //    if (File.Exists(JsonAllQuotesFile))
        //    {
        //        try
        //        {
        //            var jsonData = File.ReadAllText(JsonAllQuotesFile);
        //            if (jsonData.Length > 0)
        //            {
        //                _globals.AllQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData);
        //            }
        //        }
        //        catch (Exception ex)
        //        { Console.WriteLine(ex);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error: Could not find JSON File.");
        //    }
        //}

    }
    }
