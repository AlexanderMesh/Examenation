
/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
string text = "удалить из строки все слова ( 34, или 38, или 0) длина которых больше трех символов ()";//текст для проверкм программы
//Проверяем программу на примерах:
//string text = "Hello, 2, world, :-";
//string text = "1234, 1567, -2, computer science";
//string text = "Russia, Denmark, Kazan";
Console.WriteLine(text);
string[] text_arr = text.Split(' ');
foreach (string item in text_arr)
{
    if (item.Length > 3) text = text.Replace(item, "");
}
Console.WriteLine(text);
