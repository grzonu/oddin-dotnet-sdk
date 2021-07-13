﻿namespace Oddin.OddinSdk.SDK.AMQP.Messages
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(IsNullable = false)]
    public partial class bet_stop : FeedMessageModel
    {
        public override long GeneratedAt => timestamp;

        // ------------------------------------------

        private int productField;

        private string event_idField;

        private long timestampField;

        private long request_idField;

        private bool request_idFieldSpecified;

        private string groupsField;

        private int market_statusField;

        private bool market_statusFieldSpecified;

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
        public string event_id
        {
            get
            {
                return this.event_idField;
            }
            set
            {
                this.event_idField = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool request_idSpecified
        {
            get
            {
                return this.request_idFieldSpecified;
            }
            set
            {
                this.request_idFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string groups
        {
            get
            {
                return this.groupsField;
            }
            set
            {
                this.groupsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int market_status
        {
            get
            {
                return this.market_statusField;
            }
            set
            {
                this.market_statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool market_statusSpecified
        {
            get
            {
                return this.market_statusFieldSpecified;
            }
            set
            {
                this.market_statusFieldSpecified = value;
            }
        }
    }
}