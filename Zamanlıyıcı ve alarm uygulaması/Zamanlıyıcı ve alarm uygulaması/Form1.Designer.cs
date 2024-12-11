namespace Zamanlıyıcı_ve_alarm_uygulaması
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Tasarımcı desteği için gerekli metot
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.txtTimeInput = new System.Windows.Forms.TextBox();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AlarmZamanı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TekrarAralığı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SesliAlarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAlarmTimeInput = new System.Windows.Forms.TextBox();
            this.btnAlarmEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBaslat.Location = new System.Drawing.Point(228, 224);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 36);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.Crimson;
            this.btnDurdur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDurdur.Location = new System.Drawing.Point(336, 224);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(75, 36);
            this.btnDurdur.TabIndex = 2;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.BackColor = System.Drawing.Color.Cyan;
            this.btnSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSifirla.Location = new System.Drawing.Point(442, 224);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(75, 36);
            this.btnSifirla.TabIndex = 3;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // txtTimeInput
            // 
            this.txtTimeInput.Location = new System.Drawing.Point(210, 126);
            this.txtTimeInput.Name = "txtTimeInput";
            this.txtTimeInput.Size = new System.Drawing.Size(144, 22);
            this.txtTimeInput.TabIndex = 4;
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCountdown.Location = new System.Drawing.Point(205, 151);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(149, 39);
            this.lblCountdown.TabIndex = 5;
            this.lblCountdown.Text = "00:00:00";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlarmZamanı,
            this.TekrarAralığı,
            this.SesliAlarm});
            this.dataGridView1.Location = new System.Drawing.Point(159, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(430, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // AlarmZamanı
            // 
            this.AlarmZamanı.HeaderText = "Alarm Zamanı";
            this.AlarmZamanı.MinimumWidth = 6;
            this.AlarmZamanı.Name = "AlarmZamanı";
            this.AlarmZamanı.Width = 125;
            // 
            // TekrarAralığı
            // 
            this.TekrarAralığı.HeaderText = "Tekrar Aralığı";
            this.TekrarAralığı.MinimumWidth = 6;
            this.TekrarAralığı.Name = "TekrarAralığı";
            this.TekrarAralığı.Width = 125;
            // 
            // SesliAlarm
            // 
            this.SesliAlarm.HeaderText = "Sesli Alarm";
            this.SesliAlarm.MinimumWidth = 6;
            this.SesliAlarm.Name = "SesliAlarm";
            this.SesliAlarm.Width = 125;
            // 
            // txtAlarmTimeInput
            // 
            this.txtAlarmTimeInput.Location = new System.Drawing.Point(405, 126);
            this.txtAlarmTimeInput.Name = "txtAlarmTimeInput";
            this.txtAlarmTimeInput.Size = new System.Drawing.Size(144, 22);
            this.txtAlarmTimeInput.TabIndex = 8;
            // 
            // btnAlarmEkle
            // 
            this.btnAlarmEkle.BackColor = System.Drawing.Color.LightGreen;
            this.btnAlarmEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlarmEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlarmEkle.Location = new System.Drawing.Point(427, 160);
            this.btnAlarmEkle.Name = "btnAlarmEkle";
            this.btnAlarmEkle.Size = new System.Drawing.Size(96, 32);
            this.btnAlarmEkle.TabIndex = 9;
            this.btnAlarmEkle.Text = "Alarm Ekle";
            this.btnAlarmEkle.UseVisualStyleBackColor = false;
            this.btnAlarmEkle.Click += new System.EventHandler(this.btnAlarmEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(233, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Zaman girin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(423, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Alarm kurun:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlarmEkle);
            this.Controls.Add(this.txtAlarmTimeInput);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.txtTimeInput);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBaslat);
            this.Name = "Form1";
            this.Text = "Zamanlayıcı ve Alarm Uygulaması";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.TextBox txtTimeInput;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmZamanı;
        private System.Windows.Forms.DataGridViewTextBoxColumn TekrarAralığı;
        private System.Windows.Forms.DataGridViewTextBoxColumn SesliAlarm;
        private System.Windows.Forms.TextBox txtAlarmTimeInput;
        private System.Windows.Forms.Button btnAlarmEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
