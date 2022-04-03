using BusinessLayer.Abstract;
using DataAcessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }
        public void CategoryAdd(Heading heading)
        {
            throw new NotImplementedException();
        }

        public void CategoryDelete(Heading heading)
        {
            throw new NotImplementedException();
        }

        public void CategoryUpdate(Heading heading)
        {
            throw new NotImplementedException();
        }

        public Heading GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Heading> GetList()
        {
            return _headingDal.List();
        }
    }
}
