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

[assembly: EdmRelationshipAttribute("SeminarModel", "RoomTalk", "Room", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(WebEntityFramework.Models.Room), "Talk", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WebEntityFramework.Models.Talk), true)]
[assembly: EdmRelationshipAttribute("SeminarModel", "TalkSpeaker", "Talk", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WebEntityFramework.Models.Talk), "Speaker", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WebEntityFramework.Models.Speaker))]

#endregion

namespace WebEntityFramework.Models
{
    #region 컨텍스트
    
    /// <summary>
    /// 사용 가능한 메타데이터 설명서가 없습니다.
    /// </summary>
    public partial class SeminarModelContainer : ObjectContext
    {
        #region 생성자
    
        /// <summary>
        /// 응용 프로그램 구성 파일의 'SeminarModelContainer' 섹션에서 검색된 연결 문자열을 사용하여 새 SeminarModelContainer 개체를 초기화합니다.
        /// </summary>
        public SeminarModelContainer() : base("name=SeminarModelContainer", "SeminarModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 새 SeminarModelContainer 개체를 초기화합니다.
        /// </summary>
        public SeminarModelContainer(string connectionString) : base(connectionString, "SeminarModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 새 SeminarModelContainer 개체를 초기화합니다.
        /// </summary>
        public SeminarModelContainer(EntityConnection connection) : base(connection, "SeminarModelContainer")
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
        public ObjectSet<Room> Rooms
        {
            get
            {
                if ((_Rooms == null))
                {
                    _Rooms = base.CreateObjectSet<Room>("Rooms");
                }
                return _Rooms;
            }
        }
        private ObjectSet<Room> _Rooms;
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        public ObjectSet<Talk> Talks
        {
            get
            {
                if ((_Talks == null))
                {
                    _Talks = base.CreateObjectSet<Talk>("Talks");
                }
                return _Talks;
            }
        }
        private ObjectSet<Talk> _Talks;
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        public ObjectSet<Speaker> Speakers
        {
            get
            {
                if ((_Speakers == null))
                {
                    _Speakers = base.CreateObjectSet<Speaker>("Speakers");
                }
                return _Speakers;
            }
        }
        private ObjectSet<Speaker> _Speakers;

        #endregion
        #region AddTo 메서드
    
        /// <summary>
        /// Rooms EntitySet에 새 개체를 추가하는 데 사용되지 않는 메서드입니다. 연결된 ObjectSet&lt;T&gt; 속성의 .Add 메서드를 대신 사용하십시오.
        /// </summary>
        public void AddToRooms(Room room)
        {
            base.AddObject("Rooms", room);
        }
    
        /// <summary>
        /// Talks EntitySet에 새 개체를 추가하는 데 사용되지 않는 메서드입니다. 연결된 ObjectSet&lt;T&gt; 속성의 .Add 메서드를 대신 사용하십시오.
        /// </summary>
        public void AddToTalks(Talk talk)
        {
            base.AddObject("Talks", talk);
        }
    
        /// <summary>
        /// Speakers EntitySet에 새 개체를 추가하는 데 사용되지 않는 메서드입니다. 연결된 ObjectSet&lt;T&gt; 속성의 .Add 메서드를 대신 사용하십시오.
        /// </summary>
        public void AddToSpeakers(Speaker speaker)
        {
            base.AddObject("Speakers", speaker);
        }

        #endregion
    }
    

    #endregion
    
    #region 엔터티
    
    /// <summary>
    /// 사용 가능한 메타데이터 설명서가 없습니다.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SeminarModel", Name="Room")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Room : EntityObject
    {
        #region 팩터리 메서드
    
        /// <summary>
        /// 새 Room 개체를 만듭니다.
        /// </summary>
        /// <param name="id">ID 속성의 초기 값입니다.</param>
        /// <param name="name">Name 속성의 초기 값입니다.</param>
        public static Room CreateRoom(global::System.Int32 id, global::System.String name)
        {
            Room room = new Room();
            room.ID = id;
            room.Name = name;
            return room;
        }

        #endregion
        #region 기본 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
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
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
        #region 탐색 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SeminarModel", "RoomTalk", "Talk")]
        public EntityCollection<Talk> Talks
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Talk>("SeminarModel.RoomTalk", "Talk");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Talk>("SeminarModel.RoomTalk", "Talk", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// 사용 가능한 메타데이터 설명서가 없습니다.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SeminarModel", Name="Speaker")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Speaker : EntityObject
    {
        #region 팩터리 메서드
    
        /// <summary>
        /// 새 Speaker 개체를 만듭니다.
        /// </summary>
        /// <param name="id">ID 속성의 초기 값입니다.</param>
        /// <param name="name">Name 속성의 초기 값입니다.</param>
        public static Speaker CreateSpeaker(global::System.Int32 id, global::System.String name)
        {
            Speaker speaker = new Speaker();
            speaker.ID = id;
            speaker.Name = name;
            return speaker;
        }

        #endregion
        #region 기본 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
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
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
        #region 탐색 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SeminarModel", "TalkSpeaker", "Talk")]
        public EntityCollection<Talk> Talks
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Talk>("SeminarModel.TalkSpeaker", "Talk");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Talk>("SeminarModel.TalkSpeaker", "Talk", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// 사용 가능한 메타데이터 설명서가 없습니다.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SeminarModel", Name="Talk")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Talk : EntityObject
    {
        #region 팩터리 메서드
    
        /// <summary>
        /// 새 Talk 개체를 만듭니다.
        /// </summary>
        /// <param name="id">ID 속성의 초기 값입니다.</param>
        /// <param name="title">Title 속성의 초기 값입니다.</param>
        /// <param name="roomID">RoomID 속성의 초기 값입니다.</param>
        public static Talk CreateTalk(global::System.Int32 id, global::System.String title, global::System.Int32 roomID)
        {
            Talk talk = new Talk();
            talk.ID = id;
            talk.Title = title;
            talk.RoomID = roomID;
            return talk;
        }

        #endregion
        #region 기본 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
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
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> When
        {
            get
            {
                return _When;
            }
            set
            {
                OnWhenChanging(value);
                ReportPropertyChanging("When");
                _When = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("When");
                OnWhenChanged();
            }
        }
        private Nullable<global::System.DateTime> _When;
        partial void OnWhenChanging(Nullable<global::System.DateTime> value);
        partial void OnWhenChanged();
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 RoomID
        {
            get
            {
                return _RoomID;
            }
            set
            {
                OnRoomIDChanging(value);
                ReportPropertyChanging("RoomID");
                _RoomID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("RoomID");
                OnRoomIDChanged();
            }
        }
        private global::System.Int32 _RoomID;
        partial void OnRoomIDChanging(global::System.Int32 value);
        partial void OnRoomIDChanged();

        #endregion
    
        #region 탐색 속성
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SeminarModel", "RoomTalk", "Room")]
        public Room Rooms
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Room>("SeminarModel.RoomTalk", "Room").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Room>("SeminarModel.RoomTalk", "Room").Value = value;
            }
        }
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Room> RoomsReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Room>("SeminarModel.RoomTalk", "Room");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Room>("SeminarModel.RoomTalk", "Room", value);
                }
            }
        }
    
        /// <summary>
        /// 사용 가능한 메타데이터 설명서가 없습니다.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SeminarModel", "TalkSpeaker", "Speaker")]
        public EntityCollection<Speaker> Speakers
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Speaker>("SeminarModel.TalkSpeaker", "Speaker");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Speaker>("SeminarModel.TalkSpeaker", "Speaker", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
