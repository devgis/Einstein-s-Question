using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ayst
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Man> 已知 = new List<Man>();
            string[] 饮料 = new string[4] { "咖啡", "牛奶", "啤酒", "矿泉水" };
            string[] 香烟 = new string[4] { "PALL MALL", "DUNHILL", "BLUE MASTER", "混合烟" };
            string[] 宠物 = new string[4] { "鸟", "猫", "马", "鱼" };
            string[] 房子 = new string[4] { "白", "绿", "黄", "蓝" };
            int[] 房子次序 = new int[4] { 2, 3, 4, 5 };

            int counnum = 0;

            #region 穷举所有可能性
            for (int i = 0; i < 4; i++)//饮料
            {
                string 英国人饮料 = 饮料[i];
                for (int i1 = 0; i1 < 4; i1++)
                {
                    if (饮料[i1] != 饮料[i])
                    {
                        string 瑞典人饮料 = 饮料[i1];
                        for (int i2 = 0; i2 < 4; i2++)
                        {
                            if (饮料[i2] != 饮料[i] && 饮料[i2] != 饮料[i1])
                            {
                                string 挪威人饮料 = 饮料[i2];
                                for (int i3 = 0; i3 < 4; i3++)
                                {
                                    if (饮料[i3] != 饮料[i] && 饮料[i3] != 饮料[i1] && 饮料[i3] != 饮料[i2])
                                    {
                                        string 德国人饮料 = 饮料[i3];
                                        for (int j = 0; j < 4; j++)
                                        {
                                            string 英国人香烟 = 香烟[j];
                                            for (int j1 = 0; j1 < 4; j1++)
                                            {
                                                if (香烟[j1] != 香烟[j])
                                                {
                                                    string 瑞典人香烟 = 香烟[j1];
                                                    for (int j2 = 0; j2 < 4; j2++)
                                                    {
                                                        if (香烟[j2] != 香烟[j] && 香烟[j2] != 香烟[j1])
                                                        {
                                                            string 挪威人香烟 = 香烟[j2];
                                                            for (int j3 = 0; j3 < 4; j3++)
                                                            {
                                                                if (香烟[j3] != 香烟[j] && 香烟[j3] != 香烟[j1] && 香烟[j3] != 香烟[j2])
                                                                {
                                                                    string 丹麦人香烟 = 香烟[j3];
                                                                    for (int l = 0; l < 4; l++)
                                                                    {
                                                                        string 英国人宠物 = 宠物[l];
                                                                        for (int l1 = 0; l1 < 4; l1++)
                                                                        {
                                                                            if (宠物[l1] != 宠物[l])
                                                                            {
                                                                                string 德国人宠物 = 宠物[l1];
                                                                                for (int l2 = 0; l2 < 4; l2++)
                                                                                {
                                                                                    if (宠物[l2] != 宠物[l] && 宠物[l2] != 宠物[l1])
                                                                                    {
                                                                                        string 挪威人宠物 = 宠物[l2];
                                                                                        for (int l3 = 0; l3 < 4; l3++)
                                                                                        {
                                                                                            if (宠物[l3] != 宠物[l] && 宠物[l3] != 宠物[l1] && 宠物[l3] != 宠物[l2])
                                                                                            {
                                                                                                string 丹麦人宠物 = 宠物[l3];
                                                                                                for (int m = 0; m < 4; m++)
                                                                                                {
                                                                                                    string 瑞典人房子 = 房子[m];
                                                                                                    for (int m1 = 0; m1 < 4; m1++)
                                                                                                    {
                                                                                                        if (房子[m1] != 房子[m])
                                                                                                        {
                                                                                                            string 德国人房子 = 房子[m1];
                                                                                                            for (int m2 = 0; m2 < 4; m2++)
                                                                                                            {
                                                                                                                if (房子[m2] != 房子[m] && 房子[m2] != 房子[m1])
                                                                                                                {


                                                                                                                    string 挪威人房子 = 房子[m2];
                                                                                                                    for (int m3 = 0; m3 < 4; m3++)
                                                                                                                    {
                                                                                                                        if (房子[m3] != 房子[m] && 房子[m3] != 房子[m1] && 房子[m3] != 房子[m2])
                                                                                                                        {
                                                                                                                            string 丹麦人房子 = 房子[m3];
                                                                                                                            for (int n = 0; n < 4; n++)
                                                                                                                            {
                                                                                                                                int 英国人房子次序 = 房子次序[n];
                                                                                                                                for (int n1 = 0; n1 < 4; n1++)
                                                                                                                                {
                                                                                                                                    if (房子次序[n1] != 房子次序[n])
                                                                                                                                    {
                                                                                                                                        int 德国人房子次序 = 房子次序[n1];
                                                                                                                                        for (int n2 = 0; n2 < 4; n2++)
                                                                                                                                        {
                                                                                                                                            if (房子次序[n2] != 房子次序[n] && 房子次序[n2] != 房子次序[n1])
                                                                                                                                            {
                                                                                                                                                int 瑞典房子次序 = 房子次序[n2];
                                                                                                                                                for (int n3 = 0; n3 < 4; n3++)
                                                                                                                                                {
                                                                                                                                                    if (房子次序[n3] != 房子次序[n] && 房子次序[n3] != 房子次序[n1] && 房子次序[n3] != 房子次序[n2])
                                                                                                                                                    {
                                                                                                                                                        int 丹麦人房子次序 = 房子次序[n3];

                                                                                                                                                        #region 构造相关结果
                                                                                                                                                        //counnum++;
                                                                                                                                                        //if (counnum == 4801)
                                                                                                                                                        //{
                                                                                                                                                        //    Console.WriteLine("ffffffffffff");
                                                                                                                                                        //}
                                                                                                                                                        //Console.WriteLine("第"+counnum.ToString()+"次操作！");
                                                                                                                                                        Man 英国人啊 = new Man();
                                                                                                                                                        英国人啊.国籍 = "英国";
                                                                                                                                                        英国人啊.房子 = "红";
                                                                                                                                                        英国人啊.香烟 = 英国人香烟;
                                                                                                                                                        英国人啊.宠物 = 英国人宠物;
                                                                                                                                                        英国人啊.房子次序 = 英国人房子次序;
                                                                                                                                                        英国人啊.饮料 = 英国人饮料;

                                                                                                                                                        Man 瑞典人啊 = new Man();
                                                                                                                                                        瑞典人啊.国籍 = "瑞典";
                                                                                                                                                        瑞典人啊.宠物 = "狗";
                                                                                                                                                        瑞典人啊.房子 = 瑞典人房子;
                                                                                                                                                        瑞典人啊.香烟 = 瑞典人香烟;
                                                                                                                                                        瑞典人啊.房子次序 = 瑞典房子次序;
                                                                                                                                                        瑞典人啊.饮料 = 瑞典人饮料;

                                                                                                                                                        Man 丹麦人啊 = new Man();
                                                                                                                                                        丹麦人啊.国籍 = "丹麦";
                                                                                                                                                        丹麦人啊.饮料 = "茶";
                                                                                                                                                        丹麦人啊.房子 = 丹麦人房子;
                                                                                                                                                        丹麦人啊.香烟 = 丹麦人香烟;
                                                                                                                                                        丹麦人啊.宠物 = 丹麦人宠物;
                                                                                                                                                        丹麦人啊.房子次序 = 丹麦人房子次序;


                                                                                                                                                        Man 挪威人啊 = new Man();
                                                                                                                                                        挪威人啊.国籍 = "挪威";
                                                                                                                                                        挪威人啊.房子次序 = 1;
                                                                                                                                                        挪威人啊.房子 = 挪威人房子;
                                                                                                                                                        挪威人啊.香烟 = 挪威人香烟;
                                                                                                                                                        挪威人啊.宠物 = 挪威人宠物;
                                                                                                                                                        挪威人啊.饮料 = 挪威人饮料;

                                                                                                                                                        Man 德国人啊 = new Man();
                                                                                                                                                        德国人啊.国籍 = "德国";
                                                                                                                                                        德国人啊.香烟 = "PRINCE";
                                                                                                                                                        德国人啊.房子 = 德国人房子;
                                                                                                                                                        德国人啊.宠物 = 德国人宠物;
                                                                                                                                                        德国人啊.房子次序 = 德国人房子次序;
                                                                                                                                                        德国人啊.饮料 = 德国人饮料;

                                                                                                                                                        ManContainer 老外合集 = new ManContainer();
                                                                                                                                                        老外合集.丹麦人 = 丹麦人啊;
                                                                                                                                                        老外合集.德国人 = 德国人啊;
                                                                                                                                                        老外合集.挪威人 = 挪威人啊;
                                                                                                                                                        老外合集.瑞典人 = 瑞典人啊;
                                                                                                                                                        老外合集.英国人 = 英国人啊;

                                                                                                                                                        if (Check1(老外合集) && Check2(老外合集) && Check3(老外合集) && Check4(老外合集) && Check5(老外合集) && Check6(老外合集) && Check7(老外合集) && Check8(老外合集) && Check9(老外合集))
                                                                                                                                                        {
                                                                                                                                                            Man FuHeTiaoJian = GetManByChongWu("鱼", 老外合集);
                                                                                                                                                            Console.WriteLine("养鱼的人是：" + FuHeTiaoJian.国籍);
                                                                                                                                                        }
                                                                                                                                                        #endregion
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            System.Console.Write("执行完毕！");

            System.Console.Read();
        }

        #region 判决方法
        /// <summary>
        /// 绿房子在白房子旁边，绿房子主人喝咖啡
        /// </summary>
        /// <param name="老外合集"></param>
        /// <returns></returns>
        static public bool Check1(ManContainer 一个老外)
        {
            Man temp1 = GetManByFangZi("绿", 一个老外);
            Man temp2 = GetManByFangZi("白", 一个老外);

            return (Math.Abs(temp1.房子次序 - temp2.房子次序) == 1 && temp1.饮料 == "咖啡");
        }
        /// <summary>
        /// 抽"PALL MALL"烟的人养 "鸟";
        /// </summary>
        /// <param name="老外合集"></param>
        /// <returns></returns>
        static public bool Check2(ManContainer 一个老外)
        {
            Man temp1 = GetManByYan("PALL MALL", 一个老外);
            return (temp1.宠物 == "鸟");
        }
        /// <summary>
        /// 黄房子 主人抽 "DUNHILL"烟;
        /// </summary>
        /// <param name="老外合集"></param>
        /// <returns></returns>
        static public bool Check3(ManContainer 一个老外)
        {
            Man temp1 = GetManByFangZi("黄", 一个老外);
            return (temp1.香烟 == "DUNHILL");
        }
        /// <summary>
        /// 未知4.饮料 = "牛奶";未知4.房子次序 = 3; 中间房子的人喝牛奶
        /// </summary>
        /// <param name="老外合集"></param>
        /// <returns></returns>
        static public bool Check4(ManContainer 一个老外)
        {
            Man temp1 = GetManByHouseIndex(3, 一个老外);
            return (temp1.饮料 == "牛奶");
        }
        /// <summary>
        /// 未知5 抽混合烟的人住在样猫的人旁边！
        /// </summary>
        /// <param name="老外合集"></param>
        /// <returns></returns>
        static public bool Check5(ManContainer 一个老外)
        {
            Man temp1 = GetManByYan("混合烟", 一个老外);
            Man temp2 = GetManByChongWu("猫", 一个老外);

            return (Math.Abs(temp1.房子次序 - temp2.房子次序) == 1);
        }
        /// <summary>
        /// 养马的人住在抽DUNHILL烟的旁边
        /// </summary>
        /// <param name="老外合集"></param>
        /// <returns></returns>
        static public bool Check6(ManContainer 一个老外)
        {
            Man temp1 = GetManByChongWu("马", 一个老外);
            Man temp2 = GetManByYan("DUNHILL", 一个老外);

            return (Math.Abs(temp1.房子次序 - temp2.房子次序) == 1);
        }
        /// <summary>
        /// 抽BLUEMASTER烟的人喝啤酒
        /// </summary>
        /// <param name="老外合集"></param>
        /// <returns></returns>
        static public bool Check7(ManContainer 一个老外)
        {
            Man temp1 = GetManByYan("BLUE MASTER", 一个老外);
            return (temp1.饮料 == "啤酒");
        }
        /// <summary>
        /// 挪威人住在蓝房子旁边则 蓝房子 位置为2
        /// </summary>
        /// <param name="老外合集"></param>
        /// <returns></returns>
        static public bool Check8(ManContainer 一个老外)
        {
            Man temp1 = GetManByFangZi("蓝", 一个老外);
            return (temp1.房子次序 == 2);
        }
        /// <summary>
        /// 混合烟的邻居喝矿泉水
        /// </summary>
        /// <param name="老外合集"></param>
        /// <returns></returns>
        static public bool Check9(ManContainer 一个老外)
        {
            Man temp1 = GetManByYan("混合烟", 一个老外);
            Man temp2 = GetManByYingLiao("矿泉水", 一个老外);
            return (Math.Abs(temp1.房子次序 - temp2.房子次序) == 1);
        }
        #endregion

        #region 通过一定条件获取人员
        /// <summary>
        /// 通过序号获取房主
        /// </summary>
        /// <param name="index"></param>
        /// <param name="一个老外"></param>
        /// <returns></returns>
        static public Man GetManByHouseIndex(int index, ManContainer 一个老外)
        {
            if (一个老外.丹麦人.房子次序 == index)
            {
                return 一个老外.丹麦人;
            }
            if (一个老外.德国人.房子次序 == index)
            {
                return 一个老外.德国人;
            }
            if (一个老外.挪威人.房子次序 == index)
            {
                return 一个老外.挪威人;
            }
            if (一个老外.瑞典人.房子次序 == index)
            {
                return 一个老外.瑞典人;
            }
            if (一个老外.英国人.房子次序 == index)
            {
                return 一个老外.英国人;
            }
            return null;
        }

        /// <summary>
        /// 抽某种烟的人
        /// </summary>
        /// <param name="index"></param>
        /// <param name="一个老外"></param>
        /// <returns></returns>
        static public Man GetManByYan(string 烟名, ManContainer 一个老外)
        {
            if (一个老外.丹麦人.香烟 == 烟名)
            {
                return 一个老外.丹麦人;
            }
            if (一个老外.德国人.香烟 == 烟名)
            {
                return 一个老外.德国人;
            }
            if (一个老外.挪威人.香烟 == 烟名)
            {
                return 一个老外.挪威人;
            }
            if (一个老外.瑞典人.香烟 == 烟名)
            {
                return 一个老外.瑞典人;
            }
            if (一个老外.英国人.香烟 == 烟名)
            {
                return 一个老外.英国人;
            }
            return null;
        }

        /// <summary>
        /// 养某种宠物
        /// </summary>
        /// <param name="index"></param>
        /// <param name="一个老外"></param>
        /// <returns></returns>
        static public Man GetManByChongWu(string 宠物名, ManContainer 一个老外)
        {
            if (一个老外.丹麦人.宠物 == 宠物名)
            {
                return 一个老外.丹麦人;
            }
            if (一个老外.德国人.宠物 == 宠物名)
            {
                return 一个老外.德国人;
            }
            if (一个老外.挪威人.宠物 == 宠物名)
            {
                return 一个老外.挪威人;
            }
            if (一个老外.瑞典人.宠物 == 宠物名)
            {
                return 一个老外.瑞典人;
            }
            if (一个老外.英国人.宠物 == 宠物名)
            {
                return 一个老外.英国人;
            }
            return null;
        }

        /// <summary>
        /// 住某种颜色房子的
        /// </summary>
        /// <param name="index"></param>
        /// <param name="一个老外"></param>
        /// <returns></returns>
        static public Man GetManByFangZi(string 房子颜色, ManContainer 一个老外)
        {
            if (一个老外.丹麦人.房子 == 房子颜色)
            {
                return 一个老外.丹麦人;
            }
            if (一个老外.德国人.房子 == 房子颜色)
            {
                return 一个老外.德国人;
            }
            if (一个老外.挪威人.房子 == 房子颜色)
            {
                return 一个老外.挪威人;
            }
            if (一个老外.瑞典人.房子 == 房子颜色)
            {
                return 一个老外.瑞典人;
            }
            if (一个老外.英国人.房子 == 房子颜色)
            {
                return 一个老外.英国人;
            }
            return null;
        }

        /// <summary>
        /// 喝某种饮料的人
        /// </summary>
        /// <param name="index"></param>
        /// <param name="一个老外"></param>
        /// <returns></returns>
        static public Man GetManByYingLiao(string 饮料名称, ManContainer 一个老外)
        {
            if (一个老外.丹麦人.饮料 == 饮料名称)
            {
                return 一个老外.丹麦人;
            }
            if (一个老外.德国人.饮料 == 饮料名称)
            {
                return 一个老外.德国人;
            }
            if (一个老外.挪威人.饮料 == 饮料名称)
            {
                return 一个老外.挪威人;
            }
            if (一个老外.瑞典人.饮料 == 饮料名称)
            {
                return 一个老外.瑞典人;
            }
            if (一个老外.英国人.饮料 == 饮料名称)
            {
                return 一个老外.英国人;
            }
            return null;
        }
        #endregion
    }

    #region 对象模型
    public class Man : Object
    {
        #region 属性
        private string guoji = "";
        public string 国籍
        {
            get
            {
                return guoji;
            }
            set
            {
                guoji = value;
            }
        }


        private string yinliao = "";
        public string 饮料
        {
            get
            {
                return yinliao;
            }
            set
            {
                yinliao = value;
            }
        }


        private string xiangyan = "";
        public string 香烟
        {
            get
            {
                return xiangyan;
            }
            set
            {
                xiangyan = value;
            }
        }

        private string chongwu = "";
        public string 宠物
        {
            get
            {
                return chongwu;
            }
            set
            {
                chongwu = value;
            }
        }

        private string fangzi = "";
        public string 房子
        {
            get
            {
                return fangzi;
            }
            set
            {
                fangzi = value;
            }
        }

        private string fangzizuo = "";
        public string 房子左边
        {
            get
            {
                return fangzizuo;
            }
            set
            {
                fangzizuo = value;
            }
        }

        private string fangziyou = "";
        public string 房子右边
        {
            get
            {
                return fangziyou;
            }
            set
            {
                fangziyou = value;
            }
        }
        private int fangziindex = 0;
        public int 房子次序
        {
            get
            {
                return fangziindex;
            }
            set
            {
                fangziindex = value;
            }
        }
        #endregion
        #region 方法
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public void Copy(Man a)
        {
            this.国籍 = a.国籍;
            this.香烟 = a.香烟;
            this.饮料 = a.饮料;
            this.宠物 = a.宠物;
            this.房子 = a.房子;
            this.房子次序 = a.房子次序;
            this.房子左边 = a.房子左边;
            this.房子右边 = a.房子右边;
        }
        #endregion
    }
    public class ManContainer
    {
        public Man 英国人;
        public Man 瑞典人;
        public Man 丹麦人;
        public Man 挪威人;
        public Man 德国人;
    }
    #endregion
}
