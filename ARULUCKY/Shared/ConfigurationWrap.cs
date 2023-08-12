using System.Configuration;

namespace Shared
{
    public class ConfigurationWrap
    {
        public static string BOT_TOKEN => ConfigurationManager.AppSettings["botToken"]
                                    ?? throw new ConfigurationErrorsException($"{nameof(BOT_TOKEN)} value is null.");

        public static string DATETIME_FORMAT => ConfigurationManager.AppSettings["dateTimeFormat"]
                                    ?? throw new ConfigurationErrorsException($"{nameof(DATETIME_FORMAT)} value is null.");

        public static string[] ALLOWED_FILE_EXTENSIONS => ConfigurationManager.AppSettings["allowedFileExtensions"]?.Split(",")
                                    ?? throw new ConfigurationErrorsException($"{nameof(ALLOWED_FILE_EXTENSIONS)} value is null."); 

        public static string DB_CONNECTION => ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString
                                    ?? throw new ConfigurationErrorsException($"{nameof(DB_CONNECTION)} value is null.");


        public static string ALLOWED_EXTENSIONS_FILE_FIlTER
        {
            get
            {
                var currExt = ALLOWED_FILE_EXTENSIONS;

                string allowedFilesFilter = "Allowed Files (" + string.Join(",", currExt) + ")|" + string.Join(";", currExt.Select(ext => "*." + ext));
                string allFilesFilter = "All Files (*.*)|*.*";

                return allowedFilesFilter + "|" + allFilesFilter;
            }
        } 
    }
}
