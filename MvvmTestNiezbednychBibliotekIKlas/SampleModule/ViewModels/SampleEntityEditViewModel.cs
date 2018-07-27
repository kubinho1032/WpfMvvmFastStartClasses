using MvvmTestNiezbednychBibliotekIKlas.SampleModule;
using System;
using WarsztatWpf.Infrastructure;

namespace WarsztatWpf.Modules.SampleModule.ViewModels
{
    public class SampleEntityEditViewModel : EditViewModelBase<SampleEntity>
    {
        //IGenericDataRepository<Klienci> repositorySampleModule = new GenericDataRepository<Klienci>();
        private SampleEntity selectedKlient;

        public SampleEntity SelectedKlient
        {
            get { return selectedKlient; }
            set { SetProperty(ref selectedKlient,value);}
        }

        public SampleEntityEditViewModel()
        {
            var entity = new SampleEntity(true);
            SelectedEntity = entity;
            (SelectedEntity as SampleEntity).Id = -1;
        }

        public SampleEntityEditViewModel(object selectedEntity)
        {
            this.SelectedEntity = (SampleEntity)selectedEntity;
            
        }

        public SampleEntityEditViewModel(bool loadSubMenuToSelectEntity) : base(loadSubMenuToSelectEntity)
        {
            var entity = new SampleEntity(true);
            SelectedEntity = entity;
            (SelectedEntity as SampleEntity).Id = -1;
        }

        protected override void OnDelete(object obj)
        {
            if (!Validate(SelectedEntity, out results)) // model zawiera błędy
            {

            }

            else // model poprawny - można zapisywać
            {
                try
                {
                    //if ((SelectedEntity as EntityBase).Id != -1)
                    //{
                    //    Klienci entityObj = (Klienci)SelectedEntity;
                    //    entityObj.Imie = "Update";
                    //    repositorySampleModule.Update(entityObj);
                    //}

                }
                catch (Exception ee)
                {

                }
            }
        }
    }
}
