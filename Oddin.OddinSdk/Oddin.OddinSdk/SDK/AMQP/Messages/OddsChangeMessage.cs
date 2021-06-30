﻿namespace Oddin.OddinSdk.SDK.AMQP.Messages
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "odds_change", IsNullable = false)]
    public class OddsChangeMessage : FeedMessage
    {
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
    public class sportEventStatus
    {

        private clockType clockField;

        private periodScoreType[] period_scoresField;

        private resultType[] resultsField;

        private statisticsType statisticsField;

        private int statusField;

        private int reportingField;

        private bool reportingFieldSpecified;

        private int match_statusField;

        private decimal home_scoreField;

        private bool home_scoreFieldSpecified;

        private decimal away_scoreField;

        private bool away_scoreFieldSpecified;

        private int home_penalty_scoreField;

        private bool home_penalty_scoreFieldSpecified;

        private int away_penalty_scoreField;

        private bool away_penalty_scoreFieldSpecified;

        private int home_gamescoreField;

        private bool home_gamescoreFieldSpecified;

        private int away_gamescoreField;

        private bool away_gamescoreFieldSpecified;

        private int home_legscoreField;

        private bool home_legscoreFieldSpecified;

        private int away_legscoreField;

        private bool away_legscoreFieldSpecified;

        private int current_serverField;

        private bool current_serverFieldSpecified;

        private bool expedite_modeField;

        private bool expedite_modeFieldSpecified;

        private bool tiebreakField;

        private bool tiebreakFieldSpecified;

        private int home_suspendField;

        private bool home_suspendFieldSpecified;

        private int away_suspendField;

        private bool away_suspendFieldSpecified;

        private int ballsField;

        private bool ballsFieldSpecified;

        private int strikesField;

        private bool strikesFieldSpecified;

        private int outsField;

        private bool outsFieldSpecified;

        private string basesField;

        private int home_batterField;

        private bool home_batterFieldSpecified;

        private int away_batterField;

        private bool away_batterFieldSpecified;

        private int possessionField;

        private bool possessionFieldSpecified;

        private int positionField;

        private bool positionFieldSpecified;

        private int tryField;

        private bool tryFieldSpecified;

        private int yardsField;

        private bool yardsFieldSpecified;

        private int throwField;

        private bool throwFieldSpecified;

        private int visitField;

        private bool visitFieldSpecified;

        private int remaining_redsField;

        private bool remaining_redsFieldSpecified;

        private int deliveryField;

        private bool deliveryFieldSpecified;

        private int home_remaining_bowlsField;

        private bool home_remaining_bowlsFieldSpecified;

        private int away_remaining_bowlsField;

        private bool away_remaining_bowlsFieldSpecified;

        private int current_endField;

        private bool current_endFieldSpecified;

        private int inningsField;

        private bool inningsFieldSpecified;

        private int overField;

        private bool overFieldSpecified;

        private int home_penalty_runsField;

        private bool home_penalty_runsFieldSpecified;

        private int away_penalty_runsField;

        private bool away_penalty_runsFieldSpecified;

        private int home_dismissalsField;

        private bool home_dismissalsFieldSpecified;

        private int away_dismissalsField;

        private bool away_dismissalsFieldSpecified;

        private int current_ct_teamField;

        private bool current_ct_teamFieldSpecified;

        /// <remarks/>
        public clockType clock
        {
            get
            {
                return this.clockField;
            }
            set
            {
                this.clockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("period_score", IsNullable = false)]
        public periodScoreType[] period_scores
        {
            get
            {
                return this.period_scoresField;
            }
            set
            {
                this.period_scoresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("result", IsNullable = false)]
        public resultType[] results
        {
            get
            {
                return this.resultsField;
            }
            set
            {
                this.resultsField = value;
            }
        }

        /// <remarks/>
        public statisticsType statistics
        {
            get
            {
                return this.statisticsField;
            }
            set
            {
                this.statisticsField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int reporting
        {
            get
            {
                return this.reportingField;
            }
            set
            {
                this.reportingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reportingSpecified
        {
            get
            {
                return this.reportingFieldSpecified;
            }
            set
            {
                this.reportingFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int match_status
        {
            get
            {
                return this.match_statusField;
            }
            set
            {
                this.match_statusField = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool home_scoreSpecified
        {
            get
            {
                return this.home_scoreFieldSpecified;
            }
            set
            {
                this.home_scoreFieldSpecified = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool away_scoreSpecified
        {
            get
            {
                return this.away_scoreFieldSpecified;
            }
            set
            {
                this.away_scoreFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int home_penalty_score
        {
            get
            {
                return this.home_penalty_scoreField;
            }
            set
            {
                this.home_penalty_scoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool home_penalty_scoreSpecified
        {
            get
            {
                return this.home_penalty_scoreFieldSpecified;
            }
            set
            {
                this.home_penalty_scoreFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int away_penalty_score
        {
            get
            {
                return this.away_penalty_scoreField;
            }
            set
            {
                this.away_penalty_scoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool away_penalty_scoreSpecified
        {
            get
            {
                return this.away_penalty_scoreFieldSpecified;
            }
            set
            {
                this.away_penalty_scoreFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int home_gamescore
        {
            get
            {
                return this.home_gamescoreField;
            }
            set
            {
                this.home_gamescoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool home_gamescoreSpecified
        {
            get
            {
                return this.home_gamescoreFieldSpecified;
            }
            set
            {
                this.home_gamescoreFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int away_gamescore
        {
            get
            {
                return this.away_gamescoreField;
            }
            set
            {
                this.away_gamescoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool away_gamescoreSpecified
        {
            get
            {
                return this.away_gamescoreFieldSpecified;
            }
            set
            {
                this.away_gamescoreFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int home_legscore
        {
            get
            {
                return this.home_legscoreField;
            }
            set
            {
                this.home_legscoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool home_legscoreSpecified
        {
            get
            {
                return this.home_legscoreFieldSpecified;
            }
            set
            {
                this.home_legscoreFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int away_legscore
        {
            get
            {
                return this.away_legscoreField;
            }
            set
            {
                this.away_legscoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool away_legscoreSpecified
        {
            get
            {
                return this.away_legscoreFieldSpecified;
            }
            set
            {
                this.away_legscoreFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int current_server
        {
            get
            {
                return this.current_serverField;
            }
            set
            {
                this.current_serverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool current_serverSpecified
        {
            get
            {
                return this.current_serverFieldSpecified;
            }
            set
            {
                this.current_serverFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool expedite_mode
        {
            get
            {
                return this.expedite_modeField;
            }
            set
            {
                this.expedite_modeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expedite_modeSpecified
        {
            get
            {
                return this.expedite_modeFieldSpecified;
            }
            set
            {
                this.expedite_modeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool tiebreak
        {
            get
            {
                return this.tiebreakField;
            }
            set
            {
                this.tiebreakField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tiebreakSpecified
        {
            get
            {
                return this.tiebreakFieldSpecified;
            }
            set
            {
                this.tiebreakFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int home_suspend
        {
            get
            {
                return this.home_suspendField;
            }
            set
            {
                this.home_suspendField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool home_suspendSpecified
        {
            get
            {
                return this.home_suspendFieldSpecified;
            }
            set
            {
                this.home_suspendFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int away_suspend
        {
            get
            {
                return this.away_suspendField;
            }
            set
            {
                this.away_suspendField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool away_suspendSpecified
        {
            get
            {
                return this.away_suspendFieldSpecified;
            }
            set
            {
                this.away_suspendFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int balls
        {
            get
            {
                return this.ballsField;
            }
            set
            {
                this.ballsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ballsSpecified
        {
            get
            {
                return this.ballsFieldSpecified;
            }
            set
            {
                this.ballsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int strikes
        {
            get
            {
                return this.strikesField;
            }
            set
            {
                this.strikesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool strikesSpecified
        {
            get
            {
                return this.strikesFieldSpecified;
            }
            set
            {
                this.strikesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int outs
        {
            get
            {
                return this.outsField;
            }
            set
            {
                this.outsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool outsSpecified
        {
            get
            {
                return this.outsFieldSpecified;
            }
            set
            {
                this.outsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bases
        {
            get
            {
                return this.basesField;
            }
            set
            {
                this.basesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int home_batter
        {
            get
            {
                return this.home_batterField;
            }
            set
            {
                this.home_batterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool home_batterSpecified
        {
            get
            {
                return this.home_batterFieldSpecified;
            }
            set
            {
                this.home_batterFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int away_batter
        {
            get
            {
                return this.away_batterField;
            }
            set
            {
                this.away_batterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool away_batterSpecified
        {
            get
            {
                return this.away_batterFieldSpecified;
            }
            set
            {
                this.away_batterFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int possession
        {
            get
            {
                return this.possessionField;
            }
            set
            {
                this.possessionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool possessionSpecified
        {
            get
            {
                return this.possessionFieldSpecified;
            }
            set
            {
                this.possessionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool positionSpecified
        {
            get
            {
                return this.positionFieldSpecified;
            }
            set
            {
                this.positionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int @try
        {
            get
            {
                return this.tryField;
            }
            set
            {
                this.tryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool trySpecified
        {
            get
            {
                return this.tryFieldSpecified;
            }
            set
            {
                this.tryFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int yards
        {
            get
            {
                return this.yardsField;
            }
            set
            {
                this.yardsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool yardsSpecified
        {
            get
            {
                return this.yardsFieldSpecified;
            }
            set
            {
                this.yardsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int @throw
        {
            get
            {
                return this.throwField;
            }
            set
            {
                this.throwField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool throwSpecified
        {
            get
            {
                return this.throwFieldSpecified;
            }
            set
            {
                this.throwFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int visit
        {
            get
            {
                return this.visitField;
            }
            set
            {
                this.visitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool visitSpecified
        {
            get
            {
                return this.visitFieldSpecified;
            }
            set
            {
                this.visitFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int remaining_reds
        {
            get
            {
                return this.remaining_redsField;
            }
            set
            {
                this.remaining_redsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool remaining_redsSpecified
        {
            get
            {
                return this.remaining_redsFieldSpecified;
            }
            set
            {
                this.remaining_redsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int delivery
        {
            get
            {
                return this.deliveryField;
            }
            set
            {
                this.deliveryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deliverySpecified
        {
            get
            {
                return this.deliveryFieldSpecified;
            }
            set
            {
                this.deliveryFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int home_remaining_bowls
        {
            get
            {
                return this.home_remaining_bowlsField;
            }
            set
            {
                this.home_remaining_bowlsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool home_remaining_bowlsSpecified
        {
            get
            {
                return this.home_remaining_bowlsFieldSpecified;
            }
            set
            {
                this.home_remaining_bowlsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int away_remaining_bowls
        {
            get
            {
                return this.away_remaining_bowlsField;
            }
            set
            {
                this.away_remaining_bowlsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool away_remaining_bowlsSpecified
        {
            get
            {
                return this.away_remaining_bowlsFieldSpecified;
            }
            set
            {
                this.away_remaining_bowlsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int current_end
        {
            get
            {
                return this.current_endField;
            }
            set
            {
                this.current_endField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool current_endSpecified
        {
            get
            {
                return this.current_endFieldSpecified;
            }
            set
            {
                this.current_endFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int innings
        {
            get
            {
                return this.inningsField;
            }
            set
            {
                this.inningsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inningsSpecified
        {
            get
            {
                return this.inningsFieldSpecified;
            }
            set
            {
                this.inningsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int over
        {
            get
            {
                return this.overField;
            }
            set
            {
                this.overField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overSpecified
        {
            get
            {
                return this.overFieldSpecified;
            }
            set
            {
                this.overFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int home_penalty_runs
        {
            get
            {
                return this.home_penalty_runsField;
            }
            set
            {
                this.home_penalty_runsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool home_penalty_runsSpecified
        {
            get
            {
                return this.home_penalty_runsFieldSpecified;
            }
            set
            {
                this.home_penalty_runsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int away_penalty_runs
        {
            get
            {
                return this.away_penalty_runsField;
            }
            set
            {
                this.away_penalty_runsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool away_penalty_runsSpecified
        {
            get
            {
                return this.away_penalty_runsFieldSpecified;
            }
            set
            {
                this.away_penalty_runsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int home_dismissals
        {
            get
            {
                return this.home_dismissalsField;
            }
            set
            {
                this.home_dismissalsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool home_dismissalsSpecified
        {
            get
            {
                return this.home_dismissalsFieldSpecified;
            }
            set
            {
                this.home_dismissalsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int away_dismissals
        {
            get
            {
                return this.away_dismissalsField;
            }
            set
            {
                this.away_dismissalsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool away_dismissalsSpecified
        {
            get
            {
                return this.away_dismissalsFieldSpecified;
            }
            set
            {
                this.away_dismissalsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int current_ct_team
        {
            get
            {
                return this.current_ct_teamField;
            }
            set
            {
                this.current_ct_teamField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool current_ct_teamSpecified
        {
            get
            {
                return this.current_ct_teamFieldSpecified;
            }
            set
            {
                this.current_ct_teamFieldSpecified = value;
            }
        }
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

        private string idField;

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
    public class periodScoreType
    {

        private int match_status_codeField;

        private int numberField;

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
