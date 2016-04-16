using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokerAppMVC.Models
{
    public class Input
    {
        
        public int SmallBlind { get; set; }
        
        
        public int BigBlind { get; set; }
        
        
        public int? Ante { get; set; }

        
        public int Stack { get; set; }

        
        public int Players { get; set; }

        public int Opponents { get; set; }

        public Result Calculate()
        {
            var cpr = SmallBlind + BigBlind + (Players * (Ante.HasValue ? Ante.Value : 0));
            var csi = Stack / cpr;

            var pn = csi * Opponents;
            if (Ante > SmallBlind / 5 && Players == 9)
                pn = Convert.ToInt16(pn * 0.95);

            return new Result(cpr, csi, pn);            
        }
    }
}