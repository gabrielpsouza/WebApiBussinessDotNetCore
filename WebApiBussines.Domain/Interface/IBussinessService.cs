﻿using System.Collections.Generic;
using WebApiBussines.Domain.Models;

namespace WebApiBussines.Domain.Interface
{
    public interface IBussinessService
    {
        List<BussinessModel> GetBussiness();

        List<BussinessModel> GetByIdBussiness(int id);
    }
}
