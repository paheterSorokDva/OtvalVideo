using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace OtvalVideo
{
    public partial class Form1 : Form
    {

        // Для хранения скрина
        public static Bitmap BM = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        Graphics GH = Graphics.FromImage(BM as Image);

        Random rnd = new Random();

        static System.Windows.Forms.Timer aTimer = new System.Windows.Forms.Timer();

        // bool _closeoff = true;
        bool _closeoff = false; // изменить на тру в конце
        public Form1()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            var fullscreenSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Size = fullscreenSize;

            //aTimer.Enabled = true;

            aTimer.Tick += new EventHandler(timer1_Tick_1);
            aTimer.Interval = 33;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Скрин
            //Graphics GH = Graphics.FromImage(BM as Image);
            GH.CopyFromScreen(0, 0, 0, 0, BM.Size);

            /// отключить бордюр
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            /// Делаем окно на весь экран
            WindowState = FormWindowState.Maximized;

            /// Поверх всех
            TopMost = true;

            /// отключаем курсор
            Cursor.Hide();

            /// меняем цвет формы
            BackColor = Color.Black;


            
            BackgroundImage = BM;

            






        }


       




        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = _closeoff; // блокировка закрытия
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.SuppressKeyPress = e.Alt || e.KeyCode == Keys.F4) // Блокируем  ALT+F4
            {
                _closeoff = true;
            }

            if (e.SuppressKeyPress = e.Control && e.KeyCode == Keys.Z) // Присваиваем новый ALT+F4
            {
                _closeoff = false;
                Application.Exit();
            }

            

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Random rnd = new Random();
            //Graphics GH = Graphics.FromImage(BM as Image);
           GH.CopyFromScreen(rnd.Next(-5, 11), 0, rnd.Next(-5, 11), 0, BM.Size);


        }




        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            //Random rnd = new Random();
           // Graphics GH = Graphics.FromImage(BM as Image);
            //GH.CopyFromScreen(rnd.Next(-5, 11), 0, rnd.Next(-5, 11), 0, BM.Size);

            

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            
        }
    }
}
