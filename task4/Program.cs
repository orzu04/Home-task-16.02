


void Nums(int n)
{
    if(n==0)
    {
        System.Console.WriteLine();
    }
    else{

         Nums(n/10);
        
        System.Console.Write($"{n%10} ");
       
    
    }
}

Nums(1234);