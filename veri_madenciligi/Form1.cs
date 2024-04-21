using System.Data;
using OfficeOpenXml;

namespace veri_madenciligi
{
    public partial class Form1 : Form
    {
        DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void buttonSiparisVer_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;
            int gun = dateTime.Day;
            int ay = dateTime.Month;
            int yil = dateTime.Year;
            string date_time = $"{gun.ToString()}/{ay.ToString()}/{yil.ToString()}";

            RadioButton seciliButton = selectedRadioButton();

            if (seciliButton != null)
            {
                if (seciliButton == radioButtonU1)
                {
                    DataRow lastRow = dataTable.Rows[dataTable.Rows.Count - 1];

                    int parca1 = (Convert.ToInt32(lastRow["Parca1"])) + 1;
                    int parca2 = (Convert.ToInt32(lastRow["Parca2"])) + 1;
                    int parca3 = (Convert.ToInt32(lastRow["Parca3"])) + 1;
                    int parca4 = Convert.ToInt32(lastRow["Parca4"]);
                    int parca5 = Convert.ToInt32(lastRow["Parca5"]);
                    int toplam = parca1 + parca2 + parca3 + parca4 + parca5;

                    DataRow newRow = dataTable.NewRow();
                    newRow["Parca1"] = parca1.ToString();
                    newRow["Parca2"] = parca2.ToString();
                    newRow["Parca3"] = parca3.ToString();
                    newRow["Parca4"] = parca4.ToString();
                    newRow["Parca5"] = parca5.ToString();
                    newRow["Toplam"] = toplam.ToString();
                    newRow["Tarih"] = date_time.ToString();
                    newRow["SiparisAd"] = textBoxSprsName.Text;
                    dataTable.Rows.Add(newRow);

                    dataGridView1.DataSource = dataTable;
                }
                else if (seciliButton == radioButtonU2)
                {
                    DataRow lastRow = dataTable.Rows[dataTable.Rows.Count - 1];

                    int parca1 = (Convert.ToInt32(lastRow["Parca1"])) + 1;
                    int parca2 = (Convert.ToInt32(lastRow["Parca2"])) + 1;
                    int parca3 = (Convert.ToInt32(lastRow["Parca3"])) + 1;
                    int parca4 = (Convert.ToInt32(lastRow["Parca4"])) + 1;
                    int parca5 = (Convert.ToInt32(lastRow["Parca5"])) + 1;
                    int toplam = parca1 + parca2 + parca3 + parca4 + parca5;

                    DataRow newRow = dataTable.NewRow();
                    newRow["Parca1"] = parca1.ToString();
                    newRow["Parca2"] = parca2.ToString();
                    newRow["Parca3"] = parca3.ToString();
                    newRow["Parca4"] = parca4.ToString();
                    newRow["Parca5"] = parca5.ToString();
                    newRow["Toplam"] = toplam.ToString();
                    newRow["Tarih"] = date_time.ToString();
                    newRow["SiparisAd"] = textBoxSprsName.Text;
                    dataTable.Rows.Add(newRow);

                    dataGridView1.DataSource = dataTable;
                }
                else if (seciliButton == radioButtonU3)
                {
                    DataRow lastRow = dataTable.Rows[dataTable.Rows.Count - 1];

                    int parca1 = (Convert.ToInt32(lastRow["Parca1"]));
                    int parca2 = (Convert.ToInt32(lastRow["Parca2"])) + 1;
                    int parca3 = (Convert.ToInt32(lastRow["Parca3"]));
                    int parca4 = Convert.ToInt32(lastRow["Parca4"]) + 1;
                    int parca5 = Convert.ToInt32(lastRow["Parca5"]);
                    int toplam = parca1 + parca2 + parca3 + parca4 + parca5;

                    DataRow newRow = dataTable.NewRow();
                    newRow["Parca1"] = parca1.ToString();
                    newRow["Parca2"] = parca2.ToString();
                    newRow["Parca3"] = parca3.ToString();
                    newRow["Parca4"] = parca4.ToString();
                    newRow["Parca5"] = parca5.ToString();
                    newRow["Toplam"] = toplam.ToString();
                    newRow["Tarih"] = date_time.ToString();
                    newRow["SiparisAd"] = textBoxSprsName.Text;
                    dataTable.Rows.Add(newRow);

                    dataGridView1.DataSource = dataTable;
                }
            }
            Excel.UpdateExcelFile("C:\\Users\\Bilal\\Desktop\\!\\c#\\verimadenciligi\\siparis.xlsx", dataTable);
            buttonSiparisVer.Enabled = false;
        }
        public RadioButton selectedRadioButton()
        {
            if (radioButtonU1.Checked)
            {
                return radioButtonU1;
            }
            else if (radioButtonU2.Checked)
            {
                return radioButtonU2;
            }
            else if (radioButtonU3.Checked)
            {
                return radioButtonU3;
            }
            else
            {
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable = Excel.ReadExcelToDataTable("C:\\Users\\Bilal\\Desktop\\!\\c#\\verimadenciligi\\siparis.xlsx", "Sayfa1");
            dataGridView1.DataSource = dataTable;

            buttonSiparisVer.Enabled = false;
        }

        private void buttonGecikme_Click(object sender, EventArgs e)
        {
            DateTime nowTime = DateTime.Now;
            DateTime siparisTime = dateTimePicker1.Value.ToLocalTime();
            TimeSpan farkTime = siparisTime - nowTime;
            int gunFarki = farkTime.Days;

            int k = gunFarki / 10;

            DataRow lastRow = dataTable.Rows[dataTable.Rows.Count - 1];

            if (Convert.ToInt32(lastRow["Parca2"]) > k + 78)
            {
                if (Convert.ToInt32(lastRow["Toplam"]) > k + 309)
                {
                    textBox1.Text = "Siparis Gecikir";
                    buttonSiparisVer.Enabled = false;
                }
                else
                {
                    if (Convert.ToInt32(lastRow["Parca1"]) > k + 85)
                    {
                        textBox1.Text = "Siparis Gecikir";
                        buttonSiparisVer.Enabled = false;
                    }
                    else
                    {
                        if (Convert.ToInt32(lastRow["Toplam"]) > k + 324)
                        {
                            textBox1.Text = "Siparis Gecikir";
                            buttonSiparisVer.Enabled = false;
                        }
                        else
                        {
                            textBox1.Text = "Siparis Verilebilir";
                            buttonSiparisVer.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                if (Convert.ToInt32(lastRow["Toplam"]) > k + 309)
                {
                    if (Convert.ToInt32(lastRow["Parca3"]) > k + 58)
                    {
                        if (Convert.ToInt32(lastRow["Toplam"]) > k + 331)
                        {
                            textBox1.Text = "Siparis Gecikir";
                            buttonSiparisVer.Enabled = false;
                        }
                        else
                        {
                            textBox1.Text = "Siparis Verilebilir";
                            buttonSiparisVer.Enabled = true;
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(lastRow["Parca4"]) > k + 58)
                        {
                            textBox1.Text = "Siparis Gecikir";
                            buttonSiparisVer.Enabled = false;
                        }
                        else
                        {
                            textBox1.Text = "Siparis Verilebilir";
                            buttonSiparisVer.Enabled = true;
                        }
                    }
                }
                else
                {
                    if (Convert.ToInt32(lastRow["Parca5"]) > k + 29)
                    {
                        textBox1.Text = "Siparis Gecikir";
                        buttonSiparisVer.Enabled = false;
                    }
                    else
                    {
                        textBox1.Text = "Siparis Verilebilir";
                        buttonSiparisVer.Enabled = true;
                    }
                }
            }

        }

        private void buttonSprsTamamla_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;
            int gun = dateTime.Day;
            int ay = dateTime.Month;
            int yil = dateTime.Year;
            string date_time = $"{gun.ToString()}/{ay.ToString()}/{yil.ToString()}";

            RadioButton seciliButton = selectedRadioButton();

            if (seciliButton != null)
            {
                if (seciliButton == radioButtonU1)
                {
                    DataRow lastRow = dataTable.Rows[dataTable.Rows.Count - 1];

                    int parca1 = (Convert.ToInt32(lastRow["Parca1"])) - 1;
                    int parca2 = (Convert.ToInt32(lastRow["Parca2"])) - 1;
                    int parca3 = (Convert.ToInt32(lastRow["Parca3"])) - 1;
                    int parca4 = Convert.ToInt32(lastRow["Parca4"]);
                    int parca5 = Convert.ToInt32(lastRow["Parca5"]);
                    int toplam = parca1 + parca2 + parca3 + parca4 + parca5;

                    DataRow newRow = dataTable.NewRow();
                    newRow["Parca1"] = parca1.ToString();
                    newRow["Parca2"] = parca2.ToString();
                    newRow["Parca3"] = parca3.ToString();
                    newRow["Parca4"] = parca4.ToString();
                    newRow["Parca5"] = parca5.ToString();
                    newRow["Toplam"] = toplam.ToString();
                    newRow["Tarih"] = DateTime.Now;
                    newRow["SiparisAd"] = textBoxSprsName.Text;
                    dataTable.Rows.Add(newRow);

                    dataGridView1.DataSource = dataTable;
                }
                else if (seciliButton == radioButtonU2)
                {
                    DataRow lastRow = dataTable.Rows[dataTable.Rows.Count - 1];

                    int parca1 = (Convert.ToInt32(lastRow["Parca1"])) - 1;
                    int parca2 = (Convert.ToInt32(lastRow["Parca2"])) - 1;
                    int parca3 = (Convert.ToInt32(lastRow["Parca3"])) - 1;
                    int parca4 = (Convert.ToInt32(lastRow["Parca4"])) - 1;
                    int parca5 = (Convert.ToInt32(lastRow["Parca5"])) - 1;
                    int toplam = parca1 + parca2 + parca3 + parca4 + parca5;

                    DataRow newRow = dataTable.NewRow();
                    newRow["Parca1"] = parca1.ToString();
                    newRow["Parca2"] = parca2.ToString();
                    newRow["Parca3"] = parca3.ToString();
                    newRow["Parca4"] = parca4.ToString();
                    newRow["Parca5"] = parca5.ToString();
                    newRow["Toplam"] = toplam.ToString();
                    newRow["Tarih"] = DateTime.Now;
                    newRow["SiparisAd"] = textBoxSprsName.Text;
                    dataTable.Rows.Add(newRow);

                    dataGridView1.DataSource = dataTable;
                }
                else if (seciliButton == radioButtonU3)
                {
                    DataRow lastRow = dataTable.Rows[dataTable.Rows.Count - 1];

                    int parca1 = (Convert.ToInt32(lastRow["Parca1"]));
                    int parca2 = (Convert.ToInt32(lastRow["Parca2"])) - 1;
                    int parca3 = (Convert.ToInt32(lastRow["Parca3"]));
                    int parca4 = Convert.ToInt32(lastRow["Parca4"]) - 1;
                    int parca5 = Convert.ToInt32(lastRow["Parca5"]);
                    int toplam = parca1 + parca2 + parca3 + parca4 + parca5;

                    DataRow newRow = dataTable.NewRow();
                    newRow["Parca1"] = parca1.ToString();
                    newRow["Parca2"] = parca2.ToString();
                    newRow["Parca3"] = parca3.ToString();
                    newRow["Parca4"] = parca4.ToString();
                    newRow["Parca5"] = parca5.ToString();
                    newRow["Toplam"] = toplam.ToString();
                    newRow["Tarih"] = DateTime.Now;
                    newRow["SiparisAd"] = textBoxSprsName.Text;
                    dataTable.Rows.Add(newRow);

                    dataGridView1.DataSource = dataTable;
                }
            }
            Excel.UpdateExcelFile("C:\\Users\\Bilal\\Desktop\\!\\c#\\verimadenciligi\\siparis.xlsx", dataTable);
        }
    }
}
