
#nullable enable

namespace SoundCloud
{
    public partial interface IRepostsClient
    {
        /// <summary>
        /// Authorize using OAuth authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingOAuth(
            string apiKey);
    }
}