string[] array = {"Hello", "2", "world", ":-)"};
PrintArray(array);
System.Console.WriteLine("\n");
PrintArray(NewArrayThriChar(array));



void PrintArray(string[] matr){
    for (int i = 0; i < matr.Length; i++)
    {
        System.Console.Write($"({matr[i]}), ");
    }
}

string[] NewArrayThriChar(string[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3){
            count++;
        }
    }
    string[] result = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3){
            result[j] = array[i];
            j++;
        }
    }
    return result;
}