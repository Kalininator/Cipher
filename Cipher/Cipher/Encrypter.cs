using System;

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
    public static char ShiftChar(char x, int shift)
    {

        if(shift < 0)
        {
            int shiftabs = Math.Abs(shift);
            shiftabs %= 26;
            shift = 26 - shiftabs;
        }

        if ((int)x < 91 && (int)x > 64)
        {
            int initChar = (int)x;
            return (char)((((initChar - 65) + shift) % 26) + 65);
        }
        else if ((int)x < 122 && (int)x > 96)
        {
            int initChar = (int)x;
            return (char)((((initChar - 97) + shift) % 26) + 97);
        }
        else
        {
            return x;
        }
    }
}
