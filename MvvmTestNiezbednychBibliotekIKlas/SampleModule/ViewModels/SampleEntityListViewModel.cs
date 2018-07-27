using MvvmTestNiezbednychBibliotekIKlas.SampleModule;
using WarsztatWpf.Infrastructure;

namespace WarsztatWpf.Modules.SampleModule.ViewModels
{
    public class SampleEntityListViewModel : ListViewModelBase<SampleEntity>
    {
        private SampleEntity selectedKlient;

        public SampleEntity SelectedKlient
        {
            get { return selectedKlient; }
            set { SetProperty(ref selectedKlient,value); RaisePropertyChanged("SelectedKlient"); }
        }

        public SampleEntityListViewModel()
        {
            ViewName = "SampleEntity";


        }
        public SampleEntityListViewModel(bool loadSubMenuToSelectEntity):base(loadSubMenuToSelectEntity)
        {
            ViewName = "SampleEntity";

        }

        protected override void Delete(object obj)
        {
            //(SelectedEntity as Klienci).Aktywny = false;
            //base.Delete(obj);
        }

        #region Filter
        private string surnameFilter;

        public string SurnameFilter
        {
            get { return surnameFilter; }
            set { SetProperty(ref surnameFilter,value); }
        }

        private string forenameFilter;

        public string ForenameFilter
        {
            get { return forenameFilter; }
            set { SetProperty(ref forenameFilter, value); }
        }

        protected override void OnFilterCommand()
        {
            string where = "1=1 ";
            if (ForenameFilter != null)
            {
                where += string.Format("and UPPER(Imie) like '%{0}%' ", ForenameFilter.ToUpper());
            }

            if (SurnameFilter != null)
            {
                where += string.Format("and UPPER(Nazwisko) like '%{0}%' ", SurnameFilter.ToUpper());
            }

           // Entities = (adoRepository as KlienciRepository).GetAll(where);
        }

        protected override void OnClearFilterCommand()
        {
            //Entities = adoRepository.GetAll();
            //ForenameFilter = null;
            //SurnameFilter = null;
        }
        #endregion
    }
}
