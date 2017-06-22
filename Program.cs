using System;

class Program
{
    static void Main()
    {
        DateTime datetime=DateTime.Now;
        if(datetime.Hour>=4&&datetime.Hour<12)
        Console.WriteLine("Good Morning");
        if(datetime.Hour>=12&&datetime.Hour<16)
        Console.WriteLine("Good Afternoon");
        if(datetime.Hour>=16&&datetime.Hour<20)
        Console.WriteLine("Good Evening");
        if(datetime.Hour>=20&&datetime.Hour<4)
        Console.WriteLine("Good Night");
        
        Console.ReadKey();
    }
}

