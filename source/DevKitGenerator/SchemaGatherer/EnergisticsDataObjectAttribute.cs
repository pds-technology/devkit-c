using System;

namespace Energistics.SchemaGatherer
{
    /// <summary>
    /// Placeholder attribute to transfer the standards family and data schema version to the Generator.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class EnergisticsDataObjectAttribute : Attribute
    {
        /// <summary>
        /// Create a new EnergisticsDataObject attribute with the specified standard and data schema version.
        /// </summary>
        /// <param name="standardFamily">The standard family the attributed object is defined in</param>
        /// <param name="dataSchemaVersion">The data schema version of the attributed object</param>
        public EnergisticsDataObjectAttribute(string standardFamily, string dataSchemaVersion)
        {
            StandardFamily = standardFamily;
            DataSchemaVersion = dataSchemaVersion;
        }

        /// <summary>
        /// The standard family the attributed object is defined in
        /// </summary>
        public string StandardFamily { get; private set; }

        /// <summary>
        /// The data schema version of the attributed object
        /// </summary>
        public string DataSchemaVersion { get; private set; }
    }
}
