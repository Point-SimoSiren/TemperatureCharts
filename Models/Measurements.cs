//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TempCharts.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Measurements
    {
        public int MeasurementID { get; set; }
        public string Sender { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public Nullable<double> Temperature { get; set; }
        public Nullable<double> Humidity { get; set; }
        public Nullable<double> Pressure { get; set; }
    }
}
