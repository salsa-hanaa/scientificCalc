using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private readonly CalculatorService _service = new CalculatorService();
        double firstNumber = 0;
        double secondNumber = 0;
        double result = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = button.Text;
            else
                textBox1.Text += button.Text;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            try
            {
                firstNumber = double.Parse(textBox1.Text);
                operation = button.Text;
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input tidak valid: " + ex.Message, "Error");
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                secondNumber = double.Parse(textBox1.Text);
                result = _service.Calculate(firstNumber, secondNumber, operation);

                // Tambahkan hasil perhitungan ke ListBox Riwayat
                string historyEntry = _service.FormatHistory(firstNumber, operation, secondNumber, result);
                lstHistory.Items.Add(historyEntry);

                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            textBox1.Text = _service.GetPi().ToString();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            textBox1.Text = _service.GetE().ToString();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);
                result = _service.CalculateFactorial(n);
                lstHistory.Items.Add($"{n}! = {result}");
                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faktorial error: " + ex.Message, "Error");
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            textBox1.Text = _service.Backspace(textBox1.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            result = 0;
            operation = "";
            textBox1.Text = "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(".")) textBox1.Text += ".";
        }

        private void btnParenthesis_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text == "0") textBox1.Text = btn.Text;
            else textBox1.Text += btn.Text;
        }

        // Tombol untuk me-refresh/membersihkan riwayat jika diperlukan
        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void lstHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}