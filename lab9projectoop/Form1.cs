using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9projectoop
{
    public partial class Form1 : Form
    {
        private Date date;

        public Form1()
        {
            InitializeComponent();
            date = new Date(17, 4, 2024);
            textBoxData.TextChanged += textBoxData_TextChanged; // дод завдання

        }

        private void Form1_Load(object sender, EventArgs e) //метод поточної дати
        {
            UpdateDate();
        }

        private void UpdateDate()
        {
            WData.Text = $"{date.Day}.{date.Month}.{date.Year}";
        }

        private void btnDayMinus_Click(object sender, EventArgs e)
        {
            date.AddDays(-1);
            UpdateDate();
        }

        private void btnDayPlus_Click(object sender, EventArgs e)
        {
            date.AddDays(1);
            UpdateDate();
        }

        private void btnMouthMinus_Click(object sender, EventArgs e)
        {
            date.AddMonths(-1);
            UpdateDate();
        }

        private void btnMouthPlus_Click(object sender, EventArgs e)
        {
            date.AddMonths(1);
            UpdateDate();
        }

        private void btnYearMinus_Click(object sender, EventArgs e)
        {
            date.AddYears(-1);
            UpdateDate();
        }

        private void btnYearPlus_Click(object sender, EventArgs e)
        {
            date.AddYears(1);
            UpdateDate();
        }

        private void textBoxData_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] parts = textBoxData.Text.Split('.');
                if (parts.Length != 3)
                    throw new Exception("Invalid");

                int day = int.Parse(parts[0]);
                int month = int.Parse(parts[1]);
                int year = int.Parse(parts[2]);

                date = new Date(day, month, year);
                LData.Text = $"{date.Day}.{date.Month}.{date.Year}";
                LData.ForeColor = Color.Black;
            }
            catch
            {
                LData.Text = "ERROR";
                LData.ForeColor = Color.Red;
            }
        }
    }
}//