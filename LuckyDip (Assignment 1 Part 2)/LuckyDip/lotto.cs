using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;

namespace LuckyDip
{
    class Lotto
    {

        private int[] numArray;
        private Random randomNumber;

        public Lotto()
        {
            numArray = new int[6];
            randomNumber = new Random(DateTime.Now.Millisecond);
        }

        public void SetNumbersToZero()
        {
            for (int loop = 0; loop < numArray.Length; loop++)
            {
                numArray[loop] = 6;
            }
        }

        public void SortNumbers()
        {
            int Sort;
            for (int OutLoop = 0; OutLoop < numArray.Length - 1; OutLoop++)
            {
                for (int InLoop = 0; InLoop < numArray.Length - 1; InLoop++)
                {
                    if (numArray[InLoop] > numArray[InLoop + 1])
                    {
                        Sort = numArray[InLoop + 1];
                        numArray[InLoop + 1] = numArray[InLoop];
                        numArray[InLoop] = Sort;
                    }
                }
            }

        }

        public void GenerateNumbers()
        {
            numArray[0] = randomNumber.Next(1, 49);

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = randomNumber.Next(1, 49);
            }
        }

        public void PrintNumbers(TextBlock OutputTextBlock)
        {
            OutputTextBlock.Text = OutputTextBlock.Text + numArray[0] + "  ";
        }

    }
}
