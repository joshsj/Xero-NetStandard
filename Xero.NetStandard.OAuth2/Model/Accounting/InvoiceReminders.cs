/* 
 * Xero Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// InvoiceReminders
    /// </summary>
    [DataContract]
    public partial class InvoiceReminders :  IEquatable<InvoiceReminders>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets _InvoiceReminders
        /// </summary>
        [DataMember(Name="InvoiceReminders", EmitDefaultValue=false)]
        public List<InvoiceReminder> _InvoiceReminders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceReminders {\n");
            sb.Append("  _InvoiceReminders: ").Append(_InvoiceReminders).Append("\n");
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
            return this.Equals(input as InvoiceReminders);
        }

        /// <summary>
        /// Returns true if InvoiceReminders instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceReminders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceReminders input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._InvoiceReminders == input._InvoiceReminders ||
                    this._InvoiceReminders != null &&
                    input._InvoiceReminders != null &&
                    this._InvoiceReminders.SequenceEqual(input._InvoiceReminders)
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
                if (this._InvoiceReminders != null)
                    hashCode = hashCode * 59 + this._InvoiceReminders.GetHashCode();
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
