using System;
using System.IO;
using System.Xml.Serialization;

namespace Validation
{
    class XmlValidation
    {

        #region Data
        private string PATH;
        private string _email;
        private string _url;
        private string _path;
        #endregion

        public XmlValidation(string path)
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
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Data));
                    Data deserializeData = (Data)xmlSerializer.Deserialize(reader);
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
