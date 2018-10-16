using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Objects;
using System.Linq;


namespace clsProva
{
    public class Prova
    {
        public static bool Salvar(clsBanco.Prova objProva)
        {
            try
            {
                clsBanco.dbProvaEntities contexto = new clsBanco.dbProvaEntities();

                if (objProva.id == 0)
                    contexto.Prova.Add(objProva);
               else
                {
                    contexto.Prova.Attach(objProva);
                    contexto.Entry(objProva).State = EntityState.Modified;
                }

                contexto.SaveChanges();                
                return true;
            }
            catch
            {
                throw;
            }
        }

        public static clsBanco.Prova SelectById(Int32 id)
        {
            try
            {
                clsBanco.dbProvaEntities contexto = new clsBanco.dbProvaEntities();
                clsBanco.Prova objProva = contexto.Prova.First(c => c.id == id);
                return objProva;
            }
            catch
            {
                throw;
            }
        }

        public static List<clsBanco.Prova> SelectAll()
        {
            try
            {
                clsBanco.dbProvaEntities contexto = new clsBanco.dbProvaEntities();
                List<clsBanco.Prova> ltsProva = contexto.Prova.ToList();
                return ltsProva;
            }
            catch
            {
                throw;
            }
        }

        public static bool Apagar(int id)
        {
            try
            {
                clsBanco.dbProvaEntities contexto = new clsBanco.dbProvaEntities();
                clsBanco.Prova objProva = contexto.Prova.First(c => c.id == id);
                contexto.Prova.Remove(objProva);
                contexto.SaveChanges();
                
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
