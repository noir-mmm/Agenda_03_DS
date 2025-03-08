using MauiAppMinhasCompras.Helpers;

namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {

        static SQliteDatabaseHelper _db;
        //campo

        public static SQliteDatabaseHelper Db
        {
            get
            {
                if(_db == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_compras.db3");

                    _db = new SQliteDatabaseHelper(path);
                }

                return _db;
            }
        
        }
        //propriedade
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.ListaProduto());

        }

        //protected override Window CreateWindow(IActivationState? activationState)
        //{
        // return new Window(new AppShell());
        //}
    }
}