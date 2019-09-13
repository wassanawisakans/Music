using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String m_id = txtMusicID.Text;
            String m_name = txtMusicName.Text;
            String m_type = txtMusicType.Text;
            String m_price = txtMusicPrice.Text;
            Manager.Inserta(m_id, m_name, m_type, m_price);
            MessageBox.Show("บันทึกเรียบร้อยแล้ว", "แจ้งเตือน");
            label6.Text = m_id;
            label7.Text = m_name;
            label8.Text = m_type;
            label9.Text = m_price;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            String m_id = txtMusicID.Text;
            String m_name = txtMusicName.Text;
            String m_type = txtMusicType.Text;
            String m_price = txtMusicPrice.Text;
            Manager.UpdateMusic(m_id, m_name, m_type, m_price);
            MessageBox.Show("แก้ไขเรียบร้อยแล้ว", "แจ้งเตือน");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            String m_id = txtMusicID.Text;
            Manager.DeleteMusic(m_id);
            MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "แจ้งเตือน");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            txtMusicID.Text = "";
            txtMusicName.Text = "";
            txtMusicType.Text = "";
            txtMusicPrice.Text = "";
        }
    }
}
