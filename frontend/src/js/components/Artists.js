export default function Artists(artists) {
    return `
    <h1>List of Artists</h1>
        ${artists.map(artist => {
            return `
            <hr />
            <img src="../../../images/${artist.image}" />
            <p class="artist-name" id = "${artist.id}">${artist.name}</p>
            `
        }).join('')}
    `
}