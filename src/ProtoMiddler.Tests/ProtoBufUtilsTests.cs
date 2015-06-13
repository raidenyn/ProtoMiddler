using System.Diagnostics;
using NUnit.Framework;
using ProtoMiddler.Tests.Resources;

namespace ProtoMiddler.Tests
{
    public class ProtoBufUtilsTests
    {
        [Test]
        public void DecodeRaw()
        {
            var str = ProtoBufUtil.DecodeRaw(Samples.proto);

            Trace.WriteLine(str);
        }
    }
}
