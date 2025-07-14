namespace YoutubeIntegration.Models
{
    public class cYoutubeUrls
    {
        public static readonly Uri AuthorizeUri = new("");

        public static readonly Uri V3Uri = new("https://www.googleapis.com/youtube/v3");

        public static readonly Uri OAuthTokenUri = new("");

        public static Uri Search() => new("search");

        public static Uri Videos() => new("videos");

        public static Uri Playlists() => new("playlists");


    }
}
