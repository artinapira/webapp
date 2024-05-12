using webapp.Models;
using webapp.ViewModels;

namespace webapp.Services
{
    public class InventaryService
    {
        private ClinicDbContext _context;

        public InventaryService(ClinicDbContext context)
        {
            _context = context;
        }
        public void AddInventory(InventaryVM inventory)
        {
            var _inventory = new Inventory()
            {
                Emri = inventory.Emri,
            };
            _context.Inventories.Add(_inventory);
            _context.SaveChanges();
        }
        public List<Inventory> GetAllInventory()
        {
            var allinventories = _context.Inventories.ToList();
            return allinventories;
        }
        public Inventory GetInventoryById(int itemId) => _context.Inventories.FirstOrDefault(n => n.ItemId == itemId);

        public Inventory UpdateInventoryById(int itemId, InventaryVM inventory)
        {
            var _inventory = _context.Inventories.FirstOrDefault(n => n.ItemId == itemId);
            if (_inventory != null)
            {
               
                _inventory.Emri = inventory.Emri;
               

                _context.SaveChanges();
            }
            return _inventory;
        }
        public void DeleteInventoryById(int itemId)
        {
            var _inventory = _context.Inventories.FirstOrDefault(n => n.ItemId == itemId);
            if (_inventory != null)
            {
                _context.Inventories.Remove(_inventory);
                _context.SaveChanges();
            }
        }
    }
}

