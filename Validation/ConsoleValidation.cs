using System;

namespace Validation
{
    class ConsoleValidation
    {

        #region Data
        private string _email;
        private string _url;
        private string _path;
        #endregion

        public void GetData()
        {
            SetData();
        }

        private void SetData()
        {
            Console.WriteLine("Input email");
            _email = Console.ReadLine();
            Console.WriteLine("Input Url");
            _url = Console.ReadLine();
            Console.WriteLine("Input Path");
            _path = Console.ReadLine();
            var validator = new Validator(_email, _url, _path);
        }
    }
}
