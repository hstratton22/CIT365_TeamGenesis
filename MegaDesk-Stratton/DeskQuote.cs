using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Stratton
{/// <summary>
/// DeskQuote class including constructors
/// get; set;
/// and calculation methods
/// </summary>
    public class DeskQuote
    {
        private string custName;
        private int rush;
        private int[,] rushShipping;
        private int quote;
        private const int BaseCost = 200;
        private const int PerDrawer = 50;
        private const int OversizeSurface = 1;
        private const int OversizeLowNum = 1000;
        private const int OversizeHighNum = 2000;
        private DateTime date ;// = DateTime.Now;
        private Desk Desk;//readonly

        public DeskQuote()
        {
        }
        public DeskQuote(Desk desk) {
            this.Desk = desk;
        }
        public DeskQuote( Desk desk, DeskQuote newDeskQuote)//Desk desk
        {
            
    }
        
        public string GetCustName() { return this.custName; }
        public void SetCustName(string name) { custName = name; }
        public void SetDate(DateTime date)
        {
            this.date = date;
        }
        public DateTime GetDate() { return date; }//.ToString("dd MMMM yyyy");

        public int GetRush() { return rush; }
        public void SetRush(int rushNum) {  rush= rushNum; }
       public void SetDesk(Desk desk) { Desk = desk; }
        public Desk GetDesk() { return Desk; }

        public int GetQuote() { return quote; }
        public void setQuote() { quote = AreaTotalCost() + CalcDrawerCost() + CalcRushCost() + CalcSurfaceCost();
         
        }
        /// <summary>
        /// w*d of Desk, and calculates cost
        /// </summary>
        /// <returns></returns>
        public int AreaTotalCost()
        {
            int oversizedArea = 0;
            if (Desk.GetArea() > OversizeLowNum)
            {
                oversizedArea = Desk.GetArea() - OversizeLowNum;
            }
                return BaseCost + (OversizeSurface * oversizedArea);
            
        }/// <summary>
        /// calculates total cost of drawers
        /// </summary>
        /// <returns></returns>
        public int CalcDrawerCost()
        {
            return PerDrawer * Desk.GetDrawerCount();
        }/// <summary>
        /// calculates total cost of rush order 
        /// </summary>
        /// <returns></returns>
        public int CalcRushCost() { 
            int result = 0;
            GetRushOrder();
            switch(rush)
            { case 3:
                    if (Desk.GetArea() < OversizeLowNum) result = rushShipping[0,0];
                    else if (Desk.GetArea() > OversizeLowNum && Desk.GetArea() < OversizeHighNum) result = rushShipping[0, 1];
                    else result = rushShipping[0, 2];
                    break;
                case 5:
                    if (Desk.GetArea() < OversizeLowNum) result = rushShipping[1, 0];
                    else if (Desk.GetArea() > OversizeLowNum && Desk.GetArea() < OversizeHighNum) result = rushShipping[1, 1];
                    else result = rushShipping[1, 2];
                    break;
                case 7:
                    if (Desk.GetArea() < OversizeLowNum) result = rushShipping[2, 0];
                    else if (Desk.GetArea() > OversizeLowNum && Desk.GetArea() < OversizeHighNum) result = rushShipping[2, 1];
                    else result = rushShipping[2, 2];
                    break;
                 default: 
                    result = 0;
                    break;

            }
            return result;
        }/// <summary>
        /// calculates surface cost using enum DesktopMaterial
        /// </summary>
        /// <returns></returns>
        public int CalcSurfaceCost()
        {
            int result = 0; 
            switch (Desk.GetDesktopMaterial()) 
            { 
                case DesktopMaterial.laminate: result = 100; break; 
                case DesktopMaterial.oak: result = 200; break; 
                case DesktopMaterial.pine: result = 50; break; 
                case DesktopMaterial.rosewood: result = 300; break; 
                case DesktopMaterial.veneer: result = 125; break;
        } return result;
            
            
}/// <summary>
/// calculates surface cost using string from combobox
/// </summary>
/// <param name="selectedSurface"></param>
/// <returns></returns>
        public int CalcSurfaceCost(string selectedSurface)
        {
            int result = 0;
            switch (selectedSurface)
            {
                case "laminate": result = 100; break;
                case "oak": result = 200; break;
                case "pine": result = 50; break;
                case "rosewood": result = 300; break;
                case "veneer": result = 125; break;
            }
            return result;


        }
        /// <summary>
        /// override ToString() including custName for reference
        /// </summary>
        /// <returns></returns>



        public override string ToString()
        {
            return base.ToString()+"\n"+
               "name:" + GetCustName();
        }

        public int[,] GetRushOrder()
        {
            try
            {
                string[] vs = File.ReadAllLines("Resources\\rushOrderPrices.txt");
                int[] rushPrices = Array.ConvertAll(vs, item => int.Parse(item));
                rushShipping = new int[3, 3];
                int index = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        rushShipping[i, j] = rushPrices[index];
                        index++;
                    }
                }

            }
            catch (Exception e)
            {
                //change catch to something more appropriate
                MessageBox.Show("File Could Not be Found" + e);
            }

            return rushShipping;
        }
    }

    
}
