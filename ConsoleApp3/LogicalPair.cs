namespace LicenseApplication;

public class LogicalPair
{
    private bool firstValue;
    private bool secondValue;

    public LogicalPair(bool first, bool second)
    {
        firstValue = first;
        secondValue = second;
    }
        
    public LogicalPair(LogicalPair other)
    {
        if (other != null)
        {
            firstValue = other.firstValue;
            secondValue = other.secondValue;
        }
    }

    public bool FirstValue
    {
        get { return firstValue; }
        set { firstValue = value; }
    }

    public bool SecondValue
    {
        get { return secondValue; }
        set { secondValue = value; }
    }
        
    public bool CalculateConjunction()
    {
        return firstValue && secondValue;
    }

    public override string ToString()
    {
        return string.Format("Теория: " + firstValue + ", Практика: " + secondValue);
    }
}