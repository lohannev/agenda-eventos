using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_de_eventos_aula17
{
    public partial class Form1 : Form
    {
        //declaração de vetores de forma global:
        String[] Meses;
        String[] Datas;
        RadioButton[] RBs;

        // declaração de matriz de forma global:
        String[,] Eventos;


        public Form1()
        {
            InitializeComponent();

        }

        void Localizar(ref RadioButton radio) //criação de método sem retorno
        {
            for (int i = 0; i <= Eventos.GetUpperBound(0); i++)
            {
                if (radio.Text == Eventos[i, 0])
                {
                    lblEntrada.Text = Eventos[i, 1];
                    lblEvento.Text = Eventos[i, 2];
                    lblinicio.Text = Eventos[i, 3];
                    lblLocal.Text = Eventos[i, 4];
                    lblTermino.Text = Eventos[i, 5];
                    panel1.Visible = true;
                    lblAmarelo.Visible = false;
                    return; //finaliza o loop
                }
                else
                {
                    lblAmarelo.Visible = true;
                    panel1.Visible = false;
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)

        {
            Meses = new String[3] { "Maio", "Junho", "Julho" };
            Datas = new String[6] { "05/", "06/", "07/", "08/", "09/", "10/" };
            RBs = new RadioButton[6] { radioD1, radioD2, radioD3, radioD4, radioD5, radioD6 };

    

            //instanciando a matriz de eventos: **erros no forms aqui. verificar com rodrgo**
            Eventos = new String[13, 6];

            Eventos[0, 0] = "05/Mai";               	    //Data
            Eventos[0, 1] = "Feira Agronegócio";    //Evento
            Eventos[0, 2] = "Centro de Exposições"; //Local
            Eventos[0, 3] = "10:00h";               //Hora início
            Eventos[0, 4] = "18:00h";               //Hora Término
            Eventos[0, 5] = "R$ 50,00";             //Valor Entrada

            Eventos[1, 0] = "06/Mai";
            Eventos[1, 1] = "Feira do Imigrante";
            Eventos[1, 2] = "Pavilhão Amarelo";
            Eventos[1, 3] = "08:00h";
            Eventos[1, 4] = "22:00h";
            Eventos[1, 5] = "Gratuito";

            Eventos[2, 0] = "07/Mai";
            Eventos[2, 1] = "Congresso Direito";
            Eventos[2, 2] = "Centro de Eventos";
            Eventos[2, 3] = "14:00h";
            Eventos[2, 4] = "21:00h";
            Eventos[2, 5] = "R$ 35,00";

            Eventos[3, 0] = "08/Mai";
            Eventos[3, 1] = "Fórum Educação";
            Eventos[3, 2] = "Hotel Estrela";
            Eventos[3, 3] = "16:00h";
            Eventos[3, 4] = "22:00h";
            Eventos[3, 5] = "Gratuito";

            Eventos[4, 0] = "09/Mai";
            Eventos[4, 1] = "Festival Ecologia";
            Eventos[4, 2] = "Parque Estadual";
            Eventos[4, 3] = "08:00h";
            Eventos[4, 4] = "17:00h";
            Eventos[4, 5] = "Gratuito";

            Eventos[5, 0] = "10/Mai";
            Eventos[5, 1] = "Encontro Estudantes";
            Eventos[5, 2] = "Ginásio Municipal";
            Eventos[5, 3] = "16:00h";
            Eventos[5, 4] = "22:00h";
            Eventos[5, 5] = "R$ 10,00";

            Eventos[6, 0] = "05/Jun";
            Eventos[6, 1] = "Festa da Pitanga";
            Eventos[6, 2] = "Estufa Agrícola";
            Eventos[6, 3] = "15:00h";
            Eventos[6, 4] = "20:00h";
            Eventos[6, 5] = "R$ 15,00";

            Eventos[7, 0] = "06/Jun";
            Eventos[7, 1] = "Feira de Arte";
            Eventos[7, 2] = "Bienal";
            Eventos[7, 3] = "10:00h";
            Eventos[7, 4] = "19:00h";
            Eventos[7, 5] = "R$ 25,00";

            Eventos[8, 0] = "07/Jun";
            Eventos[8, 1] = "Encontro Hoteleiro";
            Eventos[8, 2] = "Centro de Convenções";
            Eventos[8, 3] = "11:00h";
            Eventos[8, 4] = "21:00h";
            Eventos[8, 5] = "R$ 35,00";

            Eventos[9, 0] = "08/Jun";
            Eventos[9, 1] = "Diário do Turismo";
            Eventos[9, 2] = "Hotel Central";
            Eventos[9, 3] = "09:00h";
            Eventos[9, 4] = "18:00h";
            Eventos[9, 5] = "R$ 30,00";

            Eventos[10, 0] = "09/Jun";
            Eventos[10, 1] = "Encontro Feiras e Negócios";
            Eventos[10, 2] = "Centro de Exposições";
            Eventos[10, 3] = "09:00h";
            Eventos[10, 4] = "19:00h";
            Eventos[10, 5] = "R$ 70,00";

            Eventos[11, 0] = "10/Jun";
            Eventos[11, 1] = "Palestra Interativa";
            Eventos[11, 2] = "Academia Principal";
            Eventos[11, 3] = "08:00h";
            Eventos[11, 4] = "11:00h";
            Eventos[11, 5] = "Gratuito";

            Eventos[12, 0] = "05/Jul";
            Eventos[12, 1] = "Reunião Negócios";
            Eventos[12, 2] = "Clube Municipal";
            Eventos[12, 3] = "09:00h";
            Eventos[12, 4] = "12:00h";
            Eventos[12, 5] = "R$ 80,00";

            //Carrega o combobox do mês:
            
            for (int i = 0; i <= Meses.GetUpperBound(0); i++)
            {
                cmbMes.Items.Add(Meses[i]);
            }

            //Deixa o groupbox, panel e label amarelo invisiveis.
            gbDatas.Visible = false;
            panel1.Visible = false;
            lblAmarelo.Visible = false;


           

        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= RBs.GetUpperBound(0); i++)
            {
                //elimina a seleção dos radiobuttons
                RBs[i].Checked = false;
                 
                //preenche cada radio button com as datas
                RBs[i].Text = Datas[i] + cmbMes.Text.Substring(0, 3);

            }
            gbDatas.Visible = true;
            panel1.Visible = false;
            lblAmarelo.Visible = false;
        }

        private void radioD1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioD1.Checked)
                Localizar(ref radioD1);
        }

        private void radioD2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioD2.Checked)
                Localizar(ref radioD2);
        }

        private void radioD3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioD3.Checked)
                Localizar(ref radioD3);
        }

        private void radioD4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioD4.Checked)
                Localizar(ref radioD4);

        }

        private void radioD5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioD5.Checked)
                Localizar(ref radioD5);
        }

        private void radioD6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioD6.Checked)
                Localizar(ref radioD6);
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            cmbMes.ResetText();
            gbDatas.Visible = false;
            panel1.Visible = false;
            lblAmarelo.Visible = false;

            //estrutura de repetição contendo os 06 itens do vetor de radiobuttons e eliminando suas marcações:

            for (int i = 0; i <= RBs.GetUpperBound (0); i++)
            {
                RBs[i].Checked = false;
            }


        }
        private void bttSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //fecha a aplicação completamente
            //Close(); //fecha apenas o formulário
            //application.Exit(); fecha a aplicação completamente

        }
    }
}
