using IWshRuntimeLibrary;
using File = System.IO.File;

namespace PSAppsLib.AppLoader
{
    public class Application
    {
        public AppManifest AppManifest;
        public string AppFolder;

        public Application(string AppFolder)
        {
            if (!File.Exists(AppFolder + "AppManifest.pam")) 
            {
                throw new InvalidDataException("The app folder " + AppFolder + " is invalid!");
            }
            else
            {
                AppManifest = new AppManifest(AppFolder + "AppManifest.pam");
                this.AppFolder = AppFolder;
            }
        }
        public void CreateLauncherScript()
        {
            StreamWriter w = new(AppFolder + "Launcher.ps1");

            // Add common lines to hide PowerShell
            w.WriteLine("Add-Type -Name Window -Namespace Console -MemberDefinition '[DllImport(\"Kernel32.dll\")] public static extern IntPtr GetConsoleWindow(); [DllImport(\"user32.dll\")] public static extern bool ShowWindow(IntPtr hWnd, Int32 nCmdShow);'");
            w.WriteLine("$consolePtr = [Console.Window]::GetConsoleWindow()");
            w.WriteLine("[Console.Window]::ShowWindow($consolePtr, 0)");

            switch (AppManifest.AppType)
            {
                case AppType.DotNetAssembly:
                    w.WriteLine($"Import-Module '{AppFolder + AppManifest.ExecutableFile}'");
                    w.WriteLine($"[{AppManifest.MainType}]::Main()");
                    break;
                case AppType.Win32Executable:
                    w.WriteLine($"Start-Process '{AppFolder + AppManifest.ExecutableFile}'");
                    break;
            }
            w.Close();
        }
        public void BuildStartMenuShortcut(bool UsePublicSM)
        {
            WshShell shell = new WshShell();
            string shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + $@"\{AppManifest.AppDisplayName}.lnk";

            if (UsePublicSM)
                shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + $@"\{AppManifest.AppDisplayName}.lnk";

            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = AppManifest.AppDescription;
            shortcut.Hotkey = $"Ctrl+Shift+{AppManifest.AppDisplayName[0]}";
            shortcut.TargetPath = $"cmd";
            shortcut.Arguments = $"/c pwsh \"{AppFolder}Launcher.ps1\" -WindowStyle Hidden  -NoProfile";
            shortcut.IconLocation = $"{AppFolder}{AppManifest.AppIcon}";
            shortcut.Save();
        }
        public void BuildDesktopShortcut(bool UsePublicDesktop)
        {
            WshShell shell = new WshShell();
            string shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + $@"\{AppManifest.AppDisplayName}.lnk";

            if (UsePublicDesktop)
                shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + $@"\{AppManifest.AppDisplayName}.lnk";

            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = AppManifest.AppDescription;
            shortcut.Hotkey = $"Ctrl+Shift+{AppManifest.AppDisplayName[0]}";
            shortcut.TargetPath = $"cmd";
            shortcut.Arguments = $"/c pwsh \"{AppFolder}Launcher.ps1\" -WindowStyle Hidden -NoProfile";
            shortcut.IconLocation = $"{AppFolder}{AppManifest.AppIcon}";
            shortcut.Save();
        }
    }
}