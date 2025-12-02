using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Advent_of_Code_2025_Day_1
{
    public partial class Form1 : Form
    {
        public static string Dir = @"..\..\..\Input\";
        public static string Path = Dir + "input";
        public int position = 50;
        public int zeroHits = 0;
        StreamReader inputIn;
        public Form1()
        {
            InitializeComponent();

            try
            {
                inputIn = new(new FileStream(Path, FileMode.Open, FileAccess.Read));
                while (inputIn.Peek() != -1)
                {
                    string line = inputIn.ReadLine() ?? "L0";
                    Regex splitter = new Regex(@"([a-zA-Z]+)(\d+)");
                    Match result = splitter.Match(line);

                    string direction = result.Groups[1].Value;
                    int amount = int.Parse(result.Groups[2].Value);

                    if (direction == "L")
                    {
                        position -= amount;
                        while (position < 0)
                        {
                            Underflow();
                        }
                    }

                    if (direction == "R")
                    {
                        position += amount;
                        while (position > 99)
                        {
                            Overflow();
                        }
                    }

                    if (position == 0)
                    {
                        zeroHits++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtZeroHits.Text = zeroHits.ToString();
        }

        public void Overflow()
        {
            position -= 100;
        }

        public void Underflow()
        {
            position += 100;
        }
    }
}
