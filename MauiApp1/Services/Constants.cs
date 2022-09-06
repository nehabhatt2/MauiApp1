namespace MauiApp1.Services
{
    public static class Constants
    {
        // Reference : https://docs.microsoft.com/en-us/dotnet/maui/data-cloud/rest
        // URL of REST service
        //public static string RestUrl = "https://YOURPROJECT.azurewebsites.net/api/todoitems/{0}";

        // URL of REST service (Android does not use localhost)
        // Use http cleartext for local deployment. Change to https for production
        public static string LocalhostUrl = DeviceInfo.Platform == DevicePlatform.Android ? "172.30.102.236" : "localhost";
        public static string Scheme = "http"; // or https
        public static string Port = "5000"; // 5000 for http, 5001 for https
        public static string RestUrl = $"{Scheme}://{LocalhostUrl}:{Port}/api/todoitems/";
    }
}
