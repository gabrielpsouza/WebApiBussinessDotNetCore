using System.Collections.Generic;
using WebApiBussines.Domain.Models;

namespace WebApiBussines.Domain.Interface
{
    public interface IBussinessService
    {
        List<BussinessModel> GetBussiness();

        BussinessModel GetByIdBussiness(int id);

        ReturnModel PostBussiness(BussinessModel model);

        ReturnModel DeleteBussiness(int id);
    }
}
