using System.Configuration;
using System.IO;

namespace Bounce.Console
{
    class BounceDirectoryFinder : IBounceDirectoryFinder
    {
        private readonly string directoryName;

        public BounceDirectoryFinder()
        {
            directoryName = ConfigurationManager.AppSettings["Tasks.Directory.Name"];
            if (directoryName == null) throw new ConfigurationException("The AppSetting key Tasks.Directory.Name was not found.");
        }

        public string FindBounceDirectory()
        {
            return FindBounceDirectoryFrom(Directory.GetCurrentDirectory());
        }

        private string FindBounceDirectoryFrom(string dir)
        {
            if (string.IsNullOrEmpty(dir))
            {
                return null;
            }

            var bounceDir = Path.Combine(dir, directoryName);

            return Directory.Exists(bounceDir) ? bounceDir : FindBounceDirectoryFrom(Path.GetDirectoryName(dir));
        }
    }
}