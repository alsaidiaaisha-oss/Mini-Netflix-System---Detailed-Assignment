using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // قائمة الأفلام المشاهدة
        List<string> watchedMovies = new List<string>();

        public Form1()
        {
            InitializeComponent();

            // إضافة الأفلام
            cmbMovies.Items.Add("Naruto Movie");
            cmbMovies.Items.Add("One Piece Red");
            cmbMovies.Items.Add("Demon Slayer");
            cmbMovies.Items.Add("Attack On Titan");

            cmbMovies.SelectedIndex = 0;

            // إعداد التقييم
            numRating.Minimum = 1;
            numRating.Maximum = 10;
        }

        // زر Watch
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string movie = cmbMovies.SelectedItem.ToString();

            if (userName == "")
            {
                MessageBox.Show("Please Enter User Name");
                return;
            }

            watchedMovies.Add(movie);

            MessageBox.Show(userName + " is watching " + movie);
        }

        // زر Rate
        private void button2_Click(object sender, EventArgs e)
        {
            string movie = cmbMovies.SelectedItem.ToString();
            int rating = (int)numRating.Value;

            // التحقق من المشاهدة أولاً
            if (!watchedMovies.Contains(movie))
            {
                MessageBox.Show("Watch movie first!");
                return;
            }

            lstMovies.Items.Add(movie + " - Your Rating: " + rating + "/10");
        }

        // زر Show
        private void button3_Click(object sender, EventArgs e)
        {
            if (watchedMovies.Count == 0)
            {
                MessageBox.Show("No watched movies");
                return;
            }

            string movies = "";

            foreach (string movie in watchedMovies)
            {
                movies += movie + "\n";
            }

            MessageBox.Show(movies);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}