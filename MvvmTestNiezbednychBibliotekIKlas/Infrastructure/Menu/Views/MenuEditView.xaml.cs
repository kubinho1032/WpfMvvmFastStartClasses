using System.Windows.Controls;
using WarsztatWpf.Infrastructure;

namespace WarsztatWpf
{
    /// <summary>
    /// Interaction logic for MenuEditView.xaml
    /// </summary>
    public partial class MenuEditView : Page
    {
        public MenuEditView()
        {
            InitializeComponent();
            this.DataContext = new MenuEditViewModel();
        }
        public MenuEditView(ViewModelBase model)
        {
            InitializeComponent();
            this.DataContext = new MenuEditViewModel(model);
            
        }
    }
}
