
using Microsoft.Extensions.Configuration;
using MyGuestApp.DAL;


namespace myHostApp
{
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            string? conn = config["ConnectionString"];
            string? dbName = config["DefaultDB"];

            if (string.IsNullOrEmpty(conn) || string.IsNullOrEmpty(dbName))
            {
                throw new ArgumentNullException("Connection string or database name is missing");
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            DBContext dbContext = new DBContext(conn);
            Manager guestManager = new Manager(dbContext);
            FormHandler handler = new FormHandler(guestManager);
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            handler.ShowMainform();
            Application.Run();
            /*
             ?????, ????? ???????, ????????
             */
        }
    }
}