//Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

System.Console.WriteLine("Введите размер массива:");
string input;
int size;
do{
  input  = Console.ReadLine(); 
}
while (!int.TryParse(input, out size));
size = int.Parse(input);

int[] CreateArray (int size){
    int [] array = new int [size];
    Random rand = new Random();

    for (int i = 0; i < size; i++){
        array[i] = rand.Next(1, 100);
    }
    return array;
}

void ShowElements (int[] array){
    if (array.Length == 0)
        return;
    
    System.Console.Write($"{array[array.Length - 1]}\t");
    int[] result = new int[array.Length - 1];
    Array.Copy(array, result, array.Length-1);

    ShowElements(result);
}
int[] ints = CreateArray(size);

foreach (int e in ints){
    System.Console.Write($"{e}\t");
}
System.Console.WriteLine();
ShowElements(ints);