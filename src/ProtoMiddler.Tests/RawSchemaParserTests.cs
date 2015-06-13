using System.Diagnostics;
using NUnit.Framework;
using ProtoMiddler.Tests.Resources;

namespace ProtoMiddler.Tests
{
    public class RawSchemaParserTests
    {
        [Test]
        public void ParseRawSchema()
        {
            var tree = SchemaParser.ReadAsTree(Samples.raw_schema);

            Assert.NotNull(tree);

            tree.Traverse((node)=>{Trace.WriteLine(node.ToString());});

        }
    }
}
