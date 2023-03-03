
using HelloWorld;

public class ReadFromFile : Evaluate
{
    static void Main(string[] args)
    {


        // Считываем содержимое файла
        string text = System.IO.File.ReadAllText(@"D:\readText\WriteText.txt");

        
        // Разбиваем содержимое файла на массив строк
        string[] lines = text.Split('\n');

        
        // Проходим по всем строкам файла
        foreach (string line in lines)
        {
            // Выполняем математическую операцию над примером и выводим результат в консоль
            Console.WriteLine(line + " = " + EvaluateExpression(line));
        }

    }
}
