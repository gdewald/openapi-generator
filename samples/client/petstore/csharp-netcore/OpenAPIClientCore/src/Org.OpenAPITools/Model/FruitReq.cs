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
    /// FruitReq
    /// </summary>
    [DataContract(Name = "fruitReq")]
    public partial class FruitReq : IEquatable<FruitReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FruitReq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FruitReq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FruitReq" /> class.
        /// </summary>
        /// <param name="cultivar">cultivar (required).</param>
        /// <param name="mealy">mealy.</param>
        /// <param name="lengthCm">lengthCm (required).</param>
        /// <param name="sweet">sweet.</param>
        public FruitReq(string cultivar = default(string), bool mealy = default(bool), decimal lengthCm = default(decimal), bool sweet = default(bool))
        {
            // to ensure "cultivar" is required (not null)
            this.Cultivar = cultivar ?? throw new ArgumentNullException("cultivar is a required property for FruitReq and cannot be null");
            this.LengthCm = lengthCm;
            this.Mealy = mealy;
            this.Sweet = sweet;
        }

        /// <summary>
        /// Gets or Sets Cultivar
        /// </summary>
        [DataMember(Name = "cultivar", IsRequired = true, EmitDefaultValue = false)]
        public string Cultivar { get; set; }

        /// <summary>
        /// Gets or Sets Mealy
        /// </summary>
        [DataMember(Name = "mealy", EmitDefaultValue = false)]
        public bool Mealy { get; set; }

        /// <summary>
        /// Gets or Sets LengthCm
        /// </summary>
        [DataMember(Name = "lengthCm", IsRequired = true, EmitDefaultValue = false)]
        public decimal LengthCm { get; set; }

        /// <summary>
        /// Gets or Sets Sweet
        /// </summary>
        [DataMember(Name = "sweet", EmitDefaultValue = false)]
        public bool Sweet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FruitReq {\n");
            sb.Append("  Cultivar: ").Append(Cultivar).Append("\n");
            sb.Append("  Mealy: ").Append(Mealy).Append("\n");
            sb.Append("  LengthCm: ").Append(LengthCm).Append("\n");
            sb.Append("  Sweet: ").Append(Sweet).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as FruitReq).AreEqual;
        }

        /// <summary>
        /// Returns true if FruitReq instances are equal
        /// </summary>
        /// <param name="input">Instance of FruitReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FruitReq input)
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
                if (this.Cultivar != null)
                    hashCode = hashCode * 59 + this.Cultivar.GetHashCode();
                hashCode = hashCode * 59 + this.Mealy.GetHashCode();
                hashCode = hashCode * 59 + this.LengthCm.GetHashCode();
                hashCode = hashCode * 59 + this.Sweet.GetHashCode();
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
