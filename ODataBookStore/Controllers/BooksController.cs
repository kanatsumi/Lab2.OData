﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using ODataBookStore.Models;

namespace ODataBookStore.Controllers
{
    public class BooksController : ODataController
    {
        private BookStoreContext _dbContext;
        public BooksController(BookStoreContext dbContext) 
        {
            _dbContext = dbContext;
            _dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            if(dbContext.Books.Count() == 0)
            {
                foreach (var item in DataSource.GetBooks())
                {
                    dbContext.Books.Add(item);
                    dbContext.Presses.Add(item.Press);
                }
                dbContext.SaveChanges();
            }
        }

        [EnableQuery(PageSize = 10)]
        public IActionResult Get() 
        {
            return Ok(_dbContext.Books);
        }

        [EnableQuery]
        public IActionResult Get(int key, string version) 
        {
            return Ok(_dbContext.Books.FirstOrDefault(c => c.Id == key));
        }

        [EnableQuery]
        public IActionResult Post([FromBody] Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
            return Created(book);
        }

        [EnableQuery]
        public IActionResult Delete([FromBody] int key) 
        {
            Book book = _dbContext.Books.FirstOrDefault(p => p.Id == key);
            if(book == null)
            {
                return NotFound();
            }

            _dbContext.Remove(book);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
