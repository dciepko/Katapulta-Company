using System.Linq;
using System.Windows.Controls;

namespace Sortowanie
{
    public class Sort
    {
        public static void InsertionSort(TextBox input, TextBox output)
        {
            int[] arrayToSort = inputSplit(input);

            for (int i = 1; i < arrayToSort.Length; i++)
            {
                int temp = arrayToSort[i];
                int j = i - 1;

                while (j > 0 && arrayToSort[j] > temp)
                {
                    arrayToSort[j + 1] = arrayToSort[j];
                    j--;
                }

                arrayToSort[j + 1] = temp;
            }

            string stringOutput = "";

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                stringOutput += arrayToSort[i].ToString() + ", ";
            }

            output.Text = stringOutput;
        }

        static int[] inputSplit(TextBox input)
        {
            string stringArr = input.Text;

            int[] intArr = stringArr.Split(',').Select(int.Parse).ToArray();

            return intArr;
        }
    }
}
