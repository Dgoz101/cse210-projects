public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 10, 31), 30, 3.0),
            new Cycling(new DateTime(2024, 11, 28), 45, 12.0),
            new Swimming(new DateTime(2024, 12, 25), 60, 100)
        };
  
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}