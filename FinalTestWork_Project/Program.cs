

string[] UserArrayElementsWithLt3Symbols(string[] userArray)
{
    string[] subresultArray = new string[userArray.Length];
    int i = 0, j = 0;
    while (i < userArray.Length)
    {
        if (userArray[i].Length > 3)
        {
            i = i + 1;
            continue;
        }
        else
        {
            subresultArray[j] = userArray[i];
            j = j + 1;
        }
    }
    string[] resultArray = new string[j];
    i = 0;
    while (i < j)
    {
        resultArray[i] = subresultArray[i];
        i = i + 1;
    }
    return resultArray;
}

void PrintArray(string[] someArray)
{
    for (int i = 0; i < someArray.Length; i = i + 1)
    {
        Console.Write($"{someArray[i]}, ");
        if (i + 1 == someArray.Length - 1)
        {
            Console.Write($"{someArray[i]}, ");
            break;
        }
    }
}

string[] userArray1 = { };
string[] userArray2 = { };
string[] userArray3 = { };
string[] userArray4 = { };

