using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace IndicesAPI
{
    public class CreateIndex
    {
        private readonly string url;
        public CreateIndex(string url)
        {
            this.url = url;
        }
        #region DSL

        public void CreateDSL(string indexName)
        {
            using (var client = new HttpClient())
            {
                var ql = "{\"settings\" : {\"index\" : {\"number_of_shards\" : 3,\"number_of_replicas\" : 1 } }}";
                var content = new StringContent(ql);
                var result = client.PutAsync(url.URLCombine(indexName), content).Result.Content.ReadAsStringAsync();
            }

        }
    }
    #endregion
}

