﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace GoodVision
{
    public partial class LandotCheckPro : Form
    {
        public LandotCheckPro()
        {
            InitializeComponent();
        }
        int i = 5, temp;
		bool eye = true;
		Landolt_Circle Circle = new Landolt_Circle();
		int Direction;
		int rightAnswer = 0;
		int tests = 0;
		int left = 1;
		int right = 12;

		UserClass User = new UserClass();
		GoodVisionClass MyVision = new GoodVisionClass();

		private void GoLandotButton_Click(object sender, EventArgs e) // Запуск тестирования Сюда первую картинку надо
        {
            LandotTimer.Value = 0;
            EyeTestPanel.Visible = false;             // предупреждение про проверку правого глаза уходит
            System.Threading.Thread.Sleep(100);
            LTimer.Enabled = true;
            temp = i;
        }

        private void BackToVisionCheckButton_Click(object sender, EventArgs e)// возврат на предыдущую страницу
        {
            VisionCheck Vch = new VisionCheck();
            Vch.Show();
            this.Hide();
        }

        private void LTimer_Tick_1(object sender, EventArgs e)
        {

            
            temp--;
            LandotTimer.Text = Convert.ToString(temp);    
            LandotTimer.PerformStep();
            if (temp != 0)
                LTimer.Enabled = true;

            else
                LTimer.Enabled = false;
        }

    
        // Выбор ответа

        private void UpLandotButton_Click(object sender, EventArgs e) //здесь можно добавить смену картики и считывание ответа
        {
			Direction = 1;
			DirectionClick();
            LandotTimer.Value = 0;
            LTimer.Enabled = true;
            temp = i;
        }

        private void LeftLandotButton_Click(object sender, EventArgs e)
        {
			Direction = 3;
			DirectionClick();
			LandotTimer.Value = 0;
            LTimer.Enabled = true;
            temp = i;
        }


        private void DownLandotButton_Click(object sender, EventArgs e)
        {
			Direction = 2;
			DirectionClick();
			LandotTimer.Value = 0;
            LTimer.Enabled = true;
            temp = i;
        }

        private void RightLandotButton_Click(object sender, EventArgs e)
        {
			Direction = 4;
			DirectionClick();
			LandotTimer.Value = 0;
            LTimer.Enabled = true;
            temp = i;
        }

		private void LandotCheckPro_Load(object sender, EventArgs e)
		{
			FileStream session = new FileStream("session.txt", FileMode.Open, FileAccess.Read);
			if (session != null)
			{
				StreamReader reader = new StreamReader(session);
				User.Nick = reader.ReadToEnd();
				session.Close();
			}
		}

		private void DirectionClick()
		{

			if (Direction == Circle.Directions)
			{
				rightAnswer++;
			}

			i++;

			if (tests < 3)
			{
				Circle.Set_Circle();
				LandotCirclePictureBox.Image = Circle.ShowImage;
			}
			else if (rightAnswer >= 2)
			{
				left = Circle.ObjectRow;
				Circle.ObjectRow = (left + right) / 2;
				tests = 0;
				Circle.Set_Circle();

				LandotCirclePictureBox.Image = Circle.ShowImage;
			}
			else
			{
				right = Circle.ObjectRow;
				if (left < right)
				{
					Circle.ObjectRow = (left + right) / 2;
					Circle.CalcSize();
					LandotCirclePictureBox.Image = Circle.ShowImage;
					tests = 0;
				}
				else
				{
					if (eye)//какой глаз сейчас проверяем
					{
						User.right = Circle.Get_result(Circle.ObjectRow - 1);
						eye = false;
						// вставить предупреждение про проверку левого глаза
					}
					else
						User.left = Circle.Get_result(Circle.ObjectRow - 1);
					MyVision.Add_to_file(ref User);
					AfterTestingForm form = new AfterTestingForm();
					form.Show();
					this.Hide();
				}

			}
		}

    }
}