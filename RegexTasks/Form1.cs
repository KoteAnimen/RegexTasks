using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexTasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetAnswer_Click(object sender, EventArgs e)
        {
            answer.Text = "";
            Regex expression = new Regex(regularExpression.Text);
            MatchCollection answers = expression.Matches(text.Text);
            for(int i = 0; i < answers.Count; i++)
            {
                answer.Text += answers[i] + " ";
            }
            text.Focus();
        }
    }

}
