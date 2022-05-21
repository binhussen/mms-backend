﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DataModel.Models.DTOs.Requests
{
    public class RequestHeaderForManipulationDto
    {
        public string requestStatus { get; set; }
        public string description { get; set; }
        public string attachments { get; set; }
    }
}
