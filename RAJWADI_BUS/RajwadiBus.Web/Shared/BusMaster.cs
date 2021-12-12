using System;
using System.Collections.Generic;
using System.Text;

namespace RajwadiBus.Web.Shared
{
    public class BusMaster
    {
        public int Id { get; set; }
        public string BusName { get; set; }
        public string BusNumber { get; set; }
        public string RouteFrom { get; set; }
        public string RouteTo { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public decimal Fare { get; set; }
    }
}