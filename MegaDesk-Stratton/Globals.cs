using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_TeamGenesis
{
    public class Globals
    {
        private List<DeskQuote> _allQuotes;

        public Globals()
        {
            _allQuotes = new List<DeskQuote>();
        }
        public List<DeskQuote> AllQuotes
        {
            get => _allQuotes;
            set => _allQuotes = value;
        }
    }
}
