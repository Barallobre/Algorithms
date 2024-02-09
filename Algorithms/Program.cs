using Algorithms;

int[] listOfItems = new int[128];

for (int i = 0; i < listOfItems.Length; i++)
{
    listOfItems[i] = i + 1;
    Console.WriteLine(listOfItems[i]);
}

Console.WriteLine("Introduzca el número a buscar");
int myNumber = int.Parse(Console.ReadLine());

BinarySearch.BinarySearchAlgorithm(listOfItems, myNumber);
