export default function Artist(artist){
    return `
    <div class="artist-page">
        <div class="artist-details-image-div">
        <img src="../../../images/${artist.image}"/>
        </div>
        <h1>${artist.name}</h1>
    </div>
    <div class="albums">
        ${artist.albums.map(album =>{
            return `
            <div class="album">
                <h4>${album.name}</h4>
                <img src=../../../images/${album.image} />
                <button class="artist-delete-album">Delete</button>
                <input class="artist-album-id" type="hidden" value="${album.id}">
            </div>
            `
        }).join("")}
    </div>
    <section class="artist-add-album">
        <h2>Add an Album for ${artist.name}</h2>
        <input class="artist-album-input" type="text" placeholder="Album Name"></input>
        <input class="artist-album-description-input" type="text" placeholder="Description"></input>
        <input class="artist-album-rating-input" type="number" min="1" max="10" placeholder="Rating out of 10"></input>
        <input class="artist-album-track-input" type="text" placeholder="Popular Track"></input>
        <button class="artist-album-submit" id="${artist.id}">Add</button>
    </section>

    `
}