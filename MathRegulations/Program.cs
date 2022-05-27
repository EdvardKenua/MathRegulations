using System;
using AngouriMath;
using System.Collections.Generic;

namespace FromStringToMath // Note: actual namespace depends on the project name.
{
    class ConverterExpression
    {
        private string rawExpression;
        private string numExpression;
        private string result;
        public string RawExpression
        {
            get { return rawExpression; }
            set { rawExpression = value; }
        }
        public string Result
        {
            get { return result; }
        }
        public string NumExpression
        {
            get { return numExpression; }
        }
        private Dictionary<string, string> Variables;
        public List<string> ListKeys;

        public ConverterExpression(string rawExpression)
        {
            this.rawExpression = rawExpression;
            ListKeys = FindVariables();

        }

        private void SetResultVariable(string Variable) 
        {
            
        }

        public double GetResult()
        {
            return 0.0;
        }
        /// <summary> Работа с библиотекой Angouri
        private void ConvertToAngouri() 
        {
           // Строит выражение для конвертации
        }
        private void BuildExpression() 
        {
            // Преобразует выражение
        }
        /// </summary>
        
        private List<string> FindVariables() 
        {
            // Находит буквы и заносит их в список
            List<string> letters = new List<string>();
            foreach (char item in rawExpression)
            {
                // узнаем какие символы у нас записаны
                if (Char.IsLetter(item) == true)
                {
                    letters.Add(item.ToString());
                }
            }
            return letters; 
        }
        private void SetKeys(List<string> Keys) 
        {
            // Устанавливает значения ключей из списка 2
        }
        public void SetKeysWithVariables(Dictionary<string,string> keyValuePairs) 
        {
            Variables = keyValuePairs;
        }


    }

    internal class Program
    {   
        public static void Main()
        {
            string expression = "x = a + b";
            var Converter = new ConverterExpression(expression);
            var dict = new Dictionary<string, string>();
            foreach (var key in Converter.ListKeys)
            {
                Console.Write($"Введите значение для: {key}");
                string value = Console.ReadLine();
                dict.Add(key, value);
            }
            Converter.SetKeysWithVariables(dict);
        }
    }
}