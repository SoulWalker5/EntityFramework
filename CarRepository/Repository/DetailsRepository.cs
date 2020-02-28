﻿using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repository
{
    public class DetailsRepository : IDetailsRepository
    {
        private readonly CarContext _ctx;
        public DetailsRepository()
        {
            _ctx = new CarContext();
        }
        public void Delete(Detail detail)
        {
            _ctx.Details.Remove(detail);
            _ctx.SaveChanges();
        }

        public IEnumerable<Detail> GetDetails()
        {
            var cars = _ctx.Cars.Select(x => x).ToList();
            var details = _ctx.Details.Select(x => x).ToList();
            return details;
        }

        public void Create(Detail detail)
        {
            _ctx.Details.Add(detail);
            _ctx.SaveChanges();
        }

        public void Update(Detail detail)
        {
            var finddetail = _ctx.Details.Find(detail.Id);
            finddetail.Name = detail.Name;
            finddetail.CarId = detail.CarId;
            _ctx.SaveChanges();
        }

        public Detail GetById(int id)
        {
            var search = _ctx.Details.Find(id);
            return search;
        }
    }
}
