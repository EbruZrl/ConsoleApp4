using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Customer = InterfaceAbstractDemo.Entities.Customer;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;
        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer) //overrideı tekrar savei kullanabilmek için kullandık. Bu şekilde if else kullanabildik.
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
               
            }

            else 
            {
                throw new Exception("Not a valid person");
            }
            
             //veri tabanına kaydeden kod
        }

  
    }

    //ikisinde de aynı görev olduğu için inheritans yapmak yeriine abstract kısmına gelip bir class 
    //ekliyor bu da base classı.  
}   //Bunu bir gün nero da isterse ne yapıcaz? Bu durumda interfacelerin ability operasyon sınıflandırılması durumu devreye giriyot.
    