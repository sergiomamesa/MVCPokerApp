using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokerAppMVC.Models
{
    public class PowerNumbersTable
    {
        public PowerNumber[,] Table = new PowerNumber[13, 13];

        private int[] RowA = new int[13] { 100, 100, 100, 100, 100, 50, 37, 32, 28, 31, 27, 26, 24 };
        private int[] RowK = new int[13] { 100, 100, 100, 75, 66, 44, 17, 15, 14, 13, 11, 10, 9 };
        private int[] RowQ = new int[13] { 100, 48, 100, 75, 58, 38, 16, 11, 10, 8, 8, 8, 8 };
        private int[] RowJ = new int[13] { 50, 31, 26, 100, 58, 39, 21, 12, 7, 7, 7, 7, 5 };
        private int[] RowT = new int[13] { 36, 19, 17, 22, 100, 43, 26, 15, 10, 9, 7, 5, 4 };
        private int[] Row9 = new int[13] { 27, 12, 9, 9, 11, 100, 31, 17, 10, 9, 3, 2, 0 };
        private int[] Row8 = new int[13] { 24, 10, 8, 8, 10, 10, 66, 19, 15, 10, 9, 0, 0 };
        private int[] Row7 = new int[13] { 22, 9, 6, 5, 6, 7, 10, 58, 15, 10, 9, 0, 0 };
        private int[] Row6 = new int[13] { 18, 9, 6, 4, 3, 3, 4, 7, 51, 11, 10, 4, 0 };
        private int[] Row5 = new int[13] { 21, 9, 6, 4, 0, 0, 0, 0, 0, 44, 11, 8, 0 };
        private int[] Row4 = new int[13] { 18, 8, 5, 3, 0, 0, 0, 0, 0, 0, 39, 6, 0 };
        private int[] Row3 = new int[13] { 16, 8, 5, 3, 0, 0, 0, 0, 0, 0, 0, 33, 0 };
        private int[] Row2 = new int[13] { 15, 7, 4, 3, 0, 0, 0, 0, 0, 0, 0, 0, 28 };

        public PowerNumbersTable()
        {
            CreateRow(0, RowA);
            CreateRow(1, RowK);
            CreateRow(2, RowQ);
            CreateRow(3, RowJ);
            CreateRow(4, RowT);
            CreateRow(5, Row9);
            CreateRow(6, Row8);
            CreateRow(7, Row7);
            CreateRow(8, Row6);
            CreateRow(9, Row5);
            CreateRow(10, Row4);
            CreateRow(11, Row3);
            CreateRow(12, Row2);
        }

        private void CreateRow(int rowNumber, int[] rowData)
        {
            for (int i = 0; i <= 12; i++)
            {
                Table[rowNumber, i] = PowerNumber.GetValue(rowData[i]);
            }
        }
    }
}