using System;
using zametka;
int a = 0;
int dat = 1;
ConsoleKeyInfo key;
zam z0 = new zam();
zam z1 = new zam();
zam z2= new zam();
zam z3 = new zam();
zam z4 = new zam();
zam[] z = new zam[5];
Zam();
Meni();
Menu();
do
{
    keyy();
    if (key.Key == ConsoleKey.Enter)
    {
        body();
    }
    else
    {
        Meni();
        Menu();
    }
}
while (key.Key != ConsoleKey.Escape);
void Zam()
{
    z0.nam = "коледж";
    z0.desc = "пары: матеиатика, ОАИП";
    z0.na1 = "дом";
    z0.des1 = "лежать на диване";
    z[0] = z0;
    z1.nam = "коледж";
    z1.desc = "пары: матеиатика";
    z1.na1 = "дом";
    z1.des1 = "занялся чем то полеззным";
    z[1] = z1;
    z2.nam = "коледж";
    z2.desc = "пары: ОАИП";
    z2.na1 = "дом";
    z2.des1 = "лежать на диване";
    z[2] = z2;
    z3.nam = "коледж";
    z3.desc = "пары: матеиатика, БЖД";
    z3.na1 = "дом";
    z3.des1 = "лежать на диване";
    z[3] = z3;
    z4.nam = "коледж";
    z4.desc = "пары: БЖД, ОАИП";
    z4.na1 = "дом";
    z4.des1 = "лежать на диване";
    z[4] = z4;
}
void Menu()
{
    if (dat < 1)
    {
        dat = 1;
    }
    if (dat >31)
    {
        dat = 31;
    }
    if (dat < 10)
    {
        Console.SetCursorPosition(0, 0);
        Console.Write("0");
        Console.Write(dat);
        Console.Write(".10.2022");
    }
    else if (dat >=10)
    {
        Console.SetCursorPosition(0, 0);
        Console.Write(dat);
        Console.Write(".10.2022");
    }
    if (dat < 6)
    {
        Console.SetCursorPosition(2, 1);
        Console.Write("1 ");
        Console.Write(z[dat - 1].nam);
        Console.SetCursorPosition(2, 2);
        Console.Write("2 ");
        Console.Write(z[dat - 1].na1);
    }
}
void Meni()
{
    if (a < 0 || a > 1)
    { a = 0; }
    Console.Clear();
    Console.SetCursorPosition(0, a + 1);
    Console.WriteLine("->");
}
void keyy()
{
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.UpArrow)
    {
        a--;
    }
    if (key.Key == ConsoleKey.DownArrow)
    {
        a++;
    }
    if (key.Key == ConsoleKey.LeftArrow)
    {
        dat--;
    }
    if (key.Key == ConsoleKey.RightArrow)
    {
        dat++;
    }
}
void body()
{
Console.Clear();
if (a==0)
    {

        Console.WriteLine(z[dat - 1].nam);
        Console.WriteLine("--------------");
        Console.WriteLine("Описание:");
        Console.WriteLine(z[dat - 1].desc);
        Console.Write("Дата:");
        Console.Write("0");
        Console.Write(dat);
        Console.Write(".10.2022");
    }
else
    {
        Console.WriteLine(z[dat - 1].na1);
        Console.WriteLine("--------------");
        Console.WriteLine("Описание:");
        Console.WriteLine(z[dat - 1].des1);
        Console.Write("Дата:");
        Console.Write("0");
        Console.Write(dat);
        Console.Write(".10.2022");

    }
}