using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;

namespace MegaDesk_Stratton
{
    /// <summary>
    /// ViewAllQuotes Form
    /// </summary>
    public partial class ViewAllQuotes : Form
    {
        
        private const string JsonAllQuotesFile = @"Data\quotes.json";
        
        public ViewAllQuotes()
        {
           InitializeComponent();
        }
        /// <summary>
        /// close button to return to menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void allQuotesClose_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }
        /// <summary>
        /// PopulateDataGridView()
        /// checks for Json File, reads data, populates GridView, checks for errors
        /// </summary>
        
        private void PopulateDataGridView()
        {
            if (File.Exists(JsonAllQuotesFile))
            {
                try
                {
                    var jsonData = File.ReadAllText(JsonAllQuotesFile);
                    if (jsonData.Length > 0)
                    {
                        dataGridView1.DataSource = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData);
                        dataGridView1.AutoResizeColumns();
                        dataGridView1.RowHeadersVisible = false;
                        
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
        /// <summary>
        /// calls ListQuotes() on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {            
            ListQuotes();

        }
        /// <summary>
        /// calls PopulateDataGridView()
        /// </summary>
        private void ListQuotes()
        {
            PopulateDataGridView();
            
        }
        
    }
}
