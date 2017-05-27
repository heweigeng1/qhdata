using core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ManC
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Show();
            }

        }
        public static void Show()
        {
            string data = Get("http://hq.sinajs.cn/list=RB1710,RB1801,I1709,I1801");
            //var data= Get("http://api.money.126.net/data/feed/FU_i1709");
            List<List<string>> list = new List<List<string>>();
            var str_body = data.Substring(0,data.Length-3).Split(';');
            Regex reg = new Regex(@"[""].*?[""]");
            var mathch = reg.Matches(data);
            var head = $"期货名称\t编号\t开盘价\t最高价\t最低价\t收盘价\t买价\t卖价\t最新价\t结算价\t昨结算\t买量\t卖量\t持仓量\t成交量\t成交所\t简称\t日期";
            Console.WriteLine(head);
            foreach (Match m in mathch)
            {
                string str = m.Value.Substring(1, m.Value.Length - 2);
                
                QHModel model = new QHModel(str);
            }
            Thread.Sleep(1000);
            Console.Clear();
        }
        public static string Get(string url)
        {
            string result = string.Empty;
            try
            {
                HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
                wbRequest.Method = "GET";
                wbRequest.ContentType = "text/html;charset=UTF-8";
                HttpWebResponse wbResponse = (HttpWebResponse)wbRequest.GetResponse();
                using (Stream responseStream = wbResponse.GetResponseStream())
                {
                    using (StreamReader sReader = new StreamReader(responseStream, Encoding.GetEncoding("gb2312")))
                    {
                        result = sReader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }
    }

}
