using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

[assembly: ProvideCodeBase(AssemblyName = "LanguagePack")]

namespace LanguagePack
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [ProvideBindingPath()]
    [Guid(PackageGuidString)]
    public sealed class LanguagePackPackage : AsyncPackage
    {
        public const string PackageGuidString = "3886ab54-9cf3-4377-b908-c711071a2f67";
    }
}