﻿//------------------------------------------------------------------------------
// <auto-generated>
//    이 코드는 템플릿에서 생성되었습니다.
//
//    이 파일을 수동으로 변경하면 응용 프로그램에 예기치 않은 동작이 발생할 수 있습니다.
//    코드가 다시 생성되면 이 파일에 대한 수동 변경 사항을 덮어씁니다.
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
#region EDM 관계 메타데이터

[assembly: EdmRelationshipAttribute("NorthwindModel", "FK_Products_Categories", "Categories", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(WebEntityFramework.Models.Categories), "Products", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WebEntityFramework.Models.Products), true)]

#endregion

namespace WebEntityFramework.Models
{
    #region 컨텍스트
    
    /// <summary>
    /// 사용 가능한 메타데이터 설명서가 없습니다.
    /// </summary>
    public partial class NorthwindEntities : ObjectContext
    {
        #region 생성자
    
        /// <summary>
        /// 응용 프로그램 구성 파일의 'NorthwindEntities' 섹션에서 검색된 연결 문자열을 사용하여 새 NorthwindEntities 개체를 초기화합니다.
        /// </summary>
        public NorthwindEntities() : base("name=NorthwindEntities", "NorthwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 새 NorthwindEntities 개체를 초기화합니다.
        /// </summary>
        public NorthwindEntities(string connectionString) : base(connectionString, "NorthwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 새 NorthwindEntities 개체를 초기화합니다.
        /// </summary>
        public NorthwindEntities(EntityConnection connection) : base(connection, "NorthwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 부분 메서드(Partial Method)
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        public ObjectSet<Categories> Categories
        {
            get
            {
                if ((_Categories == null))
                {
                    _Categories = base.CreateObjectSet<Categories>("Categories");
                }
                return _Categories;
            }
        }
        private ObjectSet<Categories> _Categories;
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        public ObjectSet<Products> Products
        {
            get
            {
                if ((_Products == null))
                {
                    _Products = base.CreateObjectSet<Products>("Products");
                }
                return _Products;
            }
        }
        private ObjectSet<Products> _Products;

        #endregion
        #region AddTo 메서드
    
        /// <summary>
        /// Categories EntitySet에 새 개체를 추가하는 데 사용되지 않는 메서드입니다. 연결된 ObjectSet&lt;T&gt; 속성의 .Add 메서드를 대신 사용하십시오.
        /// </summary>
        public void AddToCategories(Categories categories)
        {
            base.AddObject("Categories", categories);
        }
    
        /// <summary>
        /// Products EntitySet에 새 개체를 추가하는 데 사용되지 않는 메서드입니다. 연결된 ObjectSet&lt;T&gt; 속성의 .Add 메서드를 대신 사용하십시오.
        /// </summary>
        public void AddToProducts(Products products)
        {
            base.AddObject("Products", products);
        }

        #endregion
        #region 함수 가져오기
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        /// <param name="categoryName">사용 가능한 메타데이터 설명서가 없습니다.</param>
        /// <param name="ordYear">사용 가능한 메타데이터 설명서가 없습니다.</param>
        public ObjectResult<SalesByCategory_Result> SalesByCategory(global::System.String categoryName, global::System.String ordYear)
        {
            ObjectParameter categoryNameParameter;
            if (categoryName != null)
            {
                categoryNameParameter = new ObjectParameter("CategoryName", categoryName);
            }
            else
            {
                categoryNameParameter = new ObjectParameter("CategoryName", typeof(global::System.String));
            }
    
            ObjectParameter ordYearParameter;
            if (ordYear != null)
            {
                ordYearParameter = new ObjectParameter("OrdYear", ordYear);
            }
            else
            {
                ordYearParameter = new ObjectParameter("OrdYear", typeof(global::System.String));
            }
    
            return base.ExecuteFunction<SalesByCategory_Result>("SalesByCategory", categoryNameParameter, ordYearParameter);
        }

        #endregion
    }
    

    #endregion
    
    #region 엔터티
    
    /// <summary>
    /// 사용 가능한 메타데이터 설명서가 없습니다.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NorthwindModel", Name="Categories")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Categories : EntityObject
    {
        #region 팩터리 메서드
    
        /// <summary>
        /// 새 Categories 개체를 만듭니다.
        /// </summary>
        /// <param name="categoryID">CategoryID 속성의 초기 값입니다.</param>
        /// <param name="categoryName">CategoryName 속성의 초기 값입니다.</param>
        public static Categories CreateCategories(global::System.Int32 categoryID, global::System.String categoryName)
        {
            Categories categories = new Categories();
            categories.CategoryID = categoryID;
            categories.CategoryName = categoryName;
            return categories;
        }

        #endregion
        #region 기본 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CategoryID
        {
            get
            {
                return _CategoryID;
            }
            set
            {
                if (_CategoryID != value)
                {
                    OnCategoryIDChanging(value);
                    ReportPropertyChanging("CategoryID");
                    _CategoryID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CategoryID");
                    OnCategoryIDChanged();
                }
            }
        }
        private global::System.Int32 _CategoryID;
        partial void OnCategoryIDChanging(global::System.Int32 value);
        partial void OnCategoryIDChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CategoryName
        {
            get
            {
                return _CategoryName;
            }
            set
            {
                OnCategoryNameChanging(value);
                ReportPropertyChanging("CategoryName");
                _CategoryName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CategoryName");
                OnCategoryNameChanged();
            }
        }
        private global::System.String _CategoryName;
        partial void OnCategoryNameChanging(global::System.String value);
        partial void OnCategoryNameChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] Picture
        {
            get
            {
                return StructuralObject.GetValidValue(_Picture);
            }
            set
            {
                OnPictureChanging(value);
                ReportPropertyChanging("Picture");
                _Picture = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Picture");
                OnPictureChanged();
            }
        }
        private global::System.Byte[] _Picture;
        partial void OnPictureChanging(global::System.Byte[] value);
        partial void OnPictureChanged();

        #endregion
    
        #region 탐색 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("NorthwindModel", "FK_Products_Categories", "Products")]
        public EntityCollection<Products> Products
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Products>("NorthwindModel.FK_Products_Categories", "Products");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Products>("NorthwindModel.FK_Products_Categories", "Products", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// 사용 가능한 메타데이터 설명서가 없습니다.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NorthwindModel", Name="Products")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Products : EntityObject
    {
        #region 팩터리 메서드
    
        /// <summary>
        /// 새 Products 개체를 만듭니다.
        /// </summary>
        /// <param name="productID">ProductID 속성의 초기 값입니다.</param>
        /// <param name="productName">ProductName 속성의 초기 값입니다.</param>
        /// <param name="discontinued">Discontinued 속성의 초기 값입니다.</param>
        public static Products CreateProducts(global::System.Int32 productID, global::System.String productName, global::System.Boolean discontinued)
        {
            Products products = new Products();
            products.ProductID = productID;
            products.ProductName = productName;
            products.Discontinued = discontinued;
            return products;
        }

        #endregion
        #region 기본 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProductID
        {
            get
            {
                return _ProductID;
            }
            set
            {
                if (_ProductID != value)
                {
                    OnProductIDChanging(value);
                    ReportPropertyChanging("ProductID");
                    _ProductID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ProductID");
                    OnProductIDChanged();
                }
            }
        }
        private global::System.Int32 _ProductID;
        partial void OnProductIDChanging(global::System.Int32 value);
        partial void OnProductIDChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ProductName
        {
            get
            {
                return _ProductName;
            }
            set
            {
                OnProductNameChanging(value);
                ReportPropertyChanging("ProductName");
                _ProductName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ProductName");
                OnProductNameChanged();
            }
        }
        private global::System.String _ProductName;
        partial void OnProductNameChanging(global::System.String value);
        partial void OnProductNameChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> SupplierID
        {
            get
            {
                return _SupplierID;
            }
            set
            {
                OnSupplierIDChanging(value);
                ReportPropertyChanging("SupplierID");
                _SupplierID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SupplierID");
                OnSupplierIDChanged();
            }
        }
        private Nullable<global::System.Int32> _SupplierID;
        partial void OnSupplierIDChanging(Nullable<global::System.Int32> value);
        partial void OnSupplierIDChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> CategoryID
        {
            get
            {
                return _CategoryID;
            }
            set
            {
                OnCategoryIDChanging(value);
                ReportPropertyChanging("CategoryID");
                _CategoryID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CategoryID");
                OnCategoryIDChanged();
            }
        }
        private Nullable<global::System.Int32> _CategoryID;
        partial void OnCategoryIDChanging(Nullable<global::System.Int32> value);
        partial void OnCategoryIDChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String QuantityPerUnit
        {
            get
            {
                return _QuantityPerUnit;
            }
            set
            {
                OnQuantityPerUnitChanging(value);
                ReportPropertyChanging("QuantityPerUnit");
                _QuantityPerUnit = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("QuantityPerUnit");
                OnQuantityPerUnitChanged();
            }
        }
        private global::System.String _QuantityPerUnit;
        partial void OnQuantityPerUnitChanging(global::System.String value);
        partial void OnQuantityPerUnitChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> UnitPrice
        {
            get
            {
                return _UnitPrice;
            }
            set
            {
                OnUnitPriceChanging(value);
                ReportPropertyChanging("UnitPrice");
                _UnitPrice = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UnitPrice");
                OnUnitPriceChanged();
            }
        }
        private Nullable<global::System.Decimal> _UnitPrice;
        partial void OnUnitPriceChanging(Nullable<global::System.Decimal> value);
        partial void OnUnitPriceChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> UnitsInStock
        {
            get
            {
                return _UnitsInStock;
            }
            set
            {
                OnUnitsInStockChanging(value);
                ReportPropertyChanging("UnitsInStock");
                _UnitsInStock = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UnitsInStock");
                OnUnitsInStockChanged();
            }
        }
        private Nullable<global::System.Int16> _UnitsInStock;
        partial void OnUnitsInStockChanging(Nullable<global::System.Int16> value);
        partial void OnUnitsInStockChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> UnitsOnOrder
        {
            get
            {
                return _UnitsOnOrder;
            }
            set
            {
                OnUnitsOnOrderChanging(value);
                ReportPropertyChanging("UnitsOnOrder");
                _UnitsOnOrder = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UnitsOnOrder");
                OnUnitsOnOrderChanged();
            }
        }
        private Nullable<global::System.Int16> _UnitsOnOrder;
        partial void OnUnitsOnOrderChanging(Nullable<global::System.Int16> value);
        partial void OnUnitsOnOrderChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> ReorderLevel
        {
            get
            {
                return _ReorderLevel;
            }
            set
            {
                OnReorderLevelChanging(value);
                ReportPropertyChanging("ReorderLevel");
                _ReorderLevel = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ReorderLevel");
                OnReorderLevelChanged();
            }
        }
        private Nullable<global::System.Int16> _ReorderLevel;
        partial void OnReorderLevelChanging(Nullable<global::System.Int16> value);
        partial void OnReorderLevelChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Discontinued
        {
            get
            {
                return _Discontinued;
            }
            set
            {
                OnDiscontinuedChanging(value);
                ReportPropertyChanging("Discontinued");
                _Discontinued = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Discontinued");
                OnDiscontinuedChanged();
            }
        }
        private global::System.Boolean _Discontinued;
        partial void OnDiscontinuedChanging(global::System.Boolean value);
        partial void OnDiscontinuedChanged();

        #endregion
    
        #region 탐색 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("NorthwindModel", "FK_Products_Categories", "Categories")]
        public Categories Categories
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Categories>("NorthwindModel.FK_Products_Categories", "Categories").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Categories>("NorthwindModel.FK_Products_Categories", "Categories").Value = value;
            }
        }
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Categories> CategoriesReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Categories>("NorthwindModel.FK_Products_Categories", "Categories");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Categories>("NorthwindModel.FK_Products_Categories", "Categories", value);
                }
            }
        }

        #endregion
    }

    #endregion
    #region ComplexTypes
    
    /// <summary>
    /// 사용 가능한 메타데이터 설명서가 없습니다.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="NorthwindModel", Name="SalesByCategory_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class SalesByCategory_Result : ComplexObject
    {
        #region 팩터리 메서드
    
        /// <summary>
        /// 새 SalesByCategory_Result 개체를 만듭니다.
        /// </summary>
        /// <param name="productName">ProductName 속성의 초기 값입니다.</param>
        public static SalesByCategory_Result CreateSalesByCategory_Result(global::System.String productName)
        {
            SalesByCategory_Result salesByCategory_Result = new SalesByCategory_Result();
            salesByCategory_Result.ProductName = productName;
            return salesByCategory_Result;
        }

        #endregion
        #region 기본 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ProductName
        {
            get
            {
                return _ProductName;
            }
            set
            {
                OnProductNameChanging(value);
                ReportPropertyChanging("ProductName");
                _ProductName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ProductName");
                OnProductNameChanged();
            }
        }
        private global::System.String _ProductName;
        partial void OnProductNameChanging(global::System.String value);
        partial void OnProductNameChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> TotalPurchase
        {
            get
            {
                return _TotalPurchase;
            }
            set
            {
                OnTotalPurchaseChanging(value);
                ReportPropertyChanging("TotalPurchase");
                _TotalPurchase = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TotalPurchase");
                OnTotalPurchaseChanged();
            }
        }
        private Nullable<global::System.Decimal> _TotalPurchase;
        partial void OnTotalPurchaseChanging(Nullable<global::System.Decimal> value);
        partial void OnTotalPurchaseChanged();

        #endregion
    }

    #endregion
    
}