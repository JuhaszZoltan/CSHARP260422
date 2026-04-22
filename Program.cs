namespace CSHARP260422;

public static class Program
{
    public const string ConnectionString = "server=(localdb)\\mssqllocaldb;database=people;";

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmContactList());
    }
}