using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Define the random characters
            const string charsLower = "abcdefghijklmnopqrstuvwxyz";
            const string charsUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string charsNumber = "0123456789";
            const string charsSymbols = "!@#$%^&*";

            // Create a variable called random, that is random, and make a new random function.
            Random random = new();

            // Create a string builder object
            StringBuilder password = new();

            // Create a loop to pull random characters, 3 in length. 3 lower, 3 upper, 3 symbol, 3 number
            for (int i = 0; i < 4; i++)
            {
                // The first set is Lowers, 3 of them. Then random append 3 upper, number, symbols.
                password.Append(charsLower[random.Next(charsLower.Length)]);
                password.Append(charsUpper[random.Next(charsUpper.Length)]);
                password.Append(charsNumber[random.Next(charsNumber.Length)]);
                password.Append(charsSymbols[random.Next(charsSymbols.Length)]);
            }

            label2.Text = password.ToString();
            label3.Text = "Random Password Generated!!";

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) //Menu
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e) //About
        {
            // Define a function that shows a message popup
            void ShowMessage(string message)
            {
                // Call the MessageBox.Show method with the message
                MessageBox.Show(message);
            }

            // Test the function
            ShowMessage("My First Project \n" +
                "Written by J.East \n" +
                "\n" +
                "No license. Open Source. No Warranty");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //Exit
        {
            Application.Exit();
        }
    }
}
