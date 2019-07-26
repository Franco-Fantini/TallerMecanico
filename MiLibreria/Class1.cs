using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace MiLibreria
{
    public class Utilidades

    {
        public static DataSet Ejecutar(string cmd)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
            con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);

            DP.Fill(DS);
            con.Close();

            return DS;
        }
      
        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider ErrorProvider)
        {

            Boolean HayErrores = false;
            foreach (Control Item in Objeto.Controls)
            {
                if (Item is ErrorTxtBox)
                {
                    ErrorTxtBox Obj = (ErrorTxtBox)Item;

                    if (Obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(Obj, "Este campo no puede estar vacio");
                            HayErrores = true;

                        }
                    }
                   if(Obj.SoloNumeros == true)
                    {
                        int cont = 0, letrasencontradas = 0;

                        foreach (char letra in Obj.Text.Trim())
                        { if(char.IsLetter(Obj.Text.Trim(), cont))
                            {
                                letrasencontradas++;
                            }
                            cont++;
                         }
                        if(letrasencontradas !=0)
                        { HayErrores = true;
                            ErrorProvider.SetError(Obj, "Este campo solo admite numeros");

                        }
                    }



                }
            }
            return HayErrores;
        }
    }
}
