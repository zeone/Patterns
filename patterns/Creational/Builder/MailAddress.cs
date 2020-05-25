using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Creational.Builder
{
   public class MailAddress
   {
       public MailAddress(string address, string name)
       {
           Address = address;
           Name = name;
       }

       public string Address { get; }

       public string Name { get; }
   }
}
