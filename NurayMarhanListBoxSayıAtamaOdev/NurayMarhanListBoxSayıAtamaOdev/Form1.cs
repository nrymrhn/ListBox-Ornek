using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurayMarhanListBoxSayıAtamaOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                cbmBirdenOnaKadar.Items.Add(i);
            }

            lbRastgeleSayilar.SelectionMode = SelectionMode.MultiSimple; // Çoklu seçim yapabilmesi için.
            lbSag.SelectionMode = SelectionMode.MultiSimple;
        }

        private void cbmBirdenOnaKadar_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= cbmBirdenOnaKadar.SelectedIndex;)
            {

                lbRastgeleSayilar.Items.Add(rnd.Next(0, 101));
                i++;
            }
        }

        private void btnSag_Click(object sender, EventArgs e)
        {

            for (int i = lbRastgeleSayilar.SelectedIndices.Count - 1; i >= 0; i--)//Çoklu seçim ListBoxiçin, bu özellik içinde seçilen ListBox tüm öğelerin dizinlerini içeren bir koleksiyon döndürür.
            {
                //Seçili elemanı ikinci listeye ekle
                lbSag.Items.Add(lbRastgeleSayilar.SelectedItems[i]);
                //Seçilen elemanı listeden silme
                lbRastgeleSayilar.Items.RemoveAt(lbRastgeleSayilar.SelectedIndices[i]);


            }
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            for (int i = lbSag.SelectedIndices.Count - 1; i >= 0; i--)
            {
                //Seçili elemanı ikinci listeye ekle
                lbRastgeleSayilar.Items.Add(lbSag.SelectedItems[i]);
                //Seçilen elemanı listeden silme
                lbSag.Items.RemoveAt(lbSag.SelectedIndices[i]);

            }
        }
    }
}
