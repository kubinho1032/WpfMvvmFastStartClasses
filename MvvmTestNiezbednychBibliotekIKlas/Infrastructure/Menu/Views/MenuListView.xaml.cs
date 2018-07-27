using System.Windows.Controls;
using WarsztatWpf.Infrastructure;

namespace WarsztatWpf
{
    /// <summary>
    /// Interaction logic for MenuListView.xaml
    /// </summary>
    public partial class MenuListView : Page
    {
        public MenuListView()
        {
            InitializeComponent();
            this.DataContext = new MenuListViewModel();
        }
        public MenuListView(ViewModelBase model)
        {
            InitializeComponent();
            this.DataContext = new MenuListViewModel(model);

        }
    }
}
