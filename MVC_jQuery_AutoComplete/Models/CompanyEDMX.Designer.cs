﻿//------------------------------------------------------------------------------
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
namespace MVC_jQuery_AutoComplete.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CompanyEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CompanyEntities object using the connection string found in the 'CompanyEntities' section of the application configuration file.
        /// </summary>
        public CompanyEntities() : base("name=CompanyEntities", "CompanyEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CompanyEntities object.
        /// </summary>
        public CompanyEntities(string connectionString) : base(connectionString, "CompanyEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CompanyEntities object.
        /// </summary>
        public CompanyEntities(EntityConnection connection) : base(connection, "CompanyEntities")
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
        public ObjectSet<EmployeeInfo> EmployeeInfoes
        {
            get
            {
                if ((_EmployeeInfoes == null))
                {
                    _EmployeeInfoes = base.CreateObjectSet<EmployeeInfo>("EmployeeInfoes");
                }
                return _EmployeeInfoes;
            }
        }
        private ObjectSet<EmployeeInfo> _EmployeeInfoes;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the EmployeeInfoes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployeeInfoes(EmployeeInfo employeeInfo)
        {
            base.AddObject("EmployeeInfoes", employeeInfo);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CompanyModel", Name="EmployeeInfo")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EmployeeInfo : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EmployeeInfo object.
        /// </summary>
        /// <param name="empNo">Initial value of the EmpNo property.</param>
        /// <param name="empName">Initial value of the EmpName property.</param>
        /// <param name="salary">Initial value of the Salary property.</param>
        /// <param name="deptName">Initial value of the DeptName property.</param>
        /// <param name="designation">Initial value of the Designation property.</param>
        public static EmployeeInfo CreateEmployeeInfo(global::System.Int32 empNo, global::System.String empName, global::System.Decimal salary, global::System.String deptName, global::System.String designation)
        {
            EmployeeInfo employeeInfo = new EmployeeInfo();
            employeeInfo.EmpNo = empNo;
            employeeInfo.EmpName = empName;
            employeeInfo.Salary = salary;
            employeeInfo.DeptName = deptName;
            employeeInfo.Designation = designation;
            return employeeInfo;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmpNo
        {
            get
            {
                return _EmpNo;
            }
            set
            {
                if (_EmpNo != value)
                {
                    OnEmpNoChanging(value);
                    ReportPropertyChanging("EmpNo");
                    _EmpNo = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EmpNo");
                    OnEmpNoChanged();
                }
            }
        }
        private global::System.Int32 _EmpNo;
        partial void OnEmpNoChanging(global::System.Int32 value);
        partial void OnEmpNoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String EmpName
        {
            get
            {
                return _EmpName;
            }
            set
            {
                OnEmpNameChanging(value);
                ReportPropertyChanging("EmpName");
                _EmpName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("EmpName");
                OnEmpNameChanged();
            }
        }
        private global::System.String _EmpName;
        partial void OnEmpNameChanging(global::System.String value);
        partial void OnEmpNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Salary
        {
            get
            {
                return _Salary;
            }
            set
            {
                OnSalaryChanging(value);
                ReportPropertyChanging("Salary");
                _Salary = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Salary");
                OnSalaryChanged();
            }
        }
        private global::System.Decimal _Salary;
        partial void OnSalaryChanging(global::System.Decimal value);
        partial void OnSalaryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DeptName
        {
            get
            {
                return _DeptName;
            }
            set
            {
                OnDeptNameChanging(value);
                ReportPropertyChanging("DeptName");
                _DeptName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("DeptName");
                OnDeptNameChanged();
            }
        }
        private global::System.String _DeptName;
        partial void OnDeptNameChanging(global::System.String value);
        partial void OnDeptNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Designation
        {
            get
            {
                return _Designation;
            }
            set
            {
                OnDesignationChanging(value);
                ReportPropertyChanging("Designation");
                _Designation = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Designation");
                OnDesignationChanged();
            }
        }
        private global::System.String _Designation;
        partial void OnDesignationChanging(global::System.String value);
        partial void OnDesignationChanged();

        #endregion

    
    }

    #endregion

    
}