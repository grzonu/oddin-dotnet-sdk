//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 

namespace Oddin.OddsFeedSdk.API.Models
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute()]
    [System.Xml.Serialization.XmlRootAttribute("match_summary", IsNullable = false)]
    public partial class MatchSummaryEndpointModel
    {

        private sportEvent sport_eventField;

        private sportEventStatus sport_event_statusField;

        private System.DateTime generated_atField;

        private bool generated_atFieldSpecified;

        /// <remarks/>
        public sportEvent sport_event
        {
            get
            {
                return this.sport_eventField;
            }
            set
            {
                this.sport_eventField = value;
            }
        }

        /// <remarks/>
        public sportEventStatus sport_event_status
        {
            get
            {
                return this.sport_event_statusField;
            }
            set
            {
                this.sport_event_statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime generated_at
        {
            get
            {
                return this.generated_atField;
            }
            set
            {
                this.generated_atField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool generated_atSpecified
        {
            get
            {
                return this.generated_atFieldSpecified;
            }
            set
            {
                this.generated_atFieldSpecified = value;
            }
        }
    }

}
