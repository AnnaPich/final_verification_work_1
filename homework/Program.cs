
//Receiving a message from the user:
string[] DataEntySymbols(int sizeArray)
{
    string[] array = new string[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        Console.Write("Введите строку символов: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

//Program:

int sizeArray = 4;
string[] array = DataEntySymbols(sizeArray);
Console.Write('[' + string.Join(", ", array) + ']');

string[] newArray = new string[sizeArray];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    } 
}   
Console.Write(" -> " + '[' + string.Join(", ", newArray) + ']');
