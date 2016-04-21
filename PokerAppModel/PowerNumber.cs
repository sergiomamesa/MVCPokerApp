using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokerAppMVC.Models
{
    public class PowerNumber
    {
        private static PowerNumber Plus = new PowerNumber() { IsPlus = true };
        private static PowerNumber Negative = new PowerNumber() { IsNegative = true };

        public bool IsPlus { get; private set; }
        public bool IsNegative { get; private set; }
        public int Value { get; private set; }

        public static PowerNumber GetValue(int value)
        {
            if (value == 100)
                return PowerNumber.Plus;

            if (value == 0)
                return PowerNumber.Negative;

            return new PowerNumber() { Value = value };
        }

        public static bool GetIsValid(PowerNumber currentValue, int weight)
        {
            if (currentValue.IsPlus)
                return true;

            if (currentValue.IsNegative)
                return false;

            if (currentValue.Value > weight)
                return true;

            return false;
        }

        public override string ToString()
        {
            if (this.IsPlus)
                return "+";

            if (this.IsNegative)
                return "-";

            return this.Value.ToString();
        }
    }
}