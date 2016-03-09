using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Energistics.DataAccess.Validation
{
    /// <summary>
    /// Custom ValidationResult class to capture additional information, e.g. error code
    /// </summary>
    /// <seealso cref="System.ComponentModel.DataAnnotations.ValidationResult" />
    public class WitsmlValidationResult : ValidationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WitsmlValidationResult"/> class.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="memberNames">The member names.</param>
        public WitsmlValidationResult(short errorCode, string errorMessage, IEnumerable<string> memberNames): base(errorMessage, memberNames)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Gets the error code.
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        public short ErrorCode { get; private set; }
    }
}
