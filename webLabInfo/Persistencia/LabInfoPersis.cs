using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;

namespace Persistencia
{
    public class LabInfoPersis
    {
        public static int Salvar(Entidade.LabInfo objLabInfo)
        {
            try
            {
                LabInfoContexto contexto = new LabInfoContexto();
                contexto.LabInfos.Add(objLabInfo);

                if (objLabInfo.id != 0)
                    contexto.Entry(objLabInfo).State = System.Data.Entity.EntityState.Modified;

                contexto.SaveChanges();
 
                return objLabInfo.id;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
        }

        public Boolean SalvarEntidade(Entidade.LabInfo objLabInfo)
        {
            try
            {
                LabInfoContexto contexto = new LabInfoContexto();
                contexto.LabInfos.Add(objLabInfo);

                if (objLabInfo.id != 0)
                    contexto.Entry(objLabInfo).State = System.Data.Entity.EntityState.Modified;

                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
        }

        public static List<LabInfo> FillLabInfo(int? id, string nome, bool? isprojetor, int? qtdAlunos, int? qtdComputadores
                                                , string sistemaOperacional, string software1, string software2, string software3)
        {
            try
            {
                List<LabInfo> lstlabinfo = new List<LabInfo>();
                LabInfoContexto contexto = new LabInfoContexto();
                if (id != null)
                    lstlabinfo = contexto.LabInfos.Where(l => l.id == id).ToList();
                else
                   lstlabinfo = (from l in contexto.LabInfos
                                where (nome != null ? l.nome.Contains(nome) : true)
                                   && (qtdAlunos != null ? l.qtdAlunos == qtdAlunos : true)
                                   && (qtdComputadores != null ? l.qtdComputadores == qtdComputadores : true)
                                   && (sistemaOperacional != null ? l.sistemaOperacional.Contains(sistemaOperacional) : true)
                                   && (software1 != null ? l.software1.Contains(software1) : true)
                                   && (software2 != null ? l.software2.Contains(software2) : true)
                                   && (software3 != null ? l.software3.Contains(software3) : true)
                                   && (isprojetor != null ? l.projetor == isprojetor : true)
                                 orderby l.nome descending
                               select l).ToList();

                return lstlabinfo;
            }
            catch
            {
                throw;
            }
        }

        public static Boolean ExcluirEntidade(Entidade.LabInfo objLabInfo)
        {
            try
            {
                LabInfoContexto contexto = new LabInfoContexto();
                contexto.Entry(objLabInfo).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
        }
    }
}
