class Quiz
{  
    static void Main()  
    {  
        // Массив вопросов и ответов на них  
        string[,] questions = { {"Сколько будет 2+2?", "4"},  
                                {"Как называется самый большой океан?", "Тихий"},  
                                {"Кто расколол орех Петру Первому во сне?", "Лиза"},  
                                {"Сколько часов в сутках?", "24"} };
         
         string[,] answers = { {"2", "4","5","8"},  
                                {"атлантический", "тихий","индийский","северный"},  
                                {"коля", "оля", "лиза", "дима"},  
                                {"12", "15", "18","24"} };
        
        // счётчики ответов
        int true_answer = 0; 
        int false_answer = 0; 
        // перебираем все вопросы в массиве  
        for (int i = 0; i < questions.GetLength(0); i++)  
        {  
            // выводим очередной вопрос  
            
            //Console.WriteLine($"{i + 1}. {questions[i, 0]}");
           Console.WriteLine( "{0}. {1}", i + 1, questions[i, 0]);
            Console.WriteLine("Варианты ответа:");
           for (int j=0; j < answers.GetLength(1); j++)
           {
            Console.WriteLine($"{j+1}. {answers[i,j]} ");  
           }
             // получаем ответ от пользователя  
            Console.Write("Ответ: ");  
            string answer = Console.ReadLine();  
            // проверяем правильность ответа  переводим в нижний регистр избежав регистровых ошибок
            if (answer.ToLower() == questions[i, 1].ToLower())  
            {  
                Console.WriteLine("Правильно!");  
                true_answer++; 
            }  
            else  
            {  
                Console.WriteLine("Неправильно. Правильный ответ: {0}", questions[i, 1]);  
                false_answer++; 
            }  
        }  
        Console.WriteLine();  
        Console.WriteLine("Викторина завершена. Ваш результат:");  
        Console.WriteLine("Правильных ответов - {0}", true_answer);  
        Console.WriteLine("Неправильных ответов - {0}", false_answer);  
        Console.ReadLine();  
    }  
}