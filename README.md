# Youtube/Spotify syncing

## Main use case:
- Syncing of spotify music into Youtube
- - Everytime a user likes a song, the service will search for the song in Youtube and if found, add it to a playlist

## Future use cases:
- Syncing with other services
- - iTunes
- - Pandora
- - Audible
- - Tiktok
- Creator searching
- When liking a video on YouTube, service will notify user if they have music on Spotify
- Playlist management

## API services needed
- Youtube
- Spotify
- Google login service
- Facebook login service
- iTunes login service

## Database design
- What data do we need
- - Users information for accounts 
- - Third party credentials?
- - User preferences for syncing?
- Data from Youtube
- - Playlists
- - Liked videos
- Data from Spotify
- - Playlists
- - Liked songs

## Starting Implementation:
- [ ] Create API getter for Youtube
- [ ] Create API getter for spotify
- [ ] Write spotify playlist to youtube and save
- [ ] Write youtube playlist to spotify and save
- [ ] Utilize DB to save user information
- [ ] Create scheduler for syncing services

## Future Implementation
- [ ] Integration of iTunes
- [ ] Integration of Pandora
- [ ] Create frontend design
	- [ ] Create mockup of UX
	- [ ] Create possible user interactions/wants
- [ ] Add frontend functionality
	- [ ] Create atoms
	- [ ] Create molecules
	- [ ] Create organisms
	- [ ] Create templates