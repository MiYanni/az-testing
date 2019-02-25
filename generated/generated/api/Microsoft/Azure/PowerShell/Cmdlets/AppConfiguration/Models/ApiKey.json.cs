namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;
    /// <summary>An API key used for authenticating with a configuration store endpoint.</summary>
    public partial class ApiKey
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject into a new instance of <see cref="ApiKey" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ApiKey(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;
            _connectionString = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString>("connectionString"), out var __jsonConnectionString) ? (string)__jsonConnectionString : (string)ConnectionString;
            _id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;
            _lastModified = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString>("lastModified"), out var __jsonLastModified) ? System.DateTime.TryParse((string)__jsonLastModified, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastModifiedValue) ? __jsonLastModifiedValue : LastModified : LastModified;
            _readOnly = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonBoolean>("readOnly"), out var __jsonReadOnly) ? (bool?)__jsonReadOnly : ReadOnly;
            _value = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString>("value"), out var __jsonValue) ? (string)__jsonValue : (string)Value;
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKey.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKey.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKey FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject json ? new ApiKey(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ApiKey" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ApiKey" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)Name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString(Name.ToString()) : null, "name" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)ConnectionString)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString(ConnectionString.ToString()) : null, "connectionString" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)Id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString(Id.ToString()) : null, "id" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != LastModified ? (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString(LastModified?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "lastModified" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != ReadOnly ? (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonBoolean((bool)ReadOnly) : null, "readOnly" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)Value)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString(Value.ToString()) : null, "value" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}