using System;
using System.Windows.Forms;

namespace Cipher
{
    class FrequencyAnalysis
    {

        public static double[] letterfrequency = {8.167,1.492,2.782,4.253,12.702,2.228,2.015,6.094,6.966,0.153,0.772,4.025,2.406,6.749,7.507,1.929,0.095,5.987,6.327,9.056,2.758,0.978,2.361,0.15,1.974,0.074};


        public static double[] getLetterFrequency(string text)
        {
            double[] frequency = new double[26];
            int[] lettercount = getLetterCount(text);

            for(int i = 0; i < 26; i ++)
            {
                frequency[i] = Math.Round(((double)lettercount[i] / (double)text.Length) * 100,3);
            }

            return frequency;
        }

        public static int[] getLetterCount(String text)
        {
            int[] count = new int[26];

            foreach (char x in text)
            {
                if ((int)x < 91 && (int)x > 64)
                {
                    count[Encrypter.CharToInt(x)]++;
                }

            }

            return count;
        }

        public static double getStringScore(String text)
        {
            double score = 0.0;

            double[] textLetterFrequency = getLetterFrequency(text);

            for (int i = 0; i < 26; i++)
            {
                score += Math.Abs(textLetterFrequency[i] - letterfrequency[i]);
            }

            return score;
        }

        public static double[] getScores(String text)
        {
            double[] scores = new double[26];

            for (int i = 0; i < 26; i++)
            {
                scores[i] = getStringScore(Encrypter.ShiftString(text, i));
            }

            return scores;
        }

        public static int PredictShiftValue(String text)
        {
            text = text.ToUpper();
            double[] scores = getScores(text);
           
            int minindex = 0;
            double minval = scores[0];
            for (int i = 0; i < 26; i ++)
            {
                if(scores[i] < minval)
                {
                    minindex = i;
                    minval = scores[i];
                }
            }
            
            
            return minindex;
        }
    }
}
