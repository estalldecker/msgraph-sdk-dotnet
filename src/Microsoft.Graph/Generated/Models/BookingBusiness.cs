using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Represents a Microsot Bookings Business.
    /// </summary>
    public class BookingBusiness : Entity, IParsable {
        /// <summary>The street address of the business. The address property, together with phone and webSiteUrl, appear in the footer of a business scheduling page. The attribute type of physicalAddress is not supported in v1.0. Internally we map the addresses to the type others.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PhysicalAddress? Address {
            get { return BackingStore?.Get<PhysicalAddress?>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#nullable restore
#else
        public PhysicalAddress Address {
            get { return BackingStore?.Get<PhysicalAddress>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#endif
        /// <summary>All the appointments of this business. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingAppointment>? Appointments {
            get { return BackingStore?.Get<List<BookingAppointment>?>("appointments"); }
            set { BackingStore?.Set("appointments", value); }
        }
#nullable restore
#else
        public List<BookingAppointment> Appointments {
            get { return BackingStore?.Get<List<BookingAppointment>>("appointments"); }
            set { BackingStore?.Set("appointments", value); }
        }
#endif
        /// <summary>The hours of operation for the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingWorkHours>? BusinessHours {
            get { return BackingStore?.Get<List<BookingWorkHours>?>("businessHours"); }
            set { BackingStore?.Set("businessHours", value); }
        }
#nullable restore
#else
        public List<BookingWorkHours> BusinessHours {
            get { return BackingStore?.Get<List<BookingWorkHours>>("businessHours"); }
            set { BackingStore?.Set("businessHours", value); }
        }
#endif
        /// <summary>The type of business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessType {
            get { return BackingStore?.Get<string?>("businessType"); }
            set { BackingStore?.Set("businessType", value); }
        }
#nullable restore
#else
        public string BusinessType {
            get { return BackingStore?.Get<string>("businessType"); }
            set { BackingStore?.Set("businessType", value); }
        }
#endif
        /// <summary>The set of appointments of this business in a specified date range. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingAppointment>? CalendarView {
            get { return BackingStore?.Get<List<BookingAppointment>?>("calendarView"); }
            set { BackingStore?.Set("calendarView", value); }
        }
#nullable restore
#else
        public List<BookingAppointment> CalendarView {
            get { return BackingStore?.Get<List<BookingAppointment>>("calendarView"); }
            set { BackingStore?.Set("calendarView", value); }
        }
#endif
        /// <summary>All the customers of this business. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingCustomerBase>? Customers {
            get { return BackingStore?.Get<List<BookingCustomerBase>?>("customers"); }
            set { BackingStore?.Set("customers", value); }
        }
#nullable restore
#else
        public List<BookingCustomerBase> Customers {
            get { return BackingStore?.Get<List<BookingCustomerBase>>("customers"); }
            set { BackingStore?.Set("customers", value); }
        }
#endif
        /// <summary>All the custom questions of this business. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingCustomQuestion>? CustomQuestions {
            get { return BackingStore?.Get<List<BookingCustomQuestion>?>("customQuestions"); }
            set { BackingStore?.Set("customQuestions", value); }
        }
#nullable restore
#else
        public List<BookingCustomQuestion> CustomQuestions {
            get { return BackingStore?.Get<List<BookingCustomQuestion>>("customQuestions"); }
            set { BackingStore?.Set("customQuestions", value); }
        }
#endif
        /// <summary>The code for the currency that the business operates in on Microsoft Bookings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultCurrencyIso {
            get { return BackingStore?.Get<string?>("defaultCurrencyIso"); }
            set { BackingStore?.Set("defaultCurrencyIso", value); }
        }
#nullable restore
#else
        public string DefaultCurrencyIso {
            get { return BackingStore?.Get<string>("defaultCurrencyIso"); }
            set { BackingStore?.Set("defaultCurrencyIso", value); }
        }
#endif
        /// <summary>The name of the business, which interfaces with customers. This name appears at the top of the business scheduling page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The email address for the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>The scheduling page has been made available to external customers. Use the publish and unpublish actions to set this property. Read-only.</summary>
        public bool? IsPublished {
            get { return BackingStore?.Get<bool?>("isPublished"); }
            set { BackingStore?.Set("isPublished", value); }
        }
        /// <summary>The language of the self-service booking page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LanguageTag {
            get { return BackingStore?.Get<string?>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
#nullable restore
#else
        public string LanguageTag {
            get { return BackingStore?.Get<string>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
#endif
        /// <summary>The telephone number for the business. The phone property, together with address and webSiteUrl, appear in the footer of a business scheduling page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone {
            get { return BackingStore?.Get<string?>("phone"); }
            set { BackingStore?.Set("phone", value); }
        }
#nullable restore
#else
        public string Phone {
            get { return BackingStore?.Get<string>("phone"); }
            set { BackingStore?.Set("phone", value); }
        }
#endif
        /// <summary>The URL for the scheduling page, which is set after you publish or unpublish the page. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublicUrl {
            get { return BackingStore?.Get<string?>("publicUrl"); }
            set { BackingStore?.Set("publicUrl", value); }
        }
#nullable restore
#else
        public string PublicUrl {
            get { return BackingStore?.Get<string>("publicUrl"); }
            set { BackingStore?.Set("publicUrl", value); }
        }
#endif
        /// <summary>Specifies how bookings can be created for this business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BookingSchedulingPolicy? SchedulingPolicy {
            get { return BackingStore?.Get<BookingSchedulingPolicy?>("schedulingPolicy"); }
            set { BackingStore?.Set("schedulingPolicy", value); }
        }
