using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Energistics.DataAccess
{
    /// <summary>
    /// Custom validation attribute that specifies how a non-primitive property is validated
    /// </summary>
    /// <seealso cref="System.ComponentModel.DataAnnotations.ValidationAttribute" />
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class ObjectAttribute : ValidationAttribute
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
            IList<ValidationResult> results;
            EntityValidator.TryValidate(value, out results);
            return results.FirstOrDefault();
        }
    }

    /// <summary>
    /// Defines a helper method that can be used to validate objects using data annotation attributes.
    /// </summary>
    public static class EntityValidator
    {
        /// <summary>
        /// Determines whether the specified object is valid.
        /// </summary>
        /// <param name="instance">The object instance.</param>
        /// <param name="results">The validation results.</param>
        /// <returns>true if the object is valid; otherwise, false</returns>
        public static bool TryValidate(object instance, out IList<ValidationResult> results)
        {
            var context = new ValidationContext(instance, serviceProvider: null, items: null);
            results = new List<ValidationResult>();

            return Validator.TryValidateObject(instance, context, results, validateAllProperties: true);
        }
    }
}
