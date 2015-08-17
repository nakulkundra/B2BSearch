using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2BSearch.Search.Common;
using System.Net.Http;
using System.Xml;
using Newtonsoft.Json;

namespace B2BSearch.Search.BookSearch.ThirdPartyHelper
{
    public class SearchForBooks : ISearch
    {
        private const string uriSnip = "https://www.googleapis.com/books/v1/volumes?q=#query#";
        public XmlDocument Search(string query)
        {
            string JSONOutPut;
            using (var client = new HttpClient())
            {
                JSONOutPut = client.GetStringAsync(this.TPQueryBuilder(query)).Result;
            }
            return Convert(JSONOutPut);
        }
        private string TPQueryBuilder(string query)
        {
            return uriSnip.Replace("#query#", query);
        }

        private XmlDocument Convert(string json)
        {
            XmlDocument doc = JsonConvert.DeserializeXmlNode(json, "root");
            return doc;
        }

        private string Convert(XmlDocument xml)
        {
            string jsonText = JsonConvert.SerializeXmlNode(xml);
            return jsonText;
        }

    }
}

