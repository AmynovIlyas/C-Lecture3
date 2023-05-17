// Задача:
// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
// заменить большими «К», а большие «С» заменить на маленькие «с».

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// Console.WriteLine(text[5], text [6]); // такой командой можно обратиться к конкретному символу строки 
// (можно использовать не только Console.WriteLine); [] - идентификатор строки

string Replace(string text, char oldValue, char newValue) // изначальная цель - заменить пробелы чёрточками, 
// поэтому oldValue - это символ пробела (' '), а newValue - это символ чёрточки ('_')
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}";
        }
    }
    return result;
}

string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);

