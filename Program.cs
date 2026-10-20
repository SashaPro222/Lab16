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

// int[] points = { 4, 7, 2, 9, 5 };

// for (int i = 0; i < points.Length; i++)
// {
//     if (points[i] < 10)
//     {
//         points[i] = points[i] + 1;
//     }

// }

// foreach (int point in points)
// {
//     System.Console.WriteLine(point);
// }

// int[] grades = { 4, 5, 3, 5, 4, 2 };

// for (int i = 0; i < grades.Length - 1; i++)
// {
//     for (int j = 0; j < grades.Length - 1 - i; j++)
//     {
//         if (grades[j] < grades[j + 1])
//         {
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;
//         }

//     }
// }

// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
// }

// int[] GenerateScheduleSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];

//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = i + 1;
//     }

//     return slots
// }

// int[] slots = GenerateScheduleSlots(6);

// foreach (int slot in slots)
// {
//     System.Console.WriteLine(slot);
// }
// int[] GenerateEvenSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];

//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = (i + 1) * 2;
//     }

//     return slots;
// }

// int[] slots = GenerateEvenSlots(6);

// foreach (int slot in slots)
// {
//     System.Console.WriteLine(slot);
// }

// int[] grades = { 4, 5, 3, 5, 4, 2 };
// Array.Sort(grades);

// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
// }

//Вариант A
// int n = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите число:");
// int[] grades = new int[n];

// for (int i = 0; i < n; i++)
// {
//     grades[i] = i + 1;
// }
// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
// }

// Вариант Б
int[] grades = { -1, 5, 9, -9, 4, 9 };
for (int i = 0; i <= grades.Length; i++)
{
    if (grades[i] < 0)
    {
        grades[i] = 0;
    }
}
foreach (int grade in grades)
{
    System.Console.WriteLine(grade);
}