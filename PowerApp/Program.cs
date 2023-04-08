using PowerAppLib;

namespace PowerApp;

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
            }
        }
    }

    public static void ShowHelpApplet()
    {
        Console.WriteLine("PowerApps help");

        Console.WriteLine("powerapp install <appfile> (Install an app)");
        Console.WriteLine("powerapp uninstall <appname> (Coming soon...)");

        Console.WriteLine();
        Console.WriteLine("Examples :");

        Console.WriteLine("powerapp install C:\\foo.zip");
        Console.WriteLine("powerapp uninstall foo");
    }
}