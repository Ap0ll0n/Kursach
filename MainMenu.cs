﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodVision
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
           
        }
      static  string UserName;
     
        public string Exchange // передаем имя пользователя в эту форму
        {
            get {return UserName; }
            set
            {
                if (value != null)
                {
                    UserName = value;
                    HelloLab.Text = "Hello, " + value;
                }
                else HelloLab.Text= "Hello, " + UserName;
            }
        }
       
        private void StaticticButton_Click(object sender, EventArgs e)  // просмотр статистики
        {
            StatisticForm statForm = new StatisticForm();
            statForm.StatistExchange = Exchange;
            statForm.Show();
            this.Hide();

        }

        private void VisionCheckButton_Click(object sender, EventArgs e) // переход к форме тестирования
        {
            VisionCheck VChForm = new VisionCheck();
            VChForm.Show();
            this.Hide();
        }


        // вызываем помощь для главного меню
        private void HelpButton_Click(object sender, EventArgs e) 
        {
            HellpMessage hellpForm = new HellpMessage();

            hellpForm.Show();
        }
    }
}
