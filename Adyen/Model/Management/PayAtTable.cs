/*
* Management API
*
*
* The version of the OpenAPI document: 1
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = HeadOn.Classic.Adyen.ApiSerialization.OpenAPIDateConverter;

namespace HeadOn.Classic.Adyen.Model.Management
{
    /// <summary>
    /// PayAtTable
    /// </summary>
    [DataContract(Name = "PayAtTable")]
    public partial class PayAtTable : IEquatable<PayAtTable>, IValidatableObject
    {
        /// <summary>
        /// Allowed authentication methods: Magswipe, Manual Entry.
        /// </summary>
        /// <value>Allowed authentication methods: Magswipe, Manual Entry.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationMethodEnum
        {
            /// <summary>
            /// Enum MAGSWIPE for value: MAGSWIPE
            /// </summary>
            [EnumMember(Value = "MAGSWIPE")]
            MAGSWIPE = 1,

            /// <summary>
            /// Enum MKE for value: MKE
            /// </summary>
            [EnumMember(Value = "MKE")]
            MKE = 2

        }


        /// <summary>
        /// Allowed authentication methods: Magswipe, Manual Entry.
        /// </summary>
        /// <value>Allowed authentication methods: Magswipe, Manual Entry.</value>
        [DataMember(Name = "authenticationMethod", EmitDefaultValue = false)]
        public AuthenticationMethodEnum? AuthenticationMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayAtTable" /> class.
        /// </summary>
        /// <param name="authenticationMethod">Allowed authentication methods: Magswipe, Manual Entry..</param>
        /// <param name="enablePayAtTable">Enable Pay at table..</param>
        public PayAtTable(AuthenticationMethodEnum? authenticationMethod = default(AuthenticationMethodEnum?), bool enablePayAtTable = default(bool))
        {
            this.AuthenticationMethod = authenticationMethod;
            this.EnablePayAtTable = enablePayAtTable;
        }

        /// <summary>
        /// Enable Pay at table.
        /// </summary>
        /// <value>Enable Pay at table.</value>
        [DataMember(Name = "enablePayAtTable", EmitDefaultValue = false)]
        public bool EnablePayAtTable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PayAtTable {\n");
            sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
            sb.Append("  EnablePayAtTable: ").Append(EnablePayAtTable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PayAtTable);
        }

        /// <summary>
        /// Returns true if PayAtTable instances are equal
        /// </summary>
        /// <param name="input">Instance of PayAtTable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayAtTable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthenticationMethod == input.AuthenticationMethod ||
                    this.AuthenticationMethod.Equals(input.AuthenticationMethod)
                ) && 
                (
                    this.EnablePayAtTable == input.EnablePayAtTable ||
                    this.EnablePayAtTable.Equals(input.EnablePayAtTable)
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
                hashCode = (hashCode * 59) + this.AuthenticationMethod.GetHashCode();
                hashCode = (hashCode * 59) + this.EnablePayAtTable.GetHashCode();
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
