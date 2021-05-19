using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDePago.Models
{
    public class DetalleDePago
    {
        //Llave primaria, ID de la transaccion
        [Key]
        public int IDPago { get; set; }
        
        //Nombre de la tarjeta
        [Column(TypeName = "nvarchar (25)")]
        public string NombreTarjeta { get; set; }

        //Numero de tarjeta
        [Column (TypeName ="nvarchar (16)")]
        public string NumeroTarjeta { get; set; }

        //Fecha de vencimiento
        [Column(TypeName = "nvarchar (5)")]
        public string VencimientoTarjeta { get; set; }

        //Codigo de seguridad
        [Column(TypeName = "nvarchar (3)")]
        public string CodigoSeguridad { get; set; }
     }
}
