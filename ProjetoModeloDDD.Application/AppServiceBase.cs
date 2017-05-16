using System;
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class AppServiceBase<TEntry> : IDisposable, IServiceBase<TEntry> where TEntry : class
    {
        private readonly IServiceBase<TEntry> _serviceBase;

        public AppServiceBase(IServiceBase<TEntry> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntry obj)
        {
            _serviceBase.Add(obj);
        }

        public IEnumerable<TEntry> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntry GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public void Remove(TEntry obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Update(TEntry obj)
        {
            _serviceBase.Update(obj);
        }
        
        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
