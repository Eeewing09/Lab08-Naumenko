// int lessonNumber = 1;
// int totalLessons = 5;
// while (totalLessons >= 1)
// {
//     Console.WriteLine($"Пара           {totalLessons}");
//     totalLessons--;
// }
// Console.WriteLine("Пары закончились");

Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int occ = 0;
int grade = int.Parse(Console.ReadLine());

while (grade != -1)
{
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
    occ++;
}
Console.WriteLine("Ввод завершен");
Console.WriteLine($"Всего оценок введено {occ}");

