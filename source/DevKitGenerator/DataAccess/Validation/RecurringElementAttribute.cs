using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Energistics.DataAccess.Validation
{
    /// <summary>
    /// Custom validation attribute that specifies how a collection property is validated.
    /// </summary>
    /// <seealso cref="System.ComponentModel.DataAnnotations.ValidationAttribute" />
    public class RecurringElementAttribute : ValidationAttribute
    {
        /// <summary>
        /// Returns true if the collection object value is valid.
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

            var uids = new List<string>();
            var list = value as IEnumerable;
            if (list == null)
                return null;

            foreach (var obj in list)
            {
                IList<ValidationResult> results;
                DataObjectValidator.TryValidate(obj, out results);
                if (results.Count > 0)
                    return results.FirstOrDefault();

                var dataObj = obj as IUniqueId;
                if (dataObj != null)
                {
                    var uid = dataObj.Uid;
                    if (uids.Contains(uid))
                        return new WitsmlValidationResult(-464, "Uid for recurring element must be unique", new string[] { "Uid" });
                    uids.Add(uid);
                }
            }
            return null;
        }
    }
}
