using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DianShangAPI.WModel
{
    public class UserEnter
    {
        public Guid ClienteleRegisterId { get; set; }
        public string ClienteleRegister { get; set; }
        public string ClientelePassword { get; set; }
      public Guid  ClienteleId       {get;set;}  
      public string  ClienteleName     {get;set;}
      public string  ClienteleNickName {get;set;}
      public string  ClientelePhone    {get;set;}
      public string  ClientelePicture  {get;set;}
      public Guid UserEnterId { get; set; }

    }
}
