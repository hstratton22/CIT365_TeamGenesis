﻿using System;
using System.Windows.Forms;

namespace MegaDesk_Stratton
{/// <summary>
/// by Heather Stratton
/// </summary>
    public partial class MainMenu : Form
    {
        
        public static Globals _globals;
        public MainMenu()
        {
           InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// opens AddQuote form
        /// sends empty _newDesk and _newQuote for filling and processing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewQuotesBtn_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            this.Hide();
        }
        /// <summary>
        /// opens ViewAllQuotes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewQuotesBtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewViewAllQuotes = new ViewAllQuotes();
            viewViewAllQuotes.Tag = this;
            viewViewAllQuotes.Show(this);
            this.Hide();
        }
        /// <summary>
        /// opens SearchQuotes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchQuotesBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes();
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show(this);
            this.Hide();
        }
        /// <summary>
        /// exits application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();//this.Close();
        }
    }
}
