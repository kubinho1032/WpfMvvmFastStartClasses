using WarsztatWpf.Infrastructure;

namespace WarsztatWpf
{

    public class RibbonViewModelBase
    {
        private ViewModelBase contentViewModel;
        public ViewModelBase ContentViewModel
        {
            get { return contentViewModel; }
            set { contentViewModel = value; }
        }
        public RibbonViewModelBase()
        {
        }    
    }
}
