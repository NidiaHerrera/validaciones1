using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clases_y_objetos
{
    class validarcajas
    {
        public Boolean vacio(TextBox caja, ErrorProvider error, string mensajeError)
        {
            if (caja.Text == "")
            {
                error.SetError(caja, mensajeError);
                caja.Focus();
                return true;
            }
            else
            {
                error.Clear();
                return false;
            }
        }

        public Boolean esUnPasswordValido(TextBox caja, ErrorProvider error)
        {
            String pass = caja.Text;
            if (pass.Length<6)
            {
                error.SetError(caja, "La clave debe ser de minimo 6 caracteres");
                return false;
            }
                if (pass.Contains("*")|| pass.Contains("/") || pass.Contains("#") || pass.Contains("$"))
                {
                    error.Clear();
                    return true;
                }
                else
                {
                    error.SetError(caja, "La clave debe contener un caracter especial  (*, $,  /, #) ");
                    return false;
                }
            
        }



    }
}
