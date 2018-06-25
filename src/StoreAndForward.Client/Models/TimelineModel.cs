// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DigitalHealth.StoreAndForward.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Timeline model.
    /// </summary>
    public partial class TimelineModel
    {
        /// <summary>
        /// Initializes a new instance of the TimelineModel class.
        /// </summary>
        public TimelineModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TimelineModel class.
        /// </summary>
        /// <param name="timelineEvents">Timeline events.</param>
        public TimelineModel(IList<TimelineEventModel> timelineEvents = default(IList<TimelineEventModel>))
        {
            TimelineEvents = timelineEvents;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets timeline events.
        /// </summary>
        [JsonProperty(PropertyName = "timeline_events")]
        public IList<TimelineEventModel> TimelineEvents { get; set; }

    }
}
