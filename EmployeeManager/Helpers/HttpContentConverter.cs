using System.Net.Http;
using System.Text;

namespace EmployeeManager.Helpers
{
    class HttpContentConverter
    {
        public static StringContent ConvertFromJson(string jsonContent)
        {
            var stringContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
