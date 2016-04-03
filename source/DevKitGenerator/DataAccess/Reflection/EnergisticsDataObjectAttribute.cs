using System;

namespace Energistics.DataAccess.Reflection
{
    /// <summary>
    /// Attribute specifying the standards family and data schema version of an Energistics data object.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class EnergisticsDataObjectAttribute : Attribute
    {
        /// <summary>
        /// Create a new EnergisticsDataObject attribute with the specified standard and data schema version.
        /// </summary>
        /// <param name="standardFamily">The standard family the attributed object is defined in</param>
        /// <param name="dataSchemaVersion">The data schema version of the attributed object</param>
        public EnergisticsDataObjectAttribute(StandardFamily standardFamily, string dataSchemaVersion)
        {
            StandardFamily = standardFamily;
            DataSchemaVersion = new Version(dataSchemaVersion);
        }

        /// <summary>
        /// The standard family the attributed object is defined in
        /// </summary>
        public StandardFamily StandardFamily { get; private set; }

        /// <summary>
        /// The data schema version of the attributed object
        /// </summary>
        public Version DataSchemaVersion { get; private set; }
    }
}
