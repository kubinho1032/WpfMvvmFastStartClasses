using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WarsztatWpf.Infrastructure.DbHelper;

namespace WarsztatWpf.Infrastructure
{
    public class ListViewModelBase<T>: ViewModelBase where T:class
    {
        public ListViewModelBase()
        {
            LoadSubMenu();
            //adoRepository= (AdoRepository<T>)Activator.CreateInstance(RepositoriesDictionary.ViewSources[typeof(T)]);
            //repository = new GenericDataRepository<T>();
            //(viewCodeBehindClass as Page).Loaded += ListViewModelBase_Loaded;
            Entities = new ObservableCollection<T>();
            
        }

        public ListViewModelBase(bool loadSubMenuToSelectEntity)
        {
            //adoRepository = (AdoRepository<T>)Activator.CreateInstance(RepositoriesDictionary.ViewSources[typeof(T)]);
            //repository = new GenericDataRepository<T>();
            Entities = new ObservableCollection<T>();
            //this.Bind(x => x.LoadSubMenuToSelect, OnLoadSubMenuToSelect);
            LoadSubMenu(true);

        }



        public ListViewModelBase(
                   string detailsViewName)
            : base()
        {
            //LoadSubMenu();
        }

        private void LoadSubMenu()
        {
            MainWindow mw = MainWindow.Instance;
            mw.SubMenuFrame.Navigate(new MenuListView(this));
        }

        private void LoadSubMenu(bool loadSubMenuToEntitySelect)
        {
            MainWindow mw = MainWindow.Instance;
            mw.listSubMenuFrame.Navigate(new MenuListToSelectView(this));
        }


        #region Properties
        private bool loadSubMenuToSelect;

        public bool LoadSubMenuToSelect
        {
            get { return loadSubMenuToSelect; }
            set { SetProperty(ref loadSubMenuToSelect,value); }
        }

        private bool isFilter=false;

        public bool IsFilter
        {
            get { return isFilter; }
            set { SetProperty(ref isFilter, value); }
        }

        //protected AdoRepository<T> adoRepository;
        //protected IGenericDataRepository<T> repository;
        private ObservableCollection<T> entities;
        public ObservableCollection<T> Entities
        {
            get { return entities; }
            set
            {
                entities = value;
                RaisePropertyChanged("Entities");
            }
        }

        private string _listType = string.Empty;
        public string ListType
        {
            get { return _listType; }
            set
            {
                _listType = value;
                RaisePropertyChanged("ListType");
            }
        }

        private EntityBase _selectedEntity;
        public EntityBase SelectedEntity
        {
            get { return _selectedEntity; }
            set
            {
                _selectedEntity = value;
                RaisePropertyChanged("SelectedEntity");
                OnSelectedEntityChanged();
            }
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                RaisePropertyChanged("IsSelected");
            }
        }
        private string _isEntityToReturnSelected;
        public string IsEntityToReturnSelected
        {
            get { return _isEntityToReturnSelected; }
            set
            {
                SetProperty(ref _isEntityToReturnSelected, value);
            }
        }

        #endregion

        #region Command
        public ICommand DeleteEntityCommand
        {
            get { return new SimpleCommand(Delete); }
        }

        public ICommand AddEntityCommand
        {
            get { return new SimpleCommand(Add); }
        }
        public ICommand EditEntityCommand
        {
            get { return new SimpleCommand(Edit); }
        }
        public ICommand LoadedCommand
        {
            get { return new SimpleCommand(OnLoaded); }
        }
        public ICommand SelectEntityToReturnCommand
        {
            get { return new SimpleCommand(SelectEntityToReturn); }
        }
        public ICommand CloseListCommand
        {
            get { return new SimpleCommand(OnCloseList); }
        }
        public ICommand CloseListToSelectCommand
        {
            get { return new SimpleCommand(OnCloseListToSelect); }
        }

        public ICommand FilterCommand
        {
            get { return new SimpleCommand(OnFilterCommand); }
        }
        public ICommand ClearFilterCommand
        {
            get { return new SimpleCommand(OnClearFilterCommand); }
        }
        public ICommand ShowFilterCommand
        {
            get { return new SimpleCommand(OnShowFilterCommand); }
        }

        private void OnCloseList()
        {
            ClearContentFrame();
            ClearSubMenu();
        }

        public virtual void OnCloseListToSelect()
        {
            ClearSelectListFrame();
        }
        private void SelectEntityToReturn()
        {
            RaisePropertyChanged("IsEntityToReturnSelected");
        }

        protected virtual void OnLoaded()
        {
            //Entities = repository.GetAll();
            //Entities = adoRepository.GetAll();
        }
    
        #endregion

        protected virtual void OnFilterCommand()
        { }

        protected virtual void OnClearFilterCommand()
        { }

        protected void OnShowFilterCommand()
        {
            IsFilter = !IsFilter;
        }

        protected virtual void Delete(object obj)
        {
            try
            {
                if ((SelectedEntity as EntityBase).Id != -1)
                {
                   // repository.Update((SelectedEntity as IEntity));
                    //adoRepository.Update((SelectedEntity as T));
                }
            }
            catch (Exception ee)
            {

            }
        }

        protected virtual void Edit(object obj)
        {
            NavigateTo(ViewName + "Edit", obj);
        }

        protected virtual void Add()
        {
            NavigateTo(ViewName + "Edit");
        }


        public virtual void OnSelectedEntityChanged()
        {
            IsSelected = SelectedEntity != null ? true : false;
        }
        public virtual void OnSelectedEntitiesChanged() { }
        public virtual void OnSelectionMode() { }

        private void OnLoadSubMenuToSelect(object sender, PropertyChangedExtendedEventArgs<bool> e)
        {
            //if(LoadSubMenuToSelect==true) LoadSubMenu(true);

        }
    }
}