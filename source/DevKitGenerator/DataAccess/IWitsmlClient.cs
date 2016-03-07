namespace Energistics.DataAccess
{
    /// <summary>
    /// Defines methods that can be used to interact with a WTISML store.
    /// </summary>
    public interface IWitsmlClient
    {
        /// <summary>
        /// Gets or sets a value indicating whether compression is enabled.
        /// </summary>
        /// <value><c>true</c> if compression is enabled; otherwise, <c>false</c>.</value>
        bool IsCompressionEnabled { get; set; }

        /// <summary>
        /// Returns a string containing the Data Schema Version(s) that a server supports.
        /// </summary>
        /// <returns>
        /// A comma-separated list of Data Schema Versions (without spaces) that the server supports. 
        /// The server MUST list the supported Data Schema Versions, from oldest to newest
        /// </returns>
        string WMLS_GetVersion();

        /// <summary>
        /// Returns the capServer object that describes the capabilities of the server for one Data Schema Version.
        /// </summary>
        /// <param name="OptionsIn">The options in.</param>
        /// <param name="CapabilitiesOut">The capabilities out.</param>
        /// <param name="SuppMsgOut">The supplemental message text.</param>
        /// <returns>A positive value indicating success, or a negative value indicating an error.</returns>
        short WMLS_GetCap(string OptionsIn, out string CapabilitiesOut, out string SuppMsgOut);

        /// <summary>
        /// Returns one or more WITSML data-objects from the server.
        /// </summary>
        /// <param name="WMLtypeIn">The wml type in.</param>
        /// <param name="QueryIn">The query in.</param>
        /// <param name="OptionsIn">The options in.</param>
        /// <param name="CapabilitiesIn">The capabilities in.</param>
        /// <param name="XMLout">The xml out.</param>
        /// <param name="SuppMsgOut">The supplemental message text.</param>
        /// <returns>A positive value indicating success, or a negative value indicating an error.</returns>
        short WMLS_GetFromStore(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, out string XMLout, out string SuppMsgOut);

        /// <summary>
        /// Adds one WITSML data-object to the server.
        /// </summary>
        /// <param name="WMLtypeIn">The wml type in.</param>
        /// <param name="XMLin">The xml in.</param>
        /// <param name="OptionsIn">The options in.</param>
        /// <param name="CapabilitiesIn">The capabilities in.</param>
        /// <param name="SuppMsgOut">The supplemental message text.</param>
        /// <returns>A positive value indicating success, or a negative value indicating an error.</returns>
        short WMLS_AddToStore(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, out string SuppMsgOut);

        /// <summary>
        /// Updates one existing WITSML data-object on the server.
        /// </summary>
        /// <param name="WMLtypeIn">The wml type in.</param>
        /// <param name="XMLin">The xml in.</param>
        /// <param name="OptionsIn">The options in.</param>
        /// <param name="CapabilitiesIn">The capabilities in.</param>
        /// <param name="SuppMsgOut">The supplemental message text.</param>
        /// <returns>A positive value indicating success, or a negative value indicating an error.</returns>
        short WMLS_UpdateInStore(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, out string SuppMsgOut);

        /// <summary>
        /// Permanently deletes one WITSML data-object from the data store.
        /// </summary>
        /// <param name="WMLtypeIn">The wml type in.</param>
        /// <param name="QueryIn">The query in.</param>
        /// <param name="OptionsIn">The options in.</param>
        /// <param name="CapabilitiesIn">The capabilities in.</param>
        /// <param name="SuppMsgOut">The supplemental message text.</param>
        /// <returns>A positive value indicating success, or a negative value indicating an error.</returns>
        short WMLS_DeleteFromStore(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, out string SuppMsgOut);

        /// <summary>
        /// Returns a string containing only the fixed (base) message text associated with a defined Return Value.
        /// </summary>
        /// <param name="ReturnValueIn">The return value in.</param>
        /// <returns>The fixed descriptive message text associated with the Return Value.</returns>
        string WMLS_GetBaseMsg(short ReturnValueIn);
    }
}
