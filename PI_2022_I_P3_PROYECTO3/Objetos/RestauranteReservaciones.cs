using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_PROYECTO3.Objetos
{
    internal class RestauranteReservaciones
    {
        public int ID { get; set; }
        public string NombreCliente { get; set; }
        public string NumeroTelefono { get; set; }
        public string FechaReservacion { get; set; }
        public string HoraReservacion { get; set; }
        public string Ticket { get; set; }
        public string  Mesa { get; set; }
        public string Personas { get; set; }

        public RestauranteReservaciones(): this(0, string.Empty, string.Empty, string.Empty, 
            string.Empty, string.Empty,string.Empty,string.Empty)
        {
        }

        public RestauranteReservaciones(int pID ,string pNombreCliente, string pNumeroTelefono, 
            string pFechaReservacion, string pHoraReservacion, string pTicket, string pMesa, string pPersonas)
        {
            ID                      = pID;
            NombreCliente           = pNombreCliente;
            NumeroTelefono          = pNumeroTelefono;
            FechaReservacion        = pFechaReservacion;
            HoraReservacion         = pHoraReservacion;
            Ticket                  = pTicket;
            Mesa                    = pMesa;
            Personas                = pPersonas;
        }
    }
}
