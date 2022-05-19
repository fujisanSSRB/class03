// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//ハンズオン01

int a = 100;
int b = 200;

int c = a + b;

Console.WriteLine(c);

//ハンズオン02
int x = int.Parse(Console.ReadLine());
if (x % 2 == 0)
{
    Console.WriteLine(x + "は偶数です");
}
else
{
    Console.WriteLine(x + "は奇数です");

//ハンズオン03
string Answer = "i";

string userAnswer = Console.ReadLine();

while (userAnswer != Answer)
{
    Console.WriteLine("不正解だよ!");
    userAnswer = Console.ReadLine();
}
 if(userAnswer == Answer)
    {
    Console.WriteLine("正解だよ！");
}
 
    //ハンズオン04
    int loop = 1;
int sum = 0;
while(loop<=100)
{
    sum += loop;
    loop++;
}
Console.WriteLine("合計は" + sum + "です");