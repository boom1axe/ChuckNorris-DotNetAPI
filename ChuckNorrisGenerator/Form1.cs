using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorrisGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateForm();
        }

        private async void populateForm()
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach (var cat in categories)
            {
                cboCatagoies.Items.Add(cat);
            }
        }

        private async void btnGetJoke_ClickAsync(object sender, EventArgs e)
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();
            string j = $"{joke.Id}:{joke.JokeText}\n\n{string.Join(",", joke.Categories)}";
            MessageBox.Show(j);
        }
    }
}
