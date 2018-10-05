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

    /// <summary>
    /// A corporate action
    /// </summary>
    public partial class CorporateAction
    {
        /// <summary>
        /// Initializes a new instance of the CorporateAction class.
        /// </summary>
        public CorporateAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CorporateAction class.
        /// </summary>
        public CorporateAction(ResourceId sourceId, string corporateActionCode, System.DateTimeOffset? announcementDate = default(System.DateTimeOffset?), System.DateTimeOffset? exDate = default(System.DateTimeOffset?), System.DateTimeOffset? recordDate = default(System.DateTimeOffset?), System.DateTimeOffset? paymentDate = default(System.DateTimeOffset?), IList<CorporateActionTransition> transitions = default(IList<CorporateActionTransition>))
        {
            SourceId = sourceId;
            CorporateActionCode = corporateActionCode;
            AnnouncementDate = announcementDate;
            ExDate = exDate;
            RecordDate = recordDate;
            PaymentDate = paymentDate;
            Transitions = transitions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceId")]
        public ResourceId SourceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "corporateActionCode")]
        public string CorporateActionCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "announcementDate")]
        public System.DateTimeOffset? AnnouncementDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exDate")]
        public System.DateTimeOffset? ExDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recordDate")]
        public System.DateTimeOffset? RecordDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paymentDate")]
        public System.DateTimeOffset? PaymentDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transitions")]
        public IList<CorporateActionTransition> Transitions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceId");
            }
            if (CorporateActionCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CorporateActionCode");
            }
            if (Transitions != null)
            {
                foreach (var element in Transitions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
