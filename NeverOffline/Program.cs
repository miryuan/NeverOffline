using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace NeverOffline
{
    class Program
    {
        static Random anjianJiange = new Random();
        static Random tingzhiJiange = new Random();
        static Random qianhouJiange = new Random();

        static void Main(string[] args)
        {
            Console.Title = "永不下线(by 刘备编草鞋)";
            Console.WriteLine("登录魔兽世界先(免得说我盗号),然后把本程序打开,后把魔兽世界设成当前窗口.");
            Console.WriteLine("功能:自动跳跃,前进一步,后退一步.(按键间隔都是随机,防检测.)");
            Console.WriteLine("10秒后开始.");
            Thread.Sleep(10000);

            while (true)
            {
                int wuchasuiji = tingzhiJiange.Next(-5, 5);//误差随机
                try
                {
                    Suiji();
                }
                catch { }

                Console.WriteLine(string.Format("{0}\t下次模拟等待时间{1}秒", DateTime.Now.ToString("mm:HH:ss"), (15 + wuchasuiji)));
                Thread.Sleep((15 + wuchasuiji) * 1000);
            }
        }

        static void Suiji()
        {
            var ret = anjianJiange.Next(1, 5);
            switch (ret)
            {
                case 1:
                    QianJin();
                    break;
                case 2:
                    Houtui();
                    break;
                case 3:
                    Tiao();
                    break;
                case 4:
                    Baoguo();
                    break;
                case 5:
                    Zhuangbei();
                    break;
            }
        }

        /// <summary>
        /// 前进
        /// </summary>
        static void QianJin()
        {
            int qian = qianhouJiange.Next(200, 500);
            //前进一步
            Keys.keybd_event(Keys.vbKeyW, 0, 0, 0);
            Thread.Sleep(qian);
            Keys.keybd_event(Keys.vbKeyW, 0, 2, 0);
            Thread.Sleep(tingzhiJiange.Next(100, 900));
        }

        /// <summary>
        /// 
        /// </summary>
        static void Houtui()
        {
            int hou = qianhouJiange.Next(200, 500);
            //后退一步
            Keys.keybd_event(Keys.vbKeyD, 0, 0, 0);
            Thread.Sleep(hou);
            Keys.keybd_event(Keys.vbKeyD, 0, 2, 0);
        }

        /// <summary>
        /// 跳
        /// </summary>
        static void Tiao()
        {
            int jiange1 = anjianJiange.Next(12, 100);
            //模拟按下Space键
            Keys.keybd_event(Keys.vbKeySpace, 0, 0, 0);
            Thread.Sleep(jiange1);
            Keys.keybd_event(Keys.vbKeySpace, 0, 2, 0);
        }

        static void Baoguo()
        {
            int jiange1 = anjianJiange.Next(12, 100);
            //模拟按下Space键
            Keys.keybd_event(Keys.vbKeyB, 0, 0, 0);
            Thread.Sleep(jiange1);
            Keys.keybd_event(Keys.vbKeyB, 0, 2, 0);
        }

        static void Zhuangbei()
        {
            int jiange1 = anjianJiange.Next(12, 100);
            //模拟按下Space键
            Keys.keybd_event(Keys.vbKeyC, 0, 0, 0);
            Thread.Sleep(jiange1);
            Keys.keybd_event(Keys.vbKeyC, 0, 2, 0);
        }
    }
}
