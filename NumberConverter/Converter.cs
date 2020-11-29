using System;

namespace NumberConverter
{
    public class Converter
    {
        public static int ConvertToInt(string s)
        {
            int num = 0;
            if (s == null || s == "") throw new ArgumentNullException("Invalid input");
            if (s.Length > int.MaxValue.ToString().Length) throw new OverflowException("Value overflowed");

            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] < '0') || (s[i] > '9')) throw new Exception("Invalid input");
                try
                {
                    num = num * 10 + ((int)s[i] - 48);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            return num;
        }
    }
}
