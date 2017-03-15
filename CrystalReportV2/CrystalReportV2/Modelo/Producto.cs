using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrystalReportV2.Modelo
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int pkProducto { get; set; }
        [Required(ErrorMessage ="Falta Nombre")]
        public String sNombreCorto{get; set;}
        [Required(ErrorMessage = "Falta la Descripcion")]
        public String sDescripcion { get; set; }
        [Required(ErrorMessage = "Falta el Precio")]
        public Double dPrecio { get; set; }
        [Required(ErrorMessage = "Falta el Costo")]
        public Double dCosto { get; set; }
        [Required(ErrorMessage = "Falta la Existencia")]
        public int iStock { get; set; }
        [Required(ErrorMessage = "Falta el Departamento")]
        public String sDepartamento { get; set; }
        public Boolean bStatus { get; set; }


        public Producto() {
            bStatus = true;
        }

    }
}
