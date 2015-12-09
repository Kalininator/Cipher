using System;
namespace Cipher
{
    public class Affine
    {

        public static int[] affineCoprimeOptions = { 1, 3, 5, 7, 9, 11, 15, 17, 19, 21, 23, 25 };

        //AFFINE
        public static String AffineEncrypt(String str, int m, int c) //shift str using y = mx + c
        {
            String temp = "";
            int charnum;

            for(int i = 0; i < str.Length; i ++)
            {
                if(Util.isLetter(str.ToUpper()[i]))
                {
                    charnum = Util.CharToInt(str[i]);
                    charnum = (charnum * m) + c;
                    charnum = charnum % 26;
                    temp += Util.IntToChar(charnum);
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
            int initialchar, finalchar, mInverse,temp;
            string output = "";
            for(int i = 0; i < str.Length; i ++)
            {
                if(Util.isLetter(str[i]))
                {
                    initialchar = Util.CharToInt(str[i]);
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
                    output += Util.IntToChar(finalchar);
                }
                else
                {
                    output += str[i];
                }
            }
            return output;
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

    }
}
