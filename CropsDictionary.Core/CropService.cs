using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CropsDictonary.Core
{
    public class CropService : ICropService
    {
        private readonly ApplicationContext db;

        public CropService()
        {
            db = new ApplicationContext(); 
            db.Database.EnsureCreated();
            db.Crops.Load();
        }

        public BindingList<Crop> GetBindingList()
        {
            return db.Crops.Local.ToBindingList();
        }

        public void Add(string name, decimal price, decimal quantity)
        {
            var crop = new Crop
            {
                Name = name,
                Price = price,
                Quantity = quantity
            };

            db.Crops.Add(crop);
            db.SaveChanges();
        }

        public void Edit(Crop crop)
        {
            db.SaveChanges();
        }

        public void Delete(Crop crop)
        {
            db.Crops.Remove(crop);
            db.SaveChanges();
        }

        public void Dispose() 
        { 
            db.Dispose(); 
        }
    }
}
