using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOGO_VELHA
{
    public partial class Form1 : Form
    {
        string nomex, nomeo, fim_de_jogo;
        string minha_vez;
        void mostrar_tabuleiro(bool estado)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Visible = estado;
            button2.Visible = estado;
            button3.Visible = estado;
            button4.Visible = estado;
            button5.Visible = estado;
            button6.Visible = estado;
            button7.Visible = estado;
            button8.Visible = estado;
            button9.Visible = estado;
        }
        string mudar_turno()
        {
            if (minha_vez == "" || minha_vez == "O")
                minha_vez = "X";
            else
                minha_vez = "O";
            return minha_vez;
        }
        void desabilitar_tabuleiro()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        void nome_do_vencedor(string nome)
        {
            MessageBox.Show("GAME OVER");
            if (nome == "O")
                MessageBox.Show("VENCEDOR: " + nomeo);
            else
                MessageBox.Show("VENCEDOR: " + nomex);
            desabilitar_tabuleiro();
            fim_de_jogo = "sim";
            button10.Text = "JOGAR NOVAMENTE";
        }
        void vencedor()
        {
            if (button1.Text != "" & button1.Text == button2.Text & button2.Text == button3.Text)
                nome_do_vencedor(button1.Text);
            else if (button4.Text != "" & button4.Text == button5.Text & button5.Text == button6.Text)
                nome_do_vencedor(button4.Text);
            else if (button7.Text != "" & button7.Text == button8.Text & button8.Text == button9.Text)
                nome_do_vencedor(button7.Text);
            else if (button1.Text != "" & button1.Text == button4.Text & button4.Text == button7.Text)
                nome_do_vencedor(button1.Text);
            else if (button2.Text != "" & button2.Text == button5.Text & button5.Text == button8.Text)
                nome_do_vencedor(button2.Text);
            else if (button3.Text != "" & button3.Text == button6.Text & button6.Text == button9.Text)
                nome_do_vencedor(button3.Text);
            else if (button1.Text != "" & button1.Text == button5.Text & button5.Text == button9.Text)
                nome_do_vencedor(button1.Text);
            else if (button3.Text != "" & button3.Text == button5.Text & button5.Text == button7.Text)
                nome_do_vencedor(button3.Text);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrar_tabuleiro(false);
            fim_de_jogo = "não";
            button10.Text = "JOGAR";
        }

        //BOTÃO JOGAR
        private void button10_Click(object sender, EventArgs e)
        {
            if (fim_de_jogo == "sim")
                Application.Restart();
            else
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                    MessageBox.Show("DIGITE OS NOMES");
                else
                {
                    nomex = textBox1.Text;
                    nomeo = textBox2.Text;
                    label1.Visible = false;
                    label2.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    mostrar_tabuleiro(true);
                }
            }
        }

        //TABULEIRO
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = mudar_turno();
            button1.Enabled = false;
            vencedor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = mudar_turno();
            button2.Enabled = false;
            vencedor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = mudar_turno();
            button3.Enabled = false;
            vencedor();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = mudar_turno();
            button4.Enabled = false;
            vencedor();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = mudar_turno();
            button5.Enabled = false;
            vencedor();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = mudar_turno();
            button6.Enabled = false;
            vencedor();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = mudar_turno();
            button7.Enabled = false;
            vencedor();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = mudar_turno();
            button8.Enabled = false;
            vencedor();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = mudar_turno();
            button9.Enabled = false;
            vencedor();
        }
    }
}
