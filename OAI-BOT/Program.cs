namespace OAI_BOT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new OAI_APP.Form1());

            string cfgPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            cfgPath += "/open-ai-app";
            if (!Directory.Exists(cfgPath))
            {
                Directory.CreateDirectory(cfgPath);
            }

            string pathToCfg = cfgPath += "/open-ai-cfg.txt";
            if (!File.Exists(pathToCfg))
            {
                File.Create(pathToCfg);
            }
        }
    }
}