/* 
 * Xero Payroll AU API
 *
 * This is the Xero Payroll API for orgs in Australia region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// LeaveApplications
    /// </summary>
    [DataContract]
    public partial class LeaveApplications :  IEquatable<LeaveApplications>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets _LeaveApplications
        /// </summary>
        [DataMember(Name="LeaveApplications", EmitDefaultValue=false)]
        public List<LeaveApplication> _LeaveApplications { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeaveApplications {\n");
            sb.Append("  _LeaveApplications: ").Append(_LeaveApplications).Append("\n");
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
            return this.Equals(input as LeaveApplications);
        }

        /// <summary>
        /// Returns true if LeaveApplications instances are equal
        /// </summary>
        /// <param name="input">Instance of LeaveApplications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeaveApplications input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._LeaveApplications == input._LeaveApplications ||
                    this._LeaveApplications != null &&
                    input._LeaveApplications != null &&
                    this._LeaveApplications.SequenceEqual(input._LeaveApplications)
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
                if (this._LeaveApplications != null)
                    hashCode = hashCode * 59 + this._LeaveApplications.GetHashCode();
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
