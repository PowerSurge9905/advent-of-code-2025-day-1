using System.Text.RegularExpressions;

namespace Advent_of_Code_2025_Day_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int position = 50;
            int zeroPasses = 0;
            try
            {
                StringReader inputIn = new StringReader(txtInput.Text);
                while (inputIn.Peek() != -1)
                {
                    string line = inputIn.ReadLine() ?? "L0";
                    Regex splitter = new Regex(@"([a-zA-Z]+)(\d+)");
                    Match result = splitter.Match(line);

                    string direction = result.Groups[1].Value;
                    int amount = int.Parse(result.Groups[2].Value);

                    if (direction == "L")
                    {
                        if (position == 0)
                        {
                            position -= amount;
                            while (position < 0)
                            {
                                position += 100;
                                zeroPasses++;
                            }
                            zeroPasses--;
                        }
                        else
                        {
                            position -= amount;
                            while (position < 0)
                            {
                                position += 100;
                                zeroPasses++;
                            }
                            if (position == 0)
                            {
                                zeroPasses++;
                            }
                        }
                    }

                    if (direction == "R")
                    {
                        position += amount;
                        while (position > 99)
                        {
                            position -= 100;
                            zeroPasses++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtZeroHits.Text = zeroPasses.ToString();
        }
    }
}
