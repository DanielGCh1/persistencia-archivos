using persistenciaArchivos.UNA.Cheques;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Cheques;

namespace persistenciaArchivos
{
    public partial class ControlDeCheques : Form
    {
        public ArchivoManager archivoManager;
        private readonly string userPassword = "El20Examen20Estaba20Faci20";

        public ControlDeCheques()
        {
            InitializeComponent();
            archivoManager = new ArchivoManager();
            AgregarAchivos();
        }

        private void AgregarAchivos()
        {
            archivoManager.CargarCheques(userPassword);
            for (int i = 0; i < archivoManager.ChequesList.LongCount(); i++)
            {
                Cheque cheque = archivoManager.ChequesList[i];
                ChequesDataGridView.Rows.Add(cheque.Nombre, cheque.Numero, cheque.Monto, cheque.Descripcion, cheque.Emisor, cheque.Receptor, cheque.Fecha, cheque.Moneda, cheque.InstitucionFinanciera);
               // ChequesDataGridView.Rows.Clear
            }
        }

        private void ButtonRefrescar_Click(object sender, EventArgs e)
        {
            AgregarAchivos();
        }
    }
}
