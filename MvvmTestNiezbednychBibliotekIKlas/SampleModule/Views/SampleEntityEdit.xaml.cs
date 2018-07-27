using System.Windows.Controls;
using WarsztatWpf.Infrastructure;
using WarsztatWpf.Modules.SampleModule.ViewModels;

namespace WarsztatWpf.Modules.Customers.Views
{
    /// <summary>
    /// Interaction logic for CustomersEdit.xaml
    /// </summary>
    public partial class SampleEntityEdit : Page
    {
        public SampleEntityEdit()
        {
            InitializeComponent();          
            this.DataContext = new SampleEntityEditViewModel();
        }

        public SampleEntityEdit(object data)
        {
            InitializeComponent();
            this.DataContext = new SampleEntityEditViewModel(data);
        }

        public SampleEntityEdit(ViewModelBase viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
