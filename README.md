onyx
====
1. Create bin, nuspec, slns, src directories
2. Add .gitignore from another project
3. Create blank VS solution in slns
4. Create VS project inside of src
5. Update assembly version to #.#.*, update copyright and company information, e.g., in AssemblyInfo.cs
```c#
[assembly: AssemblyTitle("Loqu8.Onyx")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Loqu8")]
[assembly: AssemblyProduct("Loqu8.Onyx")]
[assembly: AssemblyCopyright("Copyright © 2007-14 Loqu8. All rights reserved worldwide.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyFileVersion("1.0.*")]
```
6. Create nuget file - can we do automatically?
