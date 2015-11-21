using System;
namespace Cipher
{
    public class Encrypter
    {
        public static String ShiftString(String str, int shift)
        {
            String temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                temp += ShiftChar(str[i], shift);
            }
            return temp;
        }
        public static String AffineEncrypt(String str, int m, int c) //shift str using y = mx + c
        {
            String temp = "";

            int charnum;

            for(int i = 0; i < str.Length; i ++)
            {
                if(isLetter(str.ToUpper()[i]))
                {
                    charnum = CharToInt(str[i]);
                    charnum = (charnum * m) + c;
                    charnum = charnum % 26;
                    temp += IntToChar(charnum);
                }
                else
                {
                    temp += str[i];
                }
            }

            return temp;
        }
        public static String AffineDecrypt(String str, int m, int c)
        {
            return "";
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

        public static char IntToChar(int val)
        {
            return (char)(val + 65);
        }
        public static int CharToInt(Char val)
        {
            val = val.ToString().ToUpper()[0];
            return (int)val -65;
        }
        public static bool isLetter(Char c)
        {
            if((int)c < 91 && (int)c > 64)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
