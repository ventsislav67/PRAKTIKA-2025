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
            lblReultat.ForeColor = Color.DarkMagenta;

            foreach (char bukva in tekst)
            {
                lblReultat.Text += bukva;
                await Task.Delay(40); // ��������� ��������
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

        private void btnSwari_Click_1(object sender, EventArgs e)
        {
            List<string> sastavki = new List<string>();

            foreach (var item in listBoxSastavki.Items)
            {
                sastavki.Add(item.ToString().ToLower());
            }

            string rezultat = "���������� ������ �������, �� ���� ��������� �� �� ������.";

            if (sastavki.Contains("������� ������") && sastavki.Contains("����� ����"))
            {
                rezultat = "������� ���������� �� 10 ������!";
                // ���������� ������������ ��������
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

            lblReultat.Text = rezultat;



        }
    }
   }


