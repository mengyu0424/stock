using System;
using System.Collections.Generic;
using System.Data;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.测试菜单
{
    public partial class 小工具 : BaseForm
    {
        public 小工具()
        {
            InitializeComponent();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            WindowsFormsApp.测试工具.MessageWin messageWin = new WindowsFormsApp.测试工具.MessageWin();
            messageWin.Show();
        }

        private void btn_redis_Click(object sender, EventArgs e)
        {
            WindowsFormsApp.测试工具.RedisLoginWin redisWin = new WindowsFormsApp.测试工具.RedisLoginWin();
            redisWin.Show();
        }

        private void btn_Lottery_Click(object sender, EventArgs e)
        {
            WindowsFormsApp.测试工具.LotteryForm lotteryForm = new WindowsFormsApp.测试工具.LotteryForm();
            lotteryForm.Show();
        }
    }
}