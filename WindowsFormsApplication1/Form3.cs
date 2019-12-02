using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nome1.Clear();
            codigo.Clear();
            descriçao.Clear();
            estoque1.Clear();
            preco1.Clear();
           tipo1.Text = "";
            unid.Text = "0";



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           bool exep = false;
            try
            {    string codBarras,nome,descricao,preco,estoque,unidade,tipo;
                codBarras = codigo.Text;
                nome = nome1.Text;
                descricao = descriçao.Text;
                preco = preco1.Text;
                estoque = estoque1.Text;
                unidade = unid.Text;
                tipo = tipo1.Text;

                if (string.IsNullOrWhiteSpace(codigo.Text))
                {

                    throw new Exception(" Codigo de barras vazio");
                }
                try
                {
                    Convert.ToInt64(codigo.Text);
                }
                catch
                {
                    throw new Exception(" O codigo de barras deve ser numero");
                }
                if (string.IsNullOrWhiteSpace(nome1.Text))
                {

                    throw new Exception(" Nome está vazio");
                }
                if (string.IsNullOrWhiteSpace(descriçao.Text))
                {

                    throw new Exception(" Descrição está vazio");
                }
                if (string.IsNullOrWhiteSpace(preco1.Text))
                {

                    throw new Exception("Preço está vazio");
                }
                if (string.IsNullOrWhiteSpace(estoque1.Text))
                {

                    throw new Exception(" Estoque está vazio");
                }
                if (string.IsNullOrWhiteSpace(unid.Text))
                {

                    throw new Exception("Unidade está vazio");
                }
                if (string.IsNullOrWhiteSpace(tipo1.Text))
                {

                    throw new Exception(" tipo está vazio");

                }

            }
            catch(Exception ex)
            {
               
               MessageBox.Show( ex.Message,"ERRO",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                exep = true;
            }
            if(exep == false)
            {
                this.Hide();
                Form4 OutroForm = new Form4();
                OutroForm.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult escolha;
            escolha=MessageBox.Show("Deseja Voltar?", " Retornar a Home", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(escolha.ToString().ToLower()=="yes");
            {
                this.Hide();
                Form1 Outroform = new Form1();
                Outroform.ShowDialog();
                this.Close();
            }
        }

     

        private void codigo_Leave(object sender, EventArgs e)
        {if (codigo.Text == "")
            {
                codigo.Text = "Digite o código de barras";
                codigo.ForeColor = Color.Silver;
            }
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

            
        }

       
    }
}
