int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
bool Chis( int message)
{
    if ( message>9999 && message <100000)
    {
        return true;
    }
    System.Console.WriteLine("не то число");
    return false;
}
int x = ReadInt("Введите число ");

int thousand  = x/10000;
int thousand2  = ((x/1000)%10);
int hundred = (((x/100)%10)%10);
int ten = ((((x/10)%10)%10)%10);
int one = x%10;

int res = ((one*10000)+(ten*1000)+(hundred*100)+(thousand2*10)+thousand);

if (Chis(x))
{
if (res == x) 
{
    Console.WriteLine("YES");
}
else Console.WriteLine ("NO");
}