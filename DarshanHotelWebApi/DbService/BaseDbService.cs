using DarshanHotelWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DarshanHotelWebApi.DbService
{
    public class BaseDbService<T> where T : class, IEntity, new()
    {
        protected DatabaseContext context;
        public BaseDbService()
        {
            context = new DatabaseContext();
        }

        public virtual List<T> GetList()
        {
            using (var db = new DatabaseContext())
            {
                var list = db.Set<T>().Where(x => !x.IsDeleted).ToList();
                return list;
            }
        }

        public virtual T GetEntity(long id)
        {
            using (var db = new DatabaseContext())
            {
                return db.Set<T>().SingleOrDefault(x => x.Id == id);
            }
        }

        public virtual bool SaveEntity(T entity, out string errorMsg)
        {
            try
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();

                errorMsg = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return false;
            }
        }

        public virtual bool UpdateEntity(T entity, out string errorMsg)
        {
            try
            {
                if (entity.Id <= 0)
                {
                    errorMsg = "Data is not valid";
                    return false;
                }

                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

                errorMsg = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return false;
            }
        }

        public virtual bool DeleteEntity(long id, out string errorMsg)
        {
            try
            {
                var entity = context.Set<T>().Find(id);
                entity.IsDeleted = true;

                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

                errorMsg = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return false;
            }
        }
    }
}