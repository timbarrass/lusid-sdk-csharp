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

    public partial class PortfoliosReconciliationRequest
    {
        /// <summary>
        /// Initializes a new instance of the PortfoliosReconciliationRequest
        /// class.
        /// </summary>
        public PortfoliosReconciliationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PortfoliosReconciliationRequest
        /// class.
        /// </summary>
        public PortfoliosReconciliationRequest(PortfolioReconciliationRequest left, PortfolioReconciliationRequest right, IList<string> instrumentPropertyKeys)
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
        /// </summary>
        [JsonProperty(PropertyName = "left")]
        public PortfolioReconciliationRequest Left { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "right")]
        public PortfolioReconciliationRequest Right { get; set; }

        /// <summary>
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