namespace FILLONE_OOP_CPE201
{
    public partial class Activity1 : Form
    {
        // Declare variables to store item details and transaction information
        private double amount_paid, price, cash_given, change;
        private int quantity;
        public Activity1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "1 – pc. Chickenjoy Solo";
            priceTxtbox.Text = "85";

            qntyTxtbox.Focus();
            qntyTxtbox.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "1 – pc. Burger Steak With Drink";
            priceTxtbox.Text = "84";

            qntyTxtbox.Focus();
            qntyTxtbox.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Supermeal w/ Drink";
            priceTxtbox.Text = "224";

            qntyTxtbox.Focus();
            qntyTxtbox.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "1-pc. Chickenjoy w/ Coke Float";
            priceTxtbox.Text = "134";

            qntyTxtbox.Focus();
            qntyTxtbox.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "1 – pc. Chickenjoy With Drink";
            priceTxtbox.Text = "105";

            qntyTxtbox.Focus();
            qntyTxtbox.Clear();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "1 – pc. Chickenjoy With Jolly Spaghetti Solo";
            priceTxtbox.Text = "135";

            qntyTxtbox.Focus();
            qntyTxtbox.Clear();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "1 – pc. Chickenjoy W/ Jolly Spaghetti w/ Drink";
            priceTxtbox.Text = "172";

            qntyTxtbox.Focus();
            qntyTxtbox.Clear();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "2 – pc. Pancakes Solo";
            priceTxtbox.Text = "87";

            qntyTxtbox.Focus();
            qntyTxtbox.Clear();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "6 – pc. Chickenjoy Bucket w/ Jolly Spaghetti";
            priceTxtbox.Text = "697";

            qntyTxtbox.Focus();
            qntyTxtbox.Clear();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "6 – pc. Chickenjoy Solo";
            priceTxtbox.Text = "467";

            qntyTxtbox.Focus();
            qntyTxtbox.Clear();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "6 – pc. Chickenjoy with Palabok Family Pan";
            priceTxtbox.Text = "927";

            qntyTxtbox.Focus();
            qntyTxtbox.Clear();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Amazing Aloha Champ Jr., Fries & Drink";
            priceTxtbox.Text = "221";

            qntyTxtbox.Focus();
            qntyTxtbox.Clear();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Chickenjoy Bucket Family Meals";
            priceTxtbox.Text = "745";

            qntyTxtbox.Focus();
            qntyTxtbox.Clear();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Jolly Crispy Fries Bucket";
            priceTxtbox.Text = "191";

            qntyTxtbox.Focus();
            qntyTxtbox.Clear();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Double Cheesy Yumburger With Fries & Drink";
            priceTxtbox.Text = "217";

            qntyTxtbox.Focus();
            qntyTxtbox.Clear();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            qntyTxtbox.Clear();
            amnt_paidTxtbox.Clear();
            cash_givenTxtbox.Clear();
            changeTxtbox.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Activity1_Load(object sender, EventArgs e)
        {
            // Set the form to be borderless and maximized to fill the entire screen
            changeTxtbox.Enabled = false;

            // Set the form to be borderless and maximized to fill the entire screen
            this.Location = new Point(0, 0);

            // Set the form to be borderless and maximized to fill the entire screen
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            price = Convert.ToDouble(priceTxtbox.Text);
            quantity = Convert.ToInt32(qntyTxtbox.Text);
            amount_paid = price * quantity;
            changeTxtbox.Text = amount_paid.ToString("n");
            cash_givenTxtbox.Focus();

            try
            {
                amount_paid = Convert.ToDouble(amnt_paidTxtbox.Text);
                cash_given = Convert.ToDouble(cash_givenTxtbox.Text);
                change = cash_given - amount_paid;
                changeTxtbox.Text = change.ToString("n");
                amnt_paidTxtbox.Text = amount_paid.ToString("c");
                cash_givenTxtbox.Text = cash_given.ToString("c");
            }
            catch (Exception)
            {
                MessageBox.Show("ex.message");
                cash_givenTxtbox.Focus();
                cash_givenTxtbox.Clear();
            }
            finally 
            { 
                MessageBox.Show("Transaction Completed!");
            }
        }
    }
}
