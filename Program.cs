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

int sum = 0;
int count2 = 0;
int grade1 = 0;
int maks = 0;

Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
while (grade != -1)
{
    sum += grade;
    count2++;
    grade = int.Parse(Console.ReadLine());
    if (grade >= grade1)
    {
        maks = grade;
    }
    grade1 = grade;

}

if (count2 > 0)
{
    Console.WriteLine($"Средний балл: {(double)sum / count2}");
}
else
{
    Console.WriteLine("Оценок не было введено");
}
Console.WriteLine($"Макс балл {maks}");

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

// string answer;

// do {
//     Console.Write("Введите дату посещения (например, 01.09): ");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");

//     Console.Write("Добавить ещё одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");

// Console.WriteLine("Дневник сохранён");
// Задача А
// Console.WriteLine("Введите число:");
// int num = int.Parse(Console.ReadLine());
// int count = 1;
// while (count <= 10)
// {
//     Console.WriteLine($"{num} * {count} = {count * num}");
//     count++;
// }
// // Задача Г
// Console.WriteLine("Введите число:");
// while (true)
// {
//     int count1 = int.Parse(Console.ReadLine());
//     if (count1 % 7 == 0)
//     {
//         Console.WriteLine("Найдено!");
//         break;
//     }
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");
// Задача 2
// int count = int.Parse(Console.ReadLine());
// int sum1 = 0;
// while (true)
// {
//     if (count > 0)
//     {
//         sum1 = sum1 + count;
//     }

//     if (count == 0)
//     {
//         Console.WriteLine("Конец");
//         break;
//     }
//     count = int.Parse(Console.ReadLine());
// }
// Console.WriteLine(sum1);

// // Задача 10
// int score = int.Parse(Console.ReadLine());
// int eq5 = 0;
// while (true)
// {
//     if (score / 5 == 1)
//     {
//         eq5 += 1;
//     }
//     if (score == -1)
//     {
//         break;
//     }
//     score = int.Parse(Console.ReadLine());
// }
// Console.WriteLine(eq5);

// string password = "engine2";
// int attempts = 0;
// int money = 0;
// int money_s = 0;
// string pass1 = "";
// bool isAuthorized = false;
// while (attempts < 3)
// {
//     Console.Write("Введите код: ");
//     pass1 = Console.ReadLine();

//     if (pass1 == password)
//     {
//         isAuthorized = true;
//         break;
//     } else
//     {
//         attempts++;
//     }
// }

// if (isAuthorized == false)
// {
//     Console.WriteLine("Карта заблокирована");
// }
// else
// {
//     while (true)
//     {
//         Console.Write("Введите сумму снятия (или 0 для выхода): ");
//         money = int.Parse(Console.ReadLine());
//         money_s += money;
//         if (money == 0)
//         {
//             break;
//         }
//     }
//     Console.WriteLine($"Итоговая снятая сумма: {money_s}");
// }