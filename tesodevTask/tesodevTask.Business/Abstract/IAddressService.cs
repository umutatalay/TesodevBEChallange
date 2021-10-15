using System;
using System.Collections.Generic;
using System.Text;
using tesodevTask.Entities;

namespace tesodevTask.Business.Abstract
{
    public interface IAddressService
    {
        List<Address> GetAll();

        Address GetById(Guid id);

        Address Create(Address address);

        Address Update(Address address);

        void Delete(Guid id);
    }
}
