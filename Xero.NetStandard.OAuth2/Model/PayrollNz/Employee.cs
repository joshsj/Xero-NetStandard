/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
 *
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.PayrollNz
{
    /// <summary>
    /// Employee
    /// </summary>
    [DataContract]
    public partial class Employee :  IEquatable<Employee>, IValidatableObject
    {
        /// <summary>
        /// The employee’s gender
        /// </summary>
        /// <value>The employee’s gender</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum GenderEnum
        {
            /// <summary>
            /// Enum M for value: M
            /// </summary>
            [EnumMember(Value = "M")]
            M = 1,

            /// <summary>
            /// Enum F for value: F
            /// </summary>
            [EnumMember(Value = "F")]
            F = 2

        }

        /// <summary>
        /// The employee’s gender
        /// </summary>
        /// <value>The employee’s gender</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public GenderEnum Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Employee() 
        { 
        }
        
        /// <summary>
        /// Xero unique identifier for the employee
        /// </summary>
        /// <value>Xero unique identifier for the employee</value>
        [DataMember(Name="employeeID", EmitDefaultValue=false)]
        public Guid? EmployeeID { get; set; }

        /// <summary>
        /// Title of the employee
        /// </summary>
        /// <value>Title of the employee</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// First name of employee
        /// </summary>
        /// <value>First name of employee</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of employee
        /// </summary>
        /// <value>Last name of employee</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Date of birth of the employee (YYYY-MM-DD)
        /// </summary>
        /// <value>Date of birth of the employee (YYYY-MM-DD)</value>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public Address Address { get; set; }

        /// <summary>
        /// The email address for the employee
        /// </summary>
        /// <value>The email address for the employee</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Employee phone number
        /// </summary>
        /// <value>Employee phone number</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Employment start date of the employee at the time it was requested
        /// </summary>
        /// <value>Employment start date of the employee at the time it was requested</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Employment end date of the employee at the time it was requested
        /// </summary>
        /// <value>Employment end date of the employee at the time it was requested</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Xero unique identifier for the payroll calendar of the employee
        /// </summary>
        /// <value>Xero unique identifier for the payroll calendar of the employee</value>
        [DataMember(Name="payrollCalendarID", EmitDefaultValue=false)]
        public Guid? PayrollCalendarID { get; set; }

        /// <summary>
        /// UTC timestamp of last update to the employee
        /// </summary>
        /// <value>UTC timestamp of last update to the employee</value>
        [DataMember(Name="updatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; set; }

        /// <summary>
        /// UTC timestamp when the employee was created in Xero
        /// </summary>
        /// <value>UTC timestamp when the employee was created in Xero</value>
        [DataMember(Name="createdDateUTC", EmitDefaultValue=false)]
        public DateTime? CreatedDateUTC { get; set; }

        /// <summary>
        /// Employee&#39;s job title
        /// </summary>
        /// <value>Employee&#39;s job title</value>
        [DataMember(Name="jobTitle", EmitDefaultValue=false)]
        public string JobTitle { get; set; }

        /// <summary>
        /// Engagement type of the employee
        /// </summary>
        /// <value>Engagement type of the employee</value>
        [DataMember(Name="engagementType", EmitDefaultValue=false)]
        public string EngagementType { get; set; }

        /// <summary>
        /// End date for an employee with a fixed-term engagement type
        /// </summary>
        /// <value>End date for an employee with a fixed-term engagement type</value>
        [DataMember(Name="fixedTermEndDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? FixedTermEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Employee {\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  PayrollCalendarID: ").Append(PayrollCalendarID).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  CreatedDateUTC: ").Append(CreatedDateUTC).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  EngagementType: ").Append(EngagementType).Append("\n");
            sb.Append("  FixedTermEndDate: ").Append(FixedTermEndDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Employee);
        }

        /// <summary>
        /// Returns true if Employee instances are equal
        /// </summary>
        /// <param name="input">Instance of Employee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Employee input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmployeeID == input.EmployeeID ||
                    (this.EmployeeID != null &&
                    this.EmployeeID.Equals(input.EmployeeID))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Gender == input.Gender ||
                    this.Gender.Equals(input.Gender)
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.PayrollCalendarID == input.PayrollCalendarID ||
                    (this.PayrollCalendarID != null &&
                    this.PayrollCalendarID.Equals(input.PayrollCalendarID))
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.CreatedDateUTC == input.CreatedDateUTC ||
                    (this.CreatedDateUTC != null &&
                    this.CreatedDateUTC.Equals(input.CreatedDateUTC))
                ) && 
                (
                    this.JobTitle == input.JobTitle ||
                    (this.JobTitle != null &&
                    this.JobTitle.Equals(input.JobTitle))
                ) && 
                (
                    this.EngagementType == input.EngagementType ||
                    (this.EngagementType != null &&
                    this.EngagementType.Equals(input.EngagementType))
                ) && 
                (
                    this.FixedTermEndDate == input.FixedTermEndDate ||
                    (this.FixedTermEndDate != null &&
                    this.FixedTermEndDate.Equals(input.FixedTermEndDate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.EmployeeID != null)
                    hashCode = hashCode * 59 + this.EmployeeID.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.PayrollCalendarID != null)
                    hashCode = hashCode * 59 + this.PayrollCalendarID.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.CreatedDateUTC != null)
                    hashCode = hashCode * 59 + this.CreatedDateUTC.GetHashCode();
                if (this.JobTitle != null)
                    hashCode = hashCode * 59 + this.JobTitle.GetHashCode();
                if (this.EngagementType != null)
                    hashCode = hashCode * 59 + this.EngagementType.GetHashCode();
                if (this.FixedTermEndDate != null)
                    hashCode = hashCode * 59 + this.FixedTermEndDate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
