

int cnt =0;
int Numbs(int n)
{

    if(n==0)
    {
        return 0;
    }
    else {
        Numbs(n/10);
        return cnt++;
    }
}
Numbs(1234);
System.Console.WriteLine(cnt);