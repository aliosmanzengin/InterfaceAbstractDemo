using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.MernisServiceReference;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerkService
    {
        void Save(Customer customer);
    }
}
