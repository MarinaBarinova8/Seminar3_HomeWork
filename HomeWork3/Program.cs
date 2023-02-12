// Задача 3(23). Напишите программу, которая принимает за вход
// число (N) и выдает таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Quards(int uN)
{
    int current = 1;
    while (current <= uN)
    {  
        int res = current * current * current; 
    
        Console.Write ($" {res},"); 

        current++;

    }

    Console.WriteLine(" \b\b ");
}
Console.Write("Input your  number:  ");
int user_number = Convert.ToInt32(Console.ReadLine());
if (user_number >= 1)
{
   Console.Write($"{user_number} -> "); 
   Quards(user_number);
}

else 
Console.Write("It's impossible value!");