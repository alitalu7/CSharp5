
Console.WriteLine("Bir sayı giriniz...");
int a = Convert.ToInt32(Console.ReadLine());

if (a<20)
{
    Console.WriteLine("Girilen sayi yirmiden küçüktür...");
}
else if (a == 20)
{
    Console.WriteLine("Sayi yirmiye eşittir...");
}
else
{
    Console.WriteLine("Sayi yirmiden büyüktür...");
}