#nullable restore
#else
        public BookingSchedulingPolicy SchedulingPolicy {
            get { return BackingStore?.Get<BookingSchedulingPolicy>("schedulingPolicy"); }
            set { BackingStore?.Set("schedulingPolicy", value); }
        }
#endif
        /// <summary>All the services offered by this business. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingService>? Services {
            get { return BackingStore?.Get<List<BookingService>?>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#nullable restore
#else
        public List<BookingService> Services {
            get { return BackingStore?.Get<List<BookingService>>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#endif
        /// <summary>All the staff members that provide services in this business. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingStaffMemberBase>? StaffMembers {
            get { return BackingStore?.Get<List<BookingStaffMemberBase>?>("staffMembers"); }
            set { BackingStore?.Set("staffMembers", value); }
        }
#nullable restore
#else
        public List<BookingStaffMemberBase> StaffMembers {
            get { return BackingStore?.Get<List<BookingStaffMemberBase>>("staffMembers"); }
            set { BackingStore?.Set("staffMembers", value); }
        }
#endif
        /// <summary>The URL of the business web site. The webSiteUrl property, together with address, phone, appear in the footer of a business scheduling page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebSiteUrl {
            get { return BackingStore?.Get<string?>("webSiteUrl"); }
            set { BackingStore?.Set("webSiteUrl", value); }
        }
#nullable restore
#else
        public string WebSiteUrl {
            get { return BackingStore?.Get<string>("webSiteUrl"); }
            set { BackingStore?.Set("webSiteUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BookingBusiness CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingBusiness();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"address", n => { Address = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"appointments", n => { Appointments = n.GetCollectionOfObjectValues<BookingAppointment>(BookingAppointment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"businessHours", n => { BusinessHours = n.GetCollectionOfObjectValues<BookingWorkHours>(BookingWorkHours.CreateFromDiscriminatorValue)?.ToList(); } },
                {"businessType", n => { BusinessType = n.GetStringValue(); } },
                {"calendarView", n => { CalendarView = n.GetCollectionOfObjectValues<BookingAppointment>(BookingAppointment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customers", n => { Customers = n.GetCollectionOfObjectValues<BookingCustomerBase>(BookingCustomerBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customQuestions", n => { CustomQuestions = n.GetCollectionOfObjectValues<BookingCustomQuestion>(BookingCustomQuestion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"defaultCurrencyIso", n => { DefaultCurrencyIso = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"isPublished", n => { IsPublished = n.GetBoolValue(); } },
                {"languageTag", n => { LanguageTag = n.GetStringValue(); } },
                {"phone", n => { Phone = n.GetStringValue(); } },
                {"publicUrl", n => { PublicUrl = n.GetStringValue(); } },
                {"schedulingPolicy", n => { SchedulingPolicy = n.GetObjectValue<BookingSchedulingPolicy>(BookingSchedulingPolicy.CreateFromDiscriminatorValue); } },
                {"services", n => { Services = n.GetCollectionOfObjectValues<BookingService>(BookingService.CreateFromDiscriminatorValue)?.ToList(); } },
                {"staffMembers", n => { StaffMembers = n.GetCollectionOfObjectValues<BookingStaffMemberBase>(BookingStaffMemberBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"webSiteUrl", n => { WebSiteUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PhysicalAddress>("address", Address);
            writer.WriteCollectionOfObjectValues<BookingAppointment>("appointments", Appointments);
            writer.WriteCollectionOfObjectValues<BookingWorkHours>("businessHours", BusinessHours);
            writer.WriteStringValue("businessType", BusinessType);
            writer.WriteCollectionOfObjectValues<BookingAppointment>("calendarView", CalendarView);
            writer.WriteCollectionOfObjectValues<BookingCustomerBase>("customers", Customers);
            writer.WriteCollectionOfObjectValues<BookingCustomQuestion>("customQuestions", CustomQuestions);
            writer.WriteStringValue("defaultCurrencyIso", DefaultCurrencyIso);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteStringValue("phone", Phone);
            writer.WriteObjectValue<BookingSchedulingPolicy>("schedulingPolicy", SchedulingPolicy);
            writer.WriteCollectionOfObjectValues<BookingService>("services", Services);
            writer.WriteCollectionOfObjectValues<BookingStaffMemberBase>("staffMembers", StaffMembers);
            writer.WriteStringValue("webSiteUrl", WebSiteUrl);
        }
    }
}
