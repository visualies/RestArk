﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseService.Core;
using BaseService.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BaseService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        private readonly IUnitOfWork context;

        public ExampleController(IUnitOfWork unitOfWork)
        {
            this.context = unitOfWork;
        }

        [HttpGet("{id}")]
        public Example Get(int id)
        {
            var example = context.ExampleRepository.Find(id.ToString());

            Console.WriteLine(example.Name);

            return example;
        }
    }
}
