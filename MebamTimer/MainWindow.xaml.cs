using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Media;

namespace MebamTimer
{
    public partial class MainWindow : Window
    {
        public DateTime zaman = new DateTime(0);
        public int saat = 0, dakika = 0, saniye = 0, msaniye = 0;
        public bool etkin = false;
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            zaman = new DateTime(0);
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
        }

        private void baslatBtn_Click(object sender, RoutedEventArgs e)
        {
            StartTimer();
        }

        private void durdurBtn_Click(object sender, RoutedEventArgs e)
        {
            StopTimer();
        }
        public void StartTimer()
        {
            alertLbl.Content = "";
            if (!etkin)
            {
                etkin = true;
                dispatcherTimer.Start();
            }
        }
        public void StopTimer()
        {
            ResetTimer();
            alertLbl.Content = "";
            if (etkin)
            {
                etkin = false;
                dispatcherTimer.Stop();
            }
            ResetTimer();
        }
        public void ResetTimer()
        {
            saat = 0;
            dakika = 0;
            saniye = 0;
            timeLbl.Content = "00:00:00";
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F1:
                    StartTimer();
                    break;
                case Key.F2:
                    StopTimer();
                    break;
                case Key.F3:
                    PlayAlarmSound();
                    break;
            }
        }
        public void PlayAlarmSound()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.bildirim);
            player.Play();
            alertLbl.Content = "UYARI! Sayaç Bitti...";
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (dakika == 1 && saniye == 30)
            {
                StopTimer();
                PlayAlarmSound();
                return;
            }

            msaniye++;
            if(dakika == 60)
            {
                dakika = 0;
                saat++;
            }
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            if (msaniye == 60)
            {
                msaniye = 0;
                saniye++;
            }
            string visualH = saat == 0 ? "00" : (saat <= 9) ? "0" + saat.ToString() : saat.ToString();
            string visualM = dakika == 0 ? "00" : (dakika <= 9) ? "0" + dakika.ToString() : dakika.ToString();
            string visualS = saniye == 0 ? "00" : (saniye <= 9) ? "0" + saniye.ToString() : saniye.ToString();
            string visualMS = msaniye == 0 ? "00" : (msaniye <= 9) ? "0" + msaniye.ToString() : msaniye.ToString();
            timeLbl.Content = $"{visualM}:{visualS}:{visualMS}";
        }
    }
}
