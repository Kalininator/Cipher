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
                if (Encrypter.isLetter(x))
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

        

        public static int Predict(String[] options)
        {
            int bestGuessIndex = 0;
            double bestScore = getStringScore(options[0]);

            double tempScore;
            for(int i = 0; i < options.Length; i ++)
            {
                tempScore = getStringScore(options[i]);
                if(bestScore > tempScore)
                {
                    bestScore = tempScore;
                    bestGuessIndex = i;
                }
            }
            return bestGuessIndex;
        }

    }
}
