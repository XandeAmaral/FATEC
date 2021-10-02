using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_Alexandre
{
    public partial class Form1 : Form
    {
        public double num01;
        public double num02;
        public double res;

        public Form1()
        {
            InitializeComponent();
        }

        /*Evento que apos a escrita verifica cada letra
         se nao for um numero ele obriga a reescrever.*/
        private void txtNum1_KeyUp(object sender, KeyEventArgs e)
        {
            try // previni excecoes
            {
                string palavra = txtNum1.Text; // pega a palavra do TextBox
                foreach (char letra in palavra) { // percorre cada letra da palavra
                    
                    if (letra >= '0' && letra <= '9') { // se estiver dentro de 0 - 9 nao faz nada
                    
                    }
                    else{ // caso contrario ele obriga a reescrever
                        MessageBox.Show("So pode escrever numero.");
                        txtNum1.Clear();
                        txtNum1.Focus();
                        break; // sai do foreach
                    }
                    
                }                
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); } // mostra o erro se houver uma excessao
        }

        // Mesma logica do txtNum1_KeyUp
        private void txtNum2_KeyUp(object sender, KeyEventArgs e)
        {
            try 
            {
                string palavra = txtNum2.Text; 
                foreach (char letra in palavra)
                { 

                    if (letra >= '0' && letra <= '9'){

                    }
                    else
                    { 
                        MessageBox.Show("So pode escrever numero.");
                        txtNum2.Clear();
                        txtNum2.Focus();
                        break; 
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); } 
        }

        private void rdbAdicao_Click(object sender, EventArgs e)
        {
            if (VerificaTexto()){

                // pega os valores
                num01 = Convert.ToDouble(txtNum1.Text);
                num02 = Convert.ToDouble(txtNum2.Text);

                res = num01 + num02; //calculo
                // escreve a resposta no TextBox
                txtResultado.Text = res.ToString(); 
            }
            else{ // caso nao passe pela funcao VerificaTexto()

                rdbAdicao.Checked = false; // desmarca o rdb
            }
            
        }

        // Mesma Logica do rdbAdicao_Click so muda o calculo
        private void rdbSubtracao_Click(object sender, EventArgs e)
        {
            if (VerificaTexto()){

                num01 = Convert.ToDouble(txtNum1.Text);
                num02 = Convert.ToDouble(txtNum2.Text);

                res = num01 - num02;
                txtResultado.Text = res.ToString();
            }
            else{

                rdbSubtracao.Checked = false;
            }
        }

        private void rdbMultiplicacao_Click(object sender, EventArgs e)
        {
            if (VerificaTexto()){

                num01 = Convert.ToDouble(txtNum1.Text);
                num02 = Convert.ToDouble(txtNum2.Text);

                res = num01 * num02;
                txtResultado.Text = res.ToString();
            }
            else{

                rdbMultiplicacao.Checked = false;
            }
        }

        private void rdbDivisao_Click(object sender, EventArgs e)
        {
            if (VerificaTexto())
            {

                num01 = Convert.ToDouble(txtNum1.Text);
                num02 = Convert.ToDouble(txtNum2.Text);

                res = num01 / num02;
                txtResultado.Text = res.ToString();
            }
            else
            {

                rdbDivisao.Checked = false;
            }
        }


        /* uma funcao para verificar se os TextBox nao estao vazios
       para nao ter q ficar repetindo toda vez */
        private bool VerificaTexto()
        {
            try
            {
                // verifica se o tamanho e maior que 0
                if ((txtNum1.TextLength > 0) && (txtNum2.TextLength > 0)){

                    return (true); //se for passa direto
                }

                else{ // se nao volta para os TextBox
                    MessageBox.Show("Primeiro digite os valores");
                    txtNum1.Focus();
                    return (false);
                }
            }
            // mostra o erro se houver uma excessao
            catch (Exception ex) { MessageBox.Show(ex.Message); return (false); }
        }
    }
}
