using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] { 5,7,9,1,3,8,4,2,6};
            Console.WriteLine("Unsorted Array:");
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.Write($"{unsortedArray[i]} ");
            }
            Console.WriteLine();

            int[] sortedArray = Sort(unsortedArray);
            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write($"{sortedArray[i]} ");
            }
            Console.WriteLine();
        }

        private static int[] Sort(int[] numbers)
        {
            int start = 0;
            int end = numbers.Length - 1;
            Quick(numbers, start, end);

            return numbers;
        }
        private static void Quick(int[] numbers, int start, int end)
        {
            //base case when to stop
            if (start >= end) return;

            //get the pivot itself - last item
            int pivot = numbers[end];

            // last item in array
            int pivotIndex = end;

            //get the pivotIndex after partitioning array
            pivotIndex = Partition(numbers, start, end, pivot);
            //repeat the procces
            Quick(numbers, start, pivotIndex - 1);
            Quick(numbers, pivotIndex + 1, end);
        }

        private static int Partition(int[] numbers, int start, int end, int pivot)
        {
            int pivotIndex = start;

            for (int i = start; i < end; i++) 
            {
                if(numbers[i] < pivot)
                {
                    //swap and move pivot index
                    Swap(numbers, pivotIndex, i);
                    pivotIndex++;
                }
            }
            Swap(numbers, pivotIndex, end);
            
            return pivotIndex;
        }

        private static void Swap(int[] numbers, int pivotIndex, int i)
        {
            int temp = numbers[pivotIndex];
            numbers[pivotIndex] = numbers[i];
            numbers[i] = temp;
        }
    }
}
