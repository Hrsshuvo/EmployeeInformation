using AutoMapper;
using Einfo.Persiatance.Database;
using EInfo.Core.Model;
using EInfo.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EInfo.Manager.Manager
{
    public class DepartmentManager
    {
        private AplicationDBContext _aplicationDBContext;

        public DepartmentManager()
        {
            _aplicationDBContext = new AplicationDBContext();
        }
        public DeparemeentVM Get(int id)
        {
            var drpertments = _aplicationDBContext.Deparements.SingleOrDefault(c => c.Id == id);

            return (Mapper.Map<Deparement, DeparemeentVM>(drpertments));

        }
    }
}
