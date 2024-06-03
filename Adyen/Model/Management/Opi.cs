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
    /// Opi
    /// </summary>
    [DataContract(Name = "Opi")]
    public partial class Opi : IEquatable<Opi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Opi" /> class.
        /// </summary>
        /// <param name="enablePayAtTable">Indicates if Pay at table is enabled..</param>
        /// <param name="payAtTableStoreNumber">The store number to use for Pay at Table..</param>
        /// <param name="payAtTableURL">The URL and port number used for Pay at Table communication..</param>
        public Opi(bool enablePayAtTable = default(bool), string payAtTableStoreNumber = default(string), string payAtTableURL = default(string))
        {
            this.EnablePayAtTable = enablePayAtTable;
            this.PayAtTableStoreNumber = payAtTableStoreNumber;
            this.PayAtTableURL = payAtTableURL;
        }

        /// <summary>
        /// Indicates if Pay at table is enabled.
        /// </summary>
        /// <value>Indicates if Pay at table is enabled.</value>
        [DataMember(Name = "enablePayAtTable", EmitDefaultValue = false)]
        public bool EnablePayAtTable { get; set; }

        /// <summary>
        /// The store number to use for Pay at Table.
        /// </summary>
        /// <value>The store number to use for Pay at Table.</value>
        [DataMember(Name = "payAtTableStoreNumber", EmitDefaultValue = false)]
        public string PayAtTableStoreNumber { get; set; }

        /// <summary>
        /// The URL and port number used for Pay at Table communication.
        /// </summary>
        /// <value>The URL and port number used for Pay at Table communication.</value>
        [DataMember(Name = "payAtTableURL", EmitDefaultValue = false)]
        public string PayAtTableURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Opi {\n");
            sb.Append("  EnablePayAtTable: ").Append(EnablePayAtTable).Append("\n");
            sb.Append("  PayAtTableStoreNumber: ").Append(PayAtTableStoreNumber).Append("\n");
            sb.Append("  PayAtTableURL: ").Append(PayAtTableURL).Append("\n");
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
            return this.Equals(input as Opi);
        }

        /// <summary>
        /// Returns true if Opi instances are equal
        /// </summary>
        /// <param name="input">Instance of Opi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Opi input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EnablePayAtTable == input.EnablePayAtTable ||
                    this.EnablePayAtTable.Equals(input.EnablePayAtTable)
                ) && 
                (
                    this.PayAtTableStoreNumber == input.PayAtTableStoreNumber ||
                    (this.PayAtTableStoreNumber != null &&
                    this.PayAtTableStoreNumber.Equals(input.PayAtTableStoreNumber))
                ) && 
                (
                    this.PayAtTableURL == input.PayAtTableURL ||
                    (this.PayAtTableURL != null &&
                    this.PayAtTableURL.Equals(input.PayAtTableURL))
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
                hashCode = (hashCode * 59) + this.EnablePayAtTable.GetHashCode();
                if (this.PayAtTableStoreNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PayAtTableStoreNumber.GetHashCode();
                }
                if (this.PayAtTableURL != null)
                {
                    hashCode = (hashCode * 59) + this.PayAtTableURL.GetHashCode();
                }
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
