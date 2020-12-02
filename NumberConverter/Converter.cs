using System;

namespace NumberConverter
{
    public class Converter
    {
        public static int ConvertToInt(string s)
        {
            int num = 0;
            if (s == null || s == "") throw new ArgumentNullException("Nothing at input. Please enter value");
            if (s.Length > int.MaxValue.ToString().Length) throw new OverflowException("Value overflowed");

            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] < '0') || (s[i] > '9')) throw new NonDigitException("Entered non-numeric value!", s[i].ToString());
                num = num * 10 + ((int)s[i] - 48);
            }

            return num;
        }
    }
}
