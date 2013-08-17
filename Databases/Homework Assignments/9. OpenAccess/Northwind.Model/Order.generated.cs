#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using NorthwindFramework;
using Northwind.Model;


namespace Northwind.Model	
{
	[Table("Orders")]
	[ConcurrencyControl(OptimisticConcurrencyControlStrategy.Changed)]
	[KeyGenerator(KeyGenerator.Autoinc)]
	[Serializable()]
	public partial class Order : NotificationObject
	{
		private int _orderID;
		[Column("OrderID", OpenAccessType = OpenAccessType.Int32, IsBackendCalculated = true, IsPrimaryKey = true, Length = 0, Scale = 0, SqlType = "int")]
		[Storage("_orderID")]
		public virtual int OrderID 
		{ 
		    get
		    {
		        return this._orderID;
		    }
		    set
		    {
				if (this.OrderID == value)
				{
					return;
				}
		        this._orderID = value;
				this.RaisePropertyChanged("OrderID");
		    }
		}
		
		private string _customerID;
		[Column("CustomerID", OpenAccessType = OpenAccessType.UnicodeStringFixedLength, IsNullable = true, Length = 5, Scale = 0, SqlType = "nchar")]
		[Storage("_customerID")]
		public virtual string CustomerID 
		{ 
		    get
		    {
		        return this._customerID;
		    }
		    set
		    {
				if (this.CustomerID == value)
				{
					return;
				}
		        this._customerID = value;
				this.RaisePropertyChanged("CustomerID");
		    }
		}
		
		private int? _employeeID;
		[Column("EmployeeID", OpenAccessType = OpenAccessType.Int32, IsNullable = true, Length = 0, Scale = 0, SqlType = "int")]
		[Storage("_employeeID")]
		public virtual int? EmployeeID 
		{ 
		    get
		    {
		        return this._employeeID;
		    }
		    set
		    {
				if (this.EmployeeID == value)
				{
					return;
				}
		        this._employeeID = value;
				this.RaisePropertyChanged("EmployeeID");
		    }
		}
		
		private DateTime? _orderDate;
		[Column("OrderDate", OpenAccessType = OpenAccessType.DateTime, IsNullable = true, Length = 0, Scale = 0, SqlType = "datetime")]
		[Storage("_orderDate")]
		public virtual DateTime? OrderDate 
		{ 
		    get
		    {
		        return this._orderDate;
		    }
		    set
		    {
				if (this.OrderDate == value)
				{
					return;
				}
		        this._orderDate = value;
				this.RaisePropertyChanged("OrderDate");
		    }
		}
		
		private DateTime? _requiredDate;
		[Column("RequiredDate", OpenAccessType = OpenAccessType.DateTime, IsNullable = true, Length = 0, Scale = 0, SqlType = "datetime")]
		[Storage("_requiredDate")]
		public virtual DateTime? RequiredDate 
		{ 
		    get
		    {
		        return this._requiredDate;
		    }
		    set
		    {
				if (this.RequiredDate == value)
				{
					return;
				}
		        this._requiredDate = value;
				this.RaisePropertyChanged("RequiredDate");
		    }
		}
		
		private DateTime? _shippedDate;
		[Column("ShippedDate", OpenAccessType = OpenAccessType.DateTime, IsNullable = true, Length = 0, Scale = 0, SqlType = "datetime")]
		[Storage("_shippedDate")]
		public virtual DateTime? ShippedDate 
		{ 
		    get
		    {
		        return this._shippedDate;
		    }
		    set
		    {
				if (this.ShippedDate == value)
				{
					return;
				}
		        this._shippedDate = value;
				this.RaisePropertyChanged("ShippedDate");
		    }
		}
		
		private int? _shipVia;
		[Column("ShipVia", OpenAccessType = OpenAccessType.Int32, IsNullable = true, Length = 0, Scale = 0, SqlType = "int")]
		[Storage("_shipVia")]
		public virtual int? ShipVia 
		{ 
		    get
		    {
		        return this._shipVia;
		    }
		    set
		    {
				if (this.ShipVia == value)
				{
					return;
				}
		        this._shipVia = value;
				this.RaisePropertyChanged("ShipVia");
		    }
		}
		
		private decimal? _freight;
		[Column("Freight", OpenAccessType = OpenAccessType.Currency, IsNullable = true, Length = 0, Scale = 0, SqlType = "money")]
		[Storage("_freight")]
		public virtual decimal? Freight 
		{ 
		    get
		    {
		        return this._freight;
		    }
		    set
		    {
				if (this.Freight == value)
				{
					return;
				}
		        this._freight = value;
				this.RaisePropertyChanged("Freight");
		    }
		}
		
