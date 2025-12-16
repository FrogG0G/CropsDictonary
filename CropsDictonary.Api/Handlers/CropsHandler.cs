using CropsDictonary.Api.Models;
using CropsDictonary.Core;

namespace CropsDictonary.Api.Handlers
{
    public class CropsHandler
    {
        private readonly ICropService service;

        public CropsHandler(ICropService service)
        {
            this.service = service;
        }

        public IEnumerable<Crop> GetAll()
        {
            return service.GetBindingList();
        }

        public void Add(CropDto dto)
        {
            service.Add(dto.Name, dto.Price, dto.Quantity);
        }

        public bool Edit(int id, CropDto dto)
        {
            var crop = service.GetBindingList().FirstOrDefault(x => x.Id == id);
            if (crop == null) return false;

            crop.Name = dto.Name;
            crop.Price = dto.Price;
            crop.Quantity = dto.Quantity;

            service.Edit(crop);
            return true;
        }

        public bool Delete(int id)
        {
            var crop = service.GetBindingList().FirstOrDefault(x => x.Id == id);
            if (crop == null) return false; 
            service.Delete(crop);
            return true;
        }
    }
}
