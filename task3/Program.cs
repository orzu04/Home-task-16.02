

int Sum(int n)
{
    if(n==0)
    {
        return 0;
    }

    else {
        return n+Sum(n-1);
    }
}

Sum(10);
System.Console.WriteLine(Sum(10));