using HospitalManagement.Repositories.Implementaiton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        GenericRepository<T> GenericRepository<T>() where T : class;
        void save();
    }
}
