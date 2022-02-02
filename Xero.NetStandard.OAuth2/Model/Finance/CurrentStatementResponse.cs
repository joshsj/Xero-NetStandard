/* 
 * Xero Finance API
 *
 * The Finance API is a collection of endpoints which customers can use in the course of a loan application, which may assist lenders to gain the confidence they need to provide capital.
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

namespace Xero.NetStandard.OAuth2.Model.Finance
{
    /// <summary>
    /// CurrentStatementResponse
    /// </summary>
    [DataContract]
    public partial class CurrentStatementResponse :  IEquatable<CurrentStatementResponse>, IValidatableObject
    {
        
        /// <summary>
        /// Looking at the most recent bank statement, this field indicates the first date which transactions on this statement pertain to. This date is represented in ISO 8601 format.
        /// </summary>
        /// <value>Looking at the most recent bank statement, this field indicates the first date which transactions on this statement pertain to. This date is represented in ISO 8601 format.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Looking at the most recent bank statement, this field indicates the last date which transactions on this statement pertain to. This date is represented in ISO 8601 format.
        /// </summary>
        /// <value>Looking at the most recent bank statement, this field indicates the last date which transactions on this statement pertain to. This date is represented in ISO 8601 format.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Looking at the most recent bank statement, this field indicates the balance before the transactions on the statement are applied (note, this is not always populated by the bank in every single instance (~10%)).
        /// </summary>
        /// <value>Looking at the most recent bank statement, this field indicates the balance before the transactions on the statement are applied (note, this is not always populated by the bank in every single instance (~10%)).</value>
        [DataMember(Name="startBalance", EmitDefaultValue=false)]
        public decimal? StartBalance { get; set; }

        /// <summary>
        /// Looking at the most recent bank statement, this field indicates the balance after the transactions on the statement are applied (note, this is not always populated by the bank in every single instance (~10%)).
        /// </summary>
        /// <value>Looking at the most recent bank statement, this field indicates the balance after the transactions on the statement are applied (note, this is not always populated by the bank in every single instance (~10%)).</value>
        [DataMember(Name="endBalance", EmitDefaultValue=false)]
        public decimal? EndBalance { get; set; }

        /// <summary>
        /// Looking at the most recent bank statement, this field indicates when the document was imported into Xero.  This date is represented in ISO 8601 format.
        /// </summary>
        /// <value>Looking at the most recent bank statement, this field indicates when the document was imported into Xero.  This date is represented in ISO 8601 format.</value>
        [DataMember(Name="importedDateTimeUtc", EmitDefaultValue=false)]
        public DateTime? ImportedDateTimeUtc { get; set; }

        /// <summary>
        /// Looking at the most recent bank statement, this field indicates the source of the data (direct bank feed, indirect bank feed, file upload, or manual keying).
        /// </summary>
        /// <value>Looking at the most recent bank statement, this field indicates the source of the data (direct bank feed, indirect bank feed, file upload, or manual keying).</value>
        [DataMember(Name="importSourceType", EmitDefaultValue=false)]
        public string ImportSourceType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrentStatementResponse {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  StartBalance: ").Append(StartBalance).Append("\n");
            sb.Append("  EndBalance: ").Append(EndBalance).Append("\n");
            sb.Append("  ImportedDateTimeUtc: ").Append(ImportedDateTimeUtc).Append("\n");
            sb.Append("  ImportSourceType: ").Append(ImportSourceType).Append("\n");
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
            return this.Equals(input as CurrentStatementResponse);
        }

        /// <summary>
        /// Returns true if CurrentStatementResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrentStatementResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrentStatementResponse input)
        {
            if (input == null)
                return false;

            return 
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
                    this.StartBalance == input.StartBalance ||
                    (this.StartBalance != null &&
                    this.StartBalance.Equals(input.StartBalance))
                ) && 
                (
                    this.EndBalance == input.EndBalance ||
                    (this.EndBalance != null &&
                    this.EndBalance.Equals(input.EndBalance))
                ) && 
                (
                    this.ImportedDateTimeUtc == input.ImportedDateTimeUtc ||
                    (this.ImportedDateTimeUtc != null &&
                    this.ImportedDateTimeUtc.Equals(input.ImportedDateTimeUtc))
                ) && 
                (
                    this.ImportSourceType == input.ImportSourceType ||
                    (this.ImportSourceType != null &&
                    this.ImportSourceType.Equals(input.ImportSourceType))
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.StartBalance != null)
                    hashCode = hashCode * 59 + this.StartBalance.GetHashCode();
                if (this.EndBalance != null)
                    hashCode = hashCode * 59 + this.EndBalance.GetHashCode();
                if (this.ImportedDateTimeUtc != null)
                    hashCode = hashCode * 59 + this.ImportedDateTimeUtc.GetHashCode();
                if (this.ImportSourceType != null)
                    hashCode = hashCode * 59 + this.ImportSourceType.GetHashCode();
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