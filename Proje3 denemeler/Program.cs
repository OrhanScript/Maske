class Program
{
    static void Main(string[] args)
    {
        SelamVer();
        SelamVer();
        SelamVer();
        SelamVer();

        PttManager pttManager = new PttManager(new ApplicantManager());

        Console.ReadLine();
    }
    static void SelamVer()
    {
        Console.WriteLine("Merhaba");
    }
}
