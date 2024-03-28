/*
* Management API
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// TerminalConnectivity
    /// </summary>
    [DataContract(Name = "TerminalConnectivity")]
    public partial class TerminalConnectivity : IEquatable<TerminalConnectivity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalConnectivity" /> class.
        /// </summary>
        /// <param name="bluetooth">bluetooth.</param>
        /// <param name="cellular">cellular.</param>
        /// <param name="ethernet">ethernet.</param>
        /// <param name="wifi">wifi.</param>
        public TerminalConnectivity(TerminalConnectivityBluetooth bluetooth = default(TerminalConnectivityBluetooth), TerminalConnectivityCellular cellular = default(TerminalConnectivityCellular), TerminalConnectivityEthernet ethernet = default(TerminalConnectivityEthernet), TerminalConnectivityWifi wifi = default(TerminalConnectivityWifi))
        {
            this.Bluetooth = bluetooth;
            this.Cellular = cellular;
            this.Ethernet = ethernet;
            this.Wifi = wifi;
        }

        /// <summary>
        /// Gets or Sets Bluetooth
        /// </summary>
        [DataMember(Name = "bluetooth", EmitDefaultValue = false)]
        public TerminalConnectivityBluetooth Bluetooth { get; set; }

        /// <summary>
        /// Gets or Sets Cellular
        /// </summary>
        [DataMember(Name = "cellular", EmitDefaultValue = false)]
        public TerminalConnectivityCellular Cellular { get; set; }

        /// <summary>
        /// Gets or Sets Ethernet
        /// </summary>
        [DataMember(Name = "ethernet", EmitDefaultValue = false)]
        public TerminalConnectivityEthernet Ethernet { get; set; }

        /// <summary>
        /// Gets or Sets Wifi
        /// </summary>
        [DataMember(Name = "wifi", EmitDefaultValue = false)]
        public TerminalConnectivityWifi Wifi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TerminalConnectivity {\n");
            sb.Append("  Bluetooth: ").Append(Bluetooth).Append("\n");
            sb.Append("  Cellular: ").Append(Cellular).Append("\n");
            sb.Append("  Ethernet: ").Append(Ethernet).Append("\n");
            sb.Append("  Wifi: ").Append(Wifi).Append("\n");
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
            return this.Equals(input as TerminalConnectivity);
        }

        /// <summary>
        /// Returns true if TerminalConnectivity instances are equal
        /// </summary>
        /// <param name="input">Instance of TerminalConnectivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminalConnectivity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Bluetooth == input.Bluetooth ||
                    (this.Bluetooth != null &&
                    this.Bluetooth.Equals(input.Bluetooth))
                ) && 
                (
                    this.Cellular == input.Cellular ||
                    (this.Cellular != null &&
                    this.Cellular.Equals(input.Cellular))
                ) && 
                (
                    this.Ethernet == input.Ethernet ||
                    (this.Ethernet != null &&
                    this.Ethernet.Equals(input.Ethernet))
                ) && 
                (
                    this.Wifi == input.Wifi ||
                    (this.Wifi != null &&
                    this.Wifi.Equals(input.Wifi))
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
                if (this.Bluetooth != null)
                {
                    hashCode = (hashCode * 59) + this.Bluetooth.GetHashCode();
                }
                if (this.Cellular != null)
                {
                    hashCode = (hashCode * 59) + this.Cellular.GetHashCode();
                }
                if (this.Ethernet != null)
                {
                    hashCode = (hashCode * 59) + this.Ethernet.GetHashCode();
                }
                if (this.Wifi != null)
                {
                    hashCode = (hashCode * 59) + this.Wifi.GetHashCode();
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