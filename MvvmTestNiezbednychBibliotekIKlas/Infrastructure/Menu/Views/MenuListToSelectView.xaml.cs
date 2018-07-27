using System.Windows.Controls;
using WarsztatWpf.Infrastructure;
using WarsztatWpf.Infrastructure.Menu.ViewModels;

namespace WarsztatWpf
{
    /// <summary>
    /// Interaction logic for MenuListToSelectView.xaml
    /// </summary>
    public partial class MenuListToSelectView : Page
    {
        public MenuListToSelectView()
        {
            InitializeComponent();
            this.DataContext = new MenuListToSelectViewModel();
        }
        public MenuListToSelectView(ViewModelBase model)
        {
            InitializeComponent();
            this.DataContext = new MenuListToSelectViewModel(model);

        }
    }
}
