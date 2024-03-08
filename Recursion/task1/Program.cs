//Задача 1: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N.
//Использовать рекурсию, не использовать циклы.

int m = 8;
int n = 100;

void PrintNumbers(int min, int max){
    if (max < min){
        return;
    }
    
    PrintNumbers(min, max - 1);
    System.Console.Write($"{max} ");
}

PrintNumbers(m, n);