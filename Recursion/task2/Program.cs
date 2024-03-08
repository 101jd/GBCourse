//Задача 2: Напишите программу вычисления функции 
//Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int m = 3;
int n = 5; 

int Ack (int m, int n){
    if (m == 0 && n > 0){
        return n + 1;
    }
    else if (n == 0 && m > 0){
        return Ack (m - 1, 1);
    }
    else if (m > 0 && n > 0){
        return Ack(m - 1, Ack(m, n - 1));
    }
    else return 0; // возвращает 0, если хоть одно число отрицательное
}

System.Console.WriteLine(Ack(m, n));