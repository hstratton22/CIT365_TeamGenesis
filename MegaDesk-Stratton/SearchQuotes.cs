using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Stratton
{
    public partial class SearchQuotes : Form
    {
        private string JsonQuotes = @"Data\quotes.json";
        private static DesktopMaterial material;

        public SearchQuotes()
        {
            InitializeComponent();
            //populate dropdownlist with enum values
            searchMaterialsComboBox.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        private void searchQuotesClose_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        private void searchMaterialsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            material = (DesktopMaterial)searchMaterialsComboBox.SelectedItem;
            FindQuotes(material);
        }

        private void FindQuotes(DesktopMaterial material)
        {
            
            //Error Checking Needed
            var jsonData = File.ReadAllText(JsonQuotes);
            var searchData = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData);
            List<DeskQuote> searchResults = searchData.FindAll(FindMaterial);
            searchGrid.DataSource = searchResults;
            searchGrid.AutoResizeColumns();
            searchGrid.RowHeadersVisible = false;
            searchGrid.BackgroundColor = Color.AntiqueWhite;
            searchGrid.GridColor = Color.AntiqueWhite;
        }

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
