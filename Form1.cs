namespace cl
{
    public partial class CALCULATOR : Form
    {
        double result = 0;
        string operation = "";
        bool isoperationperformed = false;

        public CALCULATOR()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isoperationperformed)
                textBox1.Clear();

            isoperationperformed = false; // Reset flag after entering a digit

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void display(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button2 = (Button)sender;
            operation = button2.Text;
            result = Double.Parse(textBox1.Text);

            isoperationperformed = true;
            label1.Text = textBox1.Text;
            textBox1.Text = textBox1.Text + operation;
            label2.Text = operation;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
            result = 0;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    label3.Text = double.Parse(textBox1.Text).ToString();
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();

                    break;
                case "-":
                    label3.Text = double.Parse(textBox1.Text).ToString();
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();

                    break;
                case "*":
                    label3.Text = double.Parse(textBox1.Text).ToString();
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();

                    break;
                case "/":
                    label3.Text = double.Parse(textBox1.Text).ToString();
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();

                    break;

            }

            operation = ""; // Reset operation after calculation
            isoperationperformed = false; // Reset flag after calculation
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void root_click(object sender, EventArgs e)
        {
            Button button3 = (Button)sender;
            operation = button3.Text;
            double result = Double.Parse(textBox1.Text);
            result = Math.Sqrt(result);
            textBox1.Text = result.ToString();
            label1.Text = result.ToString();



        }
    }
}
