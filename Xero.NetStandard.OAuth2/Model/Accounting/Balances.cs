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
    /// The raw AccountsReceivable(sales invoices) and AccountsPayable(bills) outstanding and overdue amounts, not converted to base currency (read only)
    /// </summary>
    [DataContract]
    public partial class Balances :  IEquatable<Balances>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets AccountsReceivable
        /// </summary>
        [DataMember(Name="AccountsReceivable", EmitDefaultValue=false)]
        public AccountsReceivable AccountsReceivable { get; set; }

        /// <summary>
        /// Gets or Sets AccountsPayable
        /// </summary>
        [DataMember(Name="AccountsPayable", EmitDefaultValue=false)]
        public AccountsPayable AccountsPayable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Balances {\n");
            sb.Append("  AccountsReceivable: ").Append(AccountsReceivable).Append("\n");
            sb.Append("  AccountsPayable: ").Append(AccountsPayable).Append("\n");
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
            return this.Equals(input as Balances);
        }

        /// <summary>
        /// Returns true if Balances instances are equal
        /// </summary>
        /// <param name="input">Instance of Balances to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Balances input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountsReceivable == input.AccountsReceivable ||
                    (this.AccountsReceivable != null &&
                    this.AccountsReceivable.Equals(input.AccountsReceivable))
                ) && 
                (
                    this.AccountsPayable == input.AccountsPayable ||
                    (this.AccountsPayable != null &&
                    this.AccountsPayable.Equals(input.AccountsPayable))
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
                if (this.AccountsReceivable != null)
                    hashCode = hashCode * 59 + this.AccountsReceivable.GetHashCode();
                if (this.AccountsPayable != null)
                    hashCode = hashCode * 59 + this.AccountsPayable.GetHashCode();
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
