using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_PROYECTO3.Objetos
{
    internal class AutoServicio
    {
        public int ID { get; set; }
        public string Nombre3 { get; set; }
        public string NombreCliente { get; set; }
        public string RTN { get; set; }
        public string Comida { get; set; }
        public string Fresco { get; set; }
        public string Postre { get; set; }
        public string Fundacion { get; set; }

        public AutoServicio():  this(0, string.Empty ,string.Empty, string.Empty, string.Empty,string.Empty, string.Empty, 
            string.Empty)
        {
        }

        public AutoServicio(int pID , string pNombre3,string pNombreCliente, string pRTN, string pComida, 
            string pFresco, string pPostre, string pFundacion)
        {
            ID              = pID;
            Nombre3         = pNombre3;
            NombreCliente   = pNombreCliente;
            RTN             = pRTN;
            Comida          = pComida;
            Fresco          = pFresco;
            Postre          = pPostre;
            Fundacion       = pFundacion;
        }
    }
    }
