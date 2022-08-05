
void methodArray (string [] array)
{
     for (int i=0; i<array.Length; i++)
     {      
        if(array[i].Length<=3)
        {
        string[] newarray = new string[array.Length];
        newarray[i]=array[i];
        Console.Write($"[{newarray[i]}] "); 
        }
     }
        Console.WriteLine(); 
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
}


Console.WriteLine("Array: ");
string [] array1 = {"hello","2","world",":-)"};
string [] array2 = {"1234", "1567", "-2", "computer science"};
string [] array3 = {"Russia", "Denmark", "Kazan"};


Console.WriteLine();
PrintArray(array1);
PrintArray(array2);
PrintArray(array3);

Console.WriteLine();
Console.WriteLine("New array-1 ");
methodArray(array1);
Console.WriteLine("New array-2 ");
methodArray(array2);
Console.WriteLine("New array-3 ");
methodArray(array3);