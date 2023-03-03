using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace HelloWorld
{
    public class Evaluate 
    {
        public static double EvaluateExpression(string expression)
        {
            // Удаляем пробелы в начале и в конце строки
            expression = expression.Trim();

            // Инициализируем объект-вычислитель математических выражений
            System.Data.DataTable table = new System.Data.DataTable();

            // Вычисляем значение выражения и возвращаем его в виде числа
            return Convert.ToDouble(table.Compute(expression, ""));
        }

    }
}
   

