namespace WarsztatWpf.Infrastructure.Menu.ViewModels
{
    public class MenuEditToSelectViewModel : RibbonViewModelBase
    {
        public MenuEditToSelectViewModel() : base()
        {

        }
        public MenuEditToSelectViewModel(ViewModelBase model) : base()
        {
            ContentViewModel = model;
        }
    }
}
