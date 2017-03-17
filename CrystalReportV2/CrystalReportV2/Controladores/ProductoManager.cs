using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity;
using CrystalReportV2.Modelo;
namespace CrystalReportV2.Controladores
{
    class ProductoManager
    {
        public static List<String> getListaDepartamentos() {
            List<String> Deptos = new List<string>();
            try
            {
                using (var ctx = new DataModel()) {                 
                    var Categoria= ctx.Productos.GroupBy(r => r.sDepartamento).ToList();
                    foreach (var item in Categoria) {
                        Deptos.Add(item.Key.ToUpper());
                    }
                    Deptos.Add("TODOS");
                    return Deptos;
                }
            }
            catch (Exception)
            {
                throw;
            }                            
        }

        public static List<Producto> getListado()
        {
            try
            {
                using (var ctx = new DataModel()) {
                    return ctx.Productos.Where(r => r.bStatus == true).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }       
    }
}
