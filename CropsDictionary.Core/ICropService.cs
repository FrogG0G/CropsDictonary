using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CropsDictonary.Core
{
    public interface ICropService : IDisposable
    {
        BindingList<Crop> GetBindingList();
        void Add(string name, decimal price, decimal quantity);
        void Edit(Crop crop);
        void Delete(Crop crop);
    }
}
