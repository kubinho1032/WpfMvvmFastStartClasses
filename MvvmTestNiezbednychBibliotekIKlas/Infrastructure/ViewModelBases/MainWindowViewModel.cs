using WarsztatWpf.Infrastructure.Menu.Views;

namespace WarsztatWpf.Infrastructure
{
    public class MainWindowViewModel:ViewModelBase
    {
        public MainWindowViewModel()
        {
            //Identity = (Thread.CurrentPrincipal as CustomPrincipal).Identity;
            //SelectedDatabase = ConnectionStringsHelper.ActiveDatabase;
            //BusyIndicatorViewModel = BusyIndicatorViewModel.Instance;

            MainWindow mw = MainWindow.Instance;
            mw.MainMenuFrame.Navigate(new MainMenu());
                    
        }

        //private BusyIndicatorViewModel busyIndicatorViewModel;
        //public BusyIndicatorViewModel BusyIndicatorViewModel
        //{
        //    get { return busyIndicatorViewModel; }
        //    set { SetProperty(ref busyIndicatorViewModel, value); }
        //}
        //private CustomIdentity identity;

        //public CustomIdentity Identity
        //{
        //    get { return identity; }
        //    set { SetProperty(ref identity, value); }
        //}

        //private string selectedDatabase;

        //public string SelectedDatabase
        //{
        //    get { return selectedDatabase; }
        //    set { SetProperty(ref selectedDatabase, value); }
        //}

    }
}
