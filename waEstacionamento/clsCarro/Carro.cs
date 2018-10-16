using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsBanco;


namespace clsCarro
{
    public class Carro
    {
        public static Boolean Salvar(clsBanco.Carro objCarro)
        {
            try
            {
                clsBanco.dbEstacionamentoEntities contexto = new clsBanco.dbEstacionamentoEntities();
                contexto.Carro.Add(objCarro);
                contexto.Entry(objCarro).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public static clsBanco.Carro SelectById(Int32 id)
        {
            try
            {
                dbEstacionamentoEntities contexto = new dbEstacionamentoEntities();
                clsBanco.Carro objCarro = contexto.Carro.First(c => c.id == id);
                return objCarro;
            }
            catch
            {
                throw;
            }
        }
    }
}
