//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Data Access Application Block
//===============================================================================
// Copyright  Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Management.Instrumentation;

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Manageability;
using Microsoft.Practices.EnterpriseLibrary.Data.Configuration.Manageability;
using Microsoft.Practices.EnterpriseLibrary.Data.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data.Oracle.Configuration;

[assembly: InternalsVisibleTo("EnterpriseLibrary.Data.Configuration.Manageability.Tests")]
[assembly: ConfigurationSectionManageabilityProvider("connectionStrings", typeof(ConnectionStringsManageabilityProvider))]
[assembly: ConfigurationSectionManageabilityProvider(DatabaseSettings.SectionName, typeof(DatabaseSettingsManageabilityProvider))]
[assembly: ConfigurationSectionManageabilityProvider(OracleConnectionSettings.SectionName, typeof(OracleConnectionSettingsManageabilityProvider))]