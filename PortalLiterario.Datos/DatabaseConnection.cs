using System.Configuration;

namespace PortalLiterario.Datos
{
    public class DatabaseConnection
    {
        public static string cn = ConfigurationManager.ConnectionStrings["Strings"].ToString();
    }
}
