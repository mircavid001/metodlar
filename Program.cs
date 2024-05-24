

//void topla()
//{
//    Console.WriteLine("plise enter first number");
//    int num1 = int.Parse(Console.ReadLine());
//    Console.WriteLine("plase enter second number");
//    int num2 = int.Parse(Console.ReadLine());
//    Console.WriteLine(num1 + num2);
//}

//topla();

//void topla(int num1, int num2)
//{
//    int res = num1 + num2;
//    Console.WriteLine(res);
//}

//topla(16, 28);



//int topla(int num1, int num2)
//{
//    int res = num1 + num2;
//    return res;
//}

Console.WriteLine("plise enter your name");
string name = Console.ReadLine();
if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("enter your name correctly");
}
else
{
    Console.WriteLine(name);
}