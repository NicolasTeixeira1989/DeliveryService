using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DeliveryService.Models
{
    public class Product
    {
        #region Properties

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        #endregion
    }
}