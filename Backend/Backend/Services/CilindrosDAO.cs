using Backend.Context;
using Backend.Models;

namespace Backend.Services
{
    public class CilindrosDAO
    {
        public CilindrosPContext context = new CilindrosPContext();
        //todos los cilindros
        public List<CilindroResp> allCilindros()
        {
            var cilindros = from c in context.Cilindros
                            join e in context.Envases on c.Idenvase equals e.Id
                            join p in context.Productos on c.Idproducto equals p.Id
                            select new CilindroResp
                            {
                                Id = c.Id,
                                Serie = c.Serie,
                                Envase = e.Descripcion,
                                Producto = p.Descripcion,
                                Capacidad = c.Capacidad
                            };
            return cilindros.ToList<CilindroResp>();
        }

        //Insertar Cilindro
        public Boolean insertCilindro(string serie, int idenvase, int idproducto, int cantidad)
        {
            try
            {
                Cilindro cilindro = new Cilindro();
                cilindro.Serie = serie;
                cilindro.Idenvase = idenvase;
                cilindro.Idproducto = idproducto;
                cilindro.Capacidad = cantidad;
                context.Cilindros.Add(cilindro);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //Editar Cilidnro

        public Boolean editCilindro(Cilindro cilindro, int idCilindro)
        {
            try
            {
                Cilindro c = context.Cilindros.Where(c => c.Id == idCilindro).FirstOrDefault();
                if(cilindro.Idenvase != null || cilindro.Idenvase !=-1)
                {
                    c.Idenvase = cilindro.Idenvase;
                }
                if (cilindro.Idproducto != null || cilindro.Idproducto != -1)
                {
                    c.Idproducto = cilindro.Idproducto;
                }
                if (cilindro.Capacidad != null || cilindro.Capacidad != -1)
                {
                    c.Capacidad = cilindro.Capacidad;
                }
                if (cilindro.Serie != null || cilindro.Serie != "")
                {
                    c.Serie = cilindro.Serie;
                }

                context.SaveChanges();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        // Borrar Cilindro
        public Boolean deleteCilindro(int idCilindro)
        {
            try
            {
                Cilindro c = context.Cilindros.Where(c => c.Id == idCilindro).FirstOrDefault();
                context.Cilindros.Remove(c);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


    }
}
