// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// odata.error
    /// </summary>
    public partial class Odataerror
    {
        /// <summary>
        /// Initializes a new instance of the Odataerror class.
        /// </summary>
        public Odataerror()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Odataerror class.
        /// </summary>
        public Odataerror(Odataerrormain error)
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public Odataerrormain Error { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Error == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Error");
            }
            if (Error != null)
            {
                Error.Validate();
            }
        }
    }
}
