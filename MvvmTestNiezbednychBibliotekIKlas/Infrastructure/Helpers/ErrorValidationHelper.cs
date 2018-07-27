using Prism.Mvvm;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WarsztatWpf.Infrastructure.Helpers
{
    public class ErrorValidationHelper : BindableBase, IDataErrorInfo
    {
        public string Error { get; }

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
