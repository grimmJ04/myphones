namespace Mobiles.Core.Utils
{
    public static class PathUtils
    {
        public static string Home => Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        public static string ResolveVirtual(string path) => path.Replace("~", Home);
    }
}
