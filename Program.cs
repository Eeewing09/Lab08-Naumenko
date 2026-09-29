// int lessonNumber = 1;
// int totalLessons = 5;
// while (totalLessons >= 1)
// {
//     Console.WriteLine($"Пара           {totalLessons}");
//     totalLessons--;
// }
// Console.WriteLine("Пары закончились");

// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int occ = 0;
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята: {grade}");
//     grade = int.Parse(Console.ReadLine());
//     occ++;
// }
// Console.WriteLine("Ввод завершен");
// Console.WriteLine($"Всего оценок введено {occ}");

// int sum = 0;
// int count = 0;
// int grade1 = 0;
// int maks = 0;

// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// while (grade != -1)
// {
//     sum += grade;
//     count++;
//     grade = int.Parse(Console.ReadLine());
//     if (grade >= grade1)
//     {
//         maks = grade;
//     }
//     grade1 = grade;

// }

// if (count > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }
// Console.WriteLine($"Макс балл {maks}");

string correctPassword = "qwerty123";
int count = 0;

while (true) {
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword) {
        Console.WriteLine("Доступ разрешён");
        break;
    }

    Console.WriteLine("Неверный пароль, попробуйте снова");
    count++;
}
Console.WriteLine($"Кол-во неверных попыток {count}");