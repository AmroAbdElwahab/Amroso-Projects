
namespace PriceListUI.Transactions.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Purch"), InstanceName("Purch"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PurchRow : Row, IIdRow, INameRow
    {
        [DisplayName("Rec Id"), Identity]
        public Int32? RecId
        {
            get { return Fields.RecId[this]; }
            set { Fields.RecId[this] = value; }
        }

        [DisplayName("Vendor Rec"), NotNull, ForeignKey("[Setup].[Vendor]", "RecId"), LeftJoin("jVendorRec"), TextualField("VendorRecAddress")]
        public Int32? VendorRecId
        {
            get { return Fields.VendorRecId[this]; }
            set { Fields.VendorRecId[this] = value; }
        }

        [DisplayName("Code"), Size(20), QuickSearch]
        public String Code
        {
            get { return Fields.Code[this]; }
            set { Fields.Code[this] = value; }
        }

        [DisplayName("Date"), NotNull]
        public DateTime? Date
        {
            get { return Fields.Date[this]; }
            set { Fields.Date[this] = value; }
        }

        [DisplayName("Description"), Size(150)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Status"), NotNull]
        public Status? Status
        {
            get { return (Status?)Fields.Status[this]; }
            set { Fields.Status[this] = (Int32?)value; }
        }

        [DisplayName("Vendor Rec Address"), Expression("jVendorRec.[Address]")]
        public String VendorRecAddress
        {
            get { return Fields.VendorRecAddress[this]; }
            set { Fields.VendorRecAddress[this] = value; }
        }

        [DisplayName("Vendor Rec Code"), Expression("jVendorRec.[Code]")]
        public String VendorRecCode
        {
            get { return Fields.VendorRecCode[this]; }
            set { Fields.VendorRecCode[this] = value; }
        }

        [DisplayName("Vendor Rec Name"), Expression("jVendorRec.[Name]")]
        public String VendorRecName
        {
            get { return Fields.VendorRecName[this]; }
            set { Fields.VendorRecName[this] = value; }
        }

        [DisplayName("Vendor Rec Image"), Expression("jVendorRec.[Image]")]
        public String VendorRecImage
        {
            get { return Fields.VendorRecImage[this]; }
            set { Fields.VendorRecImage[this] = value; }
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

        public PurchRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field RecId;
            public Int32Field VendorRecId;
            public StringField Code;
            public DateTimeField Date;
            public StringField Description;
            public Int32Field Status;

            public StringField VendorRecAddress;
            public StringField VendorRecCode;
            public StringField VendorRecName;
            public StringField VendorRecImage;

            public RowFields()
                : base("[Transactions].[Purch]")
            {
                LocalTextPrefix = "Transactions.Purch";
            }
        }
    }
}
