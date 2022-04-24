using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_PROYECTO3.Objetos
{
    internal class RestauranteMenu
    {
        public int ID { get; set; }
        public string NomnbreCliente { get; set; }
        public string RTN { get; set; }
        public string Comida { get; set; }
        public string Refresco { get; set; }
        public string Postre { get; set; }

        public RestauranteMenu(): this(0, string.Empty, string.Empty , string.Empty, string.Empty, 
            string.Empty)
        {
        }

        public RestauranteMenu(int pID, string pNomnbreCliente, string pRTN, string pComida, 
            string PRefresco, string ppostre)
        {
            ID                  = pID;
            NomnbreCliente      = pNomnbreCliente;
            RTN                 = pRTN;
            Comida              = pComida;
            Refresco            = PRefresco;
            Postre              = ppostre;
        }
    }
}
