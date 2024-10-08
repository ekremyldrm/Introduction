
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
int x = 258;
byte y = Convert.ToByte(x);
Console.WriteLine(x);



