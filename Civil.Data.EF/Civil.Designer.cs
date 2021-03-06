//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace Civil.Data.EF
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class cividatanewEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new cividatanewEntities object using the connection string found in the 'cividatanewEntities' section of the application configuration file.
        /// </summary>
        public cividatanewEntities() : base("name=cividatanewEntities", "cividatanewEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new cividatanewEntities object.
        /// </summary>
        public cividatanewEntities(string connectionString) : base(connectionString, "cividatanewEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new cividatanewEntities object.
        /// </summary>
        public cividatanewEntities(EntityConnection connection) : base(connection, "cividatanewEntities")
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
        public ObjectSet<electricion> electricions
        {
            get
            {
                if ((_electricions == null))
                {
                    _electricions = base.CreateObjectSet<electricion>("electricions");
                }
                return _electricions;
            }
        }
        private ObjectSet<electricion> _electricions;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<employee> employees
        {
            get
            {
                if ((_employees == null))
                {
                    _employees = base.CreateObjectSet<employee>("employees");
                }
                return _employees;
            }
        }
        private ObjectSet<employee> _employees;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<fabricator> fabricators
        {
            get
            {
                if ((_fabricators == null))
                {
                    _fabricators = base.CreateObjectSet<fabricator>("fabricators");
                }
                return _fabricators;
            }
        }
        private ObjectSet<fabricator> _fabricators;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<newsite> newsites
        {
            get
            {
                if ((_newsites == null))
                {
                    _newsites = base.CreateObjectSet<newsite>("newsites");
                }
                return _newsites;
            }
        }
        private ObjectSet<newsite> _newsites;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the electricions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToelectricions(electricion electricion)
        {
            base.AddObject("electricions", electricion);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToemployees(employee employee)
        {
            base.AddObject("employees", employee);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the fabricators EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTofabricators(fabricator fabricator)
        {
            base.AddObject("fabricators", fabricator);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the newsites EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTonewsites(newsite newsite)
        {
            base.AddObject("newsites", newsite);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="cividatanewModel", Name="electricion")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class electricion : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new electricion object.
        /// </summary>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="address">Initial value of the address property.</param>
        /// <param name="mobilenumber">Initial value of the mobilenumber property.</param>
        /// <param name="pointrate">Initial value of the pointrate property.</param>
        public static electricion Createelectricion(global::System.String name, global::System.String address, global::System.Int32 mobilenumber, global::System.Double pointrate)
        {
            electricion electricion = new electricion();
            electricion.name = name;
            electricion.address = address;
            electricion.mobilenumber = mobilenumber;
            electricion.pointrate = pointrate;
            return electricion;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> electricionid
        {
            get
            {
                return _electricionid;
            }
            set
            {
                OnelectricionidChanging(value);
                ReportPropertyChanging("electricionid");
                _electricionid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("electricionid");
                OnelectricionidChanged();
            }
        }
        private Nullable<global::System.Int32> _electricionid;
        partial void OnelectricionidChanging(Nullable<global::System.Int32> value);
        partial void OnelectricionidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    OnnameChanging(value);
                    ReportPropertyChanging("name");
                    _name = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("name");
                    OnnameChanged();
                }
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String address
        {
            get
            {
                return _address;
            }
            set
            {
                if (_address != value)
                {
                    OnaddressChanging(value);
                    ReportPropertyChanging("address");
                    _address = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("address");
                    OnaddressChanged();
                }
            }
        }
        private global::System.String _address;
        partial void OnaddressChanging(global::System.String value);
        partial void OnaddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 mobilenumber
        {
            get
            {
                return _mobilenumber;
            }
            set
            {
                if (_mobilenumber != value)
                {
                    OnmobilenumberChanging(value);
                    ReportPropertyChanging("mobilenumber");
                    _mobilenumber = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("mobilenumber");
                    OnmobilenumberChanged();
                }
            }
        }
        private global::System.Int32 _mobilenumber;
        partial void OnmobilenumberChanging(global::System.Int32 value);
        partial void OnmobilenumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double pointrate
        {
            get
            {
                return _pointrate;
            }
            set
            {
                if (_pointrate != value)
                {
                    OnpointrateChanging(value);
                    ReportPropertyChanging("pointrate");
                    _pointrate = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("pointrate");
                    OnpointrateChanged();
                }
            }
        }
        private global::System.Double _pointrate;
        partial void OnpointrateChanging(global::System.Double value);
        partial void OnpointrateChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="cividatanewModel", Name="employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new employee object.
        /// </summary>
        /// <param name="employeeid">Initial value of the employeeid property.</param>
        /// <param name="firstname">Initial value of the firstname property.</param>
        /// <param name="middlename">Initial value of the middlename property.</param>
        /// <param name="lastname">Initial value of the lastname property.</param>
        /// <param name="address">Initial value of the address property.</param>
        /// <param name="joindate">Initial value of the joindate property.</param>
        /// <param name="moblienumber">Initial value of the moblienumber property.</param>
        public static employee Createemployee(global::System.Int32 employeeid, global::System.String firstname, global::System.String middlename, global::System.String lastname, global::System.String address, global::System.String joindate, global::System.Int32 moblienumber)
        {
            employee employee = new employee();
            employee.employeeid = employeeid;
            employee.firstname = firstname;
            employee.middlename = middlename;
            employee.lastname = lastname;
            employee.address = address;
            employee.joindate = joindate;
            employee.moblienumber = moblienumber;
            return employee;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 employeeid
        {
            get
            {
                return _employeeid;
            }
            set
            {
                if (_employeeid != value)
                {
                    OnemployeeidChanging(value);
                    ReportPropertyChanging("employeeid");
                    _employeeid = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("employeeid");
                    OnemployeeidChanged();
                }
            }
        }
        private global::System.Int32 _employeeid;
        partial void OnemployeeidChanging(global::System.Int32 value);
        partial void OnemployeeidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                if (_firstname != value)
                {
                    OnfirstnameChanging(value);
                    ReportPropertyChanging("firstname");
                    _firstname = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("firstname");
                    OnfirstnameChanged();
                }
            }
        }
        private global::System.String _firstname;
        partial void OnfirstnameChanging(global::System.String value);
        partial void OnfirstnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String middlename
        {
            get
            {
                return _middlename;
            }
            set
            {
                if (_middlename != value)
                {
                    OnmiddlenameChanging(value);
                    ReportPropertyChanging("middlename");
                    _middlename = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("middlename");
                    OnmiddlenameChanged();
                }
            }
        }
        private global::System.String _middlename;
        partial void OnmiddlenameChanging(global::System.String value);
        partial void OnmiddlenameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                if (_lastname != value)
                {
                    OnlastnameChanging(value);
                    ReportPropertyChanging("lastname");
                    _lastname = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("lastname");
                    OnlastnameChanged();
                }
            }
        }
        private global::System.String _lastname;
        partial void OnlastnameChanging(global::System.String value);
        partial void OnlastnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String address
        {
            get
            {
                return _address;
            }
            set
            {
                if (_address != value)
                {
                    OnaddressChanging(value);
                    ReportPropertyChanging("address");
                    _address = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("address");
                    OnaddressChanged();
                }
            }
        }
        private global::System.String _address;
        partial void OnaddressChanging(global::System.String value);
        partial void OnaddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String joindate
        {
            get
            {
                return _joindate;
            }
            set
            {
                if (_joindate != value)
                {
                    OnjoindateChanging(value);
                    ReportPropertyChanging("joindate");
                    _joindate = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("joindate");
                    OnjoindateChanged();
                }
            }
        }
        private global::System.String _joindate;
        partial void OnjoindateChanging(global::System.String value);
        partial void OnjoindateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 moblienumber
        {
            get
            {
                return _moblienumber;
            }
            set
            {
                if (_moblienumber != value)
                {
                    OnmoblienumberChanging(value);
                    ReportPropertyChanging("moblienumber");
                    _moblienumber = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("moblienumber");
                    OnmoblienumberChanged();
                }
            }
        }
        private global::System.Int32 _moblienumber;
        partial void OnmoblienumberChanging(global::System.Int32 value);
        partial void OnmoblienumberChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="cividatanewModel", Name="fabricator")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class fabricator : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new fabricator object.
        /// </summary>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="address">Initial value of the address property.</param>
        /// <param name="squarefeet">Initial value of the squarefeet property.</param>
        /// <param name="runningfeet">Initial value of the runningfeet property.</param>
        /// <param name="mobilenumber">Initial value of the mobilenumber property.</param>
        public static fabricator Createfabricator(global::System.String name, global::System.String address, global::System.Double squarefeet, global::System.Double runningfeet, global::System.Int32 mobilenumber)
        {
            fabricator fabricator = new fabricator();
            fabricator.name = name;
            fabricator.address = address;
            fabricator.squarefeet = squarefeet;
            fabricator.runningfeet = runningfeet;
            fabricator.mobilenumber = mobilenumber;
            return fabricator;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> fabricatorid
        {
            get
            {
                return _fabricatorid;
            }
            set
            {
                OnfabricatoridChanging(value);
                ReportPropertyChanging("fabricatorid");
                _fabricatorid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("fabricatorid");
                OnfabricatoridChanged();
            }
        }
        private Nullable<global::System.Int32> _fabricatorid;
        partial void OnfabricatoridChanging(Nullable<global::System.Int32> value);
        partial void OnfabricatoridChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    OnnameChanging(value);
                    ReportPropertyChanging("name");
                    _name = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("name");
                    OnnameChanged();
                }
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String address
        {
            get
            {
                return _address;
            }
            set
            {
                if (_address != value)
                {
                    OnaddressChanging(value);
                    ReportPropertyChanging("address");
                    _address = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("address");
                    OnaddressChanged();
                }
            }
        }
        private global::System.String _address;
        partial void OnaddressChanging(global::System.String value);
        partial void OnaddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double squarefeet
        {
            get
            {
                return _squarefeet;
            }
            set
            {
                if (_squarefeet != value)
                {
                    OnsquarefeetChanging(value);
                    ReportPropertyChanging("squarefeet");
                    _squarefeet = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("squarefeet");
                    OnsquarefeetChanged();
                }
            }
        }
        private global::System.Double _squarefeet;
        partial void OnsquarefeetChanging(global::System.Double value);
        partial void OnsquarefeetChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double runningfeet
        {
            get
            {
                return _runningfeet;
            }
            set
            {
                if (_runningfeet != value)
                {
                    OnrunningfeetChanging(value);
                    ReportPropertyChanging("runningfeet");
                    _runningfeet = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("runningfeet");
                    OnrunningfeetChanged();
                }
            }
        }
        private global::System.Double _runningfeet;
        partial void OnrunningfeetChanging(global::System.Double value);
        partial void OnrunningfeetChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 mobilenumber
        {
            get
            {
                return _mobilenumber;
            }
            set
            {
                if (_mobilenumber != value)
                {
                    OnmobilenumberChanging(value);
                    ReportPropertyChanging("mobilenumber");
                    _mobilenumber = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("mobilenumber");
                    OnmobilenumberChanged();
                }
            }
        }
        private global::System.Int32 _mobilenumber;
        partial void OnmobilenumberChanging(global::System.Int32 value);
        partial void OnmobilenumberChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="cividatanewModel", Name="newsite")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class newsite : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new newsite object.
        /// </summary>
        /// <param name="sitename">Initial value of the sitename property.</param>
        /// <param name="siteaddress">Initial value of the siteaddress property.</param>
        /// <param name="sitearea">Initial value of the sitearea property.</param>
        /// <param name="architecturename">Initial value of the architecturename property.</param>
        /// <param name="constructiontype">Initial value of the constructiontype property.</param>
        /// <param name="timetocomplete">Initial value of the timetocomplete property.</param>
        /// <param name="totalapproximatecost">Initial value of the totalapproximatecost property.</param>
        public static newsite Createnewsite(global::System.String sitename, global::System.String siteaddress, global::System.Int32 sitearea, global::System.String architecturename, global::System.String constructiontype, global::System.String timetocomplete, global::System.Int32 totalapproximatecost)
        {
            newsite newsite = new newsite();
            newsite.sitename = sitename;
            newsite.siteaddress = siteaddress;
            newsite.sitearea = sitearea;
            newsite.architecturename = architecturename;
            newsite.constructiontype = constructiontype;
            newsite.timetocomplete = timetocomplete;
            newsite.totalapproximatecost = totalapproximatecost;
            return newsite;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> siteid
        {
            get
            {
                return _siteid;
            }
            set
            {
                OnsiteidChanging(value);
                ReportPropertyChanging("siteid");
                _siteid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("siteid");
                OnsiteidChanged();
            }
        }
        private Nullable<global::System.Int32> _siteid;
        partial void OnsiteidChanging(Nullable<global::System.Int32> value);
        partial void OnsiteidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String sitename
        {
            get
            {
                return _sitename;
            }
            set
            {
                if (_sitename != value)
                {
                    OnsitenameChanging(value);
                    ReportPropertyChanging("sitename");
                    _sitename = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("sitename");
                    OnsitenameChanged();
                }
            }
        }
        private global::System.String _sitename;
        partial void OnsitenameChanging(global::System.String value);
        partial void OnsitenameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String siteaddress
        {
            get
            {
                return _siteaddress;
            }
            set
            {
                if (_siteaddress != value)
                {
                    OnsiteaddressChanging(value);
                    ReportPropertyChanging("siteaddress");
                    _siteaddress = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("siteaddress");
                    OnsiteaddressChanged();
                }
            }
        }
        private global::System.String _siteaddress;
        partial void OnsiteaddressChanging(global::System.String value);
        partial void OnsiteaddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 sitearea
        {
            get
            {
                return _sitearea;
            }
            set
            {
                if (_sitearea != value)
                {
                    OnsiteareaChanging(value);
                    ReportPropertyChanging("sitearea");
                    _sitearea = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("sitearea");
                    OnsiteareaChanged();
                }
            }
        }
        private global::System.Int32 _sitearea;
        partial void OnsiteareaChanging(global::System.Int32 value);
        partial void OnsiteareaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String architecturename
        {
            get
            {
                return _architecturename;
            }
            set
            {
                if (_architecturename != value)
                {
                    OnarchitecturenameChanging(value);
                    ReportPropertyChanging("architecturename");
                    _architecturename = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("architecturename");
                    OnarchitecturenameChanged();
                }
            }
        }
        private global::System.String _architecturename;
        partial void OnarchitecturenameChanging(global::System.String value);
        partial void OnarchitecturenameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String constructiontype
        {
            get
            {
                return _constructiontype;
            }
            set
            {
                if (_constructiontype != value)
                {
                    OnconstructiontypeChanging(value);
                    ReportPropertyChanging("constructiontype");
                    _constructiontype = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("constructiontype");
                    OnconstructiontypeChanged();
                }
            }
        }
        private global::System.String _constructiontype;
        partial void OnconstructiontypeChanging(global::System.String value);
        partial void OnconstructiontypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String timetocomplete
        {
            get
            {
                return _timetocomplete;
            }
            set
            {
                if (_timetocomplete != value)
                {
                    OntimetocompleteChanging(value);
                    ReportPropertyChanging("timetocomplete");
                    _timetocomplete = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("timetocomplete");
                    OntimetocompleteChanged();
                }
            }
        }
        private global::System.String _timetocomplete;
        partial void OntimetocompleteChanging(global::System.String value);
        partial void OntimetocompleteChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 totalapproximatecost
        {
            get
            {
                return _totalapproximatecost;
            }
            set
            {
                if (_totalapproximatecost != value)
                {
                    OntotalapproximatecostChanging(value);
                    ReportPropertyChanging("totalapproximatecost");
                    _totalapproximatecost = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("totalapproximatecost");
                    OntotalapproximatecostChanged();
                }
            }
        }
        private global::System.Int32 _totalapproximatecost;
        partial void OntotalapproximatecostChanging(global::System.Int32 value);
        partial void OntotalapproximatecostChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String startdate
        {
            get
            {
                return _startdate;
            }
            set
            {
                OnstartdateChanging(value);
                ReportPropertyChanging("startdate");
                _startdate = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("startdate");
                OnstartdateChanged();
            }
        }
        private global::System.String _startdate;
        partial void OnstartdateChanging(global::System.String value);
        partial void OnstartdateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String status
        {
            get
            {
                return _status;
            }
            set
            {
                OnstatusChanging(value);
                ReportPropertyChanging("status");
                _status = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("status");
                OnstatusChanged();
            }
        }
        private global::System.String _status;
        partial void OnstatusChanging(global::System.String value);
        partial void OnstatusChanged();

        #endregion
    
    }

    #endregion
    
}
