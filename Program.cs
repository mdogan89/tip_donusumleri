// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Implicit Conversion
byte a = 5;
sbyte b = 30;
short c = 10;

int d = a + b + c;
Console.WriteLine("d: " + d);

long h = d;
Console.WriteLine("h: " + h);

float i = h;
Console.WriteLine("i: " + i);

string s = "str";
char f = 'k';
object g = s + f + d;
Console.WriteLine("g: " + g);

//Explicit Conversion

int x = 4;
byte y = (byte)x;
Console.WriteLine("y: " + y);

int z = 100;
byte t = (byte)z;

float w = 10.3f;
byte v = (byte)w;
Console.WriteLine("v: " + v);

// ToString

int xx = 6;
string yy = xx.ToString();
Console.WriteLine("yy: " + yy);

string zz = 12.5f.ToString();
Console.WriteLine("zz: " + zz);

//System.Convert

string s1 = "10";
string s2 = "20";
int sa1, sa2;
int top;

sa1 = Convert.ToInt32(s1);
sa2 = Convert.ToInt32(s2);
top = sa1 + sa2;
Console.WriteLine("top: " + top);

//Parse

string m1 = "10";
string m2 = "10,25";
int r1;
double double1;

r1 = Int32.Parse(m1);
double1 = Double.Parse(m2);

Console.WriteLine("r1: " + r1);
Console.WriteLine("double1: " + double1);
