using System.Collections.Generic;
using WebApiBussines.Domain.Interface;
using WebApiBussines.Domain.Models;
using WebApiBussines.Infra.Interface;

namespace WebApiBussines.Service
{
    public class BussinessService : IBussinessService
    {
        private readonly IBussinessRepository _bussinessRepository;

        public BussinessService(IBussinessRepository  bussinessRepository)
        {
            _bussinessRepository = bussinessRepository;
        }

        public List<BussinessModel> GetBussiness()
        {
            return _bussinessRepository.GetBussiness();
        }

        public List<BussinessModel> GetByIdBussiness(int id)
        {
            return _bussinessRepository.GetByIdBussiness(id);
        }
    }
}
