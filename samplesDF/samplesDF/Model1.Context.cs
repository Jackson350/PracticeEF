﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AdventureWorks2012Entities : DbContext
    {
        public AdventureWorks2012Entities()
            : base("name=AdventureWorks2012Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CountryRegionCurrency> CountryRegionCurrency { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<CurrencyRate> CurrencyRate { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<PersonCreditCard> PersonCreditCard { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
        public DbSet<SalesOrderHeader> SalesOrderHeader { get; set; }
        public DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; }
        public DbSet<SalesPerson> SalesPerson { get; set; }
        public DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; }
        public DbSet<SalesReason> SalesReason { get; set; }
        public DbSet<SalesTaxRate> SalesTaxRate { get; set; }
        public DbSet<SalesTerritory> SalesTerritory { get; set; }
        public DbSet<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public DbSet<SpecialOffer> SpecialOffer { get; set; }
        public DbSet<SpecialOfferProduct> SpecialOfferProduct { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        public DbSet<EmployeePayHistory> EmployeePayHistory { get; set; }
        public DbSet<JobCandidate> JobCandidate { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<AddressType> AddressType { get; set; }
        public DbSet<BusinessEntity> BusinessEntity { get; set; }
        public DbSet<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public DbSet<BusinessEntityContact> BusinessEntityContact { get; set; }
        public DbSet<ContactType> ContactType { get; set; }
        public DbSet<CountryRegion> CountryRegion { get; set; }
        public DbSet<EmailAddress> EmailAddress { get; set; }
        public DbSet<Password> Password { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonPhone> PersonPhone { get; set; }
        public DbSet<PhoneNumberType> PhoneNumberType { get; set; }
        public DbSet<StateProvince> StateProvince { get; set; }
    }
}
