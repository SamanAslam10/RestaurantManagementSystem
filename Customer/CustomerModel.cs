using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Customer
{
    internal class CustomerModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string contact {  get; set; }
        public string CNIC {  get; set; }
        public string email {  get; set; }

        public CustomerModel() { }
        public CustomerModel(int id,string name, string contact, string CNIC, string email)
        {
            this.Id = id;
            this.name = name;
            this.contact = contact;
            this.CNIC = CNIC;
            this.email = email;
        }
        public override string ToString()
        {
            return $"ID : {Id} ,Name : {name}, Contact : {contact}, CNIC : {CNIC}, Email : {email}";
        }
    }
}