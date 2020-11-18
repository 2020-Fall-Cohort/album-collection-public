export default function Albums(albums){
    return `
    <h1>List of Albums</h1>
        ${albums.map(album => {
            return `
            <hr />
            <img src="../../../images/${album.image}" />
            <p><strong>${album.name}</strong> by ${album.artist.name}</p>
            <p><strong>Description:</strong> ${album.description}</p>
            <p><strong>Rating:</strong> ${album.rating}</p>
            <p><strong>Popular Track:</strong> ${album.popularTrack}</p>
            `
        }).join("")}
    `
}