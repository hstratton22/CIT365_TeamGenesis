using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_Stratton
{
    /// <summary>
    /// AddQuote Form including constructors and methods
    /// collect and submit input for new DeskQuote
    /// </summary>
    public partial class AddQuote : Form
    {
        
        private readonly DeskQuote _newQuote = new DeskQuote();
        private readonly Desk _newDesk = new Desk();
        //private static Globals _globals;
        private const string JsonAllQuotesFile = @"Data\quotes.json";


        public AddQuote()//Desk d, DeskQuote q, Globals globals)
        {
                                  
            InitializeComponent();
        }
        
        /// <summary>
        /// sets values to _newDesk and _newQuote from user input
        /// </summary>
        

        /// <summary>
        /// poorly named close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();

        }
        /// <summary>
        /// calls createDeskQuote() and then passes _newQuote to next form for view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitQuoteBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                CreateDeskQuote();
                AddQuoteToList();
                SaveToJsonFile();
                DisplayQuote();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            
        
        }
        private void CreateDeskQuote()
        {
            
            _newQuote.Date = DateTime.Now;
            
            _newQuote.CustomerName = custNameInput.Text;
            _newDesk.Width = int.Parse(deskWidthInput.Text);
            _newDesk.Depth = int.Parse(deskDepthInput.Text);
           // _newDesk.Area = (_newDesk.Width, _newDesk.Depth);
            _newDesk.DrawerCount = Decimal.ToInt32(drawersUpDown.Value);
            
            _newQuote.Desk= _newDesk;

            //_newQuote.Cost;


        }
        private void AddQuoteToList()
        {
            Program._globals.AllQuotes.Add(_newQuote);
            //SaveToJsonFile();
        }
        private void SaveToJsonFile()
        {
            if (File.Exists(JsonAllQuotesFile))
            {
                try
                {

                    var jsonData = JsonConvert.SerializeObject(Program._globals.AllQuotes, Formatting.Indented);
                   // MessageBox.Show(jsonData);
                    File.WriteAllText(JsonAllQuotesFile, jsonData);
                    //MessageBox.Show("Written to json to file");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                Console.WriteLine(@"Error: Could not find JSON File");
            }

        }

        private void DisplayQuote()
        {
            var viewDisplayQuote = new DisplayQuote(_newQuote);
            viewDisplayQuote.Tag = this;
            viewDisplayQuote.Show(this);
            Hide();
        }

        /// <summary>
        /// validating deskWidthInput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deskWidthInput_Validating(object sender, CancelEventArgs e)
        {

            if (deskWidthInput.Text != null && deskWidthInput.Text != string.Empty)
            {
                
                for (int ch = 0; ch < deskWidthInput.Text.Length; ch++)
                {
                    if (!Char.IsDigit(deskWidthInput.Text[ch]) && (!Char.IsControl(deskWidthInput.Text[ch])))
                    {
                        //MessageBox.Show("not digit!");
                        //can still submit although not valid....
                        e.Cancel= true;
                        deskWidthInput.Select(0, deskWidthInput.Text.Length);
                        deskWidthInput.Focus();

                        errorProvider2.SetError(deskWidthInput, "Enter valid number");
                    }
                    else
                    {
                        errorProvider2.SetError(deskWidthInput, "");//Please enter a number
                        if (!ValidWidth(deskWidthInput.Text))
                        {

                            e.Cancel = true;
                            errorProvider2.SetError(deskWidthInput, $"Width must be greater than or equal to {_newDesk.GetMinWidth()} and less than or equal to {_newDesk.GetMaxWidth()}");
                        }
                        else
                        {
                            errorProvider2.SetError(deskWidthInput, String.Empty);//"Valid");//);//this.
                        }

                        
                    }
                }
                }
            else
            {
                e.Cancel = true;
                errorProvider2.SetError(deskWidthInput, "Enter valid number");
            }
          
}/// <summary>
/// bool to check if width input is valid using method from Desk class
/// </summary>
/// <param name="widthInput"></param>
/// <returns></returns>
        public bool ValidWidth(string widthInput)
        {
            
                if (_newDesk.ValidatedWidth(int.Parse(widthInput)))
                { return true; }
                else
                { return false; }
            

         }
        /// <summary>
        /// makes sure input string isn't empty 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void custNameInput_Validating(object sender, CancelEventArgs e)
        {
            if (custNameInput.Text == string.Empty)
                
            {
                e.Cancel = true;
                errorProvider1.SetError(custNameInput, "Name is required."); }
            else
            {
                errorProvider1.SetError(custNameInput, string.Empty);
            }
        }
        /// <summary>
        /// validates depthInput from user 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deskDepthInput_Validating(object sender, CancelEventArgs e)
        {
            if(deskDepthInput.Text != null && deskDepthInput.Text != string.Empty)
            {
                if (!ValidDepth(deskDepthInput.Text))
                {
                    e.Cancel = true;
                    errorProvider3.SetError(deskDepthInput, $"Depth must be greater than or equal to {_newDesk.GetMinDepth()} and less than or equal to {_newDesk.GetMaxDepth() }");
                }
                else
                {
                    errorProvider3.SetError(deskDepthInput, string.Empty);
                }
            }
            else
            {
                e.Cancel = true;
                errorProvider3.SetError(deskDepthInput, "Enter a valid number.");
            }
        }/// <summary>
        /// bool
        /// validates depth using method from Desk
        /// </summary>
        /// <param name="depthInput"></param>
        /// <returns></returns>
        public bool ValidDepth(string depthInput)
        { if (_newDesk.ValidatedDepth(int.Parse(depthInput)))
            { return true; }
            else return false;
        }
        /*
        private bool notNumber = false;
        private void deskWidthInput_KeyDown(object sender, KeyEventArgs e)
        {
            notNumber = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if(e.KeyCode != Keys.Back)
                    {
                        notNumber = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                notNumber = true;
            }
        }
        
        private void deskWidthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (notNumber) e.Handled = true;
        }
        */
        
        private bool depthNotNumber = false;
        /// <summary>
        /// checks if input is number
        /// </summary>
        private void deskDepthInput_KeyDown(object sender, KeyEventArgs e)
        {
            depthNotNumber = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        depthNotNumber = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                depthNotNumber = true;
            }
        }
        /// <summary>
        /// depth KeyPress check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deskDepthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (depthNotNumber) e.Handled = true;
        }
        /// <summary>
        /// takes combobox input for material and passes to _newDesk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void desktopMatComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            string selectedMaterial = this.desktopMatComboBox.SelectedItem.ToString();
            _newDesk.SetDesktopMaterial(selectedMaterial.Trim());
            
        }
        /// <summary>
        /// takes combobox for rush and passes to _newQuote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rushComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedRush = this.rushComboBox.SelectedItem.ToString();
            
            try
            {
                _newQuote.RushDays = int.Parse(selectedRush.Trim());
                
            }
            catch (Exception exc) 
            {
                Debug.WriteLine(exc);
                _newQuote.RushDays = 0;
                
                }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            dateLbl.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        /* private void desktopMatComboBox_SelectedIndexChanged(object sender, EventArgs e)
         {//not set to instance of object?
             ComboBox cmb = (ComboBox)sender;
             int selectedIndex = cmb.SelectedIndex;
             int selectedValue = (int)cmb.SelectedValue;
             MessageBox.Show( selectedIndex + ", " + selectedValue);

         }*/
        //private static void AddQuoteToList(DeskQuote deskQuote) {
        //_globals.AllQuotes.Add(deskQuote);
        //SaveToJsonFile();
        //}
        //private 
    }

    
}
