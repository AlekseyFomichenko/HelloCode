int[] array = { 2, 235, 2, 256, 8, 4572, 632335, 88413, 356, 4, 46, 15 };
int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;   
    }
    index++;
    if (index == n) Console.WriteLine("not found");
}