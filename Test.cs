using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var questions = new List<Question>
        {
            new Question("Что такое пространство имен (namespace) в C#?", new[] { "Коллекция классов", "Библиотека функций", "Тип данных" }, 0),
            new Question("Какой метод является точкой входа для C# приложения?", new[] { "main()", "start()", "run()" }, 0),
            new Question("Какой оператор используется для создания экземпляра класса?", new[] { "new", "this", "class" }, 0),
            new Question("Какой тип данных используется для хранения булевых значений?", new[] { "int", "char", "bool" }, 2),
            new Question("Какой модификатор доступа позволяет методу быть доступным только внутри своего класса?", new[] { "public", "private", "protected" }, 1),
            new Question("Что такое инкапсуляция в C#?", new[] { "Процесс объединения данных и функций в одном объекте", "Процесс создания новых типов данных", "Процесс преобразования одного типа данных в другой" }, 0),
            new Question("Какой ключевое слово используется для объявления константных переменных?", new[] { "var", "const", "static" }, 1),
            new Question("Что такое перегрузка методов (method overloading) в C#?", new[] { "Изменение поведения метода в производном классе", "Определение нескольких методов с одним и тем же именем, но с разными параметрами", "Определение метода в интерфейсе" }, 1),
            new Question("Какой оператор используется для обработки исключений в C#?", new[] { "throw", "catch", "finally" }, 1),
            new Question("Что такое делегат в C#?", new[] { "Объект, который указывает на метод", "Тип данных", "Класс" }, 0)
        };

        foreach (var question in questions)
        {
            Console.WriteLine(question.Text);
            for (var i = 0; i < question.Answers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {question.Answers[i]}");
            }
            Console.Write("Ваш ответ: ");
            var userAnswer = Console.ReadLine();
            var isCorrect = question.CheckAnswer(int.Parse(userAnswer) - 1);
            Console.WriteLine(isCorrect ? "Правильно!" : "Неправильно!");
            Console.WriteLine();
        }
    }
}

public class Question
{
    public string Text { get; }
    public string[] Answers { get; }
    private int CorrectAnswer { get; }

    public Question(string text, string[] answers, int correctAnswer)
    {
        Text = text;
        Answers = answers;
        CorrectAnswer = correctAnswer;
    }

    public bool CheckAnswer(int answer)
    {
        return answer == CorrectAnswer;
    }
}
