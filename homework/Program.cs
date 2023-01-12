
//Method for getting and outputting a result array:
void ResultArray(string[] array, int maxStringLengh)
{
    string[] newArray = new string[array.Length];
    int newSizeArray = 0;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxStringLengh)
        {
            newArray[j] = array[i];
            j++;
        }
        newSizeArray = j + 1;
    }
    string [] resaltArray = new string [newSizeArray];
    for (int i = 0; i < newSizeArray; i++)
    {
        resaltArray[i] = newArray[i];
    }
    Console.Write(" -> " + '[' + string.Join(", ", resaltArray) + ']');
}


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
int maxStringLengh = 3;
string[] array = DataEntySymbols(sizeArray);
Console.Write('[' + string.Join(", ", array) + ']');

ResultArray(array, maxStringLengh);


