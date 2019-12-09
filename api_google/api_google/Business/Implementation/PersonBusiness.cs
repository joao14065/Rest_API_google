﻿using api_google.Model;
using api_google.Repository;
using System.Collections.Generic;
using System.Linq;

namespace api_google.Business.Implementation
{
    public class PersonBusiness : IPersonBusiness
    {
        private IRepository<Person> _repository;
        public PersonBusiness(IRepository<Person> repository)
        {
            _repository = repository;
        }

        public bool Create(Person item)
        {
            return _repository.Save(item);
        }

        public bool Delete(long Id)
        {
            return _repository.Delete(Id);
        }

        public IQueryable<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long Id)
        {
            return _repository.Find(Id);
        }
    }
}
