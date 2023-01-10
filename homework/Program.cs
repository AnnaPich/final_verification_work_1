
//Receiving a message from the user:
string[] DataEntySymbols(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите строку символов: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

//Program:

int size = 4;
string[] array = DataEntySymbols(size);

//string lineFirst = DataEntySymbols("Введите первую строку символов: ");
//string lineSecond = DataEntySymbols("Введите вторую строку символов: ");
//string lineThird = DataEntySymbols("Введите третью строку символов: ");
//string LineFourth = DataEntySymbols("Введите четвертую строку символов: ");

//string [] array = new string [] {lineFirst, lineSecond, lineThird, LineFourth};

Console.Write('[' + string.Join(", ", array) + ']');
Console.WriteLine(array[1]);


