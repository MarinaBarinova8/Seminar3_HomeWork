// Задача 1(19). Напишите программу, которая принимает за вход
// пятизначное число и проверяет, является ли оно палиндромом
// 14212 -> нет
// 23432 -> да
// 12821 -> да


void Palindrom(int numUser)
{
    int num1 = numUser / 1 % 10;
    int num2 = numUser / 10 % 10;
    int num3 = numUser / 100 % 10;
    int num4 = numUser / 1000 % 10;
    int num5 = numUser / 10000 % 10;

    if(num1==num5||num2==num4)
    {
        Console.Write("Your number is palindrome");
    }
    else
        Console.Write("Your number is not palindrome");

}
    
         
Console.Write("Input your five-digit number: ");
int num5dig = Convert.ToInt32(Console.ReadLine());


if(num5dig > 9999 && num5dig < 100000)
    Palindrom(num5dig);

else 
Console.WriteLine("Impossible value!");






