using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class MergeSort
    {
        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }

        public static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                leftArray[i] = arr[left + i];
            }

            for (int j = 0; j < n2; j++)
            {
                rightArray[j] = arr[mid + 1 + j];
            }

            int i1 = 0, j1 = 0, k = left;

            while (i1 < n1 && j1 < n2)
            {
                if (leftArray[i1] <= rightArray[j1])
                {
                    arr[k] = leftArray[i1];
                    i1++;
                }
                else
                {
                    arr[k] = rightArray[j1];
                    j1++;
                }
                k++;
            }

            while (i1 < n1)
            {
                arr[k] = leftArray[i1];
                i1++;
                k++;
            }

            while (j1 < n2)
            {
                arr[k] = rightArray[j1];
                j1++;
                k++;
            }
        }
    }
}
