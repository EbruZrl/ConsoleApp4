using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer {
                DateOfBirth = new System.DateTime(2000,7,14), FirstName= "Ebru",
            LastName = "Zorlu", NationalityId ="30332280900"}); 


        }

    }
}

//Mernis için interface ve abstract(nero problemi) yazamayız
