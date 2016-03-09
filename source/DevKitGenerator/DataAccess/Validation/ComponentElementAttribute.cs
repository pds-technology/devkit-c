using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Energistics.DataAccess.Validation
{
    /// <summary>
    /// Custom validation attribute that specifies how a non-primitive property is validated.
    /// </summary>
    /// <seealso cref="System.ComponentModel.DataAnnotations.ValidationAttribute" />
    public class ComponentElementAttribute : ValidationAttribute
    {
        /// <summary>
        /// Returns true if the object value is valid.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <param name="validationContext">The context information about the validation operation.</param>
        /// <returns>
        /// An instance of the <see cref="T:System.ComponentModel.DataAnnotations.ValidationResult" /> class.
        /// </returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return null;

            IList<ValidationResult> results;
            DataObjectValidator.TryValidate(value, out results);
            return results.FirstOrDefault();
        }
    }
}
