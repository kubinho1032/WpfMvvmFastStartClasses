using WarsztatWpf.Infrastructure;

namespace WarsztatWpf
{
    public class MenuListViewModel : RibbonViewModelBase
    {
       
        public MenuListViewModel() : base()
        {

        }
        public MenuListViewModel(ViewModelBase model):base()
        {
            ContentViewModel = model;
        }

    }
}
