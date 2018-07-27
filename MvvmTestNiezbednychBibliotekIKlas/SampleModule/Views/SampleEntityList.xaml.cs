using System.Windows.Controls;
using WarsztatWpf.Modules.SampleModule.ViewModels;

namespace WarsztatWpf.Modules.Customers.Views
{
    /// <summary>
    /// Interaction logic for CustomersList.xaml
    /// </summary>
    public partial class SampleEntityList : Page
    {
        public SampleEntityList()
        {
            InitializeComponent();
            this.DataContext = new SampleEntityListViewModel();
        }
        public SampleEntityList(SampleEntityListViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
