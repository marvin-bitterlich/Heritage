using TaleWorlds.Library;

namespace Heritage
{
    internal class Utils
    {
        private static readonly Logger logger = new Logger("Heritage.Logger");

        internal static void Print(string text)
        {
            logger.Print($"[Heritage]{text}");
        }
    }
}