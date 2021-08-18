using Data.Database;
using DataAccess.UnitofWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCFson2.Dto;
using WCFson2.Interfaces;

namespace WCFson2.Services
{
    public class BuyService : IBuyService
    {
        public void AddBuyService(BuyDto buyhistory)
        {
            try
            {
                using (UnitofWork<bnetEntities> uow = new UnitofWork<bnetEntities>(new bnetEntities()))
                {
                    buyhistory buyhistory1 = new buyhistory();
                    buyhistory1.Count = buyhistory.Count;
                    buyhistory1.Price = buyhistory.Price;
                    buyhistory1.ProductName = buyhistory.ProductName;
                    uow.Repository<buyhistory>().Add(buyhistory1);
                    uow.Save();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }

        }
        public void DelBuyService(BuyDto delbuyService)
        {
            try
            {
                using (UnitofWork<bnetEntities> uow = new UnitofWork<bnetEntities>(new bnetEntities()))
                {
                    buyhistory buyhistory2 = new buyhistory();
                    buyhistory2.Count = delbuyService.Count;
                    buyhistory2.Price = delbuyService.Price;
                    buyhistory2.ProductName = delbuyService.ProductName;
                    uow.Repository<buyhistory>().Delete(buyhistory2);
                    uow.Save();
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public void GetBuyService(BuyDto GetbuyService)
        {
            try
            {
                using (UnitofWork<bnetEntities> uow = new UnitofWork<bnetEntities>(new bnetEntities()))
                {
                    buyhistory buyhistory2 = new buyhistory();
                    buyhistory2.ProductId = GetbuyService.ProductId;
                    buyhistory2.CustomerId = GetbuyService.CustomerId;
                    buyhistory2.BHid = GetbuyService.BHid;
                    uow.Repository<buyhistory>().GetType();
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public void UpBuyService(BuyDto upbuyService)
        {
            try
            {
                using(UnitofWork<bnetEntities> uow = new UnitofWork<bnetEntities>(new bnetEntities()))
                     {
                    buyhistory buyhistory3 = new buyhistory();
                    buyhistory3.Count = upbuyService.Count;
                    buyhistory3.Price = upbuyService.Price;
                    buyhistory3.ProductName = upbuyService.ProductName;
                    uow.Repository<buyhistory>().Update(buyhistory3);
                    uow.Save();
                }
            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}