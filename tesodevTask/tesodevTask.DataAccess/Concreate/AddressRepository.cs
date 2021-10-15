using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tesodevTask.DataAccess.Abstract;
using tesodevTask.Entities;

namespace tesodevTask.DataAccess.Concreate
{
    public class AddressRepository : IAddressRepository
    {
        public Address Create(Address address)
        {
            using (var TdbContext = new TdbContext())
            {
                TdbContext.Address.Add(address);
                TdbContext.SaveChanges();
                return address;

            }
        }

        public void Delete(Guid id)
        {
            using (var TdbContext = new TdbContext())
            {
                var Deleted = GetById(id);
                TdbContext.Address.Remove(Deleted);
                TdbContext.SaveChanges();
            }
        }

        public List<Address> GetAll()
        {
            using (var TdbContext = new TdbContext())
            {
                return TdbContext.Address.ToList();

            }
        }

        public Address GetById(Guid id)
        {
            using (var TdbContext = new TdbContext())
            {
                return TdbContext.Address.Find(id);
            }
        }

        public Address Update(Address address)
        {
            using (var TdbContext = new TdbContext())
            {
                TdbContext.Address.Update(address);
                TdbContext.SaveChanges();
                return address;
            }
        }
    }
}
