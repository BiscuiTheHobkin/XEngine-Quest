using System.Reflection;
using MelonLoader;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Permissions;
using System;
using System.Diagnostics;

[assembly: AssemblyTitle(TestMod.BuildInfo.Description)]
[assembly: AssemblyDescription(TestMod.BuildInfo.Description)]
[assembly: AssemblyCompany(TestMod.BuildInfo.Company)]
[assembly: AssemblyProduct(TestMod.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + TestMod.BuildInfo.Author)]
[assembly: AssemblyTrademark(TestMod.BuildInfo.Company)]
[assembly: AssemblyVersion(TestMod.BuildInfo.Version)]
[assembly: AssemblyFileVersion(TestMod.BuildInfo.Version)]
[assembly: MelonInfo(typeof(TestMod.TestMod), TestMod.BuildInfo.Name, TestMod.BuildInfo.Version, TestMod.BuildInfo.Author, TestMod.BuildInfo.DownloadLink)]
[assembly: MelonColor(ConsoleColor.DarkRed)]
[assembly: MelonGame(null, null)]