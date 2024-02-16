

System.Console.WriteLine($"All even numbers from 1 to 20 are :");
void Even(int a, int b)
{

if(a%2==0)
{
    if(a>b)
    {
        return;

    }
    else{
        
        System.Console.Write($"{a} ");
        Even(a+2,b);
    }
    
}
else {

    System.Console.Write($"{a+1} ");

    Even(a+3,b);
}
}

Even(1,20);


System.Console.WriteLine();


System.Console.WriteLine($"All odd numbers from 1 to 20 are :");
void Odd(int a, int b)
{
if(a%2!=0)
{
    if(a>b)
    {
        return;

    }
    else{
        System.Console.Write($"{a} ");
        Odd(a+2,b);
    }
    
}
else {

    System.Console.Write($"{a+1} ");

    Odd(a+3,b);
}
}

Odd(1,20);



