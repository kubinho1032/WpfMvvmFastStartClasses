using WarsztatWpf.Infrastructure;

namespace WarsztatWpf
{
    public class MenuEditViewModel:RibbonViewModelBase
    {
        public MenuEditViewModel() : base()
        {

        }
        public MenuEditViewModel(ViewModelBase model):base()
        {
            ContentViewModel = model;
        }
    }
}
