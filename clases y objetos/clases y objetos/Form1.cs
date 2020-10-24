using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clases_y_objetos
{
    public partial class Form1 : Form
    { 
        validarcajas validacion = new validarcajas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            if (!validacion.vacio(nombreIn, errorM, "El nombre no puede estar vacio"))
                if (!validacion.vacio(codigoIn, errorM, "El codigo no puede estar vacio"))
                    if (validacion.vacio(correoIn, errorM, "El correo no puede estar vacio")==false)
                    {
                        salida.Text = "Todos los valores estan llenos";
                        LimpiarCajas();
                    }
            if(validacion.esUnPasswordValido(txClave, errorM))
            {
                lblValidacionPass.Text = "El password es correcto";
            }

        }
       private void LimpiarCajas()
       {

            nombreIn.Clear();
            codigoIn.Clear();
            correoIn.Clear();

        }














        

    }

}


