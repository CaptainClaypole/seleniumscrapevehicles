﻿//------------------------------------------------------------------------------
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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("DataModel", "Page2ListList", "Page2List", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DomainWideObjects.DataAccess.ListGroup), "List", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DomainWideObjects.DataAccess.HTMLlist))]
[assembly: EdmRelationshipAttribute("DataModel", "PagePage2List", "Page", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DomainWideObjects.DataAccess.HTMLpage), "Page2List", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DomainWideObjects.DataAccess.ListGroup))]

#endregion

namespace DomainWideObjects.DataAccess
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DataModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DataModelContainer object using the connection string found in the 'DataModelContainer' section of the application configuration file.
        /// </summary>
        public DataModelContainer() : base("name=DataModelContainer", "DataModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DataModelContainer object.
        /// </summary>
        public DataModelContainer(string connectionString) : base(connectionString, "DataModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DataModelContainer object.
        /// </summary>
        public DataModelContainer(EntityConnection connection) : base(connection, "DataModelContainer")
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
        public ObjectSet<HTMLlist> HTMLlists
        {
            get
            {
                if ((_HTMLlists == null))
                {
                    _HTMLlists = base.CreateObjectSet<HTMLlist>("HTMLlists");
                }
                return _HTMLlists;
            }
        }
        private ObjectSet<HTMLlist> _HTMLlists;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<HTMLpage> HTMLpages
        {
            get
            {
                if ((_HTMLpages == null))
                {
                    _HTMLpages = base.CreateObjectSet<HTMLpage>("HTMLpages");
                }
                return _HTMLpages;
            }
        }
        private ObjectSet<HTMLpage> _HTMLpages;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ListGroup> ListGroups
        {
            get
            {
                if ((_ListGroups == null))
                {
                    _ListGroups = base.CreateObjectSet<ListGroup>("ListGroups");
                }
                return _ListGroups;
            }
        }
        private ObjectSet<ListGroup> _ListGroups;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the HTMLlists EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToHTMLlists(HTMLlist hTMLlist)
        {
            base.AddObject("HTMLlists", hTMLlist);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the HTMLpages EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToHTMLpages(HTMLpage hTMLpage)
        {
            base.AddObject("HTMLpages", hTMLpage);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ListGroups EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToListGroups(ListGroup listGroup)
        {
            base.AddObject("ListGroups", listGroup);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DataModel", Name="HTMLlist")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class HTMLlist : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new HTMLlist object.
        /// </summary>
        /// <param name="listId">Initial value of the ListId property.</param>
        /// <param name="listHtml">Initial value of the ListHtml property.</param>
        public static HTMLlist CreateHTMLlist(global::System.Int32 listId, global::System.String listHtml)
        {
            HTMLlist hTMLlist = new HTMLlist();
            hTMLlist.ListId = listId;
            hTMLlist.ListHtml = listHtml;
            return hTMLlist;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ListId
        {
            get
            {
                return _ListId;
            }
            set
            {
                if (_ListId != value)
                {
                    OnListIdChanging(value);
                    ReportPropertyChanging("ListId");
                    _ListId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ListId");
                    OnListIdChanged();
                }
            }
        }
        private global::System.Int32 _ListId;
        partial void OnListIdChanging(global::System.Int32 value);
        partial void OnListIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ListHtml
        {
            get
            {
                return _ListHtml;
            }
            set
            {
                OnListHtmlChanging(value);
                ReportPropertyChanging("ListHtml");
                _ListHtml = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ListHtml");
                OnListHtmlChanged();
            }
        }
        private global::System.String _ListHtml;
        partial void OnListHtmlChanging(global::System.String value);
        partial void OnListHtmlChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataModel", "Page2ListList", "Page2List")]
        public ListGroup Page2List
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ListGroup>("DataModel.Page2ListList", "Page2List").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ListGroup>("DataModel.Page2ListList", "Page2List").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ListGroup> Page2ListReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ListGroup>("DataModel.Page2ListList", "Page2List");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ListGroup>("DataModel.Page2ListList", "Page2List", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DataModel", Name="HTMLpage")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class HTMLpage : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new HTMLpage object.
        /// </summary>
        /// <param name="pageID">Initial value of the PageID property.</param>
        /// <param name="vehicleModel">Initial value of the VehicleModel property.</param>
        /// <param name="vehicleMake">Initial value of the VehicleMake property.</param>
        public static HTMLpage CreateHTMLpage(global::System.Int32 pageID, global::System.String vehicleModel, global::System.String vehicleMake)
        {
            HTMLpage hTMLpage = new HTMLpage();
            hTMLpage.PageID = pageID;
            hTMLpage.VehicleModel = vehicleModel;
            hTMLpage.VehicleMake = vehicleMake;
            return hTMLpage;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PageID
        {
            get
            {
                return _PageID;
            }
            set
            {
                if (_PageID != value)
                {
                    OnPageIDChanging(value);
                    ReportPropertyChanging("PageID");
                    _PageID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("PageID");
                    OnPageIDChanged();
                }
            }
        }
        private global::System.Int32 _PageID;
        partial void OnPageIDChanging(global::System.Int32 value);
        partial void OnPageIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String VehicleModel
        {
            get
            {
                return _VehicleModel;
            }
            set
            {
                OnVehicleModelChanging(value);
                ReportPropertyChanging("VehicleModel");
                _VehicleModel = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("VehicleModel");
                OnVehicleModelChanged();
            }
        }
        private global::System.String _VehicleModel;
        partial void OnVehicleModelChanging(global::System.String value);
        partial void OnVehicleModelChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String VehicleMake
        {
            get
            {
                return _VehicleMake;
            }
            set
            {
                OnVehicleMakeChanging(value);
                ReportPropertyChanging("VehicleMake");
                _VehicleMake = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("VehicleMake");
                OnVehicleMakeChanged();
            }
        }
        private global::System.String _VehicleMake;
        partial void OnVehicleMakeChanging(global::System.String value);
        partial void OnVehicleMakeChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataModel", "PagePage2List", "Page2List")]
        public ListGroup Page2List
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ListGroup>("DataModel.PagePage2List", "Page2List").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ListGroup>("DataModel.PagePage2List", "Page2List").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ListGroup> Page2ListReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ListGroup>("DataModel.PagePage2List", "Page2List");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ListGroup>("DataModel.PagePage2List", "Page2List", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DataModel", Name="ListGroup")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ListGroup : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ListGroup object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static ListGroup CreateListGroup(global::System.Int32 id)
        {
            ListGroup listGroup = new ListGroup();
            listGroup.ID = id;
            return listGroup;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataModel", "Page2ListList", "List")]
        public EntityCollection<HTMLlist> Lists
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<HTMLlist>("DataModel.Page2ListList", "List");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<HTMLlist>("DataModel.Page2ListList", "List", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataModel", "PagePage2List", "Page")]
        public HTMLpage Pages
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<HTMLpage>("DataModel.PagePage2List", "Page").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<HTMLpage>("DataModel.PagePage2List", "Page").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<HTMLpage> PagesReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<HTMLpage>("DataModel.PagePage2List", "Page");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<HTMLpage>("DataModel.PagePage2List", "Page", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}