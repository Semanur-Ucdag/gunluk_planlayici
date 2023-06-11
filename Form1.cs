using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gunluk_planlayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int click = 1;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (click == 1)
            {
                pictureBox2.Image = Image.FromFile("../../img/bardak_tick.png");
                click = 0;
            }
            else
            {
                pictureBox2.Image = Image.FromFile("../../img/bardak.png");
                click = 1;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void richtextbox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Saatler";
            dataGridView1.Columns[1].Name = " ";

            string[] row = new string[] { "08.00 AM", " " };
            dataGridView1.Rows.Add(row);
            row = new string[] { "09.00 AM", " " };
            dataGridView1.Rows.Add(row);
            row = new string[] { "10.00 AM", " " };
            dataGridView1.Rows.Add(row);
            row = new string[] { "11.00 AM", " " };
            dataGridView1.Rows.Add(row);
            row = new string[] { "12.00 AM", " " };
            dataGridView1.Rows.Add(row);
            row = new string[] { "01.00 PM", " " };
            dataGridView1.Rows.Add(row);
            row = new string[] { "02.00 PM", " " };
            dataGridView1.Rows.Add(row);
            row = new string[] { "03.00 PM", " " };
            dataGridView1.Rows.Add(row);
            row = new string[] { "04.00 PM", " " };
            dataGridView1.Rows.Add(row);
            row = new string[] { "05.00 PM", " " };
            dataGridView1.Rows.Add(row);
            row = new string[] { "06.00 PM", " " };
            dataGridView1.Rows.Add(row);
            row = new string[] { "07.00 PM", " " };
            dataGridView1.Rows.Add(row);
            row = new string[] { "08.00 PM", " " };
            dataGridView1.Rows.Add(row);
            row = new string[] { "09.00 PM", " " };
            dataGridView1.Rows.Add(row);
            row = new string[] { "10.00 PM", " " };
            dataGridView1.Rows.Add(row);
            row = new string[] { "11.00 PM", " " };
            dataGridView1.Rows.Add(row);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].ReadOnly = true;
            }
        }

        int click2 = 1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (click2 == 1)
            {
                pictureBox1.Image = Image.FromFile("../../img/bardak_tick.png");
                click2 = 0;
            }
            else
            {
                pictureBox1.Image = Image.FromFile("../../img/bardak.png");
                click2 = 1;
            }
        }

        int click3 = 1;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (click3 == 1)
            {
                pictureBox3.Image = Image.FromFile("../../img/bardak_tick.png");
                click3 = 0;
            }
            else
            {
                pictureBox3.Image = Image.FromFile("../../img/bardak.png");
                click3 = 1;
            }
        }

        int click4 = 1;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (click4 == 1)
            {
                pictureBox5.Image = Image.FromFile("../../img/bardak_tick.png");
                click4 = 0;
            }
            else
            {
                pictureBox5.Image = Image.FromFile("../../img/bardak.png");
                click4 = 1;
            }
        }

        
    

        int click5 = 1;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (click5 == 1)
            {
                pictureBox4.Image = Image.FromFile("../../img/bardak_tick.png");
                click5 = 0;
            }
            else
            {
                pictureBox4.Image = Image.FromFile("../../img/bardak.png");
                click5 = 1;
            }
        }
        int click6 = 1;
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (click6 == 1)
            {
                pictureBox6.Image = Image.FromFile("../../img/bardak_tick.png");
                click6 = 0;
            }
            else
            {
                pictureBox6.Image = Image.FromFile("../../img/bardak.png");
                click6 = 1;
            }
        }
        int click7 = 1;
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (click7 == 1)
            {
                pictureBox7.Image = Image.FromFile("../../img/bardak_tick.png");
                click7 = 0;
            }
            else
            {
                pictureBox7.Image = Image.FromFile("../../img/bardak.png");
                click7 = 1;
            }
        }
        int click8 = 1;
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (click8 == 1)
            {
                pictureBox8.Image = Image.FromFile("../../img/bardak_tick.png");
                click8 = 0;
            }
            else
            {
                pictureBox8.Image = Image.FromFile("../../img/bardak.png");
                click8 = 1;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}