
namespace PriceListUI.Setup.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Unit"), InstanceName("Unit"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class UnitRow : Row, IIdRow, INameRow
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

        IIdField IIdRow.IdField
        {
            get { return Fields.RecId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Code; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public UnitRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field RecId;
            public StringField Code;
            public StringField Name;

            public RowFields()
                : base("[Setup].[Unit]")
            {
                LocalTextPrefix = "Setup.Unit";
            }
        }
    }
}
