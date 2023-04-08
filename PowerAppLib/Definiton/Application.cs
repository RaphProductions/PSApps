using IWshRuntimeLibrary;
using File = System.IO.File;

namespace PowerAppLib.AppLoader
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
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + $@"\{AppManifest.AppDisplayName}.lnk";

            if (UsePublicSM)
                shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + $@"\{AppManifest.AppDisplayName}.lnk";

            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = AppManifest.AppDescription;
            shortcut.Hotkey = $"Ctrl+Shift+{AppManifest.AppDisplayName[0]}";
            shortcut.TargetPath = $"powershell";
            shortcut.Arguments = $"-WindowStyle Hidden '{AppFolder}Launcher.ps1'";
            shortcut.Save();
        }
        public void BuildDesktopShortcut(bool UsePublicDesktop)
        {
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + $@"\{AppManifest.AppDisplayName}.lnk";

            if (UsePublicDesktop)
                shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + $@"\{AppManifest.AppDisplayName}.lnk";

            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = AppManifest.AppDescription;
            shortcut.Hotkey = $"Ctrl+Shift+{AppManifest.AppDisplayName[0]}";
            shortcut.TargetPath = $"pwsh";
            shortcut.Arguments = $"-WindowStyle Hidden '{AppFolder}Launcher.ps1'";
            shortcut.Save();
        }
    }
}