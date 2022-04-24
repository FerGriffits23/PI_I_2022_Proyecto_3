using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_PROYECTO3.Objetos
{
    internal class RestautranteCliente
    {
        public int ID { get; set; }
        public string Cliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string NumeroTelefono { get; set; }
        public string RTN { get; set; }
        public string CorreoElectronico { get; set; }
        public RestautranteCliente () : this(0,string.Empty, string.Empty, string.Empty, string.Empty, 
            string.Empty, string.Empty)
        {
        }
  
    public RestautranteCliente(int pID,  string pCliente, string pNombreCliente, string pApellidoCliente, string pNumeroTelefono,
             string pRTN, string pCorreoElectronico)
        {
            ID                  = pID;
            Cliente             = pCliente;
            NombreCliente       = pNombreCliente;
            ApellidoCliente     = pApellidoCliente;
            NumeroTelefono      = pNumeroTelefono;
            RTN                 = pRTN;
            CorreoElectronico = pCorreoElectronico;
           

        }

      
        }
    
}
