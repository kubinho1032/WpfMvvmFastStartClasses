using System;
using System.Threading;
using System.Windows;
using WarsztatWpf.Infrastructure;

namespace WarsztatWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            instance = this;
            this.DataContext = new MainWindowViewModel();
        }

        private static MainWindow instance;

        public static MainWindow Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainWindow();
                }
                return instance;
            }
        }

        //protected override void OnClosed(EventArgs e)
        //{
        //    instance = null;          
            

        //    CustomPrincipal customPrincipal = Thread.CurrentPrincipal as CustomPrincipal;
        //    if (customPrincipal != null)
        //    {
        //        customPrincipal.Identity = new AnonymousIdentity();
        //        base.OnClosed(e);
        //        AuthorizationView.Instance.Show();
        //    }
        //}
    }
}
