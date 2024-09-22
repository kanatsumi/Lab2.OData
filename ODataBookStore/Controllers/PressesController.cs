using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ODataBookStore.Models;

namespace ODataBookStore.Controllers
{
    public class PressesController : ODataController
    {
        private BookStoreContext _dbContext;
        public PressesController(BookStoreContext dbContext)
        {
            _dbContext = dbContext;
            if(dbContext.Books == null)
            {
                foreach (var item in DataSource.GetBooks())
                {
                    dbContext.Add(item);
                    dbContext.Presses.Add(item.Press);
                }
                dbContext.SaveChanges();
            }
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_dbContext.Presses);
        }
    }
}
