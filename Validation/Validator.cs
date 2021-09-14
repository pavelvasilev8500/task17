using System;
using System.Text.RegularExpressions;


namespace Validation
{
    class Validator
    {
        private string _emailpattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
        private string _urlpattern = @"(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";
        private string _pathpattern = @"^(?:[a-zA-Z]\:|\\\\[\w\.]+\\[\w.$]+)\\(?:[\w]+\\)*\w([\w.])+$";

        Data data = new Data();

        public Validator(string email, string url, string path)
        {
            try
            {
                if (Regex.IsMatch(email, _emailpattern, RegexOptions.IgnoreCase))
                {
                    data.Email = email;
                    Console.WriteLine("Validation passed");
                    Console.WriteLine($"{data.Email}");
                }
                else
                {
                    data.Email = email;
                    Console.WriteLine("Invalid Email address");
                    Console.WriteLine($"{data.Email}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);  
            }
            try
            {
                if (Regex.IsMatch(url, _urlpattern, RegexOptions.IgnoreCase))
                {
                    data.Url = url;
                    Console.WriteLine("Validation passed");
                    Console.WriteLine($"{data.Url}");
                }
                else
                {
                    data.Url = url;
                    Console.WriteLine("Invalid Url address");
                    Console.WriteLine($"{data.Url}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                if (Regex.IsMatch(path, _pathpattern, RegexOptions.IgnoreCase))
                {
                    data.Path = path;
                    Console.WriteLine("Validation passed");
                    Console.WriteLine($"{data.Path}");
                }
                else
                {
                    data.Path = path;
                    Console.WriteLine("Invalid Path");
                    Console.WriteLine($"{data.Path}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
