using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInsertView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proba_transareDataSet1.View_Document' table. You can move, or remove it, as needed.
            this.view_DocumentTableAdapter.Fill(this.proba_transareDataSet1.View_Document);
            // TODO: This line of code loads data into the 'proba_transareDataSet.tabela_antet' table. You can move, or remove it, as needed.
            this.tabela_antetTableAdapter.Fill(this.proba_transareDataSet.tabela_antet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            var cmd = new SqlCommandBuilder(da);


            /*   tabela_antetTableAdapter.Adapter.Update(this.proba_transareDataSet.tabela_antet);
               tabelaantetBindingSource.EndEdit();
               proba_transareDataSet.EndInit();

               dataGridView1.Update();*/

            string data = dateTimePicker1.Value.ToShortDateString();

           
            view_DocumentTableAdapter.InsertQuery("5","6",7,data,1029);
           
            view_DocumentTableAdapter.Adapter.Update(proba_transareDataSet1.View_Document);
            viewDocumentBindingSource.EndEdit();
            proba_transareDataSet1.EndInit();
            dataGridView2.Update();
            




        }
    }
}
