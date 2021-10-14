using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_Stratton
{
    public partial class SearchQuotes : Form
    {
        //Variables needed - String with Json info and the desktopMaterial type to search by
        private string JsonQuotes = @"Data\quotes.json";
        private static DesktopMaterial material;

        public SearchQuotes()
        {
            InitializeComponent();
            //populate dropdownlist with enum values
            searchMaterialsComboBox.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        /// <summary>
        /// Returns to the main menu on close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchQuotesClose_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        /// <summary>
        /// grabs the user selected material name from the drop down menu then passes that to FindQuotes()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchMaterialsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            material = (DesktopMaterial)searchMaterialsComboBox.SelectedItem;
            FindQuotes(material);
        }

        /// <summary>
        /// Reads the Json file, deserializes it, and holds it in a new list.  That list in then searched through
        /// for the desktop material name that was passed in. The resulting rows are dispalyed in a datagrid Object
        /// </summary>
        /// <param name="material"></param>
        
        private void FindQuotes(DesktopMaterial material)
        {
            try
            {
                var jsonData = File.ReadAllText(JsonQuotes);
                var searchData = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData);
                List<DeskQuote> searchResults = searchData.FindAll(FindMaterial);
                searchGrid.DataSource = searchResults;
                searchGrid.AutoResizeColumns();
                searchGrid.RowHeadersVisible = false;
                searchGrid.BackgroundColor = Color.AntiqueWhite;
                searchGrid.GridColor = Color.AntiqueWhite;
            } 
            catch(FileNotFoundException)
            {
                MessageBox.Show("File Not Found");
            }

        }

        /// <summary>
        /// Defines the Predicate that will search for the selected Desktop Material
        /// </summary>
        /// <param name="dk"></param>
       
        private static bool FindMaterial(DeskQuote dk)
        {
            if (dk.Desk.desktopMaterial == material)
            {
                return true;
            }else
            {
                return false;
            }
        }

        
    }
}