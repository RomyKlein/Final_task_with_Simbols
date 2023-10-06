string[] GetArrayStringConsole (string inConsolSimb)
{
    string[] arraySimb = new string[inConsolSimb.Length];
    arraySimb = inConsolSimb.Split(",");
    return arraySimb;
}

string[] GetArraySort (string[] array)
{
    int count = 0;
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string simb = array[i];
        if (simb.Length <= 3)
        {
            count++;
        }
    }
    string[] arrayPerfSimb = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string simb = array[i];
        if (simb.Length <= 3)
        {
            arrayPerfSimb[j] = simb;
            j++;
        }
    }
    return arrayPerfSimb;
}

void Print (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]}, ");
    }
}

Console.Write ("Please print your elements with split (,): ");
string userSimbols = Console.ReadLine();
string[] arraySimb = GetArrayStringConsole(userSimbols);
Console.Write ();
Console.Write ("Your elements were sorted and now you've got new string with elements that have got 3 or less simbols in it: ");
Print (GetArraySort (arraySimb));


