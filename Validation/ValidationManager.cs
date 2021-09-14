using System;

namespace Validation
{
    class ValidationManager
    {

        private string JPATH = $"{Environment.CurrentDirectory}//data.json";
        private string XPATH = $"{Environment.CurrentDirectory}//data.xml";

        public void Manager()
        {
            #region Constractors
            ConsoleValidation consoleValidation = new ConsoleValidation();
            JsonValidation jsonValidation = new JsonValidation(JPATH);
            XmlValidation xmlValidation = new XmlValidation(XPATH);
            #endregion
            Console.WriteLine("Form Console");
            consoleValidation.GetData();
            Console.WriteLine("-------------------------");
            Console.WriteLine("From Json");
            jsonValidation.GetData();
            Console.WriteLine("-------------------------");
            Console.WriteLine("From Xml");
            xmlValidation.GetData();
            Console.WriteLine("-------------------------");
        }
    }
}
