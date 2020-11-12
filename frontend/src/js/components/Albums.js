export default function Albums(albums){
    return `
    <h1>List of Albums</h1>
    <ol>
        ${albums.map(album => {
            return `
            <li><strong>${album.name}</strong></li>
            <p>${album.description}</p>
            `
        }).join("")}
    </ol>
    `
}