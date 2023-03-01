using System;
using System.Diagnostics;   // Нужна, чтобы запускать внешние процессы
using System.IO;
using System.Net;           // Нужна, чтобы работать с Web
using System.Text.RegularExpressions;
using System.Text;
using System.Threading;     // Нужна, чтобы скоротать время
using System.Xml;
using System.Reflection;
using System.Security.Cryptography;
using System.Runtime.Remoting.Messaging;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Net.Mail;

namespace TestParcing
{
    class Program
    {
        static HttpClient httpClient = new HttpClient();
        static async Task Main()
        {
            // получаем ответ
            using (HttpResponseMessage response = await httpClient.GetAsync("https://www.lesegais.ru/open-area/deal"))
            {
                // получаем ответ
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
            Console.ReadKey();
        }
    }
}

//WebClient client = new WebClient();
//client.Encoding = System.Text.Encoding.UTF8;
//string ss;
//using (Stream stream = client.OpenRead("https://www.lesegais.ru/open-area/deal"))
//{
//    using (StreamReader sr = new StreamReader(stream))
//        ss = sr.ReadToEnd();
//}
//String Rate = Regex.Match(ss, @"<div class=""ag-header-cell ag-header-cell-sortable"">(\d+,\d+)</div>").Groups[1].Value;
//Console.WriteLine(Rate);
//Console.ReadKey();

//var code = "416001653";
//var proxy = new WebProxy("127.0.0.1:8888");
//var cookieContainer = new CookieContainer();

//var postRequest = new PostRequest("https://baucenter.ru/mebel_dlya_vannoy_razmer_50_59sm/686594/");
//postRequest.Data = $"ajax_call=y&INPUT_ID=title-search-input&q={code}&l=2";
//postRequest.Accept = "*/*";
//postRequest.Useragent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36";
//postRequest.ContentType = "application/x-www-form-urlencoded";
//postRequest.Referer = "https://baucenter.ru/mebel_dlya_vannoy_razmer_50_59sm/686594/";
//postRequest.Host = "baucenter.ru";
//postRequest.Proxy = proxy;

//postRequest.Headers.Add("Bx-ajax","true");
//postRequest.Headers.Add("Origin", "https://baucenter.ru");

//postRequest.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"110\", \"Not A(Brand\"; v =\"24\", \"Google Chrome\"; v = \"110\"");
//postRequest.Headers.Add("sec-ch-ua-mobile", "?0");
//postRequest.Headers.Add("sec-ch-ua-platform", "Windows");
//postRequest.Headers.Add("Sec-Fetch-Dest", "empty");
//postRequest.Headers.Add("Sec-Fetch-Mode", "cors");
//postRequest.Headers.Add("Sec-Fetch-Site", "same-origin");

//postRequest.Run(cookieContainer);

//var strStart = postRequest.Response.IndexOf("search-result-group search-result-product");
//strStart = postRequest.Response.IndexOf("<a href=", strStart) + 9;

//var strEnd = postRequest.Response.IndexOf("\"", strStart);
//var getPath = postRequest.Response.Substring(strStart, strEnd - strStart);

//Console.WriteLine($"getPath={getPath}");

//Console.ReadKey();

//var getRequest = new GetRequest($"https://baucenter.ru{getPath}");
//getRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7";
//getRequest.Useragent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36";
//getRequest.Referer = "https://baucenter.ru/mebel_dlya_vannoy_razmer_50_59sm/686594/";

//getRequest.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"110\", \"Not A(Brand\"; v =\"24\", \"Google Chrome\"; v = \"110\"");
//getRequest.Headers.Add("sec-ch-ua-mobile", "?0");
//getRequest.Headers.Add("sec-ch-ua-platform", "Windows");
//getRequest.Headers.Add("Sec-Fetch-Dest", "document");
//getRequest.Headers.Add("Sec-Fetch-Mode", "navigative");
//getRequest.Headers.Add("Sec-Fetch-Site", "same-origin");
//getRequest.Headers.Add("Sec-Fetch-User", "?1");
//getRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
//getRequest.Host = "baucenter.ru";
//getRequest.Run(cookieContainer);
