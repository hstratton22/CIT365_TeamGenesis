﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_Stratton
{
    public partial class ViewAllQuotes : Form
    {
        
        private const string JsonAllQuotesFile = @"Data\quotes.json";

        public ViewAllQuotes()
        {
           InitializeComponent();
        }

        private void allQuotesClose_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        private static void ReadFromJsonFile()
        {
            if (File.Exists(JsonAllQuotesFile))
            {
                try
                {
                    var jsonData = File.ReadAllText(JsonAllQuotesFile);
                    if (jsonData.Length > 0)
                    {
                        Program._globals.AllQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                Console.WriteLine(@"Error: Could not find JSON File.");
            }
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            ReadFromJsonFile();
            ListQuotes();

        }
        private void ListQuotes()
        {
            foreach (DeskQuote deskQuote in Program._globals.AllQuotes)
            {
               // MessageBox.Show($@"- {deskQuote.CustomerName}, $ {deskQuote.Cost}");
            }
        }
    }
}
