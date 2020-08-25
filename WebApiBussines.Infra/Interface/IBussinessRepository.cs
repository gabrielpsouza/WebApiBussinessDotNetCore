using System;
using System.Collections.Generic;
using System.Text;
using WebApiBussines.Domain.Models;

namespace WebApiBussines.Infra.Interface
{
    public interface IBussinessRepository
    {
        List<BussinessModel> GetBussiness();

        List<BussinessModel> GetByIdBussiness(int id);
    }
}