		private string _shipName;
		[Column("ShipName", OpenAccessType = OpenAccessType.UnicodeStringVariableLength, IsNullable = true, Length = 40, Scale = 0, SqlType = "nvarchar")]
		[Storage("_shipName")]
		public virtual string ShipName 
		{ 
		    get
		    {
		        return this._shipName;
		    }
		    set
		    {
				if (this.ShipName == value)
				{
					return;
				}
		        this._shipName = value;
				this.RaisePropertyChanged("ShipName");
		    }
		}
		
		private string _shipAddress;
		[Column("ShipAddress", OpenAccessType = OpenAccessType.UnicodeStringVariableLength, IsNullable = true, Length = 60, Scale = 0, SqlType = "nvarchar")]
		[Storage("_shipAddress")]
		public virtual string ShipAddress 
		{ 
		    get
		    {
		        return this._shipAddress;
		    }
		    set
		    {
				if (this.ShipAddress == value)
				{
					return;
				}
		        this._shipAddress = value;
				this.RaisePropertyChanged("ShipAddress");
		    }
		}
		
		private string _shipCity;
		[Column("ShipCity", OpenAccessType = OpenAccessType.UnicodeStringVariableLength, IsNullable = true, Length = 15, Scale = 0, SqlType = "nvarchar")]
		[Storage("_shipCity")]
		public virtual string ShipCity 
		{ 
		    get
		    {
		        return this._shipCity;
		    }
		    set
		    {
				if (this.ShipCity == value)
				{
					return;
				}
		        this._shipCity = value;
				this.RaisePropertyChanged("ShipCity");
		    }
		}
		
		private string _shipRegion;
		[Column("ShipRegion", OpenAccessType = OpenAccessType.UnicodeStringVariableLength, IsNullable = true, Length = 15, Scale = 0, SqlType = "nvarchar")]
		[Storage("_shipRegion")]
		public virtual string ShipRegion 
		{ 
		    get
		    {
		        return this._shipRegion;
		    }
		    set
		    {
				if (this.ShipRegion == value)
				{
					return;
				}
		        this._shipRegion = value;
				this.RaisePropertyChanged("ShipRegion");
		    }
		}
		
		private string _shipPostalCode;
		[Column("ShipPostalCode", OpenAccessType = OpenAccessType.UnicodeStringVariableLength, IsNullable = true, Length = 10, Scale = 0, SqlType = "nvarchar")]
		[Storage("_shipPostalCode")]
		public virtual string ShipPostalCode 
		{ 
		    get
		    {
		        return this._shipPostalCode;
		    }
		    set
		    {
				if (this.ShipPostalCode == value)
				{
					return;
				}
		        this._shipPostalCode = value;
				this.RaisePropertyChanged("ShipPostalCode");
		    }
		}
		
		private string _shipCountry;
		[Column("ShipCountry", OpenAccessType = OpenAccessType.UnicodeStringVariableLength, IsNullable = true, Length = 15, Scale = 0, SqlType = "nvarchar")]
		[Storage("_shipCountry")]
		public virtual string ShipCountry 
		{ 
		    get
		    {
		        return this._shipCountry;
		    }
		    set
		    {
				if (this.ShipCountry == value)
				{
					return;
				}
		        this._shipCountry = value;
				this.RaisePropertyChanged("ShipCountry");
		    }
		}
		
		private Customer _customer;
		[ForeignKeyAssociation(ConstraintName = "FK_Orders_Customers", SharedFields = "CustomerID", TargetFields = "CustomerID")]
		[Storage("_customer")]
		public virtual Customer Customer 
		{ 
		    get
		    {
		        return this._customer;
		    }
		    set
		    {
				if (this.Customer == value)
				{
					return;
				}
		        this._customer = value;
				this.RaisePropertyChanged("Customer");
		    }
		}
		
		private Employee _employee;
		[ForeignKeyAssociation(ConstraintName = "FK_Orders_Employees", SharedFields = "EmployeeID", TargetFields = "EmployeeID")]
		[Storage("_employee")]
		public virtual Employee Employee 
		{ 
		    get
		    {
		        return this._employee;
		    }
		    set
		    {
				if (this.Employee == value)
				{
					return;
				}
		        this._employee = value;
				this.RaisePropertyChanged("Employee");
		    }
		}
		
		private Shipper _shipper;
		[ForeignKeyAssociation(ConstraintName = "FK_Orders_Shippers", SharedFields = "ShipVia", TargetFields = "ShipperID")]
		[Storage("_shipper")]
		public virtual Shipper Shipper 
		{ 
		    get
		    {
		        return this._shipper;
		    }
		    set
		    {
				if (this.Shipper == value)
				{
					return;
				}
		        this._shipper = value;
				this.RaisePropertyChanged("Shipper");
		    }
		}
		
		private IList<OrderDetail> _orderDetails = new List<OrderDetail>();
		[Collection(InverseProperty = "Order")]
		[Storage("_orderDetails")]
		public virtual IList<OrderDetail> OrderDetails 
		{ 
		    get
		    {
		        return this._orderDetails;
		    }
		}
		
	}
}