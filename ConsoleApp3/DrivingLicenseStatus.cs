namespace LicenseApplication;

public class DrivingLicenseStatus : LogicalPair
{
    private Random randomizer;

    public DrivingLicenseStatus(bool theoryPassed, bool practicePassed) 
        : base(theoryPassed, practicePassed)
    {
        randomizer = new Random();
    }
        
    public void PassTheory()
    {
        FirstValue = true;
        Console.WriteLine("Экзамен по теории успешно сдан.");
    }
        
    public void PassPractice()
    {
        if (FirstValue)
        {
            SecondValue = true;
            Console.WriteLine("Экзамен по практике успешно сдан.");
        }
        else
        {
            Console.WriteLine("Нельзя сдавать практику, пока не сдана теория");
        }
    }
    public void IssueLicense()
    {
        if (CalculateConjunction())
        {
            int part1 = randomizer.Next(1000, 9999);
            int part2 = randomizer.Next(100000, 999999);
            Console.WriteLine("Водительское удостоверение выдано, номер: " + part1 + " " + part2);
        }
        else
        {
            Console.WriteLine("Необходимо сдать оба экзамена.");
        }
    }
}