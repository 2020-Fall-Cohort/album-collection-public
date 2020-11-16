export default function Artists(artists) {
    return `
    <h1>List of Artists</h1>
        <ul>
        ${artists.map(artist => {
            return `
            <li>
            <hr />
            <img src="../../../images/${artist.image}" />
            <h4 class="artist_name" id = "${artist.id}">${artist.name}</h4>
            </li>
            `
        }).join('')}
        </ul>
    `
}