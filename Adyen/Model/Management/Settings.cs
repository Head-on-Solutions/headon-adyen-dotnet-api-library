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
    /// Settings
    /// </summary>
    [DataContract(Name = "Settings")]
    public partial class Settings : IEquatable<Settings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        /// <param name="band">The preferred Wi-Fi band, for use if the terminals support multiple bands. Possible values: All, 2.4GHz, 5GHz..</param>
        /// <param name="roaming">Indicates whether roaming is enabled on the terminals..</param>
        /// <param name="timeout">The connection time-out in seconds. Minimum value: 0..</param>
        public Settings(string band = default(string), bool roaming = default(bool), int? timeout = default(int?))
        {
            this.Band = band;
            this.Roaming = roaming;
            this.Timeout = timeout;
        }

        /// <summary>
        /// The preferred Wi-Fi band, for use if the terminals support multiple bands. Possible values: All, 2.4GHz, 5GHz.
        /// </summary>
        /// <value>The preferred Wi-Fi band, for use if the terminals support multiple bands. Possible values: All, 2.4GHz, 5GHz.</value>
        [DataMember(Name = "band", EmitDefaultValue = false)]
        public string Band { get; set; }

        /// <summary>
        /// Indicates whether roaming is enabled on the terminals.
        /// </summary>
        /// <value>Indicates whether roaming is enabled on the terminals.</value>
        [DataMember(Name = "roaming", EmitDefaultValue = false)]
        public bool Roaming { get; set; }

        /// <summary>
        /// The connection time-out in seconds. Minimum value: 0.
        /// </summary>
        /// <value>The connection time-out in seconds. Minimum value: 0.</value>
        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Settings {\n");
            sb.Append("  Band: ").Append(Band).Append("\n");
            sb.Append("  Roaming: ").Append(Roaming).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
            return this.Equals(input as Settings);
        }

        /// <summary>
        /// Returns true if Settings instances are equal
        /// </summary>
        /// <param name="input">Instance of Settings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Settings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Band == input.Band ||
                    (this.Band != null &&
                    this.Band.Equals(input.Band))
                ) && 
                (
                    this.Roaming == input.Roaming ||
                    this.Roaming.Equals(input.Roaming)
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    this.Timeout.Equals(input.Timeout)
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
                if (this.Band != null)
                {
                    hashCode = (hashCode * 59) + this.Band.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Roaming.GetHashCode();
                hashCode = (hashCode * 59) + this.Timeout.GetHashCode();
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
