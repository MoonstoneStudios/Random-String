using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomString
{
    public partial class Form1 : Form
    {

        private static bool hasStarted;

        private char[] chars = new char[] 
        {
            'a', 'b', 'c', 'd', 'e', 'f',
            'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p', 'q', 'r',
            's', 't', 'u', 'v', 'w', 'x',
            'y', 'z'
        };

        private char[] symbols = new char[]
        {
            '!', '@', '#', '$', '%', '^',
            '&', '*', '(', ')', '-', '_',
            '=', '+', '[', ']', '{', '}',
            '\\', '|', '\'', '\"', ';',
            ':', '<', '>', ',', '.', '/',
            '?', '~', '`'
        };

        private char[] numbers = new char[]
        {
            '1', '2', '3', '4', '5',
            '6', '7', '8', '9', '0'
        };

        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void regenButton_Click(object sender, EventArgs e)
        {
            if (!hasStarted)
            {
                hasStarted = true;
                regenButton.Text = "Regenerate";
                result.Text = GenerateRandomString();
            }
            else
            {
                result.Text = GenerateRandomString();
            }
        }

        private string GenerateRandomString()
        {
            string result = "";
            int charCount = Convert.ToInt32(numberOfChars.Text);
            bool shouldRepeat = repeatChars.Checked;
            bool useSymbols = includeSymbols.Checked;
            bool useNumbers = includeNumbers.Checked;
            char[] useChars = chars;

            if (useSymbols)
            {
                List<char> temp = new List<char>();
                temp.AddRange(useChars);
                temp.AddRange(symbols);
                useChars = temp.ToArray();
            }
            if (useNumbers)
            {
                List<char> temp = new List<char>();
                temp.AddRange(useChars);
                temp.AddRange(numbers);
                useChars = temp.ToArray();
            }

            if (charCount > useChars.Length && !shouldRepeat)
            {
                return $"error: There are more letters than specified, turn on Repeat Letters or make the number of letters less-than-or-equal-to: {useChars.Length}";
            }

            for (int i = 0; i < charCount; i++)
            {
                var number = rand.Next(useChars.Length);

                if (!shouldRepeat)
                {
                    if (result.Contains(useChars[number]))
                    {
                        while (result.Contains(useChars[number]))
                        {
                            number = rand.Next(useChars.Length);
                        }
                    }
                }

                
                result += useChars[number];
                    
            }

            return result;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

        }
    }
}
