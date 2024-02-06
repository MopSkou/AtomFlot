namespace AtomFlot;

public partial class App : Application
{
    public const string DATABASE_NAME = "Berthing.db";
    public static AtomFlotRepository database;
    public static AtomFlotRepository Database
    {
        get
        {
            if (database == null)
            {
                database = new AtomFlotRepository(
                    Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
            }
            return database;
        }
    }
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
    }
}
