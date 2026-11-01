<<<<<<< HEAD
﻿// Console.WriteLine("Сколько студентов в группе? ");
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
=======
﻿Console.WriteLine("Сколько студентов в группе? ");
int studentsCount = int.Parse(Console.ReadLine());
int[] grades = new int[studentsCount];
int sred = 0;
int res = 0;

for (int i = 0; i < grades.Length;i++)
{
    System.Console.WriteLine($"Оценка студента {i + 1}: ");
    grades[i] = int.Parse(Console.ReadLine());
    sred += grades[i];
    res = sred / (i + 1);
}
System.Console.WriteLine($"Средний балл группы: {res}");
foreach (int grade in grades)
{
    System.Console.WriteLine(grade);
}

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
>>>>>>> 9740300 (Lab16:Individual Assignment)

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

<<<<<<< HEAD
//     return slots
=======
//     return slots;
>>>>>>> 9740300 (Lab16:Individual Assignment)
// }

// int[] slots = GenerateScheduleSlots(6);

<<<<<<< HEAD
=======

>>>>>>> 9740300 (Lab16:Individual Assignment)
// foreach (int slot in slots)
// {
//     System.Console.WriteLine(slot);
// }
<<<<<<< HEAD
=======
// System.Console.WriteLine();
>>>>>>> 9740300 (Lab16:Individual Assignment)
// int[] GenerateEvenSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];

//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = (i + 1) * 2;
//     }

//     return slots;
// }

<<<<<<< HEAD
// int[] slots = GenerateEvenSlots(6);

// foreach (int slot in slots)
// {
//     System.Console.WriteLine(slot);
=======
// int[] slotss = GenerateEvenSlots(6);

// foreach (int slote in slotss)
// {
//     System.Console.WriteLine(slote);
>>>>>>> 9740300 (Lab16:Individual Assignment)
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
<<<<<<< HEAD
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
=======
// int[] grades = { -1, 5, 9, -9, 4, 9 };
// for (int i = 0; i < grades.Length; i++)
// {
//     if (grades[i] < 0)
//     {
//         grades[i] = 0;
//     }
// }
// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
// }

//Вариант 2

// int[] mass = { 1, 3, 6, 7, 4, 9, 12, 0, 2 };
// for (int i = 0; i < mass.Length; i++)
// {
//     if (mass[i] % 3 == 0)
//     {
//         mass[i] = -1;
//     }
// }
// foreach (int mas in mass)
// {
//     System.Console.WriteLine(mas);
// }

//Вариант 3

// string[] name = { "Саша", "Настя", "Лена", "Аделина", "Ярик" };
// for (int i = 0; i < name.Length - 1; i++)
// {
//     for (int j = 0; j < name.Length - 1 - i; j++)
//     {
//         if (string.Compare(name[j], name[j + 1]) > 0)
//         {
//             string temp = name[j];
//             name[j] = name[j + 1];
//             name[j + 1] = temp;
//         }

//     }
// }

// foreach (string names in name)
// {
//     System.Console.WriteLine(names);
// }
>>>>>>> 9740300 (Lab16:Individual Assignment)
