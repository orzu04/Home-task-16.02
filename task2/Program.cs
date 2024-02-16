



void PrintNums (int n)
{
    if(n<0)
    {
        System.Console.WriteLine(1);
    }

    else {
        System.Console.Write($"{n}");
   n--;
      PrintNums(n);

    }
}

PrintNums(10);