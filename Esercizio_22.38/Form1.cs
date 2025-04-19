using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_22._38
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EseguiOperazioni(string operatore)
        {
            float num1, num2;
            if(float.TryParse(txtTesto1.Text, out num1) && float.TryParse(txtTesto2.Text, out num2))
            {
                float risultato = 0;
                string operazione = "";

                switch (operatore)
                {
                    case "+":
                        risultato = num1 + num2;
                        operazione = $"{num1} + {num2} = {risultato}";
                        break;
                    case "-":
                        risultato = num1 - num2;
                        operazione = $"{num1} - {num2} = {risultato}";
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            risultato = num1 / num2;
                            operazione = $"{num1} / {num2} = {risultato}";
                        }
                        else
                        {
                            operazione = "Errore. Impossibile dividere per zero.";
                        }
                            break;
                    case "*":
                        risultato = num1 * num2;
                        operazione = $"{num1} * {num2} = {risultato}";
                        break;
                }
                lstRisultati.Items.Add(operazione);
            }
            else
            {
                MessageBox.Show("Inserisci un numero valido.");
            }
        }
        private void btnSomma_Click(object sender, EventArgs e)
        {
            EseguiOperazioni("+");
        }

        private void btnSottrazione_Click(object sender, EventArgs e)
        {
            EseguiOperazioni("-");
        }

        private void btnDivisione_Click(object sender, EventArgs e)
        {
            EseguiOperazioni("/");
        }

        private void btnMoltiplicazione_Click(object sender, EventArgs e)
        {
            EseguiOperazioni("*");
        }
    }
}
