using System.Windows.Controls;
using WarsztatWpf.Infrastructure.Menu.ViewModels;

namespace WarsztatWpf.Infrastructure.Menu.Views
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
            this.DataContext = new MainMenuViewModel();
        }
        //public MainMenu(ViewModelBase model)
        //{
        //    InitializeComponent();
        //    this.DataContext = new MainMenuViewModel(model);

        //}
    }
}
