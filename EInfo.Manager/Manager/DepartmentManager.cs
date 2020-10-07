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
        public IEnumerable<DeparemeentVM> GetAll()
        {
            var drpertments = _aplicationDBContext.Deparements.ToList().Select(Mapper.Map<Deparement, DeparemeentVM>);
            return drpertments;
        }
        public int Add(DeparemeentVM vm)
        {
            var etity = Mapper.Map<DeparemeentVM, Deparement>(vm);
            _aplicationDBContext.Deparements.Add(etity);
            var isSave = _aplicationDBContext.SaveChanges();
            return isSave;
        }
        public int Update(int id,DeparemeentVM vm)
        {
            var entity = _aplicationDBContext.Deparements.SingleOrDefault(c => c.Id == id);
            Mapper.Map(vm,entity);
            var isUpdate = _aplicationDBContext.SaveChanges();
            return isUpdate;
        }
        public int Remove(int id)
        {
            var entity = _aplicationDBContext.Deparements.SingleOrDefault(c => c.Id == id);
            _aplicationDBContext.Deparements.Remove(entity);
            var isRemove = _aplicationDBContext.SaveChanges();
            return isRemove;
        }
    }
}
