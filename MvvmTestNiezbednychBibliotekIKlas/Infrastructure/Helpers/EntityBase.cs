using Prism.Mvvm;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;

namespace WarsztatWpf.Infrastructure.DbHelper
{
    public class EntityBase: BindableBase, IDataErrorInfo,IEntity
    {
        protected int id;
        [System.ComponentModel.DataAnnotations.Key]
        public virtual int Id
        {
            get { return id; }
            set {SetProperty(ref id,value); }
        }
        public string Error { get; }

        private EntityState entityState;
        public EntityState EntityState
        {
            get { return entityState; }
            set { SetProperty(ref entityState, value); }
        }

        // check for property errors    
        public string this[string columnName]
        {
            get
            {
                var validationResults = new List<System.ComponentModel.DataAnnotations.ValidationResult>();

                if (Validator.TryValidateProperty(
                        GetType().GetProperty(columnName).GetValue(this)
                        , new ValidationContext(this)
                        {
                            MemberName = columnName
                        }
                        , validationResults))
                    return null;

                return validationResults.First().ErrorMessage;
            }
        }
    }
}
