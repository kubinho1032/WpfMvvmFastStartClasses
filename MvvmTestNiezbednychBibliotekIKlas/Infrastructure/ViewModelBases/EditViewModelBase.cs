using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarsztatWpf.Infrastructure.Menu.Views;

namespace WarsztatWpf.Infrastructure
{
    public class EditViewModelBase<T>: ViewModelBase where T : class
    {
        //protected AdoRepository<T> adoRepository;
        //protected IGenericDataRepository<T> repository;
        protected ICollection<System.ComponentModel.DataAnnotations.ValidationResult> results = null;

        public EditViewModelBase()
        {
            //adoRepository = (AdoRepository<T>)Activator.CreateInstance(RepositoriesDictionary.ViewSources[typeof(T)]);
            //repository = new GenericDataRepository<T>();
            LoadSubMenu();
            RegisterCommand();        
        }

        public EditViewModelBase(bool loadSubMenuToSelectEntity)
        {
            //adoRepository = (AdoRepository<T>)Activator.CreateInstance(RepositoriesDictionary.ViewSources[typeof(T)]);
            //repository = new GenericDataRepository<T>();
            LoadSubMenu(true);
            RegisterCommand();
        }

        private void RegisterCommand()
        {
            DoubleClickCommand = new SimpleCommand(OnDoubleClick);
            ButtonSelectCommand = new SimpleCommand(OnSelectButton);
            QuitCommand = new SimpleCommand(OnQuitClick);
            SaveCommand = new SimpleCommand(OnSave);
            DeleteCommand = new SimpleCommand(OnDelete);
            QuitToSelectCommand = new SimpleCommand(OnQuitToSelect);
        }

        protected virtual void OnDelete(object obj)
        {
          
        }

        private void LoadSubMenu()
        {
            MainWindow mw = MainWindow.Instance;
            mw.SubMenuFrame.Navigate(new MenuEditView(this));
        }
        private void LoadSubMenu(bool isMenuToSelect)
        {
            MainWindow mw = MainWindow.Instance;
            mw.listSubMenuFrame.Navigate(new MenuEditToSelectView(this));
        }
        public virtual void OnSave(object obj)
        {
            if (!Validate(SelectedEntity, out results)) // model zawiera błędy
            {

            }
             else // model poprawny - można zapisywać
            {
                //try
                //{
                //    IEntity entityObj = (IEntity)SelectedEntity;
                //    if ((SelectedEntity as EntityBase).Id != -1)
                //    {
                //        adoRepository.Update((SelectedEntity as T));
                //        //repository.Update(entityObj);
                //    }
                //    else
                //    {
                //        entityObj.EntityState = System.Data.Entity.EntityState.Added;
                //        int count= adoRepository.Add((SelectedEntity as T));

                //        //repository.Add(entityObj);
                //        if (count>0)
                //        {
                //            entityObj.EntityState = System.Data.Entity.EntityState.Unchanged;
                //            RaisePropertyChanged("IsEntityToReturnSelected");
                //        }
                //    }

                //    // Powród do listy po udanym zapisie
                //    NavigateBack();
                //    ClearSelectListFrame();
                //}
                //catch (Exception ee)
                //{

                //}
            }            
        }

        public virtual void OnQuitClick(object obj)
        {
            NavigateBack();
            ClearSelectListFrame();
        }
        public virtual void OnQuitToSelect()
        {
            ClearSelectListFrame();
        }
        public SimpleCommand QuitCommand { get; set; }
        public SimpleCommand SaveCommand { get; set; }
        public SimpleCommand DeleteCommand { get; set; }
        public SimpleCommand DoubleClickCommand { get; set; }
        public SimpleCommand ButtonSelectCommand { get; set; }
        public SimpleCommand QuitToSelectCommand { get; set; }

        public virtual void OnDoubleClick(object obj) { }
        public virtual void OnSelectButton(object obj) { }

        private Object _selectedEntity;
        public Object SelectedEntity
        {
            get { return _selectedEntity; }
            set
            {
                _selectedEntity = value;
                RaisePropertyChanged("SelectedEntity");
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
        protected static bool Validate<T>(T obj, out ICollection<System.ComponentModel.DataAnnotations.ValidationResult> results)
        {
            results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();

            return Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);
        }
    }
}
