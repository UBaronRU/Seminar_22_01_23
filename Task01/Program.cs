// See https://aka.ms/new-console-template for more information

string Replace( string text, char oldVl, char newVl)
{
    string Result = String.Empty;
    int Len = text.Length;
    for (int i = 0; i < Len; i++)
    {
        if (text[i] == oldVl) Result = Result + $"{newVl}";
        else Result = Result  + $"{text[i]}";
    }
    return Result;
}
string text = "Сегодня мы углубимся в тему и выделим 4 основных группы методов, а также будем"+
            " использовать их на практике. И познакомимся с новыми языковыми конструкциями, в "+
            "частности, циклом.";
string newText = Replace (text, ' ', '-');
Console.WriteLine(newText);