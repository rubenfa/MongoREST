using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDBAPI.Models
{
    public class Address
    {
        public string primary {get;set;}
        public string secondary {get;set;}
    }

    public class Friend
    {
        public int id {get;set;}
        public string name {get;set;}
    }

    public class People
    {
        public string _id {get;set;}
        public bool isActive {get;set;}
        public string balance {get;set;}
        public string picture {get;set;}
        public int age {get;set;}
        public string name {get;set;}
        public string gender {get;set;}
        public string email {get;set;}
        public string phone {get;set;}
        public Address address {get;set;}
        public string about {get;set;}
        public DateTime registered {get;set;}
        public float latitude {get;set;}
        public float longitude {get;set;}
        public string[] tags {get;set;}
        public Friend[] friends {get;set;}
        public string randomArrayItem {get;set;} 



    }
}
