/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// GmFruit
    /// </summary>
    [DataContract(Name = "gmFruit")]
    public partial class GmFruit : IEquatable<GmFruit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GmFruit" /> class.
        /// </summary>
        /// <param name="color">color.</param>
        /// <param name="cultivar">cultivar.</param>
        /// <param name="origin">origin.</param>
        /// <param name="lengthCm">lengthCm.</param>
        public GmFruit(string color = default(string), string cultivar = default(string), string origin = default(string), decimal lengthCm = default(decimal))
        {
            this.Color = color;
            this.Cultivar = cultivar;
            this.Origin = origin;
            this.LengthCm = lengthCm;
        }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets Cultivar
        /// </summary>
        [DataMember(Name = "cultivar", EmitDefaultValue = false)]
        public string Cultivar { get; set; }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or Sets LengthCm
        /// </summary>
        [DataMember(Name = "lengthCm", EmitDefaultValue = false)]
        public decimal LengthCm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GmFruit {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Cultivar: ").Append(Cultivar).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  LengthCm: ").Append(LengthCm).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as GmFruit).AreEqual;
        }

        /// <summary>
        /// Returns true if GmFruit instances are equal
        /// </summary>
        /// <param name="input">Instance of GmFruit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GmFruit input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Cultivar != null)
                    hashCode = hashCode * 59 + this.Cultivar.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                hashCode = hashCode * 59 + this.LengthCm.GetHashCode();
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
            // Cultivar (string) pattern
            Regex regexCultivar = new Regex(@"^[a-zA-Z\\s]*$", RegexOptions.CultureInvariant);
            if (false == regexCultivar.Match(this.Cultivar).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cultivar, must match a pattern of " + regexCultivar, new [] { "Cultivar" });
            }

            // Origin (string) pattern
            Regex regexOrigin = new Regex(@"^[A-Z\\s]*$", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
            if (false == regexOrigin.Match(this.Origin).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Origin, must match a pattern of " + regexOrigin, new [] { "Origin" });
            }

            yield break;
        }
    }

}
