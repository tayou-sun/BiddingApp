using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BiddingApp.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace BiddingApp.Controllers
{
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        private readonly DatabaseController _databaseController;

        public MessageController()
        {
            _databaseController = new DatabaseController();
        }

        [HttpGet("get")]
        public void get()
        {
            {
                // создаем два объекта User
                var bidding = new Bidding {Message = "Tom", Id = 33};

                // добавляем их в бд
                _databaseController.Bidding.Create(bidding);

                // получаем объекты из бд и выводим на консоль
                var users = _databaseController.Bidding.GetAll().ToList();
                Console.WriteLine("Список объектов:");
            }
        }
    }
    }
