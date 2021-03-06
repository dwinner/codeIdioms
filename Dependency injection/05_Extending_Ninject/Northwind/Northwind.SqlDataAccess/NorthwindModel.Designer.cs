//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Northwind.SqlDataAccess
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class NorthwindEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new NorthwindEntities object using the connection string found in the 'NorthwindEntities' section of the application configuration file.
        /// </summary>
        public NorthwindEntities() : base("name=NorthwindEntities", "NorthwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NorthwindEntities object.
        /// </summary>
        public NorthwindEntities(string connectionString) : base(connectionString, "NorthwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NorthwindEntities object.
        /// </summary>
        public NorthwindEntities(EntityConnection connection) : base(connection, "NorthwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Customer> Customers
        {
            get
            {
                if ((_Customers == null))
                {
                    _Customers = base.CreateObjectSet<Customer>("Customers");
                }
                return _Customers;
            }
        }
        private ObjectSet<Customer> _Customers;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Customers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCustomers(Customer customer)
        {
            base.AddObject("Customers", customer);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NorthwindModel", Name="Customer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Customer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="customer_ID">Initial value of the Customer_ID property.</param>
        /// <param name="company_Name">Initial value of the Company_Name property.</param>
        public static Customer CreateCustomer(global::System.String customer_ID, global::System.String company_Name)
        {
            Customer customer = new Customer();
            customer.Customer_ID = customer_ID;
            customer.Company_Name = company_Name;
            return customer;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Customer_ID
        {
            get
            {
                return _Customer_ID;
            }
            set
            {
                if (_Customer_ID != value)
                {
                    OnCustomer_IDChanging(value);
                    ReportPropertyChanging("Customer_ID");
                    _Customer_ID = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Customer_ID");
                    OnCustomer_IDChanged();
                }
            }
        }
        private global::System.String _Customer_ID;
        partial void OnCustomer_IDChanging(global::System.String value);
        partial void OnCustomer_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Company_Name
        {
            get
            {
                return _Company_Name;
            }
            set
            {
                OnCompany_NameChanging(value);
                ReportPropertyChanging("Company_Name");
                _Company_Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Company_Name");
                OnCompany_NameChanged();
            }
        }
        private global::System.String _Company_Name;
        partial void OnCompany_NameChanging(global::System.String value);
        partial void OnCompany_NameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Postal_Code
        {
            get
            {
                return _Postal_Code;
            }
            set
            {
                OnPostal_CodeChanging(value);
                ReportPropertyChanging("Postal_Code");
                _Postal_Code = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Postal_Code");
                OnPostal_CodeChanged();
            }
        }
        private global::System.String _Postal_Code;
        partial void OnPostal_CodeChanging(global::System.String value);
        partial void OnPostal_CodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                OnPhoneChanging(value);
                ReportPropertyChanging("Phone");
                _Phone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Phone");
                OnPhoneChanged();
            }
        }
        private global::System.String _Phone;
        partial void OnPhoneChanging(global::System.String value);
        partial void OnPhoneChanged();

        #endregion

    
    }

    #endregion

    
}
