//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace samplesDF
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesTerritory
    {
        public SalesTerritory()
        {
            this.Customer = new HashSet<Customer>();
            this.SalesOrderHeader = new HashSet<SalesOrderHeader>();
            this.SalesPerson = new HashSet<SalesPerson>();
            this.SalesTerritoryHistory = new HashSet<SalesTerritoryHistory>();
            this.StateProvince = new HashSet<StateProvince>();
        }
    
        public int TerritoryID { get; set; }
        public string Name { get; set; }
        public string CountryRegionCode { get; set; }
        public string Group { get; set; }
        public decimal SalesYTD { get; set; }
        public decimal SalesLastYear { get; set; }
        public decimal CostYTD { get; set; }
        public decimal CostLastYear { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
        public virtual ICollection<SalesPerson> SalesPerson { get; set; }
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
        public virtual CountryRegion CountryRegion { get; set; }
        public virtual ICollection<StateProvince> StateProvince { get; set; }
    }
}
