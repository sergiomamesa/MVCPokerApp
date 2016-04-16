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

        public bool[,] Table { get; set; }

        public Result()
        {

        }

        public Result(int cpr, int csi, int pn)
        {
            CPR = cpr;
            CSI = csi;
            PN = pn;

            Table = new bool[13, 13];
            var powerNumberTable = new PowerNumbersTable();
            for (int row = 0; row < 13; row++)
            {
                for (int col = 0; col < 13; col++)
                {
                    var currentValue = powerNumberTable.Table[row, col];
                    Table[row, col] = GetIsValid(currentValue);
                }
            }
        }

        private bool GetIsValid(PowerNumber currentValue)
        {
            if (currentValue.IsPlus)
                return true;

            if (currentValue.IsPlus)
                return false;

            if (currentValue.Value > PN)
                return true;

            return false;
        }
    }
}