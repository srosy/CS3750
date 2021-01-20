using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace A03
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Enter a stock code: ");
            var code = Console.ReadLine().ToUpper();
            var response = await ExecuteCallAsync(code);
            if (string.IsNullOrEmpty(response))
                Console.WriteLine("Invalid code.");
            else
                Console.WriteLine($"Response: {response}");
            Console.Read();
        }

        /// <summary>
        /// Executes an async Get to the AlphaAdvantage API. Returns response string provided passed code exists.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        static async Task<string> ExecuteCallAsync(string code)
        {
            try
            {
                var client = new HttpClient();
                var uri = $"https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=$&apikey=3O1E938UHPASK7HX".Replace("$", code);
                string responseBody = await client.GetStringAsync(uri);
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return string.Empty;
        }
    }
}
