using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokerAppMVC.Models
{
    public class Result
    {
        public int CPR { get; set; }
        public int CSI { get; set; }

        public int PN { get; set; }

        public bool[,] TableValidated { get; set; }
        public PowerNumber[,] TableWeights { get; set; }

        public Result()
        {
            //Need for the view engine
        }

        public Result(int cpr, int csi, int pn)
        {
            CPR = cpr;
            CSI = csi;
            PN = pn;

            TableValidated = PowerNumbersTable.CreateValidationTable(PN);
            TableWeights = PowerNumbersTable.CreateWeightTable();
        }
    }
}