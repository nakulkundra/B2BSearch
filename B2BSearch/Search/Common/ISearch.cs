using System.Xml;

namespace B2BSearch.Search.Common
{
    public interface ISearch
    {
        XmlDocument Search(string query);
    }
}