// See https://aka.ms/new-console-template for more information
//Selection sort 

int[] array = { 3, 4, 6, 7, 9, 10 };

 for(int i=0;i<array.Length-1;i++)
{
    Console.WriteLine("outer");
    for(int j=i+1;j>0;j--)
    {
        Console.WriteLine("inner");
        if (array[j] < array[j - 1])
        {
            int temp = array[j - 1];
            array[j - 1] = array[j];
            array[j] = temp;

        }
        else
            break;
    }
}
array.ToList().ForEach(x=>Console.WriteLine(x));