using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kovlab1
{
    public partial class Form1 : Form
    {
        private const int MinLapSeconds = 30;
        private const int MaxLapSeconds = 600;
        public Form1()
        {
            InitializeComponent();
            cmbCar.SelectedIndex = 0;
            cmbTrack.SelectedIndex = 0;
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ShowError(string message)
        {
            lblStatus.Text=message;
        }
        private void ClearInput()
        {     
            txtDriver.Clear();
            txtTime.Clear();
            cmbCar.SelectedIndex = 0;
            cmbTrack.SelectedIndex = 0;
            txtDriver.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string driver = txtDriver.Text.Trim();
            if (driver.Length == 0)
            {
                ShowError( "Введите имя пилота");
                txtDriver.Focus();
                return;
            }
            if (cmbCar.SelectedIndex < 0 || cmbTrack.SelectedIndex < 0)
            {
                ShowError( "Выберите автомобиль и трассу");
                return;
            }
            string timeText = txtTime.Text.Trim();
            if (!int.TryParse(timeText, out int seconds))
            {
                ShowError( "Время должно быть целым числом");
                txtTime.Focus();
                return;
            }
            if( seconds<MinLapSeconds || seconds>MaxLapSeconds)
            {
                ShowError( $"Время должно быть в диапозоне от {MinLapSeconds} до {MaxLapSeconds}");
                txtTime.Focus();
                return;
            }
            string record = $"{driver} | {cmbCar.Text} | {cmbTrack.Text} | {seconds} с";
            lstResults.Items.Add(record);
            ClearInput();
            ShowError($"Запись добавлена. Всего записей {lstResults.Items.Count}");
        }

        private void txtDriver_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblDriver_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            ShowError("Поля очищены.Результаты сохранены в списке");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstResults.SelectedIndex;
            if (index<0)
            {
                ShowError("Сначала выберите запись в списке");
                return;
            }
            lstResults.Items.RemoveAt(index);
            lblStatus.Text = $"Запись удалена. Всего записей: {lstResults.Items.Count}";
        }
    }
}
