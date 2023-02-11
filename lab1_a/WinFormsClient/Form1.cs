using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void secondParameterField_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultField_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var firstParameter = firstParameterField.Text;
            var secondParameter = secondParameterField.Text;

            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("x", firstParameter),
                new KeyValuePair<string, string>("y", secondParameter)
            });

            var client = new HttpClient();
            var result = await client.PostAsync("https://localhost:44337/task4.gve", formContent);
            resultField.Text = await result.Content.ReadAsStringAsync();
        }
    }
}
