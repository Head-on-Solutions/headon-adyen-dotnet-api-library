/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
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
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// OnboardingLinkInfo
    /// </summary>
    [DataContract(Name = "OnboardingLinkInfo")]
    public partial class OnboardingLinkInfo : IEquatable<OnboardingLinkInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingLinkInfo" /> class.
        /// </summary>
        /// <param name="locale">The language that will be used for the page, specified by a combination of two letter [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language and [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. See [possible values](https://docs.adyen.com/marketplaces-and-platforms/collect-verification-details/hosted#supported-languages).   If not specified in the request or if the language is not supported, the page uses the browser language. If the browser language is not supported, the page uses **en-US** by default..</param>
        /// <param name="redirectUrl">The URL where the user is redirected after they complete hosted onboarding..</param>
        /// <param name="settings">Boolean key-value pairs indicating the settings for the hosted onboarding page. The keys are the settings.  Possible keys:  By default, these values are set to **true**. Set to **false** to not allow the action.  - **changeLegalEntityType**: The user can change their legal entity type.  - **editPrefilledCountry**: The user can change the country of their legal entity&#39;s address, for example the registered address of an organization.  By default, this value is set to **false**. Set to **true** to allow the action.  - **allowBankAccountFormatSelection**: The user can select the format for their payout account if applicable.  - **allowIntraRegionCrossBorderPayout**: The user can select a payout account in a different EU/EEA country than the country of their legal entity.  .</param>
        /// <param name="themeId">The unique identifier of the hosted onboarding theme..</param>
        public OnboardingLinkInfo(string locale = default(string), string redirectUrl = default(string), Dictionary<string, bool> settings = default(Dictionary<string, bool>), string themeId = default(string))
        {
            this.Locale = locale;
            this.RedirectUrl = redirectUrl;
            this.Settings = settings;
            this.ThemeId = themeId;
        }

        /// <summary>
        /// The language that will be used for the page, specified by a combination of two letter [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language and [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. See [possible values](https://docs.adyen.com/marketplaces-and-platforms/collect-verification-details/hosted#supported-languages).   If not specified in the request or if the language is not supported, the page uses the browser language. If the browser language is not supported, the page uses **en-US** by default.
        /// </summary>
        /// <value>The language that will be used for the page, specified by a combination of two letter [ISO 639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) language and [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country codes. See [possible values](https://docs.adyen.com/marketplaces-and-platforms/collect-verification-details/hosted#supported-languages).   If not specified in the request or if the language is not supported, the page uses the browser language. If the browser language is not supported, the page uses **en-US** by default.</value>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// The URL where the user is redirected after they complete hosted onboarding.
        /// </summary>
        /// <value>The URL where the user is redirected after they complete hosted onboarding.</value>
        [DataMember(Name = "redirectUrl", EmitDefaultValue = false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Boolean key-value pairs indicating the settings for the hosted onboarding page. The keys are the settings.  Possible keys:  By default, these values are set to **true**. Set to **false** to not allow the action.  - **changeLegalEntityType**: The user can change their legal entity type.  - **editPrefilledCountry**: The user can change the country of their legal entity&#39;s address, for example the registered address of an organization.  By default, this value is set to **false**. Set to **true** to allow the action.  - **allowBankAccountFormatSelection**: The user can select the format for their payout account if applicable.  - **allowIntraRegionCrossBorderPayout**: The user can select a payout account in a different EU/EEA country than the country of their legal entity.  
        /// </summary>
        /// <value>Boolean key-value pairs indicating the settings for the hosted onboarding page. The keys are the settings.  Possible keys:  By default, these values are set to **true**. Set to **false** to not allow the action.  - **changeLegalEntityType**: The user can change their legal entity type.  - **editPrefilledCountry**: The user can change the country of their legal entity&#39;s address, for example the registered address of an organization.  By default, this value is set to **false**. Set to **true** to allow the action.  - **allowBankAccountFormatSelection**: The user can select the format for their payout account if applicable.  - **allowIntraRegionCrossBorderPayout**: The user can select a payout account in a different EU/EEA country than the country of their legal entity.  </value>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public Dictionary<string, bool> Settings { get; set; }

        /// <summary>
        /// The unique identifier of the hosted onboarding theme.
        /// </summary>
        /// <value>The unique identifier of the hosted onboarding theme.</value>
        [DataMember(Name = "themeId", EmitDefaultValue = false)]
        public string ThemeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OnboardingLinkInfo {\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  ThemeId: ").Append(ThemeId).Append("\n");
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
            return this.Equals(input as OnboardingLinkInfo);
        }

        /// <summary>
        /// Returns true if OnboardingLinkInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OnboardingLinkInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnboardingLinkInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
                ) && 
                (
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    input.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
                ) && 
                (
                    this.ThemeId == input.ThemeId ||
                    (this.ThemeId != null &&
                    this.ThemeId.Equals(input.ThemeId))
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
                if (this.Locale != null)
                {
                    hashCode = (hashCode * 59) + this.Locale.GetHashCode();
                }
                if (this.RedirectUrl != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectUrl.GetHashCode();
                }
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                if (this.ThemeId != null)
                {
                    hashCode = (hashCode * 59) + this.ThemeId.GetHashCode();
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