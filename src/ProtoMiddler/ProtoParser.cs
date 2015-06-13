using System.Linq;
using System.Text.RegularExpressions;

namespace ProtoMiddler
{
    public static class ProtoParser
    {
        private static readonly Regex PackageNameRegex = new Regex("package\\s+?(\\S+)\\s*?;", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled);

        public static string GetPackageName(string protoText)
        {
            var match = PackageNameRegex.Match(protoText);

            if (!match.Success)
            {
                return null;
            }

            return match.Groups[1].Value;
        }

        private static readonly Regex MessageNameRegex = new Regex("message\\s+?(\\S+)\\s*?{", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled);

        public static string[] GetMessages(string protoText)
        {
            var namePrefix = GetPackageName(protoText) + ".";

            var matches = MessageNameRegex.Matches(protoText);

            return matches.Cast<Match>().Select(match => namePrefix + match.Groups[1].Value).ToArray();
        } 
    }
}
