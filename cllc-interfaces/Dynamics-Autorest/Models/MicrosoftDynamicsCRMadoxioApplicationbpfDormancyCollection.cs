// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of adoxio_applicationbpf_dormancy
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_applicationbpf_dormancyCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioApplicationbpfDormancyCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationbpfDormancyCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationbpfDormancyCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationbpfDormancyCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationbpfDormancyCollection(IList<MicrosoftDynamicsCRMadoxioApplicationbpfDormancy> value = default(IList<MicrosoftDynamicsCRMadoxioApplicationbpfDormancy>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationbpfDormancy> Value { get; set; }

    }
}
