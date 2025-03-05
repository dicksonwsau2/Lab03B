namespace Lab03B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1) Parse the user inputs from the text boxes.
            //    e.g. "10000" -> 10000.0   and "6" -> 0.06 (6%)

            double principal = double.Parse(txtAmount.Text);
            double annualRate = double.Parse(txtRate.Text) / 100.0;

            // 2) Calculate the value after 10 years.
            //    Formula:  balance after 10 years = principal * (1 + annualRate)^10

            double valueAfter10 = principal * Math.Pow(1 + annualRate, 10);

            // 3) Display that value in lblValue (or whichever control you’re using)
            txtValue.Text = valueAfter10.ToString("F2");
            // "F2" -> 2 decimal places, or use "C" for currency

            // 4) Calculate how many years until the balance reaches $1,000,000.

            double balance = principal;
            int years = 0;

            // Loop year by year until $1M is reached
            while (balance < 1_000_000)
            {
                balance *= (1 + annualRate);
                years++;
            }

            // 5) Show the result in lblMillion
            txtMillion.Text = years.ToString();
        }
    }
}