using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Util
    {

        public static char IntToChar(int val)
        {
            return (char)(val + 65);
        }

        public static int CharToInt(Char val)
        {
            val = val.ToString().ToUpper()[0];
            return (int)val - 65;
        }

        public static bool isLetter(Char c)
        {
            if ((int)c < 91 && (int)c > 64)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static String ShiftString(String str, int shift)
        {
            String temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                temp += ShiftChar(str[i], shift);
            }
            return temp;
        }

        public static char ShiftChar(char x, int shift)
        {
            x = x.ToString().ToUpper()[0];
            if (shift < 0)
            {
                int shiftabs = Math.Abs(shift);
                shiftabs %= 26;
                shift = 26 - shiftabs;
            }
            if (isLetter(x))
            {
                return IntToChar((CharToInt(x) + shift) % 26);
            }
            else
            {
                return x;
            }
        }

    }
}
