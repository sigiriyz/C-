/*
Console.WriteLine("Today is Friday!");// переход на новую сточку
Console.Write("Today is Friday!")

Console.ReadLine(); //строка

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is: " + number);
Console.WriteLine($"Your number is: {number}"); // одно и тоже

//int,double (float), bool

Console.Write("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine("Square is: " + result);


Console.WriteLine("input first: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA == numberB * numberB)
{
    Console.WriteLine("Ferst number = square second");
}
else
{
    Console.WriteLine("Ferst number != square second");
}


Console.WriteLine("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number * (-1);
while(count <= number)
{
    Console.Write(count + ", ");
    count = count + 1; //count +=1 count++
}


// 11 / 3 = 3 деление на цело
// 11 % 3 = 2 остаток от деления

456 % 10 = 6
456 . 10 = 45

456 % 100 = 56
456 / 100 = 4

456 % 1000 = 456
456 / 1000 = 0
*/

Console.WriteLine("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >99 && number < 1000) // &&- логическая И, || - логическая ИЛИ
{
    //int digit = number % 10;
    //Console.WriteLine(digit);
    Console.WriteLine("The third digit is " + number % 10);
}
else
{
    Console.WriteLine("input correct number!");
}
