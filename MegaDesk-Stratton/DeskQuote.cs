using System;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_Stratton
{/// <summary>
/// DeskQuote class including constructors
/// get; set;
/// and calculation methods
/// </summary>
    public class DeskQuote
    {
       //private string custName;
        private int _rush;
        private int[,] rushShipping;
        //private int quote;

        private const int BaseCost = 200;
        private const int PerDrawer = 50;
        private const int OversizeSurface = 1;
        private const int OversizeLowNum = 1000;
        private const int OversizeHighNum = 2000;
        //private DateTime date;// = DateTime.Now;
        //private Desk _desk;//readonly
        //private int _cost;
        

        
        public string CustomerName { get; set; }
        //public int Rush { get; set; }
        public DateTime Date { get; set; }
        public int RushDays { get; set; }
        public Desk Desk { get; set; }
        public int Cost { 
            get
            { 
                return AreaTotalCost() + CalcDrawerCost() + CalcRushCost() + CalcSurfaceCost(); //return _cost; }
            }
             }


        /// <summary>
        /// w * d of Desk, and calculates cost
        /// </summary>
        /// <returns></returns>
        public int AreaTotalCost()
        {
            int oversizedArea = 0;
            if (Desk.Area > OversizeLowNum)
            {
                oversizedArea = Desk.Area - OversizeLowNum;
            }
            return BaseCost + (OversizeSurface * oversizedArea);

        }
        /// <summary>
         /// calculates total cost of drawers
         /// </summary>
         /// <returns></returns>
        public int CalcDrawerCost()
        {
            return PerDrawer * Desk.DrawerCount;
        }
        /// <summary>
         /// calculates total cost of rush order 
         /// </summary>
         /// <returns></returns>
        public int CalcRushCost()
        {
            int result = 0;
            _rush = RushDays;
            GetRushOrder();
            int speed;
            int weight;
            switch (_rush)
            {
                case 3:
                    speed = 0;
                    break;
                case 5:
                    speed = 1;
                    break;
                case 7:
                    speed = 2;
                    break;
                default:
                    result = 0;
                    return result;
            }

            if (Desk.Area < OversizeLowNum) weight = 0;
            else if (Desk.Area > OversizeLowNum && Desk.Area < OversizeHighNum) weight = 1;
            else weight = 2;


            result = rushShipping[speed, weight];
            return result;
        }
        /// <summary>
         /// calculates surface cost using enum DesktopMaterial
         /// </summary>
         /// <returns></returns>
        public int CalcSurfaceCost()
        {
            int result = 0;
            switch (Desk.GetDesktopMaterial())
            {
                case DesktopMaterial.Laminate: result = 100; break;
                case DesktopMaterial.Oak: result = 200; break;
                case DesktopMaterial.Pine: result = 50; break;
                case DesktopMaterial.Rosewood: result = 300; break;
                case DesktopMaterial.Veneer: result = 125; break;
            }
            return result;


        }
        /// <summary>
        /// calculates surface cost using string from combobox
        /// </summary>
        /// <param name="selectedSurface"></param>
        /// <returns></returns>
        public int CalcSurfaceCost(string selectedSurface)
        {
            int result = 0;
            switch (selectedSurface)
            {
                case "Laminate": result = 100; break;
                case "Oak": result = 200; break;
                case "Pine": result = 50; break;
                case "Rosewood": result = 300; break;
                case "Veneer": result = 125; break;
            }
            return result;


        }
        /// <summary>
        /// override ToString() including custName for reference
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return base.ToString() + "\n" +
               "name:" + CustomerName;
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
                MessageBox.Show(@"File Could Not be Found" + e);
            }

            return rushShipping;
        }
    }


}
