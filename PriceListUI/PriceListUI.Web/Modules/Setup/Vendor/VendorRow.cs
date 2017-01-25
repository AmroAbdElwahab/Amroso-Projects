
namespace PriceListUI.Setup.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Vendor"), InstanceName("Vendor"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class VendorRow : Row, IIdRow, INameRow
    {
        [DisplayName("Rec Id"), Identity]
        public Int32? RecId
        {
            get { return Fields.RecId[this]; }
            set { Fields.RecId[this] = value; }
        }

        [DisplayName("Code"), Size(20)]
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

        [DisplayName("Image"), Size(100),ImageUploadEditor(FilenameFormat="Vendor/Image/~"), QuickSearch]
        public String Image
        {
            get { return Fields.Image[this]; }
            set { Fields.Image[this] = value; }
        }

        [DisplayName("Address"), QuickSearch]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.RecId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Address; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VendorRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field RecId;
            public StringField Code;
            public StringField Name;
            public StringField Image;
            public StringField Address;
            
            public RowFields()
                : base("[Setup].[Vendor]")
            {
                LocalTextPrefix = "Setup.Vendor";
            }
        }
    }
}
