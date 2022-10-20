int[] massive = new int[] {-1, 0, 1, 2, 3, 4, 5, 6, 7, 8 , 9 , 10, 11, 12, 13, 14, 15, 16 };


int x = 4; 

Console.WriteLine(massive[x]);



ConsoleKeyInfo key = Console.ReadKey();

while (key.Key != ConsoleKey.Enter)
{

    if (key.Key == ConsoleKey.RightArrow)
    {
        
        x++;
        Console.Clear();
        Console.WriteLine(massive[x]);
    }
    if (key.Key == ConsoleKey.LeftArrow)
    {

        x--;
        Console.WriteLine(massive[x]);
        Console.Clear();
    }


    key = Console.ReadKey();
}