
#nullable enable

namespace SoundCloud
{
    public sealed partial class SoundCloudClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingOAuth(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "Http" &&
                    __authorization.Name == "OAuth")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::SoundCloud.EndPointAuthorization
            {
                Type = "Http",
                SchemeId = "HttpOauth",
                Location = "Header",
                Name = "OAuth",
                Value = apiKey,
            });
        }
    }
}