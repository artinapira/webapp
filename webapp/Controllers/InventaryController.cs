using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapp.Services;
using webapp.ViewModels;

namespace webapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventaryController : ControllerBase
    {
        public InventaryService _inventoryService;

        public InventaryController(InventaryService inventoryService)
        {
            _inventoryService = inventoryService;
        }
    
        [HttpPost("add-inventory")]
        public IActionResult AddInventory([FromBody] InventaryVM inventory)
        {

            _inventoryService.AddInventory(inventory);
             return Ok();
        }
        [HttpGet("get-all-inventory")]
       public IActionResult GetAllInventory()
       {
            
            var allInventory = _inventoryService.GetAllInventory();
            return Ok(allInventory);
       }
       [HttpGet("get-inventory-by-id/{id}")]
        public IActionResult GetInventoryById(int id)
        {
            var inventory = _inventoryService.GetInventoryById(id);
            return Ok(inventory);
        }
        [HttpPut("update-inventory-by-id/{id}")]
        public IActionResult UpdateInventoryById(int id, [FromBody] InventaryVM inventory)
        {
            var updatedInventory = _inventoryService.UpdateInventoryById(id, inventory);
            return Ok(updatedInventory);
        }
        [HttpDelete("delete-inventory-by-id/{id}")]
        public IActionResult DeleteInventoryById(int id)
        {
            _inventoryService.DeleteInventoryById(id);
            return Ok();
        }
    }
}
