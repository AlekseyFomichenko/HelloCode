void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
int[] myArray = { 1, 5, 7, 3, 75, 90, 6, 3, 4, 1 };
SelectionSort(myArray);
for (int i = 0; i < myArray.Length - 1; i++)
{
    Console.Write(myArray[i]);
}