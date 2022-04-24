using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_PROYECTO3.Objetos
{
    internal class RestauranteEmpleado
    {
        public int ID { get; set; }
        public string Cliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string Edad { get; set; }
        public string Sexo { get; set; }
        public string Nacimiento { get; set; }
        public string Experiencia { get; set; }

        public RestauranteEmpleado():this(0, string.Empty, string.Empty, string.Empty, string.Empty, 
            string.Empty, string.Empty,string.Empty)
        {

        }

        public RestauranteEmpleado(int pID, string pCliente, string pNombreCliente, string pApellidoCliente,
            string pEdad, string pSexo, string pNacimiento, string pExperiencia)
        {
            ID                  = pID;
            Cliente             = pCliente;
            NombreCliente       = pNombreCliente;
            ApellidoCliente     = pApellidoCliente;
            Edad                = pEdad;
            Sexo                = pSexo;
            Nacimiento          = pNacimiento;
            Experiencia         = pExperiencia;
        }
    }
}
