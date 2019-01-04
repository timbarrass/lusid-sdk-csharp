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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ValuationsReconciliationRequest
    {
        /// <summary>
        /// Initializes a new instance of the ValuationsReconciliationRequest
        /// class.
        /// </summary>
        public ValuationsReconciliationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValuationsReconciliationRequest
        /// class.
        /// </summary>
        /// <param name="left">The specification of the left hand side of the
        /// valuation (risk) reconciliation</param>
        /// <param name="right">The specification of the right hand side of the
        /// valuation (risk) reconciliation</param>
        /// <param name="instrumentPropertyKeys">Instrument properties to be
        /// included with any identified breaks. These properties will be in
        /// the effective and AsAt dates of the left portfolio</param>
        public ValuationsReconciliationRequest(ValuationReconciliationRequest left, ValuationReconciliationRequest right, IList<string> instrumentPropertyKeys)
        {
            Left = left;
            Right = right;
            InstrumentPropertyKeys = instrumentPropertyKeys;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the specification of the left hand side of the
        /// valuation (risk) reconciliation
        /// </summary>
        [JsonProperty(PropertyName = "left")]
        public ValuationReconciliationRequest Left { get; set; }

        /// <summary>
        /// Gets or sets the specification of the right hand side of the
        /// valuation (risk) reconciliation
        /// </summary>
        [JsonProperty(PropertyName = "right")]
        public ValuationReconciliationRequest Right { get; set; }

        /// <summary>
        /// Gets or sets instrument properties to be included with any
        /// identified breaks. These properties will be in the effective and
        /// AsAt dates of the left portfolio
        /// </summary>
        [JsonProperty(PropertyName = "instrumentPropertyKeys")]
        public IList<string> InstrumentPropertyKeys { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Left == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Left");
            }
            if (Right == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Right");
            }
            if (InstrumentPropertyKeys == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InstrumentPropertyKeys");
            }
            if (Left != null)
            {
                Left.Validate();
            }
            if (Right != null)
            {
                Right.Validate();
            }
        }
    }
}