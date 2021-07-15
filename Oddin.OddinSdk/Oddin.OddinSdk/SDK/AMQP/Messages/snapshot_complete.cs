﻿namespace Oddin.OddinSdk.SDK.AMQP.Messages
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(IsNullable = false)]
    public partial class snapshot_complete : FeedMessageModel
    {
        public override long GeneratedAt => timestamp;

        // -----------------------------------------

        private long request_idField;

        private int productField;

        private long timestampField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long request_id
        {
            get
            {
                return this.request_idField;
            }
            set
            {
                this.request_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }
    }
}
