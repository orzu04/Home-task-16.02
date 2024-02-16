

int a=1;
void Numbs(int n)
{
   if(a-1==n)
   {
    System.Console.WriteLine();
   }
   else {
       System.Console.Write($"{a} ");
             a++;
             Numbs(n);
   }


}
Numbs(10);