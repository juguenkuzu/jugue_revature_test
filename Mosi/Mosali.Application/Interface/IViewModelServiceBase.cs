
using System;
using System.Collections.Generic;
using System.Text;

namespace Mosali.Application.Interface
{
    public interface IViewModelServiceBase<TEntity> where TEntity : class
    {
        void Ajouter(TEntity obj);
        IEnumerable<TEntity> ObtenirTout();
        void MisAJour(TEntity obj);
        void Supprimer(TEntity obj);
        
    }
}
