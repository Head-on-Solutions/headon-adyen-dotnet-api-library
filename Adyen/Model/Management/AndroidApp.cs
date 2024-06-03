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
    /// AndroidApp
    /// </summary>
    [DataContract(Name = "AndroidApp")]
    public partial class AndroidApp : IEquatable<AndroidApp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidApp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AndroidApp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidApp" /> class.
        /// </summary>
        /// <param name="description">The description that was provided when uploading the app. The description is not shown on the terminal..</param>
        /// <param name="id">The unique identifier of the app. (required).</param>
        /// <param name="label">The app name that is shown on the terminal..</param>
        /// <param name="packageName">The package name of the app..</param>
        /// <param name="status">The status of the app. Possible values:  * &#x60;processing&#x60;: The app is being signed and converted to a format that the terminal can handle. * &#x60;error&#x60;: Something went wrong. Check that the app matches the [requirements](https://docs.adyen.com/point-of-sale/android-terminals/app-requirements). * &#x60;invalid&#x60;: There is something wrong with the APK file of the app. * &#x60;ready&#x60;: The app has been signed and converted. * &#x60;archived&#x60;: The app is no longer available. (required).</param>
        /// <param name="versionCode">The internal version number of the app..</param>
        /// <param name="versionName">The app version number that is shown on the terminal..</param>
        public AndroidApp(string description = default(string), string id = default(string), string label = default(string), string packageName = default(string), string status = default(string), int? versionCode = default(int?), string versionName = default(string))
        {
            this.Id = id;
            this.Status = status;
            this.Description = description;
            this.Label = label;
            this.PackageName = packageName;
            this.VersionCode = versionCode;
            this.VersionName = versionName;
        }

        /// <summary>
        /// The description that was provided when uploading the app. The description is not shown on the terminal.
        /// </summary>
        /// <value>The description that was provided when uploading the app. The description is not shown on the terminal.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the app.
        /// </summary>
        /// <value>The unique identifier of the app.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The app name that is shown on the terminal.
        /// </summary>
        /// <value>The app name that is shown on the terminal.</value>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// The package name of the app.
        /// </summary>
        /// <value>The package name of the app.</value>
        [DataMember(Name = "packageName", EmitDefaultValue = false)]
        public string PackageName { get; set; }

        /// <summary>
        /// The status of the app. Possible values:  * &#x60;processing&#x60;: The app is being signed and converted to a format that the terminal can handle. * &#x60;error&#x60;: Something went wrong. Check that the app matches the [requirements](https://docs.adyen.com/point-of-sale/android-terminals/app-requirements). * &#x60;invalid&#x60;: There is something wrong with the APK file of the app. * &#x60;ready&#x60;: The app has been signed and converted. * &#x60;archived&#x60;: The app is no longer available.
        /// </summary>
        /// <value>The status of the app. Possible values:  * &#x60;processing&#x60;: The app is being signed and converted to a format that the terminal can handle. * &#x60;error&#x60;: Something went wrong. Check that the app matches the [requirements](https://docs.adyen.com/point-of-sale/android-terminals/app-requirements). * &#x60;invalid&#x60;: There is something wrong with the APK file of the app. * &#x60;ready&#x60;: The app has been signed and converted. * &#x60;archived&#x60;: The app is no longer available.</value>
        [DataMember(Name = "status", IsRequired = false, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// The internal version number of the app.
        /// </summary>
        /// <value>The internal version number of the app.</value>
        [DataMember(Name = "versionCode", EmitDefaultValue = false)]
        public int? VersionCode { get; set; }

        /// <summary>
        /// The app version number that is shown on the terminal.
        /// </summary>
        /// <value>The app version number that is shown on the terminal.</value>
        [DataMember(Name = "versionName", EmitDefaultValue = false)]
        public string VersionName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AndroidApp {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  PackageName: ").Append(PackageName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  VersionCode: ").Append(VersionCode).Append("\n");
            sb.Append("  VersionName: ").Append(VersionName).Append("\n");
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
            return this.Equals(input as AndroidApp);
        }

        /// <summary>
        /// Returns true if AndroidApp instances are equal
        /// </summary>
        /// <param name="input">Instance of AndroidApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AndroidApp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.PackageName == input.PackageName ||
                    (this.PackageName != null &&
                    this.PackageName.Equals(input.PackageName))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.VersionCode == input.VersionCode ||
                    this.VersionCode.Equals(input.VersionCode)
                ) && 
                (
                    this.VersionName == input.VersionName ||
                    (this.VersionName != null &&
                    this.VersionName.Equals(input.VersionName))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.PackageName != null)
                {
                    hashCode = (hashCode * 59) + this.PackageName.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VersionCode.GetHashCode();
                if (this.VersionName != null)
                {
                    hashCode = (hashCode * 59) + this.VersionName.GetHashCode();
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
