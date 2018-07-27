using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WarsztatWpf.Infrastructure.Menu.ViewModels;

namespace WarsztatWpf.Infrastructure.Menu.Views
{
    /// <summary>
    /// Interaction logic for MenuEditToSelectView.xaml
    /// </summary>
    public partial class MenuEditToSelectView : Page
    {
        public MenuEditToSelectView()
        {
            InitializeComponent();
            this.DataContext = new MenuEditToSelectViewModel();
        }
        public MenuEditToSelectView(ViewModelBase model)
        {
            InitializeComponent();
            this.DataContext = new MenuEditToSelectViewModel(model);

        }
    }
}
