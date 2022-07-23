

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
            i = i + 1;
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
    if (someArray.Length == 1)
    {
        Console.Write(someArray[0]);
    }
    else
    {
        for (int i = 0; i < someArray.Length; i = i + 1)
        {

            Console.Write($"{someArray[i]}, ");
            if (i + 1 == someArray.Length - 1)
            {
                Console.Write($"{someArray[i + 1]}");
                break;
            }
        }
    }
    Console.WriteLine();
}

string[] userArray1 = { "hello", "2", "world", ":-)" };
string[] userArray2 = { "1234", "1567", "-2", "computer science" };
string[] userArray3 = { "Russia", "Denmark", "Kazan" };

PrintArray(userArray1);
PrintArray(UserArrayElementsWithLt3Symbols(userArray1));

PrintArray(userArray2);
PrintArray(UserArrayElementsWithLt3Symbols(userArray2));

PrintArray(userArray3);
PrintArray(UserArrayElementsWithLt3Symbols(userArray3));