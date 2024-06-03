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
    /// EventUrl
    /// </summary>
    [DataContract(Name = "EventUrl")]
    public partial class EventUrl : IEquatable<EventUrl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventUrl" /> class.
        /// </summary>
        /// <param name="eventLocalUrls">One or more local URLs to send event notifications to when using Terminal API..</param>
        /// <param name="eventPublicUrls">One or more public URLs to send event notifications to when using Terminal API..</param>
        public EventUrl(List<Url> eventLocalUrls = default(List<Url>), List<Url> eventPublicUrls = default(List<Url>))
        {
            this.EventLocalUrls = eventLocalUrls;
            this.EventPublicUrls = eventPublicUrls;
        }

        /// <summary>
        /// One or more local URLs to send event notifications to when using Terminal API.
        /// </summary>
        /// <value>One or more local URLs to send event notifications to when using Terminal API.</value>
        [DataMember(Name = "eventLocalUrls", EmitDefaultValue = false)]
        public List<Url> EventLocalUrls { get; set; }

        /// <summary>
        /// One or more public URLs to send event notifications to when using Terminal API.
        /// </summary>
        /// <value>One or more public URLs to send event notifications to when using Terminal API.</value>
        [DataMember(Name = "eventPublicUrls", EmitDefaultValue = false)]
        public List<Url> EventPublicUrls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventUrl {\n");
            sb.Append("  EventLocalUrls: ").Append(EventLocalUrls).Append("\n");
            sb.Append("  EventPublicUrls: ").Append(EventPublicUrls).Append("\n");
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
            return this.Equals(input as EventUrl);
        }

        /// <summary>
        /// Returns true if EventUrl instances are equal
        /// </summary>
        /// <param name="input">Instance of EventUrl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventUrl input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EventLocalUrls == input.EventLocalUrls ||
                    this.EventLocalUrls != null &&
                    input.EventLocalUrls != null &&
                    this.EventLocalUrls.SequenceEqual(input.EventLocalUrls)
                ) && 
                (
                    this.EventPublicUrls == input.EventPublicUrls ||
                    this.EventPublicUrls != null &&
                    input.EventPublicUrls != null &&
                    this.EventPublicUrls.SequenceEqual(input.EventPublicUrls)
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
                if (this.EventLocalUrls != null)
                {
                    hashCode = (hashCode * 59) + this.EventLocalUrls.GetHashCode();
                }
                if (this.EventPublicUrls != null)
                {
                    hashCode = (hashCode * 59) + this.EventPublicUrls.GetHashCode();
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
