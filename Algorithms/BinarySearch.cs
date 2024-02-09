
namespace Algorithms
{
    public static class BinarySearch
    {

        public static void BinarySearchAlgorithm(int[] listOfItems, int myNumber)
        {
            Console.WriteLine("número a buscar: " + myNumber);
            int stepsToFindTheNumber = 0;

            int high = listOfItems.Length - 1;
            int low = 0;
            int mid = 0;

            while (listOfItems[mid] != myNumber)
            {

                mid = (high + low) / 2;

                if (listOfItems[mid] < myNumber)
                {
                    low = mid + 1;

                }
                if (listOfItems[mid] > myNumber)
                {
                    high = mid - 1;
                }

                stepsToFindTheNumber++;
            }
            Console.WriteLine(stepsToFindTheNumber);
        }
    }
}

