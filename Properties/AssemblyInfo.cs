using System.Reflection;
using MelonLoader;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Permissions;
using System;
using System.Diagnostics;

[assembly: AssemblyTitle(XEngine.BuildInfo.Description)]
[assembly: AssemblyDescription(XEngine.BuildInfo.Description)]
[assembly: AssemblyCompany(XEngine.BuildInfo.Company)]
[assembly: AssemblyProduct(XEngine.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + XEngine.BuildInfo.Author)]
[assembly: AssemblyTrademark(XEngine.BuildInfo.Company)]
[assembly: AssemblyVersion(XEngine.BuildInfo.Version)]
[assembly: AssemblyFileVersion(XEngine.BuildInfo.Version)]
[assembly: MelonInfo(typeof(XEngine.XEngine), XEngine.BuildInfo.Name, XEngine.BuildInfo.Version, XEngine.BuildInfo.Author, XEngine.BuildInfo.DownloadLink)]
[assembly: MelonColor(ConsoleColor.DarkRed)]
[assembly: MelonGame(null, null)]