using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeliveryService.Models
{
    public class ShippingRoute
    {
        #region Properties

        public int Id { get; set; }
        public List<StateZone> Zones { get; set; }


        #endregion
    }
}