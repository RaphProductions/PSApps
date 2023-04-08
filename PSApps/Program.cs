using PSAppsLib;
using PSAppsLib.AppLoader;
using System.Drawing;

namespace PSApps;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            ShowHelpApplet();
        }
        else
        {
            switch (args[0])
            {
                case "install":
                    if (args.Length < 2)
                    {
                        ShowHelpApplet();
                    }
                    else
                    {
                        var rcode = AppInstaller.InstallApp(args[1]);
                        if (rcode == 0)
                        {
                            Console.WriteLine("The specified PowerApp has been installed on your computer!");
                        }
                        else
                        {
                            Console.WriteLine("There was a problem installing the specified PowerApp on your computer.");
                        }
                    }
                    break;
                case "uninstall":
                    if (args.Length < 2)
                    {
                        ShowHelpApplet();
                    }
                    else
                    {
                        var rcode = AppInstaller.UninstallApp(args[1]);
                        if (rcode == 0)
                        {
                            Console.WriteLine("The specified PowerApp has been uninstalled from your computer!");
                        }
                        else
                        {
                            Console.WriteLine("There was a problem uninstalling the specified PowerApp from your computer.");
                        }
                    }
                    break;
                case "getinfo":
                    if (args.Length < 2)
                    {
                        ShowHelpApplet();
                    }
                    else
                    {
                        System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
                        Application app = new(AppInstaller.AppFolder + args[1] + "\\");
                        AppInfoForm f = new();
                        AppManifest am = app.AppManifest;
                        f.Title.Text = am.AppDisplayName + "'s infos";
                        f.labelAppNameValue.Text = am.AppName;
                        f.labelAppDisplayNameValue.Text = am.AppDisplayName;
                        f.labelAppDescriptionValue.Text = am.AppDescription;
                        if (am.AppAuthor == "RaphMar2022" || am.AppAuthor == "Microsoft Corporation")
                            f.labelAppAuthorValue.Text = am.AppAuthor + " (Trusted)";
                        else
                            f.labelAppAuthorValue.Text = am.AppAuthor;
                        f.labelAppMainTypeValue.Text = am.MainType;
                        switch (am.AppType)
                        {
                            case AppType.DotNetAssembly:
                                f.labelAppTypeValue.Text = ".NET Assembly";
                                break;
                            case AppType.Win32Executable:
                                f.labelAppTypeValue.Text = "Win32 Executable File (*.exe)";
                                break;
                        }
                        f.labelExeFileValue.Text = AppInstaller.AppFolder + args[1] + "\\" + am.ExecutableFile;
                        f.labelAppManifestValue.Text = am.ManifestPath;
                        f.labelAppIconPathValue.Text = AppInstaller.AppFolder + args[1] + "\\" + am.AppIcon;
                        f.pictureBoxAppIcon.Image = Image.FromFile(AppInstaller.AppFolder + args[1] + "\\" + am.AppIcon);
                        System.Windows.Forms.Application.Run(f);
                    }
                    break;

            }
        }
    }

    public static void ShowHelpApplet()
    {
        Console.WriteLine("PSApps help");

        Console.WriteLine("psapps install <appfile> (Install an app)");
        Console.WriteLine("psapps uninstall <appname> (Uninstall an app)");
        Console.WriteLine("psapps getinfo <appname> (Opens a window with some infos about an app)");

        Console.WriteLine();
        Console.WriteLine("Examples :");

        Console.WriteLine("psapps install C:\\foo.zip");
        Console.WriteLine("psapps uninstall foo");
        Console.WriteLine("psapps getinfo foo");
    }
}