﻿using LoginApiClientV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalendarApplication.Models
{
    public class UserHomePageModel
    {
        public int? LoginId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<BookingDetailsDTO> BookingDetails { get; set; }

    }
}