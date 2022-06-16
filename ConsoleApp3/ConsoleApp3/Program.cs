// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*//ハンズオン01

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
    if (userAnswer == Answer)
    {
        Console.WriteLine("正解だよ！");
    }

    //ハンズオン04
    int loop = 1;
    int sum = 0;
    while (loop <= 100)
    {
        sum += loop;
        loop++;
    }
    Console.WriteLine("合計は" + sum + "です");
}

//ハンズオン05
string Answer = "i";

string userAnswer = Console.ReadLine();

do
{
    Console.WriteLine("不正解だよなんでわかんねぇんだよ!");
    userAnswer = Console.ReadLine();

    if (userAnswer == Answer)
        Console.WriteLine("正解だよ馬鹿野郎！");
}
while (userAnswer != Answer);


//ハンズオン06
int sum05 = 0;
for (int i = 1; i <= 100; i++)
{
    sum05 += i;
}
Console.WriteLine("合計"+sum05);


//ハンズオン07
float number = 114514.810f;
float answer = number + 364364.931f;
Console.WriteLine(answer);


//ハンズオン08
float number = 0f;
for(int i= 0; i < 1000; i++)
{
    number += 0.001f;
}
Console.WriteLine(number);

float number2 = 10000f;
number2 += 0.0001f;
Console.WriteLine(number2);


//ハンズオン09
int number = 8;
if (number >= 0)
{
    //0以上
    if (number <= 10)
    {
        //10以下
        Console.WriteLine(number + "0以上１０以下です");
    }
}

*/

//ハンズオン10
int number = 1;
int number2 = 1;

Console.WriteLine(1 + ":" + number);
Console.WriteLine(2 + ":" + number2);

for(int i=3; i <= 50; i++)
{
    int next = number + number2;
    Console.WriteLine(i + ":" + next);
    //1つづつ変数の値をずらす
    number = number2;
    number2 = next;
}

