﻿// 2 группа методов
// принимает, но не возвращает

void Method2 (string msg)
{
    Console.WriteLine(msg);
}

// Method2("Текст сообщения");

// существуют еще, так называемые, аргументы именованные, когда явно указано, какому аргументу какое 
// значение мы хотим указать; это бывает очень часто нужно в случае если методы принимают какое-либо количество 
// аргументов, отличное от 1
// Пример:

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Method21("Текст", 4); 
Method21(msg: "Текст", count: 4); // можно указывать, какому аргументу какое значение мы хотим присвоить
// это способ называется "именованные аргументы" - в случае их использования, не обязательно вводить значения 
// по порядку - то есть можно вызвать метод и так: Method21(count: 4, msg: "Текст"); 



