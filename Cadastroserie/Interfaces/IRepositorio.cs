using System.Collections.Generic;

namespace Dio.Series.Interfaces
{
    
    public interface IRepositorio<T>
    {
         List<T> Lista();

        T RetornaporId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int Id, T entidade);
        int ProximoId();





    }
}