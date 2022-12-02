using System.Linq;
using System.Windows.Controls;

namespace lOgInApp
{
    public class Sort
    {
        public static void InsertionSort(TextBox input, TextBox output)
        {
            int[] arrayToSort = InputSplit(input);

            for (int i = 1; i < arrayToSort.Length; i++)
            {
                int temp = arrayToSort[i];
                int j = i - 1;

                while (j >= 0 && arrayToSort[j] > temp)
                {
                    arrayToSort[j + 1] = arrayToSort[j];
                    j--;
                }
                arrayToSort[j + 1] = temp;
            }
            WriteOutput(arrayToSort, output);
        }

        static int[] InputSplit(TextBox input)
        {
            string stringArr = input.Text;
            int[] intArr = stringArr.Split(',').Select(int.Parse).ToArray();
            return intArr;
        }

        static void WriteOutput(int[] arr, TextBox output)
        {
            string stringOutput = "";

            for (int i = 0; i < arr.Length; i++)
            {
                stringOutput += arr[i].ToString() + ", ";
            }
            output.Text = stringOutput;
        }
    }
}
