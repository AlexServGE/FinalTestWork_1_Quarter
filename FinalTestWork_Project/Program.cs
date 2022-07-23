

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
    string [] resultArray = new string[j];
    return resultArray;
}