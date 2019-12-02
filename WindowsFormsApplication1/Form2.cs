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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool exep = false;
            try
            { string nome1, rg1, cpf1, email1, endereco1, bairro1, cidade1, numero1, estado1, cep1, senha1, senha3,masc1,fam1,outro1
                    ;
                nome1 = nome.Text;
                rg1 = rg.Text;
                cpf1 = cpf.Text;
                email1 = email.Text;
                endereco1 = endereço.Text;
                bairro1 = bairro.Text;
                cidade1 = cidade.Text;
                numero1 = numero.Text;
                estado1 = estado.Text;
                cep1 = cep.Text;
                senha1 = senha.Text;
                numero1 = numero.Text;
                senha3 = senha2.Text;




                if (string.IsNullOrWhiteSpace(nome.Text))
                {

                    throw new Exception(" O campo 'nome' está vazio");

                }
                if (string.IsNullOrWhiteSpace(rg.Text))
                {

                    throw new Exception( "O campo 'RG' está vazio");
                }
                try
                {
                    Convert.ToInt64(rg.Text);
                }
                catch
                {
                    throw new Exception("O campo 'RG' deve ser numero");
                }
                if (string.IsNullOrWhiteSpace(cpf.Text))
                {

                    throw new Exception("O campo 'cpf' está vazio");
                }
                try
                {
                    Convert.ToInt64(cpf.Text);
                }
                catch
                {
                    throw new Exception("O campo 'cpf' deve ser numero");
                }
                if (string.IsNullOrWhiteSpace(email.Text))
                {

                    throw new Exception("O email está vazio");
                }
                if (string.IsNullOrWhiteSpace(endereço.Text))
                {

                    throw new Exception("O endereço está vazio");
                }
                if (string.IsNullOrWhiteSpace(bairro.Text))
                {

                    throw new Exception("O bairro está vazio");
                }
                if (string.IsNullOrWhiteSpace(cidade.Text))
                {

                    throw new Exception("O campo 'Cidade' está vazio");
                }
                if (string.IsNullOrWhiteSpace(numero.Text))
                {

                    throw new Exception(" O campo 'numero' está vazio");

                }
                if (string.IsNullOrWhiteSpace(estado.Text))
                {

                    throw new Exception(" O campo 'estado' está vazio");

                }
                if (string.IsNullOrWhiteSpace(cep.Text))
                {

                    throw new Exception("O campo 'cep' está vazio");
                }
                try
                {
                    Convert.ToInt64(cep.Text);
                }
                catch
                {
                    throw new Exception("O campo 'CEP' deve ser numero");
                }
                if (string.IsNullOrWhiteSpace(senha.Text))
                {

                    throw new Exception(" O campo 'senha' está vazio");

                }
                if (string.IsNullOrWhiteSpace(senha2.Text))
                {

                    throw new Exception(" O campo 'confirmar senha' está vazio");

                }
                if (string.IsNullOrWhiteSpace(numero.Text))
                {

                    throw new Exception(" O campo 'numero' está vazio");

                }
                if (masc.Checked == true)
                {
                   masc1 = masc.Text;
                }
                if (feme.Checked == true)
                {
                    fam1= feme.Text;
                }
                if (outro.Checked == true)
                {
                   outro1 = outro.Text;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exep = true;
            }
            if (exep == false)
            {
                this.Hide();
                Form4 OutroForm = new Form4();
                OutroForm.ShowDialog();
                this.Close();
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            
          



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult escolha;
            escolha = MessageBox.Show("Deseja Voltar?", " Retornar a Home", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (escolha.ToString().ToLower() == "yes") ;
            {
                this.Hide();
                Form1 Outroform = new Form1();
                Outroform.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            nome.Clear();
            rg.Clear();
            cpf.Clear();
            email.Clear();
            endereço.Clear();
            bairro.Clear();
            cidade.Clear();
            numero.Clear();
            cep.Clear(); 
            senha.Clear();
            senha2.Clear();
        }
    }
}
