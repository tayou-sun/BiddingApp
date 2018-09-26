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
                // ������� ��� ������� User
                var bidding = new Bidding {Message = "Tom", Id = 33};

                // ��������� �� � ��
                _databaseController.Bidding.Create(bidding);

                // �������� ������� �� �� � ������� �� �������
                var users = _databaseController.Bidding.GetAll().ToList();
                Console.WriteLine("������ ��������:");
            }
        }
    }
    }
