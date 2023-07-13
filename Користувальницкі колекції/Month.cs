namespace Користувальницкі_колекції;

public class Month
{
    public string? MonthName { get; set; }
    public int Index { get; set; }
    public uint NumberOfDays { get; set; }

    public Month(string? monthName, int index, uint numberOfDays)
    {
        MonthName = monthName;
        Index = index;
        NumberOfDays = numberOfDays;
    }
}