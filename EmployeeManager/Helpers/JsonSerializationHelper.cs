using System;
using System.Text.Json;

namespace EmployeeManager.Helpers
{
    class JsonSerializationHelper<T>
    {
        public T DeserializeFromString(string input)
        {
            try
            {
                var deserializedObject = JsonSerializer.Deserialize<T>(input);
                return deserializedObject;
            }
            catch(Exception ex)
            {
                Logger.Log($"{ex.Message}{Environment.NewLine}{ex.StackTrace}");
                return default(T);
            }

        }

        public string SerializeObject(T input)
        {
            try
            {
                var serializedString = JsonSerializer.Serialize<T>(input);
                return serializedString;
            }
            catch (Exception ex)
            {
                Logger.Log($"{ex.Message}{Environment.NewLine}{ex.StackTrace}");
                return string.Empty;
            }
        }
    }
}
