using System.Threading;

namespace WarsztatWpf.Infrastructure.Menu.ViewModels
{
    public class MainMenuViewModel : ViewModelBase
    {
        //private DatabaseQueriesTestingService databaseQueriesTestingService;
        public MainMenuViewModel()
        {
            RegisterCommands();
            //databaseQueriesTestingService = new DatabaseQueriesTestingService();
        }


        public SimpleCommand ModuleNavigateCommand { get; set; }


        private void RegisterCommands()
        {
            ModuleNavigateCommand = new SimpleCommand(OnModuleNavigate);
        }


        private string role;

        public string Role
        {
            get { return role; }
            set { SetProperty(ref role, value); }
        }


        private void OnModuleNavigate(object module)
        {
            if (module == null) return;
            NavigateTo((string)module);
        }

        //private void OnLogoutCommand()
        //{
        //    CustomPrincipal customPrincipal = Thread.CurrentPrincipal as CustomPrincipal;
        //    if (customPrincipal != null)
        //    {
        //        customPrincipal.Identity = new AnonymousIdentity();
        //        RaisePropertyChanged("AuthenticatedUser");
        //        RaisePropertyChanged("IsAuthenticated");

                
        //        MainWindow.Instance.Close();
        //        AuthorizationView.Instance.Show();

        //    }
        //}

        
    }
}
