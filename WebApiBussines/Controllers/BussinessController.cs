using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiBussines.Domain.Interface;
using WebApiBussines.Domain.Models;

namespace WebApiBussines.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BussinessController : Controller
    {
        private readonly IBussinessService _bussinessService;

        /// <summary>
        /// Class's Constructor
        /// </summary>
        /// <param name="bussinessService"></param>
        public BussinessController(IBussinessService bussinessService)
        {
            _bussinessService = bussinessService;
        }

        /// <summary>
        /// Method that does a query in table bussines and get all data
        /// </summary>
        /// <returns></returns>
        [HttpGet("/")]
        public List<BussinessModel> GetBussiness()
        {
            return _bussinessService.GetBussiness();
        }

        /// <summary>
        /// Method that does a query with a id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("/GetById")]
        public BussinessModel GetByIdBussiness(int id)
        {
            return _bussinessService.GetByIdBussiness(id);
        }

        /// <summary>
        /// Method that inserts the data in database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("/PostBussiness")]
        public ReturnModel PostBussiness(BussinessModel model)
        {
            ReturnModel retorno = new ReturnModel();
            retorno = _bussinessService.PostBussiness(model);
            return retorno;
         
        }

        [HttpDelete("/DeleteBussiness")]
        public ReturnModel DeleteBussiness(int id)
        {
            ReturnModel retorno = new ReturnModel();
            retorno = _bussinessService.DeleteBussiness(id);
            return retorno;
        }
    }
}