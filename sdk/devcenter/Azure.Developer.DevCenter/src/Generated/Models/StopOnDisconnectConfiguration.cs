// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> Stop on disconnect configuration settings for Dev Boxes created in this pool. </summary>
    public partial class StopOnDisconnectConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StopOnDisconnectConfiguration"/>. </summary>
        /// <param name="status">
        /// Indicates whether the feature to stop the devbox on disconnect once the grace
        /// period has lapsed is enabled.
        /// </param>
        internal StopOnDisconnectConfiguration(StopOnDisconnectStatus status)
        {
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="StopOnDisconnectConfiguration"/>. </summary>
        /// <param name="status">
        /// Indicates whether the feature to stop the devbox on disconnect once the grace
        /// period has lapsed is enabled.
        /// </param>
        /// <param name="gracePeriodMinutes">
        /// The specified time in minutes to wait before stopping a Dev Box once disconnect
        /// is detected.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StopOnDisconnectConfiguration(StopOnDisconnectStatus status, int? gracePeriodMinutes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            GracePeriodMinutes = gracePeriodMinutes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StopOnDisconnectConfiguration"/> for deserialization. </summary>
        internal StopOnDisconnectConfiguration()
        {
        }

        /// <summary>
        /// Indicates whether the feature to stop the devbox on disconnect once the grace
        /// period has lapsed is enabled.
        /// </summary>
        public StopOnDisconnectStatus Status { get; }
        /// <summary>
        /// The specified time in minutes to wait before stopping a Dev Box once disconnect
        /// is detected.
        /// </summary>
        public int? GracePeriodMinutes { get; }
    }
}
