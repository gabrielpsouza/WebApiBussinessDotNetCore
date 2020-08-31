using System;
using System.Collections.Generic;
using System.Text;
using WebApiBussines.Domain.Models;

namespace WebApiBussines.Infra.Interface
{
    public interface IBussinessRepository
    {
        List<BussinessModel> GetBussiness();

        BussinessModel GetByIdBussiness(int id);

        ReturnModel PostBussiness(BussinessModel model);

        void DeleteBussiness(int id);
    }
}
