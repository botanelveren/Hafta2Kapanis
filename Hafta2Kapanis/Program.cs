using System;

namespace Hafta2Kapanis
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.//Console.WriteLine($"Merhaba\nNasılsın?\nİyiyim\nSen nasılsın?");

            //2.//string text = "Botan";
            //int age = 34;
            //Console.WriteLine($"{text} {age}");


            //3.//Random rnd = new Random();
            //int randomnumber = rnd.Next(1, 100);
            //Console.WriteLine($"{randomnumber}");


            //4.//Random rnd = new Random();
            //int randomnumber = rnd.Next(1, 100);
            //int remainder =randomnumber % 3;
            //Console.WriteLine($"{remainder}");


            //5.//Console.WriteLine("Yaşınız nedir?");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age > 18)
            //    Console.WriteLine("+");
            //else if (age < 18)
            //    Console.WriteLine("-");


            //6.//for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
            //}

            //7.//Console.WriteLine("Birinci metni giriniz.");
            //string text1 = Console.ReadLine();
            //Console.WriteLine("İkinci metni giriniz.");
            //string text2 = Console.ReadLine();

            //string temptext1 = "Gülse Birsel";
            //string temptext2 = "Demet Evgar";

            //text1 = temptext1;
            //text2 = temptext2;

            //Console.WriteLine(temptext1);
            //Console.WriteLine(temptext2);


            //8.//void BenDegerDondurmem()
            //{
            //    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma.");
            //}
            //BenDegerDondurmem();

            //9.//int Addition(int a, int b) 
            //{ 
            //    int result = a + b;
            //    return result;
            //}
            //Console.WriteLine(Addition(5, 9)); 


            //10.//string BoolToString (bool input) 
            //{
            //    if (input)
            //        return "Değer doğrudur.";
            //    else 
            //        return "Değer yanlıştır.";
            //}

            //Console.WriteLine("Lütfen true veya false değerini giriniz.");
            //bool value = Convert.ToBoolean(Console.ReadLine());

            //string result = BoolToString(value);
            //Console.WriteLine(result);


            //11.//int Oldest(int age1, int age2, int age3)
            //{
            //    int oldestAge = age1;

            //    if (age2 > oldestAge)

            //    {
            //        oldestAge = age2;
            //    }

            //    if (age3 > oldestAge)
            //    {
            //        oldestAge = age3;
            //    }

            //    return oldestAge;
            //}

            //Console.WriteLine("Lütfen üç kişinin yaşlarını sırasıyla giriniz:");
            //int age1 = Convert.ToInt32(Console.ReadLine());
            //int age2 = Convert.ToInt32(Console.ReadLine());
            //int age3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Oldest(age1, age2, age3));


            //12.//int FindBiggestNumber()
            //{
            //    int biggestNumber = int.MinValue;

            //    Console.WriteLine("Sayılar giriniz (çıkmak için 0 girin.)");

            //    while (true)
            //    {
            //        Console.WriteLine("Sayı:");
            //        if (int.TryParse(Console.ReadLine(), out int number))
            //        {
            //            if (number == 0)
            //            {
            //                break;
            //            }
            //            if (number > biggestNumber)
            //            {
            //                biggestNumber = number;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
            //            }
            //        }
            //        Console.WriteLine($"Girilen sayılar için en büyük sayı: {biggestNumber}");

            //    }
            //    return biggestNumber;
            //}
            //Console.WriteLine(FindBiggestNumber());

            //13.//void ChangeName(ref string name1, ref string name2)
            //{
            //    string tempName = name1;
            //    name1 = name2;
            //    name2 = tempName;
            //}

            //Console.WriteLine("Lütfen iki tane isim giriniz:");
            //Console.WriteLine("İsim1:");
            //string name1 = Console.ReadLine();
            //Console.WriteLine("İsim2:");
            //string name2 = Console.ReadLine();

            //ChangeName(ref name1, ref name2);
            //Console.WriteLine("isimler değiştirildikten sonra:");
            //Console.WriteLine($"İsim 1: {name1}");
            //Console.WriteLine($"İsim 2: {name2}");


            //14.//bool IsOdd(int number)
            //{
            //    return number % 2 != 0;
            //}

            //Console.WriteLine("Lütfen bir sayı giriniz:");
            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    bool result = IsOdd(number);

            //    if(result)
            //    {
            //        Console.WriteLine($"Girilen sayı: {number} tektir." );
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Girilen sayı: {number} çifttir.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
            //}


            //15.//double CalculateDistance(double speed, double time)
            //{
            //    return speed * time;
            //}

            //Console.WriteLine("Lütfen hızı (km/s) giriniz:");
            //if (double.TryParse(Console.ReadLine(), out double speed))
            //{
            //    Console.WriteLine("Lütfen süreyi (saat) giriniz:");
            //    if (double.TryParse(Console.ReadLine(), out double time))
            //    {
            //        double distance = CalculateDistance(speed, time);
            //        Console.WriteLine($"Gidilen mesafe: {distance} km");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Geçersiz giriş. Lütfen bir süre giriniz.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz giriş. Lütfen bir hız giriniz.");
            //}


            //16.//double CalculateCircleArea(double radius)
            //{
            //    double pi = 3.14;
            //    return pi * radius * radius;
            //}

            //Console.WriteLine("Dairenin yarıçapını giriniz: ");

            //if (double.TryParse(Console.ReadLine(), out double radius))
            //{
            //    double area = CalculateCircleArea(radius);
            //    Console.WriteLine($"Dairenin alanı: {area}");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz giriş. Lütfen bir yarıçap giriniz.");
            //}

            //17.//string sentence ="Zaman bir GeRi SayIm";

            //string upperCase = sentence.ToUpper();
            //Console.WriteLine(upperCase);
            //string lowerCase = sentence.ToLower();
            //Console.WriteLine(lowerCase);

            //18.//string text = " Selamlar ";
            //text = text.Trim();
            //Console.WriteLine(text);





        }
    }
}