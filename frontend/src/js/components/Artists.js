export default function Artists(artists) {
    return `
    <h1>List of Artists</h1>
    <ul>
        ${artists.map(artist => {
            return `
            <li>
                <p>${artist.name}</p>
            </li>
            `
        }).join('')}
    </ul>
    
    `
}