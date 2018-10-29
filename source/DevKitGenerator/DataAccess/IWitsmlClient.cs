// 
// License notice
//  
// Standards DevKit, version 2.0
// Copyright 2016 Petrotechnical Data Systems
// 
// Third Party Software
// 
// Energistics 
// The following Energistics (c) products were used in the creation of this work: 
// 
// •             WITSML Data Schema Specifications, Version 1.4.1.1 
// •             WITSML API Specifications, version 1.4.1.1 
// •             WITSML Data Schema Specifications, Version 1.3.1.1 
// •             WITSML API Specifications, version 1.3.1 
// •             PRODML Data Schema Specifications, Version 1.2.2 
// •             PRODML Web Service Specifications, Version 2.1.0.1
// •             RESQML Data Schema Specifications, Version 1.1 
// 
// All rights in the WITSML™ Standard, the PRODML™ Standard, and the RESQML™ Standard, or
// any portion thereof, which remain in the Standards DevKit shall remain with Energistics
// or its suppliers and shall remain subject to the terms of the Product License Agreement
// available at http://www.energistics.org/product-license-agreement. 
// 
// Apache
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
// except in compliance with the License. 
// 
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. 
// 
// See the License for the specific language governing permissions and limitations under the
// License.
// 
// HDF5
// HDF5 (Hierarchical Data Format 5) Software Library and Utilities Copyright 2006-2012 by
// The HDF Group. 
// 
// NCSA HDF5 (Hierarchical Data Format 5) Software Library and Utilities Copyright 1998-2006
// by the Board of Trustees of the University of Illinois. 
// 
// All rights reserved. 
// 
// Redistribution and use in source and binary forms, with or without modification, are
// permitted for any purpose (including commercial purposes) provided that the following
// conditions are met: 
//    1. Redistributions of source code must retain the above copyright notice, this list
//       of conditions, and the following disclaimer. 
//    2. Redistributions in binary form must reproduce the above copyright notice, this
//       list of conditions, and the following disclaimer in the documentation and/or
// 	  materials provided with the distribution. 
//    3. In addition, redistributions of modified forms of the source or binary code must
//       carry prominent notices stating that the original code was changed and the date of
// 	  the change. 
//    4. All publications or advertising materials mentioning features or use of this
//       software are asked, but not required, to acknowledge that it was developed by The
// 	  HDF Group and by the National Center for Supercomputing Applications at the 
// 	  University of Illinois at Urbana-Champaign and credit the contributors. 
//    5. Neither the name of The HDF Group, the name of the University, nor the name of any
//       Contributor may be used to endorse or promote products derived from this software
// 	  without specific prior written permission from The HDF Group, the University, or
// 	  the Contributor, respectively. 
// 
// DISCLAIMER: THIS SOFTWARE IS PROVIDED BY THE HDF GROUP AND THE CONTRIBUTORS "AS IS" WITH
// NO WARRANTY OF ANY KIND, EITHER EXPRESSED OR IMPLIED. In no event shall The HDF Group or
// the Contributors be liable for any damages suffered by the users arising out of the use
// of this software, even if advised of the possibility of such damage. 
// 
// Contributors: National Center for Supercomputing Applications (NCSA) at the University of
// Illinois, Fortner Software, Unidata Program Center (netCDF), The Independent JPEG Group
// (JPEG), Jean-loup Gailly and Mark Adler (gzip), and Digital Equipment Corporation (DEC). 
// 

using System;
using System.Collections.Generic;

namespace Energistics.DataAccess
{
    /// <summary>
    /// Defines methods that can be used to interact with a WTISML store.
    /// </summary>
    public interface IWitsmlClient
    {
        /// <summary>
        /// Equivalent to AcceptCompressedResponses
        /// </summary>
        [Obsolete("Use AcceptCompressedResponses instead.")]
        bool IsCompressionEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether compressed responses from the server are accepted.
        /// </summary>
        /// <value><c>true</c> if compressed responses are accepted; otherwise, <c>false</c>.</value>
        /// <remarks>If enabled, WITSML API calls will inform the server that compressed responses are accepted and handle any compressed responses.</remarks>
        bool AcceptCompressedResponses { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether requests from the client should be compressed.
        /// </summary>
        /// <value><c>true</c> if client requests should be compressed; otherwise, <c>false</c>.</value>
        /// <remarks>
        /// If <c>true</c>, client applications should call <see cref="CompressRequests"/> to
        /// compress XML input sent to the server for GetFromStore, AddToStore and UpdateInStore.
        /// </remarks>
        bool CompressRequests { get; set; }

        /// <summary>
        /// Gets or sets the collection of name/value pairs to include as HTTP headers.
        /// </summary>
        /// <value>The collection of name/value pairs.</value>
        IDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Returns a string containing the Data Schema Version(s) that a server supports.
        /// </summary>
        /// <returns>
        /// A comma-separated list of Data Schema Versions (without spaces) that the server supports. 
        /// The server MUST list the supported Data Schema Versions, from oldest to newest
        /// </returns>
        string WMLS_GetVersion();

        /// <summary>
        /// Asynchronously requests a string containing the Data Schema Version(s) that a server supports.
        /// </summary>
        /// <param name="callback">The callback to call when the request is completed.</param>
        /// <param name="asyncState">The asynchronous state.</param>
        /// <returns>An <see cref="IAsyncResult"/> that can be used to wait for the result.</returns>
        IAsyncResult BeginWMLS_GetVersion(AsyncCallback callback, object asyncState);

        /// <summary>
        /// Asynchronously returns a string containing the Data Schema Version(s) that a server supports.
        /// </summary>
        /// <param name="asyncResult">The <see cref="IAsyncResult"/> from the request.</param>
        /// <returns>
        /// A comma-separated list of Data Schema Versions (without spaces) that the server supports. 
        /// The server MUST list the supported Data Schema Versions, from oldest to newest
        /// </returns>
        string EndWMLS_GetVersion(IAsyncResult asyncResult);

        /// <summary>
        /// Returns the capServer object that describes the capabilities of the server for one Data Schema Version.
        /// </summary>
        /// <param name="OptionsIn">The options in.</param>
        /// <param name="CapabilitiesOut">The capabilities out.</param>
        /// <param name="SuppMsgOut">The supplemental message text.</param>
        /// <returns>A positive value indicating success, or a negative value indicating an error.</returns>
        short WMLS_GetCap(string OptionsIn, out string CapabilitiesOut, out string SuppMsgOut);

        /// <summary>
        /// Asynchronously requests the capServer object that describes the capabilities of the server for one Data Schema Version.
        /// </summary>
        /// <param name="OptionsIn">The options in.</param>
        /// <param name="callback">The callback to call when the request is completed.</param>
        /// <param name="asyncState">The asynchronous state.</param>
        /// <returns>An <see cref="IAsyncResult"/> that can be used to wait for the result.</returns>
        IAsyncResult BeginWMLS_GetCap(string OptionsIn, AsyncCallback callback, object asyncState);

        /// <summary>
        /// Asynchronously returns the capServer object that describes the capabilities of the server for one Data Schema Version.
        /// </summary>
        /// <param name="asyncResult">The <see cref="IAsyncResult"/> from the request.</param>
        /// <param name="CapabilitiesOut">The capabilities out.</param>
        /// <param name="SuppMsgOut">The supplemental message text.</param>
        /// <returns>A positive value indicating success, or a negative value indicating an error.</returns>
        short EndWMLS_GetCap(IAsyncResult asyncResult, out string CapabilitiesOut, out string SuppMsgOut);

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
        /// Asynchronously requests one or more WITSML data-objects from the server.
        /// </summary>
        /// <param name="WMLtypeIn">The wml type in.</param>
        /// <param name="QueryIn">The query in.</param>
        /// <param name="OptionsIn">The options in.</param>
        /// <param name="CapabilitiesIn">The capabilities in.</param>
        /// <param name="callback">The callback to call when the request is completed.</param>
        /// <param name="asyncState">The asynchronous state.</param>
        /// <returns>An <see cref="IAsyncResult"/> that can be used to wait for the result.</returns>
        IAsyncResult BeginWMLS_GetFromStore(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, AsyncCallback callback, object asyncState);

        /// <summary>
        /// Asynchronously returns one or more WITSML data-objects from the server.
        /// </summary>
        /// <param name="asyncResult">The <see cref="IAsyncResult"/> from the request.</param>
        /// <param name="XMLout">The xml out.</param>
        /// <param name="SuppMsgOut">The supplemental message text.</param>
        /// <returns>A positive value indicating success, or a negative value indicating an error.</returns>
        short EndWMLS_GetFromStore(IAsyncResult asyncResult, out string XMLout, out string SuppMsgOut);

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
        /// Asynchronously requests to add one WITSML data-object to the server.
        /// </summary>
        /// <param name="WMLtypeIn">The wml type in.</param>
        /// <param name="XMLin">The xml in.</param>
        /// <param name="OptionsIn">The options in.</param>
        /// <param name="CapabilitiesIn">The capabilities in.</param>
        /// <param name="callback">The callback to call when the request is completed.</param>
        /// <param name="asyncState">The asynchronous state.</param>
        /// <returns>An <see cref="IAsyncResult"/> that can be used to wait for the result.</returns>
        IAsyncResult BeginWMLS_AddToStore(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, AsyncCallback callback, object asyncState);

        /// <summary>
        /// Asynchronously completes the request to add one WITSML data-object to the server.
        /// </summary>
        /// <param name="asyncResult">The <see cref="IAsyncResult"/> from the request.</param>
        /// <param name="SuppMsgOut">The supplemental message text.</param>
        /// <returns>A positive value indicating success, or a negative value indicating an error.</returns>
        short EndWMLS_AddToStore(IAsyncResult asyncResult, out string SuppMsgOut);
        
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
        /// Asynchronously requests to update one existing WITSML data-object on the server.
        /// </summary>
        /// <param name="WMLtypeIn">The wml type in.</param>
        /// <param name="XMLin">The xml in.</param>
        /// <param name="OptionsIn">The options in.</param>
        /// <param name="CapabilitiesIn">The capabilities in.</param>
        /// <param name="callback">The callback to call when the request is completed.</param>
        /// <param name="asyncState">The asynchronous state.</param>
        /// <returns>An <see cref="IAsyncResult"/> that can be used to wait for the result.</returns>
        IAsyncResult BeginWMLS_UpdateInStore(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, AsyncCallback callback, object asyncState);

        /// <summary>
        /// Asynchronously completes the request to update one existing WITSML data-object on the server.
        /// </summary>
        /// <param name="asyncResult">The <see cref="IAsyncResult"/> from the request.</param>
        /// <param name="SuppMsgOut">The supplemental message text.</param>
        /// <returns>A positive value indicating success, or a negative value indicating an error.</returns>
        short EndWMLS_UpdateInStore(IAsyncResult asyncResult, out string SuppMsgOut);

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
        /// Asynchronously requests to permanently delete one WITSML data-object from the data store.
        /// </summary>
        /// <param name="WMLtypeIn">The wml type in.</param>
        /// <param name="QueryIn">The query in.</param>
        /// <param name="OptionsIn">The options in.</param>
        /// <param name="CapabilitiesIn">The capabilities in.</param>
        /// <param name="callback">The callback to call when the request is completed.</param>
        /// <param name="asyncState">The asynchronous state.</param>
        /// <returns>An <see cref="IAsyncResult"/> that can be used to wait for the result.</returns>
        IAsyncResult BeginWMLS_DeleteFromStore(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, AsyncCallback callback, object asyncState);

        /// <summary>
        /// Asynchronously completes the request to permantently delete one WITSML data-object from the data store.
        /// </summary>
        /// <param name="asyncResult">The <see cref="IAsyncResult"/> from the request.</param>
        /// <param name="SuppMsgOut">The supplemental message text.</param>
        /// <returns>A positive value indicating success, or a negative value indicating an error.</returns>
        short EndWMLS_DeleteFromStore(IAsyncResult asyncResult, out string SuppMsgOut);

        /// <summary>
        /// Returns a string containing only the fixed (base) message text associated with a defined Return Value.
        /// </summary>
        /// <param name="ReturnValueIn">The return value in.</param>
        /// <returns>The fixed descriptive message text associated with the Return Value.</returns>
        string WMLS_GetBaseMsg(short ReturnValueIn);

        /// <summary>
        /// Asynchronously requests a string containing only the fixed (base) message text associated with a defined Return Value.
        /// </summary>
        /// <param name="ReturnValueIn">The return value in.</param>
        /// <param name="callback">The callback to call when the request is completed.</param>
        /// <param name="asyncState">The asynchronous state.</param>
        /// <returns>An <see cref="IAsyncResult"/> that can be used to wait for the result.</returns>
        IAsyncResult BeginWMLS_GetBaseMsg(short ReturnValueIn, AsyncCallback callback, object asyncState);

        /// <summary>
        /// Asynchronously returns a string containing only the fixed (base) message text associated with a defined Return Value.
        /// </summary>
        /// <param name="asyncResult">The <see cref="IAsyncResult"/> from the request.</param>
        /// <returns>The fixed descriptive message text associated with the Return Value.</returns>
        string EndWMLS_GetBaseMsg(IAsyncResult asyncResult);
    }
}
