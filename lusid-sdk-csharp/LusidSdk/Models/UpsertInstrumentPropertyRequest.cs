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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class UpsertInstrumentPropertyRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpsertInstrumentPropertyRequest
        /// class.
        /// </summary>
        public UpsertInstrumentPropertyRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpsertInstrumentPropertyRequest
        /// class.
        /// </summary>
        /// <param name="lusidInstrumentId">Unique instrument
        /// identifier</param>
        /// <param name="properties">A collection of properties to create or
        /// update</param>
        /// <param name="deletedProperties">A collection of property keys to
        /// remove property values from, if any are set for the
        /// instrument</param>
        public UpsertInstrumentPropertyRequest(string lusidInstrumentId = default(string), IList<InstrumentProperty> properties = default(IList<InstrumentProperty>), IList<DeleteInstrumentPropertyRequest> deletedProperties = default(IList<DeleteInstrumentPropertyRequest>))
        {
            LusidInstrumentId = lusidInstrumentId;
            Properties = properties;
            DeletedProperties = deletedProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique instrument identifier
        /// </summary>
        [JsonProperty(PropertyName = "lusidInstrumentId")]
        public string LusidInstrumentId { get; set; }

        /// <summary>
        /// Gets or sets a collection of properties to create or update
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<InstrumentProperty> Properties { get; set; }

        /// <summary>
        /// Gets or sets a collection of property keys to remove property
        /// values from, if any are set for the instrument
        /// </summary>
        [JsonProperty(PropertyName = "deletedProperties")]
        public IList<DeleteInstrumentPropertyRequest> DeletedProperties { get; set; }

    }
}