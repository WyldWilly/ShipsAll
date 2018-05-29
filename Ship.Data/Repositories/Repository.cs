﻿using System;
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

        #region Insert

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


        #region Update
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

        #region Delete
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

        #region Retrieval
        public IQueryable<ShipIndex> GetShipIs()
        {
            return ctx.ShipI.AsQueryable();
        }

        public ShipIndex GetShipI(int id)
        {
            return ctx.ShipI.Find(id);
        }
    }
}