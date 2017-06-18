namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival...
    /// </summary>
    [DataContract]
    public partial class Event : Thing
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Event";

        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        [DataMember(Name = "about", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? About { get; set; }

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Actor { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AggregateRating>? AggregateRating { get; set; }

        /// <summary>
        /// A person or organization attending the event.
        /// </summary>
        [DataMember(Name = "attendee", Order = 5)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Organization>? Attendee { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 6)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Audience>? Audience { get; set; }

        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        [DataMember(Name = "composer", Order = 7)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Composer { get; set; }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [DataMember(Name = "contributor", Order = 8)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Organization>? Contributor { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 9)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Director { get; set; }

        /// <summary>
        /// The time admission will commence.
        /// </summary>
        [DataMember(Name = "doorTime", Order = 10)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? DoorTime { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 11)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan?>? Duration { get; set; }

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "endDate", Order = 12)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? EndDate { get; set; }

        /// <summary>
        /// An eventStatus of an event represents its status; particularly useful when an event is cancelled or rescheduled.
        /// </summary>
        [DataMember(Name = "eventStatus", Order = 13)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<EventStatusType?>? EventStatus { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 14)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Funder { get; set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage", Order = 15)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Language, string>? InLanguage { get; set; }

        /// <summary>
        /// A flag to signal that the publication is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 16)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<bool?>? IsAccessibleForFree { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 17)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place, string, PostalAddress>? Location { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [DataMember(Name = "maximumAttendeeCapacity", Order = 18)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 19)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? Offers { get; set; }

        /// <summary>
        /// An organizer of an Event.
        /// </summary>
        [DataMember(Name = "organizer", Order = 20)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Organizer { get; set; }

        /// <summary>
        /// A performer at the event&amp;#x2014;for example, a presenter, musician, musical group or actor.
        /// </summary>
        [DataMember(Name = "performer", Order = 21)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Performer { get; set; }

        /// <summary>
        /// Used in conjunction with eventStatus for rescheduled or cancelled events. This property contains the previously scheduled start date. For rescheduled events, the startDate property should be used for the newly scheduled start date. In the (rare) case of an event that has been postponed and rescheduled multiple times, this field may be repeated.
        /// </summary>
        [DataMember(Name = "previousStartDate", Order = 22)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? PreviousStartDate { get; set; }

        /// <summary>
        /// The CreativeWork that captured all or part of this Event.
        /// </summary>
        [DataMember(Name = "recordedIn", Order = 23)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? RecordedIn { get; set; }

        /// <summary>
        /// The number of attendee places for an event that remain unallocated.
        /// </summary>
        [DataMember(Name = "remainingAttendeeCapacity", Order = 24)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? RemainingAttendeeCapacity { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 25)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Review>? Review { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 26)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Sponsor { get; set; }

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "startDate", Order = 27)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? StartDate { get; set; }

        /// <summary>
        /// An Event that is part of this event. For example, a conference event includes many presentations, each of which is a subEvent of the conference.
        /// </summary>
        [DataMember(Name = "subEvent", Order = 28)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Event>? SubEvent { get; set; }

        /// <summary>
        /// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
        /// </summary>
        [DataMember(Name = "superEvent", Order = 29)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Event>? SuperEvent { get; set; }

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        [DataMember(Name = "translator", Order = 30)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Organization>? Translator { get; set; }

        /// <summary>
        /// The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        [DataMember(Name = "typicalAgeRange", Order = 31)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TypicalAgeRange { get; set; }

        /// <summary>
        /// A work featured in some event, e.g. exhibited in an ExhibitionEvent.
        ///        Specific subproperties are available for workPerformed (e.g. a play), or a workPresented (a Movie at a ScreeningEvent).
        /// </summary>
        [DataMember(Name = "workFeatured", Order = 32)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? WorkFeatured { get; set; }

        /// <summary>
        /// A work performed in some event, for example a play performed in a TheaterEvent.
        /// </summary>
        [DataMember(Name = "workPerformed", Order = 33)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? WorkPerformed { get; set; }
    }
}