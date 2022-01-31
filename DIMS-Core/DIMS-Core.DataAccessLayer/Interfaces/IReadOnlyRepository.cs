﻿using System;
using System.Linq;

namespace DIMS_Core.DataAccessLayer.Interfaces
{
    public interface IReadOnlyRepository<out TEntity> : IDisposable
        where TEntity : class
    {
        IQueryable<TEntity> GetAll();
    }
}
