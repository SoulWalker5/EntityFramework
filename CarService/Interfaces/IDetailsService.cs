using BusinessLogicLayer.Models;
using System.Collections.Generic;

namespace BusinessLogicLayer.Interfaces
{
    public interface IDetailsService
    {
        IEnumerable<DetailModel> GetDetails();
        void Create(DetailModel detail);
        void Update(DetailModel detail);
        void Delete(int id);
        DetailModel GetById(int id);
    }
}