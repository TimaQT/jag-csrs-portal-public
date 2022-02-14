// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Csrs.Interfaces.Dynamics.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.campaignactivity
    /// </summary>
    public partial class MicrosoftDynamicsCRMcampaignactivity : MicrosoftDynamicsCRMactivitypointer
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcampaignactivity class.
        /// </summary>
        public MicrosoftDynamicsCRMcampaignactivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcampaignactivity class.
        /// </summary>
        public MicrosoftDynamicsCRMcampaignactivity(System.DateTimeOffset? lastonholdtime = default(System.DateTimeOffset?), string _owningteamValue = default(string), string exchangeitemid = default(string), bool? ismapiprivate = default(bool?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string seriesid = default(string), string _regardingobjectidValue = default(string), System.DateTimeOffset? deliverylastattemptedon = default(System.DateTimeOffset?), bool? isbilled = default(bool?), bool? isworkflowcreated = default(bool?), string _sendermailboxidValue = default(string), System.DateTimeOffset? scheduledend = default(System.DateTimeOffset?), string description = default(string), int? onholdtime = default(int?), string _modifiedbyValue = default(string), int? community = default(int?), System.DateTimeOffset? sortdate = default(System.DateTimeOffset?), int? instancetypecode = default(int?), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), string _createdbyValue = default(string), string _transactioncurrencyidValue = default(string), string versionnumber = default(string), string processid = default(string), int? prioritycode = default(int?), string _serviceidValue = default(string), string _slaidValue = default(string), string stageid = default(string), System.DateTimeOffset? actualstart = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), string _owninguserValue = default(string), int? utcconversiontimezonecode = default(int?), string exchangeweblink = default(string), int? scheduleddurationminutes = default(int?), System.DateTimeOffset? senton = default(System.DateTimeOffset?), System.DateTimeOffset? scheduledstart = default(System.DateTimeOffset?), string _slainvokedidValue = default(string), int? statecode = default(int?), string subject = default(string), System.DateTimeOffset? postponeactivityprocessinguntil = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), decimal? exchangerate = default(decimal?), bool? isregularactivity = default(bool?), int? deliveryprioritycode = default(int?), int? actualdurationminutes = default(int?), string traversedpath = default(string), string activityid = default(string), string activitytypecode = default(string), string activityadditionalparams = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owneridValue = default(string), bool? leftvoicemail = default(bool?), int? statuscode = default(int?), System.DateTimeOffset? actualend = default(System.DateTimeOffset?), MicrosoftDynamicsCRMinteractionforemail regardingobjectidNewInteractionforemail = default(MicrosoftDynamicsCRMinteractionforemail), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecord = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMlead regardingobjectidLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebooking = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheader = default(MicrosoftDynamicsCRMbookableresourcebookingheader), IList<MicrosoftDynamicsCRMbulkoperation> activityPointerBulkOperation = default(IList<MicrosoftDynamicsCRMbulkoperation>), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperation = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMcampaign regardingobjectidCampaign = default(MicrosoftDynamicsCRMcampaign), IList<MicrosoftDynamicsCRMcampaignactivity> activityPointerCampaignactivity = default(IList<MicrosoftDynamicsCRMcampaignactivity>), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), IList<MicrosoftDynamicsCRMcampaignresponse> activityPointerCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMbulkoperationlog> activityPointerBulkOperationLogs = default(IList<MicrosoftDynamicsCRMbulkoperationlog>), IList<MicrosoftDynamicsCRMbulkoperationlog> createdActivityBulkOperationLogs = default(IList<MicrosoftDynamicsCRMbulkoperationlog>), IList<MicrosoftDynamicsCRMcampaignactivityitem> activityPointerCampaignActivityItems = default(IList<MicrosoftDynamicsCRMcampaignactivityitem>), IList<MicrosoftDynamicsCRMcampaignresponse> activityCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), MicrosoftDynamicsCRMcontract regardingobjectidContract = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlement = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplate = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMincident regardingobjectidIncident = default(MicrosoftDynamicsCRMincident), IList<MicrosoftDynamicsCRMincidentresolution> activityPointerIncidentResolution = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMserviceappointment> activityPointerServiceAppointment = default(IList<MicrosoftDynamicsCRMserviceappointment>), MicrosoftDynamicsCRMsite regardingobjectidSite = default(MicrosoftDynamicsCRMsite), MicrosoftDynamicsCRMservice serviceid = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMinvoice regardingobjectidInvoice = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunity = default(MicrosoftDynamicsCRMopportunity), IList<MicrosoftDynamicsCRMopportunityclose> activityPointerOpportunityClose = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> activityPointerOrderClose = default(IList<MicrosoftDynamicsCRMorderclose>), MicrosoftDynamicsCRMquote regardingobjectidQuote = default(MicrosoftDynamicsCRMquote), IList<MicrosoftDynamicsCRMquoteclose> activityPointerQuoteClose = default(IList<MicrosoftDynamicsCRMquoteclose>), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorder = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMmsdynPostalbum regardingobjectidMsdynPostalbum = default(MicrosoftDynamicsCRMmsdynPostalbum), MicrosoftDynamicsCRMssgSearchrequest regardingobjectidSsgSearchrequest = default(MicrosoftDynamicsCRMssgSearchrequest), MicrosoftDynamicsCRMssgIjssservicerequest regardingobjectidSsgIjssservicerequest = default(MicrosoftDynamicsCRMssgIjssservicerequest), MicrosoftDynamicsCRMssgIjsscase regardingobjectidSsgIjsscase = default(MicrosoftDynamicsCRMssgIjsscase), MicrosoftDynamicsCRMssgCsrsfile regardingobjectidSsgCsrsfile = default(MicrosoftDynamicsCRMssgCsrsfile), MicrosoftDynamicsCRMssgCsrsrecalculation regardingobjectidSsgCsrsrecalculation = default(MicrosoftDynamicsCRMssgCsrsrecalculation), MicrosoftDynamicsCRMafkWorkflowelementoption regardingobjectidAfkWorkflowelementoption = default(MicrosoftDynamicsCRMafkWorkflowelementoption), IList<MicrosoftDynamicsCRMafkWorkflowtask> activityPointerAfkWorkflowtask = default(IList<MicrosoftDynamicsCRMafkWorkflowtask>), MicrosoftDynamicsCRMssgRequestforinformationletter regardingobjectidSsgRequestforinformationletter = default(MicrosoftDynamicsCRMssgRequestforinformationletter), MicrosoftDynamicsCRMssgMspgroup regardingobjectidSsgMspgroup = default(MicrosoftDynamicsCRMssgMspgroup), MicrosoftDynamicsCRMaccount regardingobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcontact regardingobjectidContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMsocialactivity> activityPointerSocialactivity = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> activityPointerRecurringappointmentmaster = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMemail> activityPointerEmail = default(IList<MicrosoftDynamicsCRMemail>), MicrosoftDynamicsCRMmailbox sendermailboxid = default(MicrosoftDynamicsCRMmailbox), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMqueueitem> activityPointerQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsla slaActivitypointerSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMactivitymimeattachment> activityPointerActivityMimeAttachment = default(IList<MicrosoftDynamicsCRMactivitymimeattachment>), IList<MicrosoftDynamicsCRMfax> activityPointerFax = default(IList<MicrosoftDynamicsCRMfax>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMtask> activityPointerTask = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMphonecall> activityPointerPhonecall = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMappointment> activityPointerAppointment = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMletter> activityPointerLetter = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMconnection> activitypointerConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceActivitypointer = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMbulkdeletefailure> activityPointerBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsla slainvokedidActivitypointerSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMconnection> activitypointerConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMasyncoperation> activityPointerAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMrecurrencerule> activityPointerRecurrencerule = default(IList<MicrosoftDynamicsCRMrecurrencerule>), IList<MicrosoftDynamicsCRMactivityparty> activitypointerActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), decimal? budgetedcost = default(decimal?), bool? donotsendonoptout = default(bool?), bool? ignoreinactivelistmembers = default(bool?), int? importsequencenumber = default(int?), decimal? actualcostBase = default(decimal?), string category = default(string), int? channeltypecode = default(int?), int? typecode = default(int?), string subcategory = default(string), int? excludeifcontactedinxdays = default(int?), decimal? actualcost = default(decimal?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), decimal? budgetedcostBase = default(decimal?), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingCampaignactivity = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderCampaignactivity = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignCampaignactivity = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMsystemuser createdbyCampaignactivity = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMmailbox sendermailboxidCampaignactivity = default(MicrosoftDynamicsCRMmailbox), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidCampaignactivity = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMprincipal owneridCampaignactivity = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser owninguserCampaignactivity = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsla slaActivitypointerSlaCampaignactivity = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMbusinessunit owningbusinessunitCampaignactivity = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyCampaignactivity = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyCampaignactivity = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyCampaignactivity = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteamCampaignactivity = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsla slainvokedidActivitypointerSlaCampaignactivity = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), IList<MicrosoftDynamicsCRMactivityparty> campaignactivityActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMactivitypointer> campaignActivityActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMsyncerror> campaignActivitySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> campaignactivityActivityparties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMasyncoperation> campaignActivityAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> campaignActivityMailboxTrackingFolder = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> campaignActivityProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> campaignActivityBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> campaignactivityPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMappointment> campaignActivityAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> campaignActivityEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> campaignActivityFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> campaignActivityLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> campaignActivityPhonecalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> campaignActivityTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> campaignActivityRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> campaignactivitySocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMconnection> campaignactivityConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> campaignactivityConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMqueueitem> campaignActivityQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMannotation> campaignActivityAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), IList<MicrosoftDynamicsCRMcampaignresponse> campaignactivityCampaignResponses = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMbulkoperation> campaignActivityBulkOperations = default(IList<MicrosoftDynamicsCRMbulkoperation>), IList<MicrosoftDynamicsCRMlist> campaignactivitylistAssociation = default(IList<MicrosoftDynamicsCRMlist>), IList<MicrosoftDynamicsCRMincidentresolution> campaignactivityIncidentResolutions = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMserviceappointment> campaignactivityServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMopportunityclose> campaignactivityOpportunityCloses = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> campaignactivityOrderCloses = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMquoteclose> campaignactivityQuoteCloses = default(IList<MicrosoftDynamicsCRMquoteclose>), IList<MicrosoftDynamicsCRMsalesliterature> campaignactivitysalesliteratureAssociation = default(IList<MicrosoftDynamicsCRMsalesliterature>), IList<MicrosoftDynamicsCRMafkWorkflowtask> campaignactivityAfkWorkflowtasks = default(IList<MicrosoftDynamicsCRMafkWorkflowtask>))
            : base(lastonholdtime, _owningteamValue, exchangeitemid, ismapiprivate, createdon, seriesid, _regardingobjectidValue, deliverylastattemptedon, isbilled, isworkflowcreated, _sendermailboxidValue, scheduledend, description, onholdtime, _modifiedbyValue, community, sortdate, instancetypecode, timezoneruleversionnumber, _createdonbehalfbyValue, _createdbyValue, _transactioncurrencyidValue, versionnumber, processid, prioritycode, _serviceidValue, _slaidValue, stageid, actualstart, _owningbusinessunitValue, _owninguserValue, utcconversiontimezonecode, exchangeweblink, scheduleddurationminutes, senton, scheduledstart, _slainvokedidValue, statecode, subject, postponeactivityprocessinguntil, _modifiedonbehalfbyValue, exchangerate, isregularactivity, deliveryprioritycode, actualdurationminutes, traversedpath, activityid, activitytypecode, activityadditionalparams, modifiedon, _owneridValue, leftvoicemail, statuscode, actualend, regardingobjectidNewInteractionforemail, regardingobjectidKnowledgebaserecord, regardingobjectidLead, regardingobjectidBookableresourcebooking, regardingobjectidBookableresourcebookingheader, activityPointerBulkOperation, regardingobjectidBulkoperation, regardingobjectidCampaign, activityPointerCampaignactivity, regardingobjectidCampaignactivity, activityPointerCampaignresponse, activityPointerBulkOperationLogs, createdActivityBulkOperationLogs, activityPointerCampaignActivityItems, activityCampaignresponse, regardingobjectidContract, regardingobjectidEntitlement, regardingobjectidEntitlementtemplate, regardingobjectidIncident, activityPointerIncidentResolution, activityPointerServiceAppointment, regardingobjectidSite, serviceid, regardingobjectidInvoice, regardingobjectidOpportunity, activityPointerOpportunityClose, activityPointerOrderClose, regardingobjectidQuote, activityPointerQuoteClose, regardingobjectidSalesorder, regardingobjectidMsdynPostalbum, regardingobjectidSsgSearchrequest, regardingobjectidSsgIjssservicerequest, regardingobjectidSsgIjsscase, regardingobjectidSsgCsrsfile, regardingobjectidSsgCsrsrecalculation, regardingobjectidAfkWorkflowelementoption, activityPointerAfkWorkflowtask, regardingobjectidSsgRequestforinformationletter, regardingobjectidSsgMspgroup, regardingobjectidAccount, createdby, regardingobjectidContact, activityPointerSocialactivity, activityPointerRecurringappointmentmaster, activityPointerEmail, sendermailboxid, transactioncurrencyid, activityPointerQueueItem, ownerid, owninguser, slaActivitypointerSla, owningbusinessunit, regardingobjectidKnowledgearticle, modifiedonbehalfby, activityPointerActivityMimeAttachment, activityPointerFax, createdonbehalfby, modifiedby, activityPointerTask, activityPointerPhonecall, activityPointerAppointment, activityPointerLetter, activitypointerConnections2, slakpiinstanceActivitypointer, owningteam, activityPointerBulkDeleteFailures, slainvokedidActivitypointerSla, activitypointerConnections1, activityPointerAsyncOperations, activityPointerRecurrencerule, activitypointerActivityParties)
        {
            Budgetedcost = budgetedcost;
            Donotsendonoptout = donotsendonoptout;
            Ignoreinactivelistmembers = ignoreinactivelistmembers;
            Importsequencenumber = importsequencenumber;
            ActualcostBase = actualcostBase;
            Category = category;
            Channeltypecode = channeltypecode;
            Typecode = typecode;
            Subcategory = subcategory;
            Excludeifcontactedinxdays = excludeifcontactedinxdays;
            Actualcost = actualcost;
            Overriddencreatedon = overriddencreatedon;
            BudgetedcostBase = budgetedcostBase;
            RegardingobjectidBookableresourcebookingCampaignactivity = regardingobjectidBookableresourcebookingCampaignactivity;
            RegardingobjectidBookableresourcebookingheaderCampaignactivity = regardingobjectidBookableresourcebookingheaderCampaignactivity;
            RegardingobjectidCampaignCampaignactivity = regardingobjectidCampaignCampaignactivity;
            CreatedbyCampaignactivity = createdbyCampaignactivity;
            SendermailboxidCampaignactivity = sendermailboxidCampaignactivity;
            TransactioncurrencyidCampaignactivity = transactioncurrencyidCampaignactivity;
            OwneridCampaignactivity = owneridCampaignactivity;
            OwninguserCampaignactivity = owninguserCampaignactivity;
            SlaActivitypointerSlaCampaignactivity = slaActivitypointerSlaCampaignactivity;
            OwningbusinessunitCampaignactivity = owningbusinessunitCampaignactivity;
            ModifiedonbehalfbyCampaignactivity = modifiedonbehalfbyCampaignactivity;
            CreatedonbehalfbyCampaignactivity = createdonbehalfbyCampaignactivity;
            ModifiedbyCampaignactivity = modifiedbyCampaignactivity;
            OwningteamCampaignactivity = owningteamCampaignactivity;
            SlainvokedidActivitypointerSlaCampaignactivity = slainvokedidActivitypointerSlaCampaignactivity;
            ActivityidActivitypointer = activityidActivitypointer;
            CampaignactivityActivityParties = campaignactivityActivityParties;
            CampaignActivityActivityPointers = campaignActivityActivityPointers;
            CampaignActivitySyncErrors = campaignActivitySyncErrors;
            CampaignactivityActivityparties = campaignactivityActivityparties;
            CampaignActivityAsyncOperations = campaignActivityAsyncOperations;
            CampaignActivityMailboxTrackingFolder = campaignActivityMailboxTrackingFolder;
            CampaignActivityProcessSessions = campaignActivityProcessSessions;
            CampaignActivityBulkDeleteFailures = campaignActivityBulkDeleteFailures;
            CampaignactivityPrincipalobjectattributeaccess = campaignactivityPrincipalobjectattributeaccess;
            CampaignActivityAppointments = campaignActivityAppointments;
            CampaignActivityEmails = campaignActivityEmails;
            CampaignActivityFaxes = campaignActivityFaxes;
            CampaignActivityLetters = campaignActivityLetters;
            CampaignActivityPhonecalls = campaignActivityPhonecalls;
            CampaignActivityTasks = campaignActivityTasks;
            CampaignActivityRecurringAppointmentMasters = campaignActivityRecurringAppointmentMasters;
            CampaignactivitySocialActivities = campaignactivitySocialActivities;
            CampaignactivityConnections1 = campaignactivityConnections1;
            CampaignactivityConnections2 = campaignactivityConnections2;
            CampaignActivityQueueItem = campaignActivityQueueItem;
            CampaignActivityAnnotation = campaignActivityAnnotation;
            StageidProcessstage = stageidProcessstage;
            CampaignactivityCampaignResponses = campaignactivityCampaignResponses;
            CampaignActivityBulkOperations = campaignActivityBulkOperations;
            CampaignactivitylistAssociation = campaignactivitylistAssociation;
            CampaignactivityIncidentResolutions = campaignactivityIncidentResolutions;
            CampaignactivityServiceAppointments = campaignactivityServiceAppointments;
            CampaignactivityOpportunityCloses = campaignactivityOpportunityCloses;
            CampaignactivityOrderCloses = campaignactivityOrderCloses;
            CampaignactivityQuoteCloses = campaignactivityQuoteCloses;
            CampaignactivitysalesliteratureAssociation = campaignactivitysalesliteratureAssociation;
            CampaignactivityAfkWorkflowtasks = campaignactivityAfkWorkflowtasks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "budgetedcost")]
        public decimal? Budgetedcost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "donotsendonoptout")]
        public bool? Donotsendonoptout { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ignoreinactivelistmembers")]
        public bool? Ignoreinactivelistmembers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualcost_base")]
        public decimal? ActualcostBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "channeltypecode")]
        public int? Channeltypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "typecode")]
        public int? Typecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "excludeifcontactedinxdays")]
        public int? Excludeifcontactedinxdays { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actualcost")]
        public decimal? Actualcost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "budgetedcost_base")]
        public decimal? BudgetedcostBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_campaignactivity")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_campaignactivity")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_campaignactivity")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_campaignactivity")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sendermailboxid_campaignactivity")]
        public MicrosoftDynamicsCRMmailbox SendermailboxidCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_campaignactivity")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid_campaignactivity")]
        public MicrosoftDynamicsCRMprincipal OwneridCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_campaignactivity")]
        public MicrosoftDynamicsCRMsystemuser OwninguserCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_activitypointer_sla_campaignactivity")]
        public MicrosoftDynamicsCRMsla SlaActivitypointerSlaCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_campaignactivity")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_campaignactivity")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_campaignactivity")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_campaignactivity")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_campaignactivity")]
        public MicrosoftDynamicsCRMteam OwningteamCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_activitypointer_sla_campaignactivity")]
        public MicrosoftDynamicsCRMsla SlainvokedidActivitypointerSlaCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> CampaignactivityActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> CampaignActivityActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CampaignActivitySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_activityparties")]
        public IList<MicrosoftDynamicsCRMactivityparty> CampaignactivityActivityparties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CampaignActivityAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_MailboxTrackingFolder")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CampaignActivityMailboxTrackingFolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> CampaignActivityProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CampaignActivityBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CampaignactivityPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> CampaignActivityAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_Emails")]
        public IList<MicrosoftDynamicsCRMemail> CampaignActivityEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> CampaignActivityFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_Letters")]
        public IList<MicrosoftDynamicsCRMletter> CampaignActivityLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_Phonecalls")]
        public IList<MicrosoftDynamicsCRMphonecall> CampaignActivityPhonecalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> CampaignActivityTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> CampaignActivityRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> CampaignactivitySocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> CampaignactivityConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> CampaignactivityConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> CampaignActivityQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> CampaignActivityAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_CampaignResponses")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> CampaignactivityCampaignResponses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CampaignActivity_BulkOperations")]
        public IList<MicrosoftDynamicsCRMbulkoperation> CampaignActivityBulkOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivitylist_association")]
        public IList<MicrosoftDynamicsCRMlist> CampaignactivitylistAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_IncidentResolutions")]
        public IList<MicrosoftDynamicsCRMincidentresolution> CampaignactivityIncidentResolutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> CampaignactivityServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_OpportunityCloses")]
        public IList<MicrosoftDynamicsCRMopportunityclose> CampaignactivityOpportunityCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_OrderCloses")]
        public IList<MicrosoftDynamicsCRMorderclose> CampaignactivityOrderCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_QuoteCloses")]
        public IList<MicrosoftDynamicsCRMquoteclose> CampaignactivityQuoteCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivitysalesliterature_association")]
        public IList<MicrosoftDynamicsCRMsalesliterature> CampaignactivitysalesliteratureAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivity_afk_workflowtasks")]
        public IList<MicrosoftDynamicsCRMafkWorkflowtask> CampaignactivityAfkWorkflowtasks { get; set; }

    }
}
