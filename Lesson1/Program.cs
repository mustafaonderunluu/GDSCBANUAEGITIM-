using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks.Sources;


// Kullanıcıdan alınan iki sayının çift mi tek mi olduğunu kontrol eden program
int a, b;

while (true)
{
    Console.Write("Birinci değeri giriniz: ");
    a = Convert.ToInt32(Console.ReadLine());

    Console.Write("İkinci değeri giriniz: ");
    b = Convert.ToInt32(Console.ReadLine());

    if (a % b == 0)
    {
        Console.WriteLine("Çift Sayı");
    }
    else
    {
        Console.WriteLine("Tek Sayı");
    }
}
Console.ReadLine();

// Kullanıcıdan alınan bir sayıya kadar yıldızlarla üçgen çizen program
int s1;
Console.Write("Lütfen Sayı Giriniz: ");
s1 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < s1; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

// Kullanıcının iki sayı üzerinde dört işlem yapmasını sağlayan hesap makinesi programı
int s1, s2, sonuc;

while (true)
{
    Console.Write("İlk Sayıyı Giriniz: ");
    s1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("İkinci Sayıyı Giriniz: ");
    s2 = Convert.ToInt32(Console.ReadLine());

    Console.Write(" 0 = Toplama\n 1 = Çıkarma\n 2 = Çarpma\n 3 = Bölme\n " + "Yapmak İstediğiniz İşlemi Seçiniz: ");

    int seçim = Convert.ToInt32(Console.ReadLine());

    switch (seçim)
    {
        case 0:
            sonuc = s1 + s2;
            Console.WriteLine("Toplama = " + sonuc);
            break;

        case 1:
            sonuc = s1 - s2;
            Console.WriteLine("Çıkarma = " + sonuc);
            break;

        case 2:
            sonuc = s1 * s2;
            Console.WriteLine("Çarpma = " + sonuc);
            break;

        case 3:
            sonuc = s1 / s2;
            Console.WriteLine("Bölme = " + sonuc);
            break;

        default:
            Console.WriteLine("Geçersiz İşlem");
            break;
    }
}

// Kullanıcının vize ve final notlarına göre ders geçip geçmediğini kontrol eden program
double vize, final, ort;
bool geçtiniz = false;

Console.Write("Vize notu giriniz: ");
vize = Convert.ToInt32(Console.ReadLine());

Console.Write("Final notu giriniz: ");
final = Convert.ToInt32(Console.ReadLine());

ort = orthesapla(vize, final);

if (final < 50 || ort < 50)
{
    Console.WriteLine("Bütünleme Sınavına Kaldınız");
    Console.Write("Bütünleme Notunuzu Giriniz: ");
    final = Convert.ToInt32(Console.ReadLine());

    ort = 0.4 * vize + 0.6 * final;

    if (final >= 50 && ort >= 50)
    {
        geçtiniz = true;
    }
}
else
{
    geçtiniz = true;
}

if (geçtiniz)
{
    Console.WriteLine("Tebrikler dersten geçtiniz. Ortalama notunuz: " + ort);
}
else
{
    Console.WriteLine("Dersten Kaldınız. Ortalama notunuz: " + ort);
}

double orthesapla(double v, double f)
{
    ort = 0.4 * v + 0.6 * f;
    return ort;
}


// İki sayının toplamını hesaplayan ve sonucu döndüren bir fonksiyonun kullanımı
double a = 3, b = 5, sonuc;

sonuc = fonksiyon1(a, b);
Console.Write("Sonuc: " + sonuc);

double fonksiyon1(double f, double g)
{
    double sonuc = f + g;
    return f + g;
}

// Kullanıcının vize ve final notlarına göre ders geçip geçmediğini kontrol eden program
double vize, final, ort;
bool geçtiniz = false;

Console.Write("Vize notu giriniz: ");
vize = Convert.ToInt32(Console.ReadLine());

Console.Write("Final notu giriniz: ");
final = Convert.ToInt32(Console.ReadLine());

ort = 0.4 * vize + 0.6 * final;

if (final < 50 || ort < 50)
{
    Console.WriteLine("Bütünleme Sınavına Kaldınız");
    Console.Write("Bütünleme Notunuzu Giriniz: ");
    final = Convert.ToInt32(Console.ReadLine());

    ort = 0.4 * vize + 0.6 * final;

    if (final >= 50 && ort >= 50)
    {
        geçtiniz = true;
    }
}
else
{
    geçtiniz = true;
}

if (geçtiniz)
{
    Console.WriteLine("Tebrikler dersten geçtiniz. Ortalama notunuz: " + ort);
}
else
{
    Console.WriteLine("Dersten Kaldınız. Ortalama notunuz: " + ort);
}

// Kullanıcının üç sınav notunu alıp ortalama hesaplayan ve geçip geçmediğini kontrol eden program
int s1, s2, s3, ort;
Console.Write("1. sınavı giriniz: ");
s1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. sınavı giriniz: ");
s2 = Convert.ToInt32(Console.ReadLine());

Console.Write("3. sınavı giriniz: ");
s3 = Convert.ToInt32(Console.ReadLine());

ort = (s1 + s2 + s3) / 3;

if (ort > 50)
{
    Console.WriteLine("Geçtiniz: " + ort);
}
else
{
    Console.WriteLine("Kaldınız: " + ort);
}





