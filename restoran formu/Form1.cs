namespace restoran_formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //////////////////////////sözlük(dictionary)////////////////////////////////// 


        Dictionary<PictureBox, (string Category, int Price)> productInfo
        = new Dictionary<PictureBox, (string, int)>();


        /////////////////////////////////////////////////////////////
        private void ShowCategory(string category)
        {

            foreach (PictureBox pb in flowLayoutPanel1.Controls.OfType<PictureBox>())
            {
                if (string.IsNullOrEmpty(category))
                    pb.Visible = true;
                else
                    pb.Visible = (productInfo[pb].Category == category);
            }

        }
        //////////////////////////////////////////////////////////////


        private void Form1_Load(object sender, EventArgs e)
        {
            productInfo[pictureBox1] = ("Pizza", 285);
            productInfo[pictureBox2] = ("Pizza", 290);
            productInfo[pictureBox3] = ("Pizza", 275);
            productInfo[pictureBox4] = ("Pizza", 295);
            productInfo[pictureBox5] = ("Pizza", 310);
            productInfo[pictureBox6] = ("Pizza", 290);
            productInfo[pictureBox7] = ("Pizza", 300);
            productInfo[pictureBox8] = ("Pizza", 310);
            productInfo[pictureBox9] = ("Pizza", 295);
            productInfo[pictureBox13] = ("ham", 210);
            productInfo[pictureBox14] = ("ham", 260);
            productInfo[pictureBox15] = ("ham", 240);
            productInfo[pictureBox20] = ("ham", 280);
            productInfo[pictureBox10] = ("ham", 220);
            productInfo[pictureBox12] = ("iç", 85);
            productInfo[pictureBox21] = ("iç", 275);
            productInfo[pictureBox11] = ("iç", 72);
            productInfo[pictureBox16] = ("iç", 12);
            productInfo[pictureBox17] = ("tat", 6);
            productInfo[pictureBox18] = ("tat", 15);
            productInfo[pictureBox22] = ("tat", 8);







            pictureBox1.Click += PictureBox_Click;
            pictureBox2.Click += PictureBox_Click;
            pictureBox3.Click += PictureBox_Click;
            pictureBox4.Click += PictureBox_Click;
            pictureBox5.Click += PictureBox_Click;
            pictureBox6.Click += PictureBox_Click;
            pictureBox7.Click += PictureBox_Click;
            pictureBox8.Click += PictureBox_Click;
            pictureBox9.Click += PictureBox_Click;
            pictureBox10.Click += PictureBox_Click;
            pictureBox11.Click += PictureBox_Click;
            pictureBox12.Click += PictureBox_Click;
            pictureBox13.Click += PictureBox_Click;
            pictureBox14.Click += PictureBox_Click;
            pictureBox15.Click += PictureBox_Click;
            pictureBox16.Click += PictureBox_Click;
            pictureBox17.Click += PictureBox_Click;
            pictureBox18.Click += PictureBox_Click;
            pictureBox20.Click += PictureBox_Click;
            pictureBox21.Click += PictureBox_Click;
            pictureBox22.Click += PictureBox_Click;


        }
        //////////////////////////////////////////////////////////////////////////////
        private void button3_Click(object sender, EventArgs e)
        {

            ShowCategory("ham");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ShowCategory("iç");
        }
        private void button2_Click(object sender, EventArgs e)
        {

            ShowCategory("tat");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowCategory("Pizza");
        }
        /////////////////////////////////////////////////////////////////////
        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            if (pb != null && pb.Image != null)
            {
                PictureBox kopya = new PictureBox();
                kopya.Image = (Image)pb.Image.Clone();
                kopya.Size = pb.Size;
                kopya.SizeMode = pb.SizeMode;
                kopya.BorderStyle = pb.BorderStyle;

                kopya.Tag = productInfo[pb].Price;
                kopya.Click += (sender, EventArgs) =>
                {
                    if (kopya.Parent != null)////////////////////////sil////////////////////////////////
                    {
                        kopya.Parent.Controls.Remove(kopya);
                        kopya.Dispose();
                        UpdateTotal();
                    }
                };

                flowLayoutPanel2.Controls.Add(kopya);
                UpdateTotal();
            }
        }


        //////////////////////////////////////////////////////////////

        private void UpdateTotal()
        {
            int toplam = 0;
            foreach (Control ctrl in flowLayoutPanel2.Controls)
            {
                if (ctrl is PictureBox pb && pb.Tag != null)
                {
                    toplam += Convert.ToInt32(pb.Tag);
                }
            }
            label2.Text = "Toplam = " + toplam.ToString("0");
        }

        //////////////////////////////////////////////////////////////////
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            flowLayoutPanel2.Controls.Add(pb);
            UpdateTotal();
        }

        private void copiedPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            flowLayoutPanel2.Controls.Remove(pb);
            pb.Dispose();
            UpdateTotal();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        /////////////////////////////////////////////////////////////////////
    }
}   
