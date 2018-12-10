using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventPlanner.Mvc.Models
{
    public class EventPlanner
    {
        public bool IncludePublic { get; set; }

        public bool IncludePrivate { get; set; }

        public DateTime? BeginDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}