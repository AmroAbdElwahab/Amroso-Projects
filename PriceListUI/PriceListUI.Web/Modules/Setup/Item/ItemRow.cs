
namespace PriceListUI.Setup.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Item"), InstanceName("Item"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ItemRow : Row, IIdRow, INameRow
    {
        [DisplayName("Rec Id"), Identity]
        public Int32? RecId
        {
            get { return Fields.RecId[this]; }
            set { Fields.RecId[this] = value; }
        }

        [DisplayName("Code"), Size(20), QuickSearch]
        public String Code
        {
            get { return Fields.Code[this]; }
            set { Fields.Code[this] = value; }
        }

        [DisplayName("Name"), Size(150)]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Unit"), NotNull, ForeignKey("[Setup].[Unit]", "RecId"), LeftJoin("jUnitRec"), TextualField("UnitRecCode")]
        [LookupEditor("Setup.Unit")]
        public Int32? UnitRecId
        {
            get { return Fields.UnitRecId[this]; }
            set { Fields.UnitRecId[this] = value; }
        }

        [DisplayName("Unit Rec Code"), Expression("jUnitRec.[Code]")]
        public String UnitRecCode
        {
            get { return Fields.UnitRecCode[this]; }
            set { Fields.UnitRecCode[this] = value; }
        }

        [DisplayName("Unit"), Expression("jUnitRec.[Name]")]
        public String UnitRecName
        {
            get { return Fields.UnitRecName[this]; }
            set { Fields.UnitRecName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.RecId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Code; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ItemRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field RecId;
            public Int32Field UnitRecId;
            public StringField Code;
            public StringField Name;

            public StringField UnitRecCode;
            public StringField UnitRecName;

            public RowFields()
                : base("[Setup].[Item]")
            {
                LocalTextPrefix = "Setup.Item";
            }
        }
    }
}
