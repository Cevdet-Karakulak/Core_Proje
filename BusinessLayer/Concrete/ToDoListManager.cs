using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        IToDoDal _todoDal;

        public ToDoListManager(IToDoDal todoDal)
        {
            _todoDal = todoDal;
        }

        public void TAdd(ToDoList t)
        {
            _todoDal.Insert(t);
        }

        public void TDelete(ToDoList t)
        {
            _todoDal.Delete(t);
        }

        public ToDoList TGetById(int id)
        {
            return _todoDal.GetById(id);
        }

        public List<ToDoList> TGetList()
        {
            return _todoDal.GetList();
        }

        public void TUpdate(ToDoList t)
        {
            _todoDal.Update(t);
        }
    }
}
