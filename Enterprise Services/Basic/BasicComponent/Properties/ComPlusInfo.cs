using System.EnterpriseServices;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// COM+ Registration
[assembly: ApplicationID("76774B6A-8312-41f5-B55B-9F9ACFDDCD01")]
[assembly: ApplicationName("Basic Demo Service")]
[assembly: ApplicationActivation(ActivationOption.Server)]
[assembly: ApplicationAccessControl(false)]