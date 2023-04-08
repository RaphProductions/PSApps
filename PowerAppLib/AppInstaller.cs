using PowerAppLib.AppLoader;
using System.IO.Compression;

namespace PowerAppLib
{
    public class AppInstaller
    {
        public static string AppFolder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\PowerApps\\InstalledApps\\";
        public static string TempFolder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\PowerApps\\Temp\\";

        public static int InstallApp(string CompressedAppPath)
        {
            try
            {
                FileInfo i = new(CompressedAppPath);

                File.Copy(CompressedAppPath, TempFolder + $"{i.Name}.zip", true);
                ZipFile.ExtractToDirectory(TempFolder + $"{i.Name}.zip", AppFolder + i.Name);

                Application app = new(AppFolder + i.Name + "\\");

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
                                break;
                            default:
                                break;
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
            catch
            {
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