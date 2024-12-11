using System;
using System.Media;
using System.Windows.Forms;

namespace Zamanlıyıcı_ve_alarm_uygulaması
{
    public partial class Form1 : Form
    {
        private int countdownTime = 0; // Geri sayım süresi
        private Timer timer = new Timer(); // Timer nesnesi
        private int alarmTime = -1; // Alarm zamanını saklamak için bir değişken

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000; // Timer her 1 saniyede bir çalışacak
            timer.Tick += Timer_Tick; // Timer'ın tick olayına bir event ekliyoruz
        }

        // Timer'ın her tıklanmasında yapılacak işlemler
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (countdownTime > 0)
            {
                countdownTime--; // Her saniyede bir geri sayımı bir azalt
                lblCountdown.Text = TimeSpan.FromSeconds(countdownTime).ToString(@"hh\:mm\:ss"); // Geri sayımı etikette göster

                // Eğer geri sayım süresi alarm zamanına eşitse, alarm çalsın
                if (countdownTime == alarmTime)
                {
                    SystemSounds.Beep.Play(); // Alarm sesi çalar
                    MessageBox.Show("Alarm zamanı geldi!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                timer.Stop(); // Zaman dolduğunda timer'ı durdur
                SystemSounds.Beep.Play(); // Alarm sesi çalar
                MessageBox.Show("Zaman doldu!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information); // Zaman bitti uyarısı göster
            }
        }

        // Başlat butonuna tıklanıldığında yapılacak işlem
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            string timeInput = txtTimeInput.Text;

            // Girilen süreyi saniye cinsinden al
            if (int.TryParse(timeInput, out int timeInSeconds))
            {
                countdownTime = timeInSeconds;  // Geri sayım süresi olarak girdiyi kullan
                timer.Start(); // Timer'ı başlat
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir zaman girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); // Geçersiz input uyarısı
            }
        }

        // Durdur butonuna tıklanıldığında yapılacak işlem
        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer.Stop(); // Timer'ı durdur
        }

        // Sıfırla butonuna tıklanıldığında yapılacak işlem
        private void btnSifirla_Click(object sender, EventArgs e)
        {
            timer.Stop(); // Timer'ı durdur
            countdownTime = 0; // Geri sayımı sıfırla
            lblCountdown.Text = "00:00:00"; // Etiket üzerine sıfırla
        }

        // Alarm verisini DataGridView'e eklemek için bir işlem
        private void btnAlarmEkle_Click(object sender, EventArgs e)
        {
            string alarmZamani = txtAlarmTimeInput.Text; // Alarm zamanı
            TimeSpan tekrarAralığı;

            // Tekrar aralığını geçerli bir TimeSpan olarak parselle
            if (TimeSpan.TryParse(alarmZamani, out tekrarAralığı))
            {
                // Sesli alarm durumu, burası sabit olarak "Evet" olabilir
                string sesliAlarm = "Evet";

                // DataGridView'e alarm bilgilerini ekleyelim
                dataGridView1.Rows.Add(alarmZamani, tekrarAralığı.ToString(@"hh\:mm\:ss"), sesliAlarm);

                // Kullanıcıya başarı mesajı
                MessageBox.Show("Alarm verisi eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Kullanıcıya geçerli bir zaman formatı girilmediği mesajını ver
                MessageBox.Show("Lütfen geçerli bir zaman aralığı girin. (Örneğin: 01:30:00)", "Geçersiz Zaman", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
