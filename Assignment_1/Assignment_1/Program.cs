namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array for testing.
            int[] arr = { 45, 22, 67, 14, 55, 38 };

            // Display the original array.
            Console.WriteLine("Original Array: " + string.Join(", ", arr));

            // Call the Sort method of the MergeSort class to sort the array.
            MergeSort.Sort(arr, 0, arr.Length - 1);

            // Display the sorted array.
            Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
        }
    }
}
