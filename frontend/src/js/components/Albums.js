export default function Albums(albums){
    return `
  
    <h1 class="list-title">List of Albums</h1>
    <div class="albums">
        ${albums.map(album => {
            return `
           <div class= "album">
                <img src="../../../images/${album.image}" />
                <p><strong>${album.name}</strong> by ${album.artist.name}</p>
                <p><strong>Description:</strong> ${album.description}</p>
                <p><strong>Rating:</strong> ${album.rating}/10</p>
                <p><strong>Popular Track:</strong> ${album.popularTrack}</p>
            </div>
            `
        }).join("")}
    </div>
    `
}