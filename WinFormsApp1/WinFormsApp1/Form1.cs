using System.Media;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblReultat.Text = ""; // ������� ������ ���������
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
            // ������ ������ �� ������ ��������, ���������� � ����� �����
            List<string> sastavki = new List<string>();
            foreach (var item in listBoxSastavki.Items)
            {
                sastavki.Add(item.ToString().ToLower());
            }

            string rezultat = "���������� ������ �������, �� ���� ��������� �� �� ������.";

            if (sastavki.Contains("������� ������") && sastavki.Contains("����� ����"))
            {
                rezultat = "������� ���������� �� 10 ������!";
            }
            else if (sastavki.Contains("�����") && sastavki.Contains("�����"))
            {
                rezultat = "������� ������ ������!";
            }
            else if (sastavki.Contains("�������") && sastavki.Contains("����"))
            {
                rezultat = "������� ����������� ����� ���� �����!";
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
                await Task.Delay(50); // �������� ����� �� �����
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
            lblReultat.Text = "�������� �� �������...";
            Application.DoEvents();

            // ������� �� ���� �� ����� �� ��������
            SoundPlayer zvuk = new SoundPlayer("magic.wav");
            zvuk.Play();

            Thread.Sleep(2000); // ���� 2 �������
            zvuk.Stop();

            List<string> sastavki = new List<string>();

            foreach (var item in listBoxSastavki.Items)
            {
                sastavki.Add(item.ToString().ToLower());
            }

            string rezultat = "���������� ������ �������, �� ���� ��������� �� �� ������.";

            if (sastavki.Contains("������� ������") && sastavki.Contains("����� ����"))
            {
                rezultat = "������� ���������� �� 10 ������!";
                listBoxSastavki.Items.Remove("������� ������");
                listBoxSastavki.Items.Remove("����� ����");
            }
            else if (sastavki.Contains("�����") && sastavki.Contains("�����"))
            {
                rezultat = "������� ������ ������!";
                listBoxSastavki.Items.Remove("�����");
                listBoxSastavki.Items.Remove("�����");
            }
            else if (sastavki.Contains("�������") && sastavki.Contains("����"))
            {
                rezultat = "������� ����������� ����� ���� �����!";
                listBoxSastavki.Items.Remove("�������");
                listBoxSastavki.Items.Remove("����");
            }

            await PokajiSustoqnie(rezultat);
        }

    }
   }
   


