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

namespace WarsztatWpf
{
    /// <summary>
    /// Interaction logic for HeaderTabView.xaml
    /// </summary>
    public partial class HeaderTabView : Page
    {
        public HeaderTabView()
        {
            InitializeComponent();
            instance = this;
        }

        public HeaderTabView(string text)
        {
            InitializeComponent();
            instance = this;
            this.headerLabel.Content = text;
        }
        private static HeaderTabView instance;

        public static HeaderTabView Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HeaderTabView();
                }
                return instance;
            }
        }

        public static void ClearHeader()
        {
            Instance.headerLabel.Content = "";
        }
    }
}
