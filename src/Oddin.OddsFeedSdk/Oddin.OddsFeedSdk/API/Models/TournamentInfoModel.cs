//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

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
    [System.Xml.Serialization.XmlRootAttribute("tournament_info", IsNullable = false)]
    public partial class TournamentInfoModel
    {
        private tournamentExtended tournamentField;

        private team[] competitorsField;

        private System.DateTime generated_atField;

        private bool generated_atFieldSpecified;

        /// <remarks/>
        public tournamentExtended tournament
        {
            get
            {
                return this.tournamentField;
            }
            set
            {
                this.tournamentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("competitor", IsNullable = false)]
        public team[] competitors
        {
            get
            {
                return this.competitorsField;
            }
            set
            {
                this.competitorsField = value;
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sport
    {
        private string idField;

        private string nameField;

        private string abbreviationField;

        private string refidField;

        [System.Xml.Serialization.XmlElement(ElementName = "ref_id", IsNullable = true)]
        public string refid
        {
            get
            {
                return this.refidField;
            }
            set
            {
                this.refidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string abbreviation
        {
            get
            {
                return this.abbreviationField;
            }
            set
            {
                this.abbreviationField = value;
            }
        }
    }
}