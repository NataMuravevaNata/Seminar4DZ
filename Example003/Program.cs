// Написать программу копирования массива
void FillArray (int[]array)
{
    int Length = array.Length;
    int i = 0;
    while (i<Length)
    {
        array[i]=new Random().Next(1,50);
        i++;
    }
}

void PrintArray (int[]array)
{
    int count = array.Length;
    int position = 0;
    while (position<count)
    {
        Console.Write ($"{array[position]}, ");
        position++;
    }    
}

void CopyArray (int[]array)
{
        int[] copy = new int[array.Length];
        for (int i = 0; i < array.Length; i++) 
        {
            copy[i] = array[i];
        }

string str = string.Join(", ", copy);
Console.WriteLine(str);

}

int[]array=new int[5];
FillArray(array);
PrintArray(array);

Console.WriteLine(" ");
CopyArray(array);