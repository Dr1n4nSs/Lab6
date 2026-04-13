using System;

namespace LicenseApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Тестирование системы ГИБДД ===");
            
            DrivingLicenseStatus status = new DrivingLicenseStatus(false, false);
            
            Console.WriteLine("\n Текущий статус: " + status.ToString());
            
            Console.WriteLine("\nПопытка сдать практику сразу:");
            status.PassPractice();
            
            Console.WriteLine("\n Текущий статус: " + status.ToString());
            
            Console.WriteLine("\nСдаем теорию:");
            status.PassTheory();
            
            Console.WriteLine("\nПопытка получить права:");
            status.IssueLicense();

            Console.WriteLine("\n Текущий статус: " + status.ToString());
            
            Console.WriteLine("\nСдаем практику:");
            status.PassPractice();
            
            Console.WriteLine("\n Текущий статус: " + status.ToString());
            
            Console.WriteLine("\nФинальный статус: " + status.ToString());
            status.IssueLicense();
            
            DrivingLicenseStatus archiveCopy = new DrivingLicenseStatus(status.FirstValue, status.SecondValue);
            Console.WriteLine("\nКопия создана: " + archiveCopy.ToString());
            status.IssueLicense();
            
        }
    }
}