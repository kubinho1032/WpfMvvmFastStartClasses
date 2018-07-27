using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarsztatWpf.Infrastructure.Menu.ViewModels
{
    public class MenuListToSelectViewModel:RibbonViewModelBase
    {
        public MenuListToSelectViewModel() : base()
        {

        }
        public MenuListToSelectViewModel(ViewModelBase model) : base()
        {
            ContentViewModel = model;
        }
    }
}
