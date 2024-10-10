/*
 
    Operatörler => Program içerisinde atama,aritmatik işlem, karşılaştırma  gibi işlemler yapar

Operaötrler tek başına kullanılmaz. bir işleme tabi tutulmalıdır.
    
 */

// aritmatik operatörler
// + (toplama)
// - (çıkarma)
// * çarpma
// / (bölme)
// % (mod alma
// a+a =>iki sayısal değeri toplar

// atama operatörü
// = (atama operatörü) sağdaki değeri sol tarafa atar
// a = b b'nin değerini a'ya atar
// a += b    a = a+b'nin kısatlamsıdır
// a *=b


// ilişkisisel operatörler = iki değeri değeri karşılaştırmak için kullanılır. karşıştırma sonucunda true/false değeri döner
// a > b  büyük mü // a=3 b=1 ise true, a=1 b=5 ise false 
// a >= b büyük veya eşitmi
// a < b   küçük mü
// a <= b  küçük mü eşitmi
// a == b eşit mi
// a != b eşit değil

// mantıksal operatörler = birden fazla karşılaştırma operatörünü birleştir
// and (&&) => karşılaştırmanın her ikiside sağlanırsa true 
// or ||  => karşılaştırmanın herhangi biri sağlanırsa true
//a > b && a > c
// a = b && d=e

// a != b|| a!=a

// karşılaştırma ve mantıksal operatörler true yafa false döner...
int x = 3, y = 2;
bool result = true;
result = x > y; // true
result = x < y; //false
result = 100 > y;// true
result = x == y; // false
result = x != y; // true;

// mantıkal 
result = x > y && x > 1; // true
result = x < y && x > 1; // false

result = x > y || x > 1; // true
result = x < y || x > 1; // true

Console.WriteLine(result);




// dışarıdan girilen iki değeri karşılaştırıp ekrana karşılaştırma sonucunu yazdıralım...


// Console'dan deper ReadLine() metodu ile okunur. Console'dan okunan veya Console'a yazılın bütün değerler string'dir
// Not : WriteLine metodu ekranda gösterilecek değeri otomatik string'e dönüştür (Convert eder)

int sayi1, sayi2;
Console.WriteLine("1. Sayıyı Gİriniz");
sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Sayıyı Giriniz");
sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(sayi1 > sayi2);
Console.WriteLine(sayi1 + sayi2);
Console.WriteLine(sayi1 - sayi2);

bool inputResult = sayi1 > sayi2;
//Console.WriteLine(" Sayı 1 büyük mü Sayı 2'den " + inputResult);
Console.WriteLine($" Sayı 1 büyük mü Sayı 2'den {inputResult}");
Console.WriteLine($" Sayı 1 > Sayı 2 = {inputResult}");

//Console.WriteLine("Girilen 1. Sayı " + sayi1);  string ile int'i birleştirir
int i = sayi1 + 5;
int j = sayi2 + 10;

Console.WriteLine($"Girilen 1. Sayının 5 fazla {i} ");  // string ile int'i birleştirir
Console.WriteLine($"Girilen 2. Sayının 10 fazlası {j} ");