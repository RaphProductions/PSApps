using PSAppsLib.AppLoader;
using System.IO.Compression;

namespace PSAppsLib
{
    public class AppInstaller
    {
        public static string AppFolder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\PowerApps\\InstalledApps\\";
        public static string TempFolder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\PowerApps\\Temp\\";

        public static int InstallApp(string CompressedAppPath)
        {
            try
            {
                if (!Directory.Exists(AppFolder))
                    Directory.CreateDirectory(AppFolder);
                if (!Directory.Exists(TempFolder))
                    Directory.CreateDirectory(TempFolder);

                FileInfo i = new(CompressedAppPath);

                File.Copy(CompressedAppPath, TempFolder + $"{i.Name}.zip", true);
                ZipFile.ExtractToDirectory(TempFolder + $"{i.Name}.zip", AppFolder + i.Name.Remove(i.Name.Length - 4));

                Application app = new(AppFolder + i.Name.Remove(i.Name.Length - 4) + "\\");

                if (i.Name.Remove(i.Name.Length - 4) != app.AppManifest.AppName)
                {
                    Directory.Delete(AppFolder + i.Name.Remove(i.Name.Length - 4), true);
                    Console.WriteLine("The ZIP file name needs to be equals to the application name.");
                    return 4;
                }

                if (app.AppManifest.AppAuthor != "RaphMar2022")
                {
                    if (app.AppManifest.AppAuthor != "Microsoft Corporation")
                    {
                        Console.WriteLine($"The author {app.AppManifest.AppAuthor} is not an authentic author. Do you trust him? (y : yes, n : no)");
                        switch (Console.ReadLine())
                        {
                            case "y":
                                CreateAppScriptAndShortcuts(app);
                                break;
                            case "n":
                                return 3;
                            default:
                                return 3;
                        }
                    }
                    else
                    {
                        CreateAppScriptAndShortcuts(app);
                    }
                }
                else
                {
                    CreateAppScriptAndShortcuts(app);
                }

                File.Delete(TempFolder + $"{i.Name}.zip");

                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 1;
            }
        }

        public static int UninstallApp(string AppName)
        {
            try
            {
                Application app = new(AppFolder + AppName + "\\");

                Console.WriteLine($"Are you sure that you want to delete {app.AppManifest.AppName}, version {app.AppManifest.AppName} by {app.AppManifest.AppAuthor}? (y : yes, n : no)");

                switch (Console.ReadLine())
                {
                    case "y":
                        Directory.Delete(AppFolder + AppName, true);
                        File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory) + $@"\{app.AppManifest.AppDisplayName}.lnk");
                        File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + $@"\{app.AppManifest.AppDisplayName}.lnk");
                        break;
                    case "n":
                        return 2;
                    default:
                        return 2;
                }
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 1;
            }
        }

        static void CreateAppScriptAndShortcuts(Application app)
        {
            app.CreateLauncherScript();
            app.BuildStartMenuShortcut(true);
            app.BuildDesktopShortcut(true);
        }
    }
}