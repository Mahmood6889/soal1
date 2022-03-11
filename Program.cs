for (int i = 0; i<4; i++)
{
    for (int x=4; x>=i; x--)
    {
      System.Console.Write(" ");
    }

    for (int j=0; j<=(i*2);j++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}
