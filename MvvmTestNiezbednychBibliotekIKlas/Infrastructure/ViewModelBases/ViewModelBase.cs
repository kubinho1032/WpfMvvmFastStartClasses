using System;
using WarsztatWpf.Infrastructure.Helpers;

namespace WarsztatWpf.Infrastructure
{
    public class ViewModelBase : ErrorValidationHelper
    {
        protected int EventId { get; set; }
        protected string PreviousViewName { get; set; }
   
        private string viewName;
        public string ViewName
        {
            get
            {
                return viewName;
            }
            set
            {
                viewName = value;
                RaisePropertyChanged("ViewName");
            }
        }

        private bool canManipulate=true;
        public bool CanManipulate
        {
            get
            {
                return canManipulate;
            }
            set
            {
                SetProperty(ref canManipulate, value);
            }
        }

        #region Constructors

        public ViewModelBase() { }

        #endregion
        protected void NavigateTo(string module)
        {
            if (!PagesDictionary.ViewSources.ContainsKey((string)module)) return;

            MainWindow mw = MainWindow.Instance;
            ClearSelectListFrame();
            object myInstance = Activator.CreateInstance(PagesDictionary.ViewSources[module]);
            mw.ContentFrame.Navigate(myInstance);
            mw.HeaderFrame.Navigate(new HeaderTabView(PagesDictionary.ViewNamesPolishTranslate[module]));
        }
        protected void NavigateTo(string module,object data)
        {
            if (!PagesDictionary.ViewSources.ContainsKey((string)module)) return;

            MainWindow mw = MainWindow.Instance;
            ClearSelectListFrame();
            object myInstance = Activator.CreateInstance(PagesDictionary.ViewSources[module], data);
            mw.ContentFrame.Navigate(myInstance);
            mw.HeaderFrame.Navigate(new HeaderTabView(PagesDictionary.ViewNamesPolishTranslate[module]));
        }
        protected void NavigateToFrameList(string module, ViewModelBase data)
        {
            if (!PagesDictionary.ViewSources.ContainsKey((string)module)) return;

            MainWindow mw = MainWindow.Instance;
            object myInstance = Activator.CreateInstance(PagesDictionary.ViewSources[module], data);
            mw.listFrame.Navigate(myInstance);
        }

        public void NavigateBack()
        {
            MainWindow mw = MainWindow.Instance;
            if(mw.ContentFrame.CanGoBack) mw.ContentFrame.GoBack();
            if (mw.SubMenuFrame.CanGoBack) mw.SubMenuFrame.GoBack();
        }

        protected void ClearContentFrame()
        {
            MainWindow mw = MainWindow.Instance;
            HeaderTabView.ClearHeader();
            mw.ContentFrame.Content = null;
            mw.ContentFrame.NavigationService.RemoveBackEntry();
        }

        protected void ClearSelectListFrame()
        {
            MainWindow mw = MainWindow.Instance;
            mw.listFrame.Content = null;
            mw.listFrame.NavigationService.RemoveBackEntry();

            mw.listSubMenuFrame.Content = null;
            mw.listSubMenuFrame.NavigationService.RemoveBackEntry();
        }

        protected void ClearSubMenu()
        {
            MainWindow mw = MainWindow.Instance;
            mw.SubMenuFrame.Content = null;
            mw.SubMenuFrame.NavigationService.RemoveBackEntry();
        }

    }
}
