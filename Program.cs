// Console.WriteLine("Сколько студентов в группе? ");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];
// int sred = 0;
// int res = 0;

// for (int i = 0; i < grades.Length;i++)
// {
//     System.Console.WriteLine($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
//     sred += grades[i];
//     res = sred / (i + 1);
// }
// System.Console.WriteLine($"Средний балл группы: {res}");
// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
// }

int[] points = { 4, 7, 2, 9, 5 };

for (int i = 0; i < points.Length; i++)
{
    if (points[i] < 10)
    {
        points[i] = points[i] + 1;
    }
    
}

foreach (int point in points)
{
    System.Console.WriteLine(point);
}

