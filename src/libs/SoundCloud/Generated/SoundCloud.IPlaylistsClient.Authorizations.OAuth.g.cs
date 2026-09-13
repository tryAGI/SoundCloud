
#nullable enable

namespace SoundCloud
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Authorize using OAuth authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingOAuth(
            string apiKey);
    }
}