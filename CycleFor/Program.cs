// метод 4 группы, записанный с использованием цикла for

string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)  // "int i = 0" - это так называемая инициализация счётчика
    // "i < count" - проверка условия; + пишется инкремент "i++"
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "ura ");
Console.WriteLine(res);
