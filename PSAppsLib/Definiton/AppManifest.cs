namespace PSAppsLib.AppLoader
{
    public enum AppType
    {
        DotNetAssembly,
        Win32Executable,
    }
    public class AppManifest
    {
        public string AppDisplayName { get; set; } = "Application";
        public string AppName { get; set; } = "App";
        public string AppAuthor { get; set; } = "RaphMar2022";
        public string AppDescription { get; set; } = "An app.";
        public double AppVersion { get; set; } = 1.0;
        public AppType AppType { get; set; } = AppType.DotNetAssembly;
        public string AppIcon { get; set; } = "";
        public string ManifestPath { get; set; } = "";
        public string ExecutableFile { get; set; } = "";
        public string MainType { get; set; } = "";

        public int LoadManifest()
        {
            FileInfo f = new FileInfo(ManifestPath);

            if (f.Exists)
            {
                if (f.Extension.EndsWith("pam"))
                {
                    string[] lines = File.ReadAllLines(f.FullName);
                    if (lines[0] == "[PowerApp]")
                    {
                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] lineSplitted = lines[i].Split('=');
                            string name = lineSplitted[0];
                            string value = lineSplitted[1];
                            switch (name)
                            {
                                case "Type":
                                    switch (value)
                                    {
                                        case "dotnetdll":
                                            AppType = AppType.DotNetAssembly; break;
                                        case "win32exec":
                                            AppType = AppType.Win32Executable; break;
                                    }
                                    break;
                                case "DisplayName":
                                    AppDisplayName = value;
                                    break;
                                case "Name":
                                    AppName = value;
                                    break;
                                case "Icon":
                                    AppIcon = value;
                                    break;
                                case "Description":
                                    AppDescription = value;
                                    break;
                                case "Author":
                                    AppAuthor = value;
                                    break;
                                case "Version":
                                    value = value.Replace('.', ',');
                                    AppVersion = double.Parse(value);
                                    break;
                                case "Executable":
                                    ExecutableFile = value;
                                    break;
                                case "MainType":
                                    MainType = value;
                                    break;
                            }
                        }
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 3;
            }
        }

        public AppManifest(string v)
        {
            ManifestPath = v;
            Console.WriteLine(LoadManifest());
        }
    }
}