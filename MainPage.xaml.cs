using System.Data;

namespace macalculatrice
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_clicked_supp(object sender, EventArgs e)
        {
            explabel.Text = "";
        }
        private void Button_clicked_Egale(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(explabel.Text))
            {
                DataTable dt = new DataTable();
                var r = dt.Compute(explabel.Text, "");
                explabel.Text = $"{r}";
            }
        }
        private void Button_clicked_1(object sender, EventArgs e)
        {
            explabel.Text += 1;
        }

        private void Button_clicked_2(object sender, EventArgs e)
        {
            explabel.Text += 2;
        }

        private void Button_clicked_3(object sender, EventArgs e)
        {
            explabel.Text += 3;
        }

        private void Button_clicked_4(object sender, EventArgs e)
        {
            explabel.Text += 4;
        }

        private void Button_clicked_5(object sender, EventArgs e)
        {
            explabel.Text += 5;
        }
        private void Button_clicked_6(object sender, EventArgs e)
        {
            explabel.Text += 6;
        }
        private void Button_clicked_7(object sender, EventArgs e)
        {
            explabel.Text += 7;
        }
        private void Button_clicked_8(object sender, EventArgs e)
        {
            explabel.Text += 8;
        }

        private void Button_clicked_9(object sender, EventArgs e)
        {
            explabel.Text += 9;
        }

        private void Button_clicked_moinss(object sender, EventArgs e)
        {
            explabel.Text = "-";
        }
        private void Button_clicked_plus(object sender, EventArgs e)
        {
            explabel.Text = "+";
        }
        private void Button_clicked_div(object sender, EventArgs e)
        {
            explabel.Text = "/";
        }
        private void Button_clicked_foiss(object sender, EventArgs e)
        {
            explabel.Text = "*";
        }
        private void Button_clicked_0(object sender, EventArgs e)
        {
            explabel.Text += 9;
        }



    }

}
