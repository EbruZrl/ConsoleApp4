using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        
        void Save(Customer customer); //iki firma da kaydetmek istiyor
    }

    //ikisinde de varsa bu şekilde soyutlamalısın.interface implemasyonu yapan herkes implemente edinmek zorunda.
}
