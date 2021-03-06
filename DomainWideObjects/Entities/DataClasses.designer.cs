﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainWideObjects.Entities
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHtmlListingPage(HtmlListingPage instance);
    partial void UpdateHtmlListingPage(HtmlListingPage instance);
    partial void DeleteHtmlListingPage(HtmlListingPage instance);
    partial void InsertHTMLlisting2Group(HTMLlisting2Group instance);
    partial void UpdateHTMLlisting2Group(HTMLlisting2Group instance);
    partial void DeleteHTMLlisting2Group(HTMLlisting2Group instance);
    #endregion
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<HtmlListingPage> HtmlListingPages
		{
			get
			{
				return this.GetTable<HtmlListingPage>();
			}
		}
		
		public System.Data.Linq.Table<HTMLlisting2Group> HTMLlisting2Groups
		{
			get
			{
				return this.GetTable<HTMLlisting2Group>();
			}
		}
		
		public System.Data.Linq.Table<HtmlListingPageGroup> HtmlListingPageGroups
		{
			get
			{
				return this.GetTable<HtmlListingPageGroup>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class HtmlListingPage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _htmlListingID;
		
		private string _htmlListingData;
		
		private EntityRef<HTMLlisting2Group> _HTMLlisting2Group;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnhtmlListingIDChanging(int value);
    partial void OnhtmlListingIDChanged();
    partial void OnhtmlListingDataChanging(string value);
    partial void OnhtmlListingDataChanged();
    #endregion
		
		public HtmlListingPage()
		{
			this._HTMLlisting2Group = default(EntityRef<HTMLlisting2Group>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_htmlListingID", IsPrimaryKey=true, IsDbGenerated=true)]
		public int htmlListingID
		{
			get
			{
				return this._htmlListingID;
			}
			set
			{
				if ((this._htmlListingID != value))
				{
					if (this._HTMLlisting2Group.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnhtmlListingIDChanging(value);
					this.SendPropertyChanging();
					this._htmlListingID = value;
					this.SendPropertyChanged("htmlListingID");
					this.OnhtmlListingIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_htmlListingData", CanBeNull=false)]
		public string htmlListingData
		{
			get
			{
				return this._htmlListingData;
			}
			set
			{
				if ((this._htmlListingData != value))
				{
					this.OnhtmlListingDataChanging(value);
					this.SendPropertyChanging();
					this._htmlListingData = value;
					this.SendPropertyChanged("htmlListingData");
					this.OnhtmlListingDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HtmlListing2Group_HtmlListing", Storage="_HTMLlisting2Group", ThisKey="htmlListingID", OtherKey="HtmlDisplayPageGroupID_fk", IsForeignKey=true)]
		public HTMLlisting2Group HTMLlisting2Group
		{
			get
			{
				return this._HTMLlisting2Group.Entity;
			}
			set
			{
				HTMLlisting2Group previousValue = this._HTMLlisting2Group.Entity;
				if (((previousValue != value) 
							|| (this._HTMLlisting2Group.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HTMLlisting2Group.Entity = null;
						previousValue.HtmlListingPages.Remove(this);
					}
					this._HTMLlisting2Group.Entity = value;
					if ((value != null))
					{
						value.HtmlListingPages.Add(this);
						this._htmlListingID = value.HtmlDisplayPageGroupID_fk;
					}
					else
					{
						this._htmlListingID = default(int);
					}
					this.SendPropertyChanged("HTMLlisting2Group");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class HTMLlisting2Group : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _HtmlDisplayPageGroupID_fk;
		
		private int _htmlListingID_fk;
		
		private int _HtmlPageGroup2ListingID_pk;
		
		private EntitySet<HtmlListingPage> _HtmlListingPages;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHtmlDisplayPageGroupID_fkChanging(int value);
    partial void OnHtmlDisplayPageGroupID_fkChanged();
    partial void OnhtmlListingID_fkChanging(int value);
    partial void OnhtmlListingID_fkChanged();
    partial void OnHtmlPageGroup2ListingID_pkChanging(int value);
    partial void OnHtmlPageGroup2ListingID_pkChanged();
    #endregion
		
		public HTMLlisting2Group()
		{
			this._HtmlListingPages = new EntitySet<HtmlListingPage>(new Action<HtmlListingPage>(this.attach_HtmlListingPages), new Action<HtmlListingPage>(this.detach_HtmlListingPages));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HtmlDisplayPageGroupID_fk")]
		public int HtmlDisplayPageGroupID_fk
		{
			get
			{
				return this._HtmlDisplayPageGroupID_fk;
			}
			set
			{
				if ((this._HtmlDisplayPageGroupID_fk != value))
				{
					this.OnHtmlDisplayPageGroupID_fkChanging(value);
					this.SendPropertyChanging();
					this._HtmlDisplayPageGroupID_fk = value;
					this.SendPropertyChanged("HtmlDisplayPageGroupID_fk");
					this.OnHtmlDisplayPageGroupID_fkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_htmlListingID_fk")]
		public int htmlListingID_fk
		{
			get
			{
				return this._htmlListingID_fk;
			}
			set
			{
				if ((this._htmlListingID_fk != value))
				{
					this.OnhtmlListingID_fkChanging(value);
					this.SendPropertyChanging();
					this._htmlListingID_fk = value;
					this.SendPropertyChanged("htmlListingID_fk");
					this.OnhtmlListingID_fkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HtmlPageGroup2ListingID_pk", IsPrimaryKey=true, IsDbGenerated=true)]
		public int HtmlPageGroup2ListingID_pk
		{
			get
			{
				return this._HtmlPageGroup2ListingID_pk;
			}
			set
			{
				if ((this._HtmlPageGroup2ListingID_pk != value))
				{
					this.OnHtmlPageGroup2ListingID_pkChanging(value);
					this.SendPropertyChanging();
					this._HtmlPageGroup2ListingID_pk = value;
					this.SendPropertyChanged("HtmlPageGroup2ListingID_pk");
					this.OnHtmlPageGroup2ListingID_pkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HtmlListing2Group_HtmlListing", Storage="_HtmlListingPages", ThisKey="HtmlDisplayPageGroupID_fk", OtherKey="htmlListingID")]
		public EntitySet<HtmlListingPage> HtmlListingPages
		{
			get
			{
				return this._HtmlListingPages;
			}
			set
			{
				this._HtmlListingPages.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_HtmlListingPages(HtmlListingPage entity)
		{
			this.SendPropertyChanging();
			entity.HTMLlisting2Group = this;
		}
		
		private void detach_HtmlListingPages(HtmlListingPage entity)
		{
			this.SendPropertyChanging();
			entity.HTMLlisting2Group = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class HtmlListingPageGroup
	{
		
		private int _htmlDisplayPageGroupID;
		
		private string _VehicleMake;
		
		private string _VehicleModel;
		
		private System.DateTime _TimeStamp;
		
		public HtmlListingPageGroup()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_htmlDisplayPageGroupID", IsDbGenerated=true)]
		public int htmlDisplayPageGroupID
		{
			get
			{
				return this._htmlDisplayPageGroupID;
			}
			set
			{
				if ((this._htmlDisplayPageGroupID != value))
				{
					this._htmlDisplayPageGroupID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VehicleMake", CanBeNull=false)]
		public string VehicleMake
		{
			get
			{
				return this._VehicleMake;
			}
			set
			{
				if ((this._VehicleMake != value))
				{
					this._VehicleMake = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VehicleModel", CanBeNull=false)]
		public string VehicleModel
		{
			get
			{
				return this._VehicleModel;
			}
			set
			{
				if ((this._VehicleModel != value))
				{
					this._VehicleModel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeStamp", IsDbGenerated=true)]
		public System.DateTime TimeStamp
		{
			get
			{
				return this._TimeStamp;
			}
			set
			{
				if ((this._TimeStamp != value))
				{
					this._TimeStamp = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
