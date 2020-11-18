export default function Artists(artists) {
    return `
    <h1 class="list-title">List of Artists</h1>
    <div class="artists">
        ${artists.map(artist => {
            return `
            <div class="artist">
            <img src="../../../images/${artist.image}" />
            <p class="artist-name" id = "${artist.id}">${artist.name}</p>
            </div>
            `
        }).join('')}

    </div>
    `
}