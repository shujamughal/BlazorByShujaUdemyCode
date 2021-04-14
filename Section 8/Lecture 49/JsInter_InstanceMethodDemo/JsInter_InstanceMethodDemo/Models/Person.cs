using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsInter_InstanceMethodDemo.Models
{
    public class Person
    {
        public string Name { get; set; }

        [JSInvokable]
        public string SayHello(string data)
        {
            return $"Hello , {Name} and data {data}";
        }
    }
}
