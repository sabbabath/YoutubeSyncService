using System;

namespace SpotifyIntegration.Models
{
    public class cSpotifyUrls
    {
        public static readonly Uri AuthorizeUri = new("https://accounts.spotify.com/authorize");

        public static readonly Uri V1Uri = new("https://api.spotify.com/v1/");

        public static readonly Uri OAuthTokenUri = new("https://accounts.spotify.com/api/token");

        public static Uri TopTracks() => new("me/top/tracks");

        public static Uri TopArtists() => new("me/top/artists");

        public static Uri User(string userId) => new($"users/{userId}");

        public static Uri Search() => new("search");
    }
}
