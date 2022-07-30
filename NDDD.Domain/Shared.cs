using System.Configuration;

namespace NDDD.Domain
{
    public static class Shared
    {
        public static bool IsFake { get; }
            = ConfigurationManager.AppSettings["IsFake"] == "1";
    }
}
 