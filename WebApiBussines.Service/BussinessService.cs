using System;
using System.Collections.Generic;
using System.Linq;
using WebApiBussines.Domain.Interface;
using WebApiBussines.Domain.Models;
using WebApiBussines.Infra.Interface;

namespace WebApiBussines.Service
{
    public class BussinessService : IBussinessService
    {
        private readonly IBussinessRepository _bussinessRepository;

        public BussinessService(IBussinessRepository bussinessRepository)
        {
            _bussinessRepository = bussinessRepository;
        }

        public List<BussinessModel> GetBussiness()
        {
            return _bussinessRepository.GetBussiness();
        }

        public BussinessModel GetByIdBussiness(int id)
        {
            BussinessModel retorno = new BussinessModel();
            retorno = _bussinessRepository.GetByIdBussiness(id);

            if (retorno == null)
                retorno.Retorno = "ID not exist";

            return retorno;
        }

        public ReturnModel PostBussiness(BussinessModel model)
        {
            ReturnModel retorno = new ReturnModel();
            try
            {

                if (ValidateData(model))
                {
                    retorno = _bussinessRepository.PostBussiness(model);
                    return retorno;
                }
                else
                {
                    retorno.Retorno = "Unfilled data";
                    return retorno;
                }

            }
            catch (Exception ex)
            {
                retorno.Retorno = ex.Message;
                return retorno;
            }
        }

        public ReturnModel DeleteBussiness(int id)
        {
            ReturnModel retorno = new ReturnModel();
            try
            {
                if (id != 0)
                {
                    if (!ValidateRegister(id))
                    {
                        retorno.Retorno = "Register not exist!";
                        return retorno;
                    }

                    _bussinessRepository.DeleteBussiness(id);
                    retorno.Retorno = "ID excluido";

                }
                else
                {
                    retorno.Retorno = "Não tem registro";
                }
            }
            catch (Exception ex)
            {
                retorno.Retorno = ex.Message;
                return retorno;
            }

            return retorno;
        }

        private bool ValidateRegister(int id)
        {
            BussinessModel bussiness = new BussinessModel();
            var retorno = true;

            bussiness = _bussinessRepository.GetByIdBussiness(id);

            if (bussiness.BussinessId == 0)
                retorno = false;

            return retorno;
        }

        private bool ValidateData(BussinessModel model)
        {
            bool retorno = true;

            if (!model.NameBussiness.Any())
                retorno = false;

            if (!model.Phone.Any())
                retorno = false;

            if (!model.Email.Any())
                retorno = false;

            if (!model.Document.Any())
                retorno = false;

            return retorno;

        }
    }
}
