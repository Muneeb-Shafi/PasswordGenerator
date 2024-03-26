using System.Text;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == ""))
            {
                Clipboard.SetText(textBox1.Text);
                MessageBox.Show("Copied To Clipboard");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxLength = trackBar1.Value; // Maximum length of the generated string
            bool includeSpecialChars = checkBox1.Checked; // Include special characters
            bool includeNumbers = checkBox2.Checked; // Include numbers

            string randomString = GenerateRandomString(maxLength, includeSpecialChars, includeNumbers);
            textBox1.Text = randomString;
        }

        static string GenerateRandomString(int maxLength, bool includeSpecialChars, bool includeNumbers)
        {
            // Define character sets
            string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string specialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";
            string numericChars = "0123456789";

            // Create a character pool based on user preferences
            StringBuilder charPool = new StringBuilder(lowercaseChars + uppercaseChars);
            if (includeSpecialChars)
                charPool.Append(specialChars);
            if (includeNumbers)
                charPool.Append(numericChars);

            // Generate a random string
            Random random = new Random();
            string randomString = new string(
                Enumerable.Repeat(charPool.ToString(), maxLength)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return randomString;
        }
    }
}
