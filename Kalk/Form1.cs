namespace Kalk
{
    public partial class Form1 : Form
    {
        public string _do;
        public string number1;
        public bool _number2T;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
                if (_number2T)
                {
                    _number2T = false;
                    textBox1.Text = "0";
                }
                
                Button btn = (Button)sender;
                if (textBox1.Text == "0")
                {
                    textBox1.Text = btn.Text;
                }
                else
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
            
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _do = btn.Text;
            number1 = textBox1.Text;
            //textBox1.Text+=btn.Text;
            if (_do == "sqrt")
            {
                _number2T = false;
            }
            else
            {
                _number2T = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double doN1, doN2, res = 0;
            Button btn = (Button)sender;
            doN1 = Convert.ToDouble(number1);
            doN2 = Convert.ToDouble(textBox1.Text);
            if (_do == "+")
            {
                res = doN1 + doN2;
            }
            if (_do == "-")
            {
                res = doN1 - doN2;
            }
            if (_do == "*")
            {
                res = doN1 * doN2;
            }
            if (_do == "/")
            {
                res = doN1/doN2;
            }
            if(_do=="sqrt")
            {
                res = Math.Sqrt(doN1);
            }
            textBox1.Text = res.ToString();
            _number2T = true; 
            
        }
    }
}