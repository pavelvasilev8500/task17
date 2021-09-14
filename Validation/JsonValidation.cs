using System;
using System.IO;
using System.Text.Json;

namespace Validation
{
    class JsonValidation
    {

        #region Data
        private string PATH;
        private string _email;
        private string _url;
        private string _path;
        #endregion

        public JsonValidation(string path)
        {
            PATH = path;
        }

        public void GetData()
        {
            SetData();
        }

        private void SetData()
        {
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                Console.WriteLine("No file for input data.");
            }
            else
            {
                using (FileStream reader = new FileStream(PATH, FileMode.Open))
                {
                    byte[] restoredData = new byte[reader.Length];
                    reader.Read(restoredData, 0, restoredData.Length);
                    var utf8Reader = new Utf8JsonReader(restoredData);
                    Data deserializeData =
                        JsonSerializer.Deserialize<Data>(ref utf8Reader);
                    if (deserializeData == null)
                        Console.WriteLine("No data for output.");
                    else
                    {
                        _email = deserializeData.Email;
                        _url = deserializeData.Url;
                        _path = deserializeData.Path;
                    }
                }
                var validator = new Validator(_email, _url, _path);
            }
        }
    }
}
