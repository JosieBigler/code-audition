using System;
using System.Runtime.Serialization;

namespace Ilm.CodeAudition.Service.Models
{
    [DataContract]
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}