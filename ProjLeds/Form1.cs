using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaçãoLedV1
{
    public partial class Form1 : Form
    {
        private Leds luz;
        public Form1()
        {
            InitializeComponent();
            luz = new Leds();
            tbx_IndicarValor.Text = luz.getdados().ToString();
            atualizainterface();
        }

        private void atualizainterface()
        {
            tbx_IndicarValor.Text = luz.getdados().ToString();
            tbx_dado_2.Text = Convert.ToString(luz.getdados(),2);
            ckb_led1.Checked = luz.getled(1);
            ckb_led2.Checked = luz.getled(2);
            ckb_led3.Checked = luz.getled(3);
            ckb_led4.Checked = luz.getled(4);
            ckb_led5.Checked = luz.getled(5);
            ckb_led6.Checked = luz.getled(6);
            ckb_led7.Checked = luz.getled(7);
            ckb_led8.Checked = luz.getled(8);
            pic_luz1.Image = (luz.getled(1) ?
                AutomaçãoLedV1.Properties.Resources.luz1 :
                AutomaçãoLedV1.Properties.Resources.luz2);
            pic_luz2.Image = (luz.getled(2) ?
                AutomaçãoLedV1.Properties.Resources.luz1 :
                AutomaçãoLedV1.Properties.Resources.luz2);
            pic_luz3.Image = (luz.getled(3) ?
                AutomaçãoLedV1.Properties.Resources.luz1 :
                AutomaçãoLedV1.Properties.Resources.luz2);
            pic_luz4.Image = (luz.getled(4) ?
                AutomaçãoLedV1.Properties.Resources.luz1 :
                AutomaçãoLedV1.Properties.Resources.luz2);
            pic_luz5.Image = (luz.getled(5) ?
                AutomaçãoLedV1.Properties.Resources.luz1 :
                AutomaçãoLedV1.Properties.Resources.luz2);
            pic_luz6.Image = (luz.getled(6) ?
                AutomaçãoLedV1.Properties.Resources.luz1 :
                AutomaçãoLedV1.Properties.Resources.luz2);
            pic_luz7.Image = (luz.getled(7) ?
                AutomaçãoLedV1.Properties.Resources.luz1 :
                AutomaçãoLedV1.Properties.Resources.luz2);
            pic_luz8.Image = (luz.getled(8) ?
                AutomaçãoLedV1.Properties.Resources.luz1 :
                AutomaçãoLedV1.Properties.Resources.luz2);

        }

        private void btn_on_1_Click(object sender, EventArgs e)
        {
            luz.acender(1);
            atualizainterface();
        }

        private void btn_on_2_Click(object sender, EventArgs e)
        {
            luz.acender(2);
            atualizainterface();
        }

        private void btn_on_3_Click(object sender, EventArgs e)
        {
            luz.acender(3);
            atualizainterface();
        }

        private void btn_on_4_Click(object sender, EventArgs e)
        {
            luz.acender(4);
            atualizainterface();
        }

        private void btn_on_5_Click(object sender, EventArgs e)
        {
            luz.acender(5);
            atualizainterface(); ;
        }

        private void btn_on_6_Click(object sender, EventArgs e)
        {
            luz.acender(6);
            atualizainterface();
        }

        private void btn_on_7_Click(object sender, EventArgs e)
        {
            luz.acender(7);
            atualizainterface();
        }

        private void btn_on_8_Click(object sender, EventArgs e)
        {
            luz.acender(8);
            atualizainterface();
        }

        private void btn_off_1_Click(object sender, EventArgs e)
        {
            luz.apagar(1);
            atualizainterface();
        }

        private void btn_off_2_Click(object sender, EventArgs e)
        {
            luz.apagar(2);
            atualizainterface();
        }

        private void btn_off_3_Click(object sender, EventArgs e)
        {
            luz.apagar(3);
            atualizainterface();
        }

        private void btn_off_4_Click(object sender, EventArgs e)
        {
            luz.apagar(4);
            atualizainterface();
        }

        private void btn_off_5_Click(object sender, EventArgs e)
        {
            luz.apagar(5);
            atualizainterface();
        }

        private void btn_off_6_Click(object sender, EventArgs e)
        {
            luz.apagar(6);
            atualizainterface();
        }

        private void btn_off_7_Click(object sender, EventArgs e)
        {
            luz.apagar(7);
            atualizainterface();
        }

        private void btn_off_8_Click(object sender, EventArgs e)
        {
            luz.apagar(8);
            atualizainterface();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_IndicarValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
