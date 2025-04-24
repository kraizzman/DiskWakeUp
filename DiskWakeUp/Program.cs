namespace DiskWakeUp;

internal static class Program
{
    public static void Main(string[] args)
    {
        const string fileName = "WakeUp.tmp";
        var delay = int.Parse(args[1]);
        
        var path = Path.Combine(args[0], fileName);
        
        Console.WriteLine($"{path} will be updated every {delay} seconds.");
        
        if (!File.Exists(path))
            File.Create(path);
        while (true)
        {
            Thread.Sleep(delay * 1000);
            File.SetLastWriteTime(path, DateTime.Now);
        }
    }
}