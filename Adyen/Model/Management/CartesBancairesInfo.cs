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
    /// CartesBancairesInfo
    /// </summary>
    [DataContract(Name = "CartesBancairesInfo")]
    public partial class CartesBancairesInfo : IEquatable<CartesBancairesInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartesBancairesInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CartesBancairesInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CartesBancairesInfo" /> class.
        /// </summary>
        /// <param name="siret">Cartes Bancaires SIRET. Format: 14 digits. (required).</param>
        public CartesBancairesInfo(string siret = default(string))
        {
            this.Siret = siret;
        }

        /// <summary>
        /// Cartes Bancaires SIRET. Format: 14 digits.
        /// </summary>
        /// <value>Cartes Bancaires SIRET. Format: 14 digits.</value>
        [DataMember(Name = "siret", IsRequired = false, EmitDefaultValue = false)]
        public string Siret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CartesBancairesInfo {\n");
            sb.Append("  Siret: ").Append(Siret).Append("\n");
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
            return this.Equals(input as CartesBancairesInfo);
        }

        /// <summary>
        /// Returns true if CartesBancairesInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CartesBancairesInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartesBancairesInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Siret == input.Siret ||
                    (this.Siret != null &&
                    this.Siret.Equals(input.Siret))
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
                if (this.Siret != null)
                {
                    hashCode = (hashCode * 59) + this.Siret.GetHashCode();
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
