export default function Artist(artist){
    return `
    <h1>${artist.name}</h1>
    <ul>
        ${artist.albums.map(album =>{
            return `
            <li>
                <h4>${album.name}</h4>
                <button class="artist-delete-album">Delete</button>
                <input class="artist-album-id" type="hidden" value="${album.id}">
            </li>
            `
        }).join("")}
    </ul>

    <section class="artist-add-album">
        <input class="artist-album-input" type="text" placeholder="Add a new album here"></input>
        <button class="artist-album-submit" id="${artist.id}">Add an album for ${artist.name}</button>
    </section>

    `
}