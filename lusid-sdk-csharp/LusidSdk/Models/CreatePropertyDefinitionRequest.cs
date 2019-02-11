// <auto-generated>
// Copyright © 2018 FINBOURNE TECHNOLOGY LTD
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
// </auto-generated>

namespace Finbourne.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CreatePropertyDefinitionRequest
    {
        /// <summary>
        /// Initializes a new instance of the CreatePropertyDefinitionRequest
        /// class.
        /// </summary>
        public CreatePropertyDefinitionRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreatePropertyDefinitionRequest
        /// class.
        /// </summary>
        /// <param name="domain">Possible values include: 'Trade', 'Portfolio',
        /// 'Holding', 'ReferenceHolding', 'TransactionConfiguration',
        /// 'Instrument', 'CutDefinition'</param>
        /// <param name="lifeTime">Possible values include: 'Perpetual',
        /// 'TimeVariant'</param>
        /// <param name="type">Possible values include: 'Label', 'Metric',
        /// 'Information'</param>
        public CreatePropertyDefinitionRequest(string domain = default(string), string scope = default(string), string code = default(string), bool? valueRequired = default(bool?), string displayName = default(string), ResourceId dataTypeId = default(ResourceId), string lifeTime = default(string), string type = default(string))
        {
            Domain = domain;
            Scope = scope;
            Code = code;
            ValueRequired = valueRequired;
            DisplayName = displayName;
            DataTypeId = dataTypeId;
            LifeTime = lifeTime;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Trade', 'Portfolio',
        /// 'Holding', 'ReferenceHolding', 'TransactionConfiguration',
        /// 'Instrument', 'CutDefinition'
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valueRequired")]
        public bool? ValueRequired { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataTypeId")]
        public ResourceId DataTypeId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Perpetual', 'TimeVariant'
        /// </summary>
        [JsonProperty(PropertyName = "lifeTime")]
        public string LifeTime { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Label', 'Metric',
        /// 'Information'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
