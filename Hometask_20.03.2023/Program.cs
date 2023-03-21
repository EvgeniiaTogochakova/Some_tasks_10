// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int GetValueFromUser(string text)
{
    int value = 0;
    bool flag = false;
    while (!flag)
    {
        Console.WriteLine(text);
        flag = int.TryParse(Console.ReadLine(), out value);
    }
    return value;
}

string GetStringsFromUser(string text, int count)
{
    Console.WriteLine(text);
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1) result += Console.ReadLine();
        else result += Console.ReadLine() + ", ";

    }
    return result;
}

string NewStrings3CharsOrLess(string[] oldStrings)
{
    string result = string.Empty;
    for (int i = 0; i < oldStrings.Length; i++)
    {
        if (oldStrings[i].Length <= 3) 
        {
            result += oldStrings[i] + " ";
        }
    }
    return result;
}

int myCount = GetValueFromUser("Введите количество элементов в вашем массиве строк: ");
string getStrings = GetStringsFromUser("Введите, пожалуйста, наборы символов, разделяя каждый набор с помощью Enter", myCount);
Console.WriteLine("Вот ваши исходные данные");
Console.WriteLine("[" + getStrings + "]");
string[] s = getStrings.Split(", ").ToArray();

Console.WriteLine("Готовлю массив из тех строк, длина которых меньше или равна трем символам");
string myRes = "[" + NewStrings3CharsOrLess(s) + "]";
Console.WriteLine(myRes);

