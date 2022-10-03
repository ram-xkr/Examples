//Вид 1. Ничего не принимает, ничего не возвращает

void Method1()
{
    Console.WriteLine("Автор ...");
}

//Method1();


//Вид 2. Ничего не принимают и ничего не возвращают

void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method2(msg: "Текст", count: 4);


//Вид 3. Что-то возвращают, но ничего не принимают.

int Method3()
{
    return DateTime.Now.Year;
}

//int year = Method3();
//Console.WriteLine(year);


//Вид 4. Что-то принимают, что-то возвращают.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z ");
Console.WriteLine(res);

