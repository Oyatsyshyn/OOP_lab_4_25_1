using System;

namespace OOP_lab_4_25_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Iм'я: ");
            student.Name = Console.ReadLine();

            Console.Write("Прiзвище: ");
            student.LastName = Console.ReadLine();

            Console.Write("Група: ");
            student.Group = Console.ReadLine();

            Console.Write("Рiк: ");
            student.Year = int.Parse(Console.ReadLine());

            Console.Write("Адреса проживання: ");
            student.Adress = Console.ReadLine();

            Console.Write("Паспорт: ");
            student.Passport = Console.ReadLine();

            Console.Write("Вiк: ");
            student.Age = int.Parse(Console.ReadLine());

            Console.Write("Номер телефону: ");
            student.Telephon = Console.ReadLine();

            Console.Write("Рейтинг: ");
            student.Rating = int.Parse(Console.ReadLine());

            Console.WriteLine(Student.StudentRating(student.Rating));
        }
    }
}
