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

using System;
using System.Xml.Serialization;

namespace Oddin.OddsFeedSdk.AMQP.Messages
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "odds_change", IsNullable = false)]
    public class odds_change : FeedMessageModel
    {
        public override long GeneratedAt => timestamp;

        // ----------------------------------------------------------

        private sportEventStatus sport_event_statusField;
    
        private oddsGenerationProperties odds_generation_propertiesField;
    
        private odds_changeOdds oddsField;
    
        private int productField;
    
        private string event_idField;
    
        private long timestampField;
    
        private long request_idField;
    
        private bool request_idFieldSpecified;
    
        private int odds_change_reasonField;
    
        private bool odds_change_reasonFieldSpecified;

        private string event_refidField;

        [System.Xml.Serialization.XmlElement(ElementName = "event_ref_id", IsNullable = true)]
        public string event_refid
        {
            get
            {
                return this.event_refidField;
            }
            set
            {
                this.event_refidField = value;
            }
        }
    
        /// <remarks/>
        public sportEventStatus sport_event_status {
            get {
                return this.sport_event_statusField;
            }
            set {
                this.sport_event_statusField = value;
            }
        }
    
        /// <remarks/>
        public oddsGenerationProperties odds_generation_properties {
            get {
                return this.odds_generation_propertiesField;
            }
            set {
                this.odds_generation_propertiesField = value;
            }
        }
    
        /// <remarks/>
        public odds_changeOdds odds {
            get {
                return this.oddsField;
            }
            set {
                this.oddsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string event_id {
            get {
                return this.event_idField;
            }
            set {
                this.event_idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long request_id {
            get {
                return this.request_idField;
            }
            set {
                this.request_idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool request_idSpecified {
            get {
                return this.request_idFieldSpecified;
            }
            set {
                this.request_idFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int odds_change_reason {
            get {
                return this.odds_change_reasonField;
            }
            set {
                this.odds_change_reasonField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool odds_change_reasonSpecified {
            get {
                return this.odds_change_reasonFieldSpecified;
            }
            set {
                this.odds_change_reasonFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class scoreboard
    {
        [XmlAttribute]
        public int current_ct_team { get; set; }
        [XmlAttribute]
        public int home_won_rounds { get; set; }
        [XmlAttribute]
        public int away_won_rounds { get; set; }
        [XmlAttribute]
        public int current_round { get; set; }
        [XmlAttribute]
        public int home_kills { get; set; }
        [XmlAttribute]
        public int away_kills { get; set; }
        [XmlAttribute]
        public int home_destroyed_turrets { get; set; }
        [XmlAttribute]
        public int away_destroyed_turrets { get; set; }
        [XmlAttribute]
        public int home_gold { get; set; }
        [XmlAttribute]
        public int away_gold { get; set; }
        [XmlAttribute]
        public int home_destroyed_towers { get; set; }
        [XmlAttribute]
        public int away_destroyed_towers { get; set; }
    }

    [Serializable]
    public enum eventStatus
    {
        [XmlEnum("0")]
        NotStarted = 0,

        [XmlEnum("1")]
        Live = 1,

        [XmlEnum("2")]
        Suspended = 2,

        [XmlEnum("3")]
        Ended = 3,

        [XmlEnum("4")]
        Closed = 4,

        [XmlEnum("5")]
        Cancelled = 5,

        [XmlEnum("6")]
        Delayed = 6,

        [XmlEnum("7")]
        Interrupted,

        [XmlEnum("8")]
        Postponed,

        [XmlEnum("9")]
        Abandoned
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class sportEventStatus
    {
        [XmlElement]
        public scoreboard scoreboard { get; set; }
        [XmlElement]
        public periodScoresType period_scores { get; set; }
        [XmlElement]
        public resultType results { get; set; }

        [XmlAttribute]
        public eventStatus status { get; set; }
        [XmlAttribute]
        public int match_status { get; set; }
        [XmlAttribute]
        public double home_score { get; set; }
        [XmlAttribute]
        public double away_score { get; set; }
        [XmlAttribute]
        public bool scoreboard_available { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class clockType
    {
        private string match_timeField;

        private string stoppage_timeField;

        private string stoppage_time_announcedField;

        private string remaining_timeField;

        private string remaining_time_in_periodField;

        private bool stoppedField;

        private bool stoppedFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string match_time
        {
            get
            {
                return this.match_timeField;
            }
            set
            {
                this.match_timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string stoppage_time
        {
            get
            {
                return this.stoppage_timeField;
            }
            set
            {
                this.stoppage_timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string stoppage_time_announced
        {
            get
            {
                return this.stoppage_time_announcedField;
            }
            set
            {
                this.stoppage_time_announcedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string remaining_time
        {
            get
            {
                return this.remaining_timeField;
            }
            set
            {
                this.remaining_timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string remaining_time_in_period
        {
            get
            {
                return this.remaining_time_in_periodField;
            }
            set
            {
                this.remaining_time_in_periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool stopped
        {
            get
            {
                return this.stoppedField;
            }
            set
            {
                this.stoppedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stoppedSpecified
        {
            get
            {
                return this.stoppedFieldSpecified;
            }
            set
            {
                this.stoppedFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class marketMetadata
    {

        private long next_betstopField;

        private bool next_betstopFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long next_betstop
        {
            get
            {
                return this.next_betstopField;
            }
            set
            {
                this.next_betstopField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool next_betstopSpecified
        {
            get
            {
                return this.next_betstopFieldSpecified;
            }
            set
            {
                this.next_betstopFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class oddsChangeMarket
    {

        private marketMetadata market_metadataField;

        private oddsChangeMarketOutcome[] outcomeField;

        private int idField;

        private string specifiersField;

        private string extended_specifiersField;

        private int favouriteField;

        private bool favouriteFieldSpecified;

        private int statusField;

        private bool statusFieldSpecified;

        private int cashout_statusField;

        private bool cashout_statusFieldSpecified;

        private int? refidField;

        [System.Xml.Serialization.XmlElement(ElementName = "ref_id", IsNullable = true)]
        public int? refid
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
        public marketMetadata market_metadata
        {
            get
            {
                return this.market_metadataField;
            }
            set
            {
                this.market_metadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("outcome")]
        public oddsChangeMarketOutcome[] outcome
        {
            get
            {
                return this.outcomeField;
            }
            set
            {
                this.outcomeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id
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
        public string specifiers
        {
            get
            {
                return this.specifiersField;
            }
            set
            {
                this.specifiersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string extended_specifiers
        {
            get
            {
                return this.extended_specifiersField;
            }
            set
            {
                this.extended_specifiersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int favourite
        {
            get
            {
                return this.favouriteField;
            }
            set
            {
                this.favouriteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool favouriteSpecified
        {
            get
            {
                return this.favouriteFieldSpecified;
            }
            set
            {
                this.favouriteFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int cashout_status
        {
            get
            {
                return this.cashout_statusField;
            }
            set
            {
                this.cashout_statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cashout_statusSpecified
        {
            get
            {
                return this.cashout_statusFieldSpecified;
            }
            set
            {
                this.cashout_statusFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class oddsChangeMarketOutcome
    {

        private long idField;

        private double oddsField;

        private bool oddsFieldSpecified;

        private double probabilitiesField;

        private bool probabilitiesFieldSpecified;

        private double win_probabilitiesField;

        private bool win_probabilitiesFieldSpecified;

        private double lose_probabilitiesField;

        private bool lose_probabilitiesFieldSpecified;

        private double refund_probabilitiesField;

        private bool refund_probabilitiesFieldSpecified;

        private double half_win_probabilitiesField;

        private bool half_win_probabilitiesFieldSpecified;

        private double half_lose_probabilitiesField;

        private bool half_lose_probabilitiesFieldSpecified;

        private int activeField;

        private bool activeFieldSpecified;

        private int teamField;

        private bool teamFieldSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long id
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

        private long? refidField;

        [System.Xml.Serialization.XmlElement(ElementName = "ref_id", IsNullable = true)]
        public long? refid
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
        public double odds
        {
            get
            {
                return this.oddsField;
            }
            set
            {
                this.oddsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool oddsSpecified
        {
            get
            {
                return this.oddsFieldSpecified;
            }
            set
            {
                this.oddsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double probabilities
        {
            get
            {
                return this.probabilitiesField;
            }
            set
            {
                this.probabilitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool probabilitiesSpecified
        {
            get
            {
                return this.probabilitiesFieldSpecified;
            }
            set
            {
                this.probabilitiesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double win_probabilities
        {
            get
            {
                return this.win_probabilitiesField;
            }
            set
            {
                this.win_probabilitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool win_probabilitiesSpecified
        {
            get
            {
                return this.win_probabilitiesFieldSpecified;
            }
            set
            {
                this.win_probabilitiesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double lose_probabilities
        {
            get
            {
                return this.lose_probabilitiesField;
            }
            set
            {
                this.lose_probabilitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lose_probabilitiesSpecified
        {
            get
            {
                return this.lose_probabilitiesFieldSpecified;
            }
            set
            {
                this.lose_probabilitiesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double refund_probabilities
        {
            get
            {
                return this.refund_probabilitiesField;
            }
            set
            {
                this.refund_probabilitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool refund_probabilitiesSpecified
        {
            get
            {
                return this.refund_probabilitiesFieldSpecified;
            }
            set
            {
                this.refund_probabilitiesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double half_win_probabilities
        {
            get
            {
                return this.half_win_probabilitiesField;
            }
            set
            {
                this.half_win_probabilitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool half_win_probabilitiesSpecified
        {
            get
            {
                return this.half_win_probabilitiesFieldSpecified;
            }
            set
            {
                this.half_win_probabilitiesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double half_lose_probabilities
        {
            get
            {
                return this.half_lose_probabilitiesField;
            }
            set
            {
                this.half_lose_probabilitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool half_lose_probabilitiesSpecified
        {
            get
            {
                return this.half_lose_probabilitiesFieldSpecified;
            }
            set
            {
                this.half_lose_probabilitiesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool activeSpecified
        {
            get
            {
                return this.activeFieldSpecified;
            }
            set
            {
                this.activeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int team
        {
            get
            {
                return this.teamField;
            }
            set
            {
                this.teamField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool teamSpecified
        {
            get
            {
                return this.teamFieldSpecified;
            }
            set
            {
                this.teamFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class oddsGenerationProperties
    {

        private double expected_totalsField;

        private bool expected_totalsFieldSpecified;

        private double expected_supremacyField;

        private bool expected_supremacyFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double expected_totals
        {
            get
            {
                return this.expected_totalsField;
            }
            set
            {
                this.expected_totalsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expected_totalsSpecified
        {
            get
            {
                return this.expected_totalsFieldSpecified;
            }
            set
            {
                this.expected_totalsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double expected_supremacy
        {
            get
            {
                return this.expected_supremacyField;
            }
            set
            {
                this.expected_supremacyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expected_supremacySpecified
        {
            get
            {
                return this.expected_supremacyFieldSpecified;
            }
            set
            {
                this.expected_supremacyFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class statisticsScoreType
    {

        private int homeField;

        private int awayField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int home
        {
            get
            {
                return this.homeField;
            }
            set
            {
                this.homeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int away
        {
            get
            {
                return this.awayField;
            }
            set
            {
                this.awayField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class statisticsType
    {

        private statisticsScoreType yellow_cardsField;

        private statisticsScoreType red_cardsField;

        private statisticsScoreType yellow_red_cardsField;

        private statisticsScoreType cornersField;

        private statisticsScoreType green_cardsField;

        /// <remarks/>
        public statisticsScoreType yellow_cards
        {
            get
            {
                return this.yellow_cardsField;
            }
            set
            {
                this.yellow_cardsField = value;
            }
        }

        /// <remarks/>
        public statisticsScoreType red_cards
        {
            get
            {
                return this.red_cardsField;
            }
            set
            {
                this.red_cardsField = value;
            }
        }

        /// <remarks/>
        public statisticsScoreType yellow_red_cards
        {
            get
            {
                return this.yellow_red_cardsField;
            }
            set
            {
                this.yellow_red_cardsField = value;
            }
        }

        /// <remarks/>
        public statisticsScoreType corners
        {
            get
            {
                return this.cornersField;
            }
            set
            {
                this.cornersField = value;
            }
        }

        /// <remarks/>
        public statisticsScoreType green_cards
        {
            get
            {
                return this.green_cardsField;
            }
            set
            {
                this.green_cardsField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class resultType
    {

        private int match_status_codeField;

        private decimal home_scoreField;

        private decimal away_scoreField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int match_status_code
        {
            get
            {
                return this.match_status_codeField;
            }
            set
            {
                this.match_status_codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal home_score
        {
            get
            {
                return this.home_scoreField;
            }
            set
            {
                this.home_scoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal away_score
        {
            get
            {
                return this.away_scoreField;
            }
            set
            {
                this.away_scoreField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class periodScoresType
    {
        [XmlElement]
        public periodScoreType[] period_score { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class periodScoreType
    {

        private int match_status_codeField;

        private int numberField;

        private double home_scoreField;

        private double away_scoreField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int match_status_code
        {
            get
            {
                return this.match_status_codeField;
            }
            set
            {
                this.match_status_codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double home_score
        {
            get
            {
                return this.home_scoreField;
            }
            set
            {
                this.home_scoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double away_score
        {
            get
            {
                return this.away_scoreField;
            }
            set
            {
                this.away_scoreField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int home_won_rounds { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int away_won_rounds { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int home_kills { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int away_kills { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class odds_changeOdds
    {

        private oddsChangeMarket[] marketField;

        private int betting_statusField;

        private bool betting_statusFieldSpecified;

        private int betstop_reasonField;

        private bool betstop_reasonFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("market")]
        public oddsChangeMarket[] market
        {
            get
            {
                return this.marketField;
            }
            set
            {
                this.marketField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int betting_status
        {
            get
            {
                return this.betting_statusField;
            }
            set
            {
                this.betting_statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool betting_statusSpecified
        {
            get
            {
                return this.betting_statusFieldSpecified;
            }
            set
            {
                this.betting_statusFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int betstop_reason
        {
            get
            {
                return this.betstop_reasonField;
            }
            set
            {
                this.betstop_reasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool betstop_reasonSpecified
        {
            get
            {
                return this.betstop_reasonFieldSpecified;
            }
            set
            {
                this.betstop_reasonFieldSpecified = value;
            }
        }
    }
}
