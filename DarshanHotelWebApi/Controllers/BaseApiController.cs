using DarshanHotelWebApi.DbService;
using DarshanHotelWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DarshanHotelWebApi.Controllers
{
    public class BaseApiController<T> : ApiController where T : class, IEntity, new()
    {
        protected BaseDbService<T> _dataAccessService;

        public BaseApiController()
        {

        }

        public BaseApiController(BaseDbService<T> dataAccessService)
        {
            this._dataAccessService = dataAccessService;
        }

        public virtual IEnumerable<T> Get()
        {
            return _dataAccessService.GetList();
        }

        public virtual T Get(long id)
        {
            return _dataAccessService.GetEntity(id);
        }

        public virtual string Post(T entity)
        {
            string errorMsg;
            bool isSuccess;

            if (ModelState.IsValid)
            {
                isSuccess = _dataAccessService.SaveEntity(entity, out errorMsg);
            }
            else
            {
                isSuccess = false;
                errorMsg = "Data is not valid";
            }

            if (isSuccess)
                return "Data Saved";

            return errorMsg;
        }

        public string Put(T entity)
        {
            string errorMsg;
            bool isSuccess;

            if (ModelState.IsValid)
            {
                isSuccess = _dataAccessService.UpdateEntity(entity, out errorMsg);
            }
            else
            {
                isSuccess = false;
                errorMsg = "Data is not valid";
            }

            if (isSuccess)
                return "Data Updated";

            return errorMsg;
        }

        public virtual string Delete(long id)
        {
            string errorMsg;
            bool isSuccess;

            isSuccess = _dataAccessService.DeleteEntity(id, out errorMsg);

            if (isSuccess)
                return "Data Deleted";

            return errorMsg;
        }
    }
}
