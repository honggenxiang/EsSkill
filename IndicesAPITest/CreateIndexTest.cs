using IndicesAPI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndicesAPITest
{
    [TestFixture]
    public class CreateIndexTest
    {
        string url = "http://10.1.1.19:9215/";
        CreateIndex createIndex;
        public CreateIndexTest()
        {
            createIndex = new CreateIndex(url);
        }
        [Test]
        public void CreateDSL()
        {
            createIndex.CreateDSL("zxxk3");
        }

        //http://10.1.1.19:9215/


    }
}
