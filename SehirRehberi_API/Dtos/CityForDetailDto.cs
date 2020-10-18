﻿using SehirRehberi_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi_API.Dtos
{
    public class CityForDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Photo> Photos { get; set; }
    }
}
