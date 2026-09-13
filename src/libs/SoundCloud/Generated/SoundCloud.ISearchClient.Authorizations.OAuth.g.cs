
#nullable enable

namespace SoundCloud
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Authorize using OAuth authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingOAuth(
            string apiKey);
    }
}