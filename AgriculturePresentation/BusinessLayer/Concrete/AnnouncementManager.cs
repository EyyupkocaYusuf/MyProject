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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _AnnouncementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _AnnouncementDal = announcementDal;
        }

        public void AnnouncementStatusToFalse(int id)
        {
            _AnnouncementDal.AnnouncementStatusToFalse(id);
        }

        public void AnnouncementStatusToTrue(int id)
        {
            _AnnouncementDal.AnnouncementStatusToTrue(id);
        }

        public void TDelete(Announcement t)
        {
            _AnnouncementDal.Delete(t);       
        }

        public Announcement TGetById(int id)
        {
            return _AnnouncementDal.GetById(id);    
        }

        public List<Announcement> TGetListAll()
        {
            return _AnnouncementDal.GetListAll();
        }

        public void TInsert(Announcement t)
        {
            _AnnouncementDal.Insert(t);
        }

        public void TUpdate(Announcement t)
        {
            _AnnouncementDal.Update(t);
        }
    }
}
