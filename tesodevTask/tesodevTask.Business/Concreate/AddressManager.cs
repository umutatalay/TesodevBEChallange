using System;
using System.Collections.Generic;
using System.Text;
using tesodevTask.Business.Abstract;
using tesodevTask.DataAccess.Abstract;
using tesodevTask.DataAccess.Concreate;
using tesodevTask.Entities;

namespace tesodevTask.Business.Concreate
{
    public class AddressManager : IAddressService
    {
        private IAddressRepository _addressRepository;

        public AddressManager()
        {
            _addressRepository = new AddressRepository();
        }
        public Address Create(Address address)
        {
            return _addressRepository.Create(address);
        }

        public void Delete(Guid id)
        {
            _addressRepository.Delete(id);
        }

        public List<Address> GetAll()
        {
            return _addressRepository.GetAll();
        }

        public Address GetById(Guid id)
        {
            return _addressRepository.GetById(id);
        }

        public Address Update(Address address)
        {
            return _addressRepository.Update(address);

        }
    }
}
