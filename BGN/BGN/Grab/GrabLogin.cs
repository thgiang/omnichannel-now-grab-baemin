using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BNG.Grab
{
     public partial class GrabLogin
    {
        [JsonProperty("data")]
        public GrabLoginData Data { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }
    }

    public partial class GrabLoginData
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("data")]
        public DataData Data { get; set; }

        [JsonProperty("request_id")]
        public object RequestId { get; set; }

        [JsonProperty("block_minutes")]
        public object BlockMinutes { get; set; }

        [JsonProperty("block_time")]
        public object BlockTime { get; set; }
    }

    public partial class DataData
    {
        [JsonProperty("jwt")]
        public string Jwt { get; set; }

        [JsonProperty("user_profile_data")]
        public string UserProfileData { get; set; }

        [JsonProperty("enable_tc")]
        public bool EnableTc { get; set; }

        [JsonProperty("user_type")]
        public long UserType { get; set; }

        [JsonProperty("user_profile")]
        public UserProfile UserProfile { get; set; }

        [JsonProperty("business_line_ids")]
        public string[] BusinessLineIds { get; set; }

        [JsonProperty("regd_country_id")]
        public long RegdCountryId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("consent")]
        public Consent Consent { get; set; }

        [JsonProperty("analytics_id")]
        public string AnalyticsId { get; set; }

        [JsonProperty("config")]
        public Config Config { get; set; }
    }

    public partial class Config
    {
        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public partial class Consent
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("grab_id")]
        public string GrabId { get; set; }

        [JsonProperty("consent")]
        public bool ConsentConsent { get; set; }

        [JsonProperty("consent_accepted_by")]
        public string ConsentAcceptedBy { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public DateTimeOffset DeletedAt { get; set; }

        [JsonProperty("ovo_consent")]
        public bool OvoConsent { get; set; }

        [JsonProperty("ovo_consent_accepted_by")]
        public string OvoConsentAcceptedBy { get; set; }

        [JsonProperty("otp_count")]
        public long OtpCount { get; set; }

        [JsonProperty("otp_threshold_exceed")]
        public bool OtpThresholdExceed { get; set; }

        [JsonProperty("verify_otp_count")]
        public long VerifyOtpCount { get; set; }

        [JsonProperty("verify_otp_threshold_exceed")]
        public bool VerifyOtpThresholdExceed { get; set; }

        [JsonProperty("block_minutes")]
        public object BlockMinutes { get; set; }

        [JsonProperty("block_time")]
        public object BlockTime { get; set; }
    }

    public partial class UserProfile
    {
        [JsonProperty("service_id")]
        public double ServiceId { get; set; }

        [JsonProperty("grab_id")]
        public Guid GrabId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("mobile_number")]
        public object MobileNumber { get; set; }

        [JsonProperty("correspondence_email")]
        public string CorrespondenceEmail { get; set; }

        [JsonProperty("verification_status")]
        public bool VerificationStatus { get; set; }

        [JsonProperty("profile_status")]
        public string ProfileStatus { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("agent")]
        public string Agent { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("country")]
        public long Country { get; set; }

        [JsonProperty("mcc")]
        public object Mcc { get; set; }

        [JsonProperty("links")]
        public Link[] Links { get; set; }

        [JsonProperty("user_profile_details")]
        public UserProfileDetails UserProfileDetails { get; set; }

        [JsonProperty("last_login_at")]
        public DateTimeOffset LastLoginAt { get; set; }

        [JsonProperty("last_password_change_at")]
        public object LastPasswordChangeAt { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("grab_food_entity_id")]
        public string GrabFoodEntityId { get; set; }

        [JsonProperty("parent_entity_id")]
        public Guid ParentEntityId { get; set; }

        [JsonProperty("parent_entity_type")]
        public long ParentEntityType { get; set; }

        [JsonProperty("parent_entity_country")]
        public string ParentEntityCountry { get; set; }

        [JsonProperty("switch_store_at")]
        public object SwitchStoreAt { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public object DeletedAt { get; set; }
    }

    public partial class Link
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("user_profile_service_id")]
        public double UserProfileServiceId { get; set; }

        [JsonProperty("user_profile_grab_id")]
        public Guid UserProfileGrabId { get; set; }

        [JsonProperty("link_entity_business_line")]
        public string LinkEntityBusinessLine { get; set; }

        [JsonProperty("link_entity_id")]
        public string LinkEntityId { get; set; }

        [JsonProperty("link_entity_type")]
        public string LinkEntityType { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public object DeletedAt { get; set; }
    }

    public partial class UserProfileDetails
    {
        [JsonProperty("service_id")]
        public double ServiceId { get; set; }

        [JsonProperty("grab_id")]
        public Guid GrabId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("job_title")]
        public object JobTitle { get; set; }

        [JsonProperty("physical_store")]
        public object PhysicalStore { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public object DeletedAt { get; set; }
    }
}
