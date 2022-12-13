//Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да

int n = 14212;
int[] array = { 1, 4, 2, 1, 2 };


if (array[0] == array[4])
{
    if (array[1] == array[3]) ;
    Console.WriteLine($"Число: {n} является палиндромом");
}
else
{
    Console.WriteLine($"Число: {n} не является палиндромом");
}

int m = 12821;
int[] arrayM = { 1, 2, 8, 2, 1 };

if (arrayM[0] == arrayM[4])
{
    if (arrayM[1] == arrayM[3]) ;
    Console.WriteLine($"Число: {m} является палиндромом");
}
else
{
    Console.WriteLine($"Число: {m} не является палиндромом");
}
