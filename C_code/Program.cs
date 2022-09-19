bool RepetitionCheck(int index,int[] temp)
{
    bool check = true;
    for (int i = 0; i < temp.Length; i++)
    {
        if (index == temp[i])
        check = false;
    }
    return check;
}

string[] FormatArray(string[] array)
{
    int newArrayLenght = new Random().Next(1,4);
    int[] temp = new int[newArrayLenght];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = -1;
    }
    string[] finalArray = new string[newArrayLenght];
    for (int i = 0; i < newArrayLenght; i++)
    {
        int positionInFirstArray = new Random().Next(0,array.Length);
        while(!RepetitionCheck(positionInFirstArray,temp))
        {
            positionInFirstArray = new Random().Next(0,array.Length);
        }
        finalArray[i] = array[positionInFirstArray];
        temp[i] = positionInFirstArray;
    }
    return finalArray;
}

string[] array = {"double","string", "int", "char", "float", "bool", "car", "object"};
string[] finalArray = FormatArray(array);
Console.WriteLine($"[{String.Join(",", finalArray)}]");