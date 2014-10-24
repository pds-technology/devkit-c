// 
// License notice
//  
// Standards DevKit, version 2.0
// Copyright 2012 ExxonMobil Upstream Research Company
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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Energistics.DataAccess;

namespace Energistics.SampleBrowserApp
{
    public partial class SampleBrowserApp : Form
    {
        private WITSMLWebServiceConnection conn;
        private IEnergisticsCollection selectedQuery;
        private IEnergisticsCollection fullObject;
        private List<Type> serverSupportedTypes;
        private DataGridViewTextBoxColumn sourceColumn;
        private Type energyObject;
        private Dictionary<object, string> sourceLookup;

        public SampleBrowserApp()
        {
            InitializeComponent();

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            CreateConnection();

            // Setup source column
            sourceColumn = new DataGridViewTextBoxColumn();
            sourceColumn.Name = "Source";
            sourceColumn.HeaderText = "Source";
            sourceColumn.Visible = false;

            // Setup data grid
            dataGridView1.Columns.Add(sourceColumn);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoGenerateColumns = true;

            sourceLookup = new Dictionary<object, string>();
        }

        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ShowErrorMessage(e.Exception);
        }

        void ShowErrorMessage(Exception e)
        {
            if (e.InnerException == null)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ShowErrorMessage(e.InnerException);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            // Add all types that this web server supports to the listbox
            serverSupportedTypes = new List<Type>();
            
            // Populate list boxes with data types
            AddSupportedTypesToListbox("WITSML131", witsml13ListBox);
            AddSupportedTypesToListbox("WITSML141", witsml14ListBox);
            AddSupportedTypesToListbox("PRODML122", prodml12ListBox);

            // Bind the connection properties to the GUI controls
            ((TextBox)urlTextBox.Control).DataBindings.Add("Text", conn, "Url");
            ((TextBox)useridTextBox.Control).DataBindings.Add("Text", conn, "Username");
            ((TextBox)passwordTextBox.Control).PasswordChar = '*';
            ((TextBox)passwordTextBox.Control).TextChanged += new EventHandler(SampleBrowserApp_PasswordTextChanged);

            passwordTextBox.Text = Environment.GetEnvironmentVariable("WITSMLPW");
        }

        /// <summary>
        /// Since the password on the connection is Read-Only, we cannot bind to it. Instead we have to update
        /// the connection based on the TextChanged event.
        /// </summary>
        void SampleBrowserApp_PasswordTextChanged(object sender, EventArgs e)
        {
            conn.SetPassword(((TextBox)sender).Text);
        }

        /// <summary>
        /// Searches for IEnergisticsCollections from devkit. These are the container classes that can be read from files / web services
        /// </summary>
        private void AddSupportedTypesToListbox(string setName, ListBox listBox)
        {
            string interfaceName = "Energistics.DataAccess.IEnergisticsCollection";
            Assembly asy = typeof(WITSMLWebServiceConnection).Assembly;
            foreach (Type t in asy.GetTypes())
            {
                if (t.Namespace == "Energistics.DataAccess." + setName && t.GetInterface(interfaceName) != null)
                {
                    listBox.Items.Add(t);
                }
            }

            listBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Make the inital connection to the web service. 
        /// </summary>
        private void ConnectToServer()
        {
            // Gets all types that the web service supports, so we can know what queries to allow
            serverSupportedTypes = conn.GetAllSupportedTypes();

            // Get the CapServer object that contains details about the server that we have connected to and display that information
            Energistics.DataAccess.WITSML131.CapServers cap = conn.GetCap<Energistics.DataAccess.WITSML131.CapServers>();

            StringBuilder msg = new StringBuilder();

            msg.AppendLine("Name: \t\t" + cap.CapServer.Name);
            msg.AppendLine("Description: \t" + cap.CapServer.Description);
            msg.AppendLine("Vendor: \t\t" + cap.CapServer.Vendor);
            msg.AppendLine("Contact name: \t" + cap.CapServer.Contact.Name);
            msg.AppendLine("Contact email: \t" + cap.CapServer.Contact.Email);
            msg.AppendLine("Contact phone: \t" + cap.CapServer.Contact.Phone);
            msg.AppendLine("Version: \t\t" + cap.CapServer.Version);
            msg.AppendLine("Schema version: \t" + cap.CapServer.SchemaVersion);
            msg.AppendLine("Api version: \t" + cap.CapServer.ApiVers);
            MessageBox.Show(msg.ToString(), "Server Connection Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Text = cap.CapServer.Name;
        }

        /// <summary>
        /// Create a new connection with default parameters
        /// </summary>
        private WITSMLWebServiceConnection CreateConnection()
        {
            conn = new WITSMLWebServiceConnection("http://sitecom.intellifield.no/Store/WITSML", WMLSVersion.WITSML131);
            conn.Proxy = new System.Net.WebProxy();
            conn.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            conn.Username = Environment.GetEnvironmentVariable("WITSMLUSER");            

            return conn;
        }

        /// <summary>
        /// Handle change of selected type
        /// </summary>
        private void listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            if (listbox.SelectedItem != null)
            {
                energyObject = (Type)listbox.SelectedItem;

                // Unselect items on other listboxes
                if (witsml13ListBox != listbox)
                    witsml13ListBox.SelectedItem = null;
                if (witsml14ListBox != listbox)
                    witsml14ListBox.SelectedItem = null;
                if (prodml12ListBox != listbox)
                    prodml12ListBox.SelectedItem = null;

                // Find out if the web service supports this data type
                bool connSupport = serverSupportedTypes.Contains(energyObject);

                // Since we have selected a data type, enable our menu items and buttons
                runQueryToolStripMenuItem.Enabled = connSupport;
                importXMLFileToolStripMenuItem.Enabled = true;
                runQueryToolStripButton2.Enabled = connSupport;
                importXMLFileToolStripButton1.Enabled = true;

                // If our server does support this data type, create an empty query for the selected data type
                if (connSupport)
                {
                    selectedQuery = (IEnergisticsCollection)typeof(WITSMLWebServiceConnection).GetMethod("BuildEmptyQuery").MakeGenericMethod(new Type[] { energyObject }).Invoke(conn, new object[] { });
                    propertyGrid1.SelectedObject = selectedQuery.Items[0];
                }
                else
                {
                    propertyGrid1.SelectedObject = null;
                }

                // Reset our grid so it doesn't show anything
                dataGridView1.DataSource = null;
                fullObject = null;
                sourceColumn.Visible = false;
                sourceLookup.Clear();
            }
        }

        private void ReadFromWebService()
        {
            // Get a Web Service Reader for the selected type
            Type t = selectedQuery.GetType();

            // Since the call to Read uses generics (i.e. Read<Wellbore>), we don't know at compile time what
            // datatype we want to read, we have to use reflection to get the proper Read method at runtime
            MethodInfo readMethodInfo = typeof(WITSMLWebServiceConnection).GetMethods().First(m => m.Name == "Read" && m.GetParameters().Count() == 1).MakeGenericMethod(t);

            // Call the read method and put the results into the data grid view. Once again, this call uses reflection.
            // If you knew what datatype ahead of time you could call it directly
            AddToGrid((IEnergisticsCollection)readMethodInfo.Invoke(conn, new object[] { selectedQuery }), "Web Service");
        }

        private void ImportXMLFile()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Get a File Reader for the selected type
                    MethodInfo readMethodInfo = typeof(EnergisticsFile).GetMethod("ReadFile").MakeGenericMethod(new Type[] { energyObject });

                    // Call the ReadFile method and append the results into the data grid view
                    AddToGrid((IEnergisticsCollection)readMethodInfo.Invoke(null, new object[] { dialog.FileName }), "File");
                }
            }
        }

        /// <summary>
        /// Add the IEnergisticsCollection items to the grid
        /// </summary>
        private void AddToGrid(IEnergisticsCollection obj, string source)
        {
            sourceColumn.Visible = true;

            if (fullObject == null)
            {
                // If nothing else is already there, just use the IEnergisticsCollection
                fullObject = obj;
            }
            else
            {
                // Since we already have items in the grid, append the new ones
                foreach (object xmlObj in obj.Items)
                {
                    fullObject.Items.Add(xmlObj);
                }
            }

            // Since we are not working with a DataSet or BindingList, we have to do this to get the grid to refresh
            dataGridView1.DataSource = typeof(IList);
            dataGridView1.DataSource = fullObject.Items;
           
            // Set values for the unbounded "Source" column
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!sourceLookup.ContainsKey(row.DataBoundItem))
                {
                    sourceLookup.Add(row.DataBoundItem, source);
                }

                row.Cells["Source"].Value = sourceLookup[row.DataBoundItem];
            }
        }

        #region GUI Event Handlers
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ImportXMLFile();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ReadFromWebService();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void importXMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportXMLFile();
        }

        private void runQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadFromWebService();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            ConnectToServer();
        }
        #endregion
    }

}
