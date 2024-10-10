
// int > byte
byte num1 = 4; // 4 değerini num1 değişkenine atadık...
int num2 = num1; // num1 değerini num2'ye atadık...

num1 = 10; // num1'e 10 değerini ata...

Console.WriteLine(num1);
Console.WriteLine(num2);

// Dönüşüm İşlemleri


// byte j = 333; //333 değeri byte için büyük bir değer olduğu için dönüştürme işlemi gerçekleştirilemez...

// C# içerisinde bir değer ataması yapılırken bu atama işleminde otomatik dönüşüm işlemi yapılır. bu dönüşüm işlemine (bilinçsiz) implicity conversion denir.


// implicity convert küçük tip'in büyük tip'e dönüşümüdür.. .örnek sıralama aşağıdaki gibidir;
// byte > short > int > long 


byte a = 1;
int b = a; //  byte intten küçük olduğu için dönüşebilir
short s = a; // byte shorttan küçük olduğu için dönüşebilir
double d = b; // int double'dan küçük olduğu için dönüşebilir

// tam tersi dönüşüm sadece explity (bilinçli) dönüşümle mümkündür...explity dönülümde type castin ile yapılır...
//(tip)deger

// type casting  büyük tip'in (ortak) küçük tip'e dönüşümüne denir...
// decimal,double,float,long,int,short,byte

// type casting yaparak uygulama derlendi...
double dd = 10;
int cc = 10;
byte bb = (byte)cc; //int byte'dan büyük olduğu için bu atama işlemi yapılamaz...
short shrt = (short)cc;
int k = (int)dd;

// Not : type casting dikkatli kullanılması gerekir. Explity convert işlemi yaılduğında uygulama derlenir ve hata vermez....
byte jj = 33;
int ll = jj;// jj int'e dönüştürülerek (implictly conversion) ll'ye atanır.. derleyici dönüştürür

int j = 258;
byte l = (byte)j; // j byte'e dönüştürülerek (explity conversion) l'ye atanır... programcı dönüştürür...

// Not : explity convert işleminde veri kaybı yaşanabilir....eğer uygun değer aralığında değilse......

Console.WriteLine(j); // j'nin değerini ekrana yazdır
Console.WriteLine(l);// l'nin değerini ekrana yazdır...


// Convert Methods
// COnvert Metotlarında  dönüşüm runtime'da (çalışma zamanında)   yapılır 
// Veri değer aralığımda değilse uygulama hata verir...OverflowException fırlatır
// Eğer convert dönüşüm işlemini yapamazsa hata fırlatır (dönüşüm değer aralığı veya format olabilir)
int x = 258;
x = 250; // x'e 250 değerini ata...
byte y = Convert.ToByte(x);
Console.WriteLine(x);

byte z;
z = Convert.ToByte("2"); // 2'yi byte dönüştür: daha z'ye ata....

bool statu = Convert.ToBoolean("false"); //false
bool status = Convert.ToBoolean(1); // true

//bool statu1 = Convert.ToBoolean("Hamburger"); uygulama bu satırda hata verir...çünkü boolean formatta değildir...
bool statu2 = Convert.ToBoolean(3); // true kabul etti...

//byte zz = Convert.ToByte("iki"); // sayı formatında olmadığı için hata verir... 

int sayi5 = Convert.ToInt32("10000");
long sayi6 = Convert.ToInt64("10000");
int sayi7 = Convert.ToByte("3"); // önce byte dönüştürür. sonra otomatik int'e dönüşütürülür...

//Convert.ToInt16 => shor
//Convert.ToInt32 => int
//Convert.ToInt64 => long

//Convert.ToSingle => float
//Convert.ToBoolean => bool

// CTS Common Type System

// C# dilindeki int .Net Frameworkte (Cts) ortak tür sisteminde Int32 olarak tanımlıdır...
// C# dilindeki short .Net Frameworkte (Cts) Int16 olarak tanımldır...
// C#d dilindeki long .Net Framewotkte (Cts) Int64 olarak tanımldır
int kl = 1;











