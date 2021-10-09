using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Stratton
{/// <summary>
/// DisplayQuote form including constructor and methods to display _deskQuote to user
/// </summary>
    public partial class DisplayQuote : Form

    {
        private DeskQuote _deskQuote;
        
        /// <summary>
        /// receives Deskquote from AddQuote
        /// </summary>
        /// <param name="dq"></param>

        public DisplayQuote(DeskQuote dq)
        {
            _deskQuote = dq;
            
            InitializeComponent();
        }

        private void displayClose_Click(object sender, EventArgs e)
        {
            //why not working?
            // MainMenu viewMainMenu = (MainMenu)Tag;
            // viewMainMenu.Tag = this;
            // viewMainMenu.Show();
            // this.Close();

            //MainMenu viewMainMenu = (MainMenu)Tag;
            //viewMainMenu.Show();
            //this.Close();
            
            
        }
        /// <summary>
        /// closes the quote form box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayQuoteMenuBtn_Click(object sender, EventArgs e)
        {
            
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            this.Hide();

        }
        /// <summary>
         /// replaces with DisplayQuote_Load
         /// </summary>
        private void setValues()
        {

        }/// <summary>
        /// loads all the data from _deskQuote and assigns to labels for user view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            displayCustNameBox.Text =  _deskQuote.CustomerName;
            displayQuoteDrawerCntBox.Text = _deskQuote.Desk.DrawerCount.ToString();
            displayQuoteRushBox.Text = _deskQuote.RushDays.ToString();
            displayQuoteRushCostBox.Text = _deskQuote.CalcRushCost().ToString();
            displayQuoteWidthBox.Text = _deskQuote.Desk.Width.ToString();
            displayQuoteDepthBox.Text = _deskQuote.Desk.Depth.ToString();
            displayQuoteAreaBox.Text = _deskQuote.Desk.Area.ToString();
            displayQuoteAreaCostBox.Text = _deskQuote.AreaTotalCost().ToString();
            displayQuoteDateBox.Text = _deskQuote.Date.ToString("MMM dd, yyyy");
            displayQuoteDrawerCostBox.Text = _deskQuote.CalcDrawerCost().ToString();
            displayQuoteMatBox.Text = _deskQuote.Desk.GetDesktopMaterial().ToString();
            displayQuoteMatCostBox.Text = _deskQuote.CalcSurfaceCost().ToString();
            displayQuoteTotalCostBox.Text = _deskQuote.Cost.ToString();

        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MainMenu viewMainMenu = new MainMenu();
            //viewMainMenu.Tag = this;
            //viewMainMenu.Show(this);
            //this.Close();
            
        }

        
    }
}
