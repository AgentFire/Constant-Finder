﻿global using Community.VisualStudio.Toolkit;
global using Microsoft.VisualStudio.Shell;
global using System;
global using Task = System.Threading.Tasks.Task;
using System.Runtime.InteropServices;
using System.Threading;

namespace ConstantFinder;
[PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
[InstalledProductRegistration(Vsix.Name, Vsix.Description, Vsix.Version)]
[ProvideToolWindow(typeof(MyToolWindow.Pane), Style = VsDockStyle.Tabbed, Window = WindowGuids.SolutionExplorer)]
[ProvideMenuResource("Menus.ctmenu", 1)]
[Guid(PackageGuids.Constant_FinderString)]
public sealed class ConstantFinderPackage : ToolkitPackage
{
    protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
    {
        await this.RegisterCommandsAsync();

        this.RegisterToolWindows();
    }
}