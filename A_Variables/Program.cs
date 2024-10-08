
//değişkenler

/*
 *  VERİ TİPLERİ (DATA TYPES)
    **TAMSAYILAR****
    sbyte
    byte
    short
    ushort
    int
    uint
    long
    ulong

   ***ONDALIKLI****
    float
    double
    decimal

    ****METİNSEL*****
    string
    char

    *** MANTIKSAL***
    bool
 */


/*
       DEĞİŞKENLER (VARIABLES)
    
        veriTipi degiskenAdi; // değişken oluşturduk
        degiskenAdi = deger; // değer atadık...

        veya
        veriTipi degiskenAdi = deger;

    = bir atama operatörüdür ... 
 
 */


byte b = 200;

byte c = 255;
//byte cc = -3; // byte işaretsiz tam sayı. ihtiyaçhalinde sbyte (signedbyte
sbyte cc = -3;

//byte d = 256; // byte 0-255 arası değer saklayabildiği için 256 değeri atanamaz. uygulama hata verir...

short e = 256;
short f = 25366;
//short g = 32768;short -32768 ile 32767 arası değer saklayabildiği için 32768 değeri atanamaz.. uygulama h
ushort g = 32768;
//ushort gg = -5; ushort işaretsiz tam sayı aldığı için short kullanılmalıdır....

//ushort h = 65536; // 0 ile 65535 arası değer saklayabildiği için 65536 değer atanamaz...

int i = 43;

float ff = 5;
double d = 2;
decimal dd = 2;


// signed int =>   int
// unsigned int => uint


// değişken isimleri unique (benzersiz) olmalıdır..

int yas = 36;
//int yas = 30; // yas değişkeni üst satırda oluşturulduğu için bu satırda oluşturulamaz....
yas = 37; // yaş değikenine 37 değerini atadık...


// değişken isimleri arada bşluk bırakılmaz, türkçe karakter olmalaıdır. özel karakter olmalaıdır. 


//rakamla başlamaz ama rakamla bitebilir...
//int 1sayi=2;
//int 2sayi=3;
int sayi1 = 2;
int sayi2 = 3;

// tek satırda aynı tipli birden fazla değişken tanımlanabilir....
int num1, num2, num3, num4;




// Name Convetion
// Pascal Case
int OgrenciNo = 12345;

// Camel Case
int ogrenciNo = 12345;

// Snake Case
int ogrenci_no = 12345;

// Not : C# case sensetive bir dildir..Büyük harf küçük harf duyarlılığı vardır...

string ogrenciAdSoyAd = "Emine Demir";
string hocaAd = "Ekrem YILDIRIM";

// string => " birden fazla karakterin tanımının yapıldığı tipdir (karakterler toplığu) yada karakter kümesi

// char => ' tek karakterlik tanımları ifade eder...

char karakter = 'A';
char chr = 'e';

// mantıksal veri tipi sadece true yada false değeri alır..
bool soru = false;


byte b1 = 1;
byte i1 = 255;


//int b3 = "200"; atama işlemlerinde sağdaki tip ile soldaki tip birbirine eşit olmak zorundadır

string str = "200";

bool bl = true;

// float,decimal,double
double number = 3.1f; 
float number2 = 3.1f; // değer derleyici tarafından double olarak yorumlandığı için f eki ile float yorumlanır
decimal number3 = 3.1m; // ondalıklı değerler double olarak yorumlandığı için m eki ile decimal yorumlanır


float k = 1.1f;
double l = 1.1d;
decimal m = 1.1m;
