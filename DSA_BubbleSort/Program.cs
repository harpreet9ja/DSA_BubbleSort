// See https://aka.ms/new-console-template for more information
int[] array = { 2, 7, 5, 19, 3, 5, 8,0 };

int arrayLength = array.Length;

for(int i = 0;i<arrayLength-1;i++)
{
    for(int j = arrayLength - 1;j>i;j-- )
    {
        if (array[j] < array[j-1])
        {
            int temp= array[j];
            array[j] = array[j-1];
            array[j-1]= temp;
        }
    }
}

foreach (var item in array)
{
    Console.WriteLine(item);
}