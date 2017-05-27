using System;

namespace core
{
    public class QHModel
    {
        public QHModel()
        {
        }
        public QHModel(string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                var str = data.Split(',');
                for (int i = 0; i <= 17; i++)
                {
                    Console.Write(str[i]);
                    Console.Write("\t");
                }
                Console.Write("\n");
                //期货名称 = str[0];
                //Console.WriteLine($"期货名称:{期货名称}");
                //编号 = str[1];
                //Console.WriteLine($"编号:{编号}");
                //开盘价 = str[2].ToDec();
                //Console.WriteLine($"开盘价:{开盘价}");
                //最高价 = str[3].ToDec();
                //Console.WriteLine($"最高价:{最高价}");
                //最低价 = str[4].ToDec();
                //Console.WriteLine($"最低价:{最低价}");
                //昨日收盘价 = str[5].ToDec();
                //Console.WriteLine($"昨日收盘价:{昨日收盘价}");
                //买价 = str[6].ToDec();
                //Console.WriteLine($"买价:{买价}");
                //卖价 = str[7].ToDec();
                //Console.WriteLine($"卖价:{卖价}");
                //最新价 = str[8].ToDec();
                //Console.WriteLine($"最新价:{最新价}");
                //结算价 = str[9].ToDec();
                //Console.WriteLine($"结算价:{结算价}");
                //昨日结算 = str[10].ToDec();
                //Console.WriteLine($"昨日结算:{昨日结算}");
                //买量 = str[11].ToDec();
                //Console.WriteLine($"买量:{买量}");
                //卖量 = str[12].ToDec();
                //Console.WriteLine($"卖量:{卖量}");
                //持仓量 = str[13].ToDec();
                //Console.WriteLine($"持仓量:{持仓量}");
                //成交量 = str[14].ToDec();
                //Console.WriteLine($"成交量:{成交量}");
                //成交所 = str[15];
                //Console.WriteLine($"成交所:{成交所}");
                //品种简称 = str[16];
                //Console.WriteLine($"品种简称:{品种简称}");
                //日期 = str[17];
                //Console.WriteLine($"日期:{日期}");
            }
        }
        public string 期货名称 { get; set; }
        public string 编号 { get; set; }
        public decimal 开盘价 { get; set; }
        public decimal 最高价 { get; set; }
        public decimal 最低价 { get; set; }
        public decimal 昨日收盘价 { get; set; }
        public decimal 买价 { get; set; }
        public decimal 卖价 { get; set; }
        public decimal 最新价 { get; set; }
        public decimal 结算价 { get; set; }
        public decimal 昨日结算 { get; set; }
        public decimal 买量 { get; set; }
        public decimal 卖量 { get; set; }
        public decimal 持仓量 { get; set; }
        public decimal 成交量 { get; set; }
        public string 成交所 { get; set; }
        public string 品种简称 { get; set; }
        public string 日期 { get; set; }
        
    }
   
}
