namespace DotNetCoreT4Template.T4
{
    partial class AppSettingsT4
    {
        private readonly string _appName;
        private readonly string _connectionStirng;

        public AppSettingsT4(string appName, string connectionStirng)
        {
            _appName = appName;
            _connectionStirng = connectionStirng;
        }
    }
}
