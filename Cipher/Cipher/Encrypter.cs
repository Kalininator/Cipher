using System;
namespace Cipher
{
    public class Encrypter
    {

        public static int[] affineCoprimeOptions = { 1, 3, 5, 7, 9, 11, 15, 17, 19, 21, 23, 25 };

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
        
        public static int ModularMultiplicativeInverse(int x)
        {
            int count = 0;
            double a;
            while(count<26)
            {
                //a = inverse of x
                a = (1 + (count * 26)) / (double)x;
                if(a % 1 == 0)
                {
                    //a is an integer, so a is correct
                    return (int)a;
                }
                else
                {
                    count++;
                }
            }
            return 0;
        }

        public static String AffineDecrypt(String str, int m, int c)
        {
            int initialchar, finalchar, mInverse,temp;
            string output = "";
            for(int i = 0; i < str.Length; i ++)
            {
                if(isLetter(str[i]))
                {
                    initialchar = CharToInt(str[i]);
                    mInverse = ModularMultiplicativeInverse(m);
                    temp = initialchar - c;

                    if(temp < 0)
                    {
                        temp = 26 - (Math.Abs(temp) % 26);
                    }
                    else
                    {
                        temp %= 26;
                    }

                    finalchar = (mInverse * (temp)) % 26;
                    output += IntToChar(finalchar);
                }
                else
                {
                    output += str[i];
                }
            }

            return output;
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
