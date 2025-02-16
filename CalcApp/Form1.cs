using System.Data;
namespace CalcApp
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_click(object sender, EventArgs e)
        {
            currentCalculation += ((Button)sender).Text;
            txtOutput.Text = currentCalculation;
        }
        private void button_Equals_click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculation.ToString();
            try
            {
                txtOutput.Text = new DataTable().Compute(formattedCalculation,"").ToString();
                currentCalculation=txtOutput.Text;
            }
            catch (Exception)
            {
                txtOutput.Text="Error";
                currentCalculation = "";
            }
        }
        private void button_Clear_click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
            currentCalculation = "";
        }
        private void button_clearEntry_click(object sender,EventArgs e)
        {
            if(currentCalculation.Length>0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }
            txtOutput.Text = currentCalculation;
        }
    }
}
