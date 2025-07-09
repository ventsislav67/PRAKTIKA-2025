using System.Media;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblReultat.Text = ""; // Начално празно съобщение
        }

        private void btnDobavi_Click(object sender, EventArgs e)
        {
            string sastavka = txtSastavka.Text.Trim();

            if (sastavka != "")
            {
                listBoxSastavki.Items.Add(sastavka);
                txtSastavka.Clear();
            }
        }

        private async void btnSwari_Click(object sender, EventArgs e)
        {
            // Правим списък от всички съставки, превърнати в малки букви
            List<string> sastavki = new List<string>();
            foreach (var item in listBoxSastavki.Items)
            {
                sastavki.Add(item.ToString().ToLower());
            }

            string rezultat = "Получената отвара бълбука, но нищо интересно не се случва.";

            if (sastavki.Contains("котешка козина") && sastavki.Contains("течен азот"))
            {
                rezultat = "Създаде невидимост за 10 минути!";
            }
            else if (sastavki.Contains("ягода") && sastavki.Contains("захар"))
            {
                rezultat = "Създаде вкусно сладко!";
            }
            else if (sastavki.Contains("батерия") && sastavki.Contains("вода"))
            {
                rezultat = "Създаде експлозивен серум… стой далеч!";
            }

            await PokajiSustoqnie(rezultat);
        }

        private async Task PokajiSustoqnie(string tekst)
        {
            lblReultat.Text = "";
            lblReultat.ForeColor = Color.White;
            lblReultat.Font = new Font("Segoe UI", 15, FontStyle.Bold);

            foreach (char bukva in tekst)
            {
                lblReultat.Text += bukva;
                await Task.Delay(50); // анимация буква по буква
            }
        }

        private void btnDobavi_Click_1(object sender, EventArgs e)
        {
            string sastavka = txtSastavka.Text.Trim();

            if (sastavka != "")
            {
                listBoxSastavki.Items.Add(sastavka);
                txtSastavka.Clear();
            }
        }

        private async void btnSwari_Click_1(object sender, EventArgs e)
        {
            lblReultat.Text = "Отварата се сварява...";
            Application.DoEvents();

            // Пускане на звук по време на варенето
            SoundPlayer zvuk = new SoundPlayer("magic.wav");
            zvuk.Play();

            Thread.Sleep(2000); // чака 2 секунди
            zvuk.Stop();

            List<string> sastavki = new List<string>();

            foreach (var item in listBoxSastavki.Items)
            {
                sastavki.Add(item.ToString().ToLower());
            }

            string rezultat = "Получената отвара бълбука, но нищо интересно не се случва.";

            if (sastavki.Contains("котешка козина") && sastavki.Contains("течен азот"))
            {
                rezultat = "Създаде невидимост за 10 минути!";
                listBoxSastavki.Items.Remove("котешка козина");
                listBoxSastavki.Items.Remove("течен азот");
            }
            else if (sastavki.Contains("ягода") && sastavki.Contains("захар"))
            {
                rezultat = "Създаде вкусно сладко!";
                listBoxSastavki.Items.Remove("ягода");
                listBoxSastavki.Items.Remove("захар");
            }
            else if (sastavki.Contains("батерия") && sastavki.Contains("вода"))
            {
                rezultat = "Създаде експлозивен серум… стой далеч!";
                listBoxSastavki.Items.Remove("батерия");
                listBoxSastavki.Items.Remove("вода");
            }

            await PokajiSustoqnie(rezultat);
        }

    }
   }
   


