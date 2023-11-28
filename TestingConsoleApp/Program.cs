// See https://aka.ms/new-console-template for more information
using System;
using static System.Net.WebRequestMethods;

Console.WriteLine("Hello, World!");
string uri = "https://raw.githubusercontent.com/qualified/challenge-data/master/words_alpha.txt";
string stem = "";
using (HttpClient httpClient = new HttpClient())
{
    HttpResponseMessage response = await httpClient.GetAsync(uri);

    if (response.IsSuccessStatusCode)
    {
        var strResponse = await response.Content.ReadAsStringAsync();

        var listResponse = strResponse.Split('\n');

        Result result = new Result();

        if (string.IsNullOrEmpty(stem) || stem == "/")
        {
            result.data.AddRange(listResponse);
        }

        var sorderList = listResponse.Where(x => x.StartsWith(stem));

        if (sorderList.Count() == 0)
        {
            Console.WriteLine(" NotFound()");
        }

        result.data.AddRange(sorderList);

        Console.WriteLine(" Ok(result)");
    }
    else
    {
        Console.WriteLine("NotFound()");
    }
}

Console.ReadKey();

public class Result
{
    public List<string> data { get; set; }

    public Result()
    {
        data = new List<string>();
    }

}