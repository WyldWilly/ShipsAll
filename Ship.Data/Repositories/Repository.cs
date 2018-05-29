using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ship.Data.Context;
using Ship.Data.Entities;

namespace Ship.Data.Repositories
{
    public class Repository
    {
        private ShipContext ctx;

        public Repository(string connString)
        {
            ctx = new ShipContext(connString);
        }

        #region Index Insert

        public ShipIndex Insert(ShipIndex a)
        {
            try
            {
                a = ctx.ShipI.Add(a);
                ctx.SaveChanges();
                return a;
            }
            catch
            {
                throw;
            }

        }
        #endregion

        #region Index Update
        public ShipIndex Update(ShipIndex a)
        {
            try
            {
                var item = ctx.ShipI.Find(a.Id);
                if (item != null)
                {
                    if (!object.Equals(item, a))
                    {
                        ctx.Entry(item).CurrentValues.SetValues(a);
                        ctx.SaveChanges();
                    }
                    else
                    {
                        ctx.SaveChanges();
                    }
                    return ctx.ShipI.Find(a.Id);
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Index Delete
        public bool Delete(ShipIndex a)
        {
            try
            {
                if (ctx.ShipI.Find(a.Id) != null)
                {
                    ctx.ShipI.Remove(a);
                    return ctx.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Index Retrieval
        public IQueryable<ShipIndex> GetShipIs()
        {
            return ctx.ShipI.AsQueryable();
        }

        public ShipIndex GetShipI(int id)
        {
            return ctx.ShipI.Find(id);
        }
        #endregion

        //------------------------------------------

        #region Types Insert
        public ShipTypes Insert(ShipTypes a)
        {
            try
            {
                a = ctx.TypeI.Add(a);
                ctx.SaveChanges();
                return a;
            }
            catch
            {
                throw;
            }

        }
        #endregion

        #region Types Update
        public ShipTypes Update(ShipTypes a)
        {
            try
            {
                var item = ctx.TypeI.Find(a.Id);
                if (item != null)
                {
                    if (!object.Equals(item, a))
                    {
                        ctx.Entry(item).CurrentValues.SetValues(a);
                        ctx.SaveChanges();
                    }
                    else
                    {
                        ctx.SaveChanges();
                    }
                    return ctx.TypeI.Find(a.Id);
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Types Delete
        public bool Delete(ShipTypes a)
        {
            try
            {
                if (ctx.TypeI.Find(a.Id) != null)
                {
                    ctx.TypeI.Remove(a);
                    return ctx.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Types Retrieval
        public IQueryable<ShipTypes> GetTypesIs()
        {
            return ctx.TypeI.AsQueryable();
        }

        public ShipTypes GetTypesI(int id)
        {
            return ctx.TypeI.Find(id);
        }
        #endregion

        //------------------------------------------

        #region Initable Insert
        public Initable Insert(Initable a)
        {
            try
            {
                a = ctx.IniT.Add(a);
                ctx.SaveChanges();
                return a;
            }
            catch
            {
                throw;
            }

        }
        #endregion

        #region Types Update
        public Initable Update(Initable a)
        {
            try
            {
                var item = ctx.IniT.Find(a.Id);
                if (item != null)
                {
                    if (!object.Equals(item, a))
                    {
                        ctx.Entry(item).CurrentValues.SetValues(a);
                        ctx.SaveChanges();
                    }
                    else
                    {
                        ctx.SaveChanges();
                    }
                    return ctx.IniT.Find(a.Id);
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Types Delete
        public bool Delete(Initable a)
        {
            try
            {
                if (ctx.IniT.Find(a.Id) != null)
                {
                    ctx.IniT.Remove(a);
                    return ctx.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Types Retrieval
        public IQueryable<Initable> GetInitIs()
        {
            return ctx.IniT.AsQueryable();
        }

        public Initable GetInitIs(int id)
        {
            return ctx.IniT.Find(id);
        }
        #endregion
    }
}