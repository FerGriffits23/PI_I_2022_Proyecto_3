using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_PROYECTO3.Objetos
{
    internal class RestauranteServicioaDomicilio
    {
        public int ID { get; set; }
        public string NombreCliente { get; set; }
        public string NumeroTelefono { get; set; }
        public string Comidaquelleva { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string TarjetaoEfectivo { get; set; }

        public RestauranteServicioaDomicilio(): this(0,string.Empty, string.Empty, string.Empty,
            string.Empty,string.Empty,String.Empty)
        {
        }

        public RestauranteServicioaDomicilio(int pID, string pNombreCliente,  string pNumeroTelefono, string pComidaquelleva, 
            string pDireccion, string pCorreoElectronico, string pTarjetaoEfectivo)
        {
            ID                  = pID;
            NombreCliente       = pNombreCliente;
            NumeroTelefono      = pNumeroTelefono;
            Comidaquelleva      = pComidaquelleva;
            Direccion           = pDireccion;
            CorreoElectronico   = pCorreoElectronico;
            TarjetaoEfectivo    = pTarjetaoEfectivo;
        }
    }
}
