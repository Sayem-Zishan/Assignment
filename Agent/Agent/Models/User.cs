using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agent.Models
{
    public class User
    {
        public int ID { set; get; }
        public int Code { set; get; }

        public string Name { set; get; }
        public string Markup { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Mobile { set; get; }
        public string Address { set; get; }
        public string City { set; get; }
        public string State { set; get; }
        public string PostalCode { set; get; }
        public string FlightAPIs { set; get; }
        public string AgentType { set; get; }
        public string Status { set; get; }
        public DateTime? Created { get; set; }




    }
}

