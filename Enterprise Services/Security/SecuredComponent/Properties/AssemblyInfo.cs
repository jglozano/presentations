using System.EnterpriseServices;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SecuredComponent")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("lozanotek")]
[assembly: AssemblyProduct("SecuredComponent")]
[assembly: AssemblyCopyright("Copyright © lozanotek 2006")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("b358d6eb-6123-4490-b877-2007207d4812")]

// COM+ Registration
[assembly: ApplicationActivation(ActivationOption.Server)]
[assembly: ApplicationAccessControl(AccessChecksLevel= 
                     AccessChecksLevelOption.ApplicationComponent)]
[assembly: ApplicationName("Security Demo")]

[assembly:SecurityRole("Senior Developer")]
[assembly:SecurityRole("Developer")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]