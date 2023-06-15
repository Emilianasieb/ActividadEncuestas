using EncuestasLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncuestasForm
{
    public partial class Form1 : Form
    {
        ProcesoEncuestas proceso = new ProcesoEncuestas();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistroDeEncuesta_Click(object sender, EventArgs e)
        {
            FormRegistroDeEncuesta fRegistro = new FormRegistroDeEncuesta();
            if (fRegistro.ShowDialog() == DialogResult.OK)
            {
                Encuesta nuevo = new Encuesta();

                Console.WriteLine("Modo de transporte habitual");

                nuevo.UsaBicicleta = fRegistro.cbkUsaBicicleta.Checked; // Consulta("¿Usa bicleta?: S/N");
                nuevo.UsaAuto = fRegistro.cbkUsaAutomovil.Checked; // Consulta("¿Usa Automóvil?: S/N");
                nuevo.UsaTransportePublico = true; // Consulta("¿Usa Transporte público?: S/N");

                //Console.WriteLine("¿Cuál es la distancia aproximada a su destino de trabajo/estudio en km? (ej:1,5)\n");
                nuevo.DistanciaASuDestino = Convert.ToDouble(Console.ReadLine());

                bool puedeSerContactado = false; // Consulta("¿Puede ser contactado?: S/N");
                if (puedeSerContactado == true)
                {
                    Console.Write("Email: ");
                    nuevo.Email = "emisiebenlist00@gmail.com ";//Console.ReadLine();
                                                               // Console.Write("\n");
                }

                proceso.RegistrarEncuesta(nuevo, puedeSerContactado);
                MessageBox.Show("Encuesta procesada!");
            
            }
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            //Console.Clear();

            FormResultados fInformes = new FormResultados();
            fInformes.listBox1.Items.Add($"{"Bicicletas:",-20}{proceso.PorcBicleta,10:f2}%");
            fInformes.ShowDialog();

            //Console.WriteLine("\t\t Informe de resultados \n");
            //Console.WriteLine("Modo de transporte habitual\n");

            //Console.WriteLine($"\t{"Bicicleta:",-20}  {proceso.PorcBicleta,10:f2}%");
            /* Console.WriteLine($"\t{"Automóvil:",-20}  {proceso.PorcAuto,10:f2}%");
            Console.WriteLine($"\t{"Transporte público:",-20}  {proceso.PorcTranspPublico,10:f2}%");

            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();*/
        }
    }
}
