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
    public class WriterMessageManager:IwriterMessageService
    {
        IWriterMessageDal _writermessageDal;

        public WriterMessageManager(IWriterMessageDal writermessageDal)
        {
            _writermessageDal = writermessageDal;
        }

        public void TAdd(WriterMessage t)
        {
            _writermessageDal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            _writermessageDal.Delete(t);
        }

        public WriterMessage TGetById(int id)
        {
            return _writermessageDal.GetById(id);
        }

        public List<WriterMessage> TGetList()
        {
            return _writermessageDal.GetList();
        }

        public void TUpdate(WriterMessage t)
        {
            _writermessageDal.Update(t);
        }
    }
}
