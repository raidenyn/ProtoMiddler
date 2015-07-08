using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ProtoMiddler
{
    public static class SchemaParser
    {
        public static TreeNode<ProtoItem> ReadAsTree(string protoSchema)
        {
            var reader = new StringReader(protoSchema);

            var tree = new TreeNode<ProtoItem>(new ProtoItem { Name = "root" });

            ReadTo(tree, reader);

            return tree;
        }


        private static void ReadTo(TreeNode<ProtoItem> node, StringReader reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (String.IsNullOrWhiteSpace(line))
                {
                    return;
                }

                if (TryParseValue(node, line))
                {
                    continue;
                }

                if (TryEndSubItem(node, reader, line))
                {
                    break;
                }

                TrySubItem(node, reader, line);
            }
        }

        private static readonly Regex ValueRegex = new Regex("^\\s*?(\\w+?) *?:(.+)$", RegexOptions.Compiled);

        private static bool TryParseValue(TreeNode<ProtoItem> node, string line)
        {
            var match = ValueRegex.Match(line);

            if (!match.Success)
            {
                return false;
            }

            node.AddChild(new ProtoItem { Name = match.Groups[1].Value, Value = match.Groups[2].Value });

            return true;
        }

        private static readonly Regex NewSubRegex = new Regex("^\\s*?(\\w+?) *?{\\s*?$", RegexOptions.Compiled);

        private static bool TrySubItem(TreeNode<ProtoItem> node, StringReader reader, string line)
        {
            var match = NewSubRegex.Match(line);

            if (!match.Success)
            {
                return false;
            }

            var newSubNode = node.AddChild(new ProtoItem { Name = match.Groups[1].Value, Value = "..." });

            ReadTo(newSubNode, reader);

            return true;
        }

        private static readonly Regex EndSubRegex = new Regex("^\\s*?}\\s*?$", RegexOptions.Compiled);

        private static bool TryEndSubItem(TreeNode<ProtoItem> node, StringReader reader, string line)
        {
            return EndSubRegex.IsMatch(line);
        }
    }

    public class ProtoItem
    {
        public string Name { get; set; }

        public string Value { get; set; }


        public override string ToString()
        {
            if (String.IsNullOrWhiteSpace(Value))
            {
                return Name;
            }

            if (Value.Length > 100)
            {
                Value = Value.Substring(0, 100) + "...";
            }

            return Name + ": " + Value;
        }
    }
}
