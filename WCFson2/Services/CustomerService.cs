using Data.Database;
using DataAccess.UnitofWork;
using System;
using WCFson2.Dto;
using WCFson2.Interfaces;

namespace WCFson2.Services
{
    public class CustomerService : ICustomerService
        {
            //try cacth blokları kullanılarak hata mesajları mesaj ve status code ile geri dönüşler sağla.
            public void AddCustomerService(CustomerDto customer)
            {
                try
                {

                    using (UnitofWork<bnetEntities> uow = new UnitofWork<bnetEntities>(new bnetEntities()))
                    {
                    customer customer1 = new customer();
                    customer1.Mail = customer.Mail;
                    customer1.Password = customer.Password;
                    customer1.UserName = customer.UserName;
                    uow.Repository<customer>().Add(customer1);
                    uow.Save();                      
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message, ex.StackTrace);//ex.message hatanın ne olduğunu geri bildirim olarak gösterir.
                }
            }
            public void DelCustomerService(CustomerDto deleteCustomerService)
            {
                try
                {
                using (UnitofWork<bnetEntities> uow = new UnitofWork<bnetEntities>(new bnetEntities()))
                {
                    customer customer1 = new customer();
                    customer1.Mail = deleteCustomerService.Mail;
                    customer1.Password = deleteCustomerService.Password;
                    customer1.UserName = deleteCustomerService.UserName;
                    uow.Repository<customer>().Delete(customer1);
                    uow.Save();
                }

                }
                catch (Exception ex)
                {
                Console.WriteLine(ex.Message, ex.StackTrace);//ex.message hatanın ne olduğunu geri bildirim olarak gösterir.

            }
        }
            //attribute'u sadece get e yazcaksın eğer attribute den geçerse bütün customerlar gelcek
            public void GetCustomerService(int getcustomerService)
            {            
                throw new NotImplementedException();
            }

            public void UpCustomerService(CustomerDto updateCutomerService)
            {
                try
                {

                using (UnitofWork<bnetEntities> uow = new UnitofWork<bnetEntities>(new bnetEntities()))
                {
                    customer customer2 = new customer();
                    customer2.Mail = updateCutomerService.Mail;
                    customer2.Password = updateCutomerService.Password;
                    customer2.UserName = updateCutomerService.UserName;
                    uow.Repository<customer>().Update(customer2);
                    uow.Save();

                }
            }
                catch (Exception ex)
                {
                    Console.WriteLine("error");
                    Console.WriteLine(ex.Message);//hatanın ne olduğunu geri bildirim atar
                    throw;
                }
            }
        }
}
