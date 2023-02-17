using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PhotoConsoleLibrary.Models
{
    public record class PhotoApiResponse(
        [property: JsonPropertyName("albumId")] int AlbumId,
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("title")] string Title,
        [property: JsonPropertyName("url")] string Url,
        [property: JsonPropertyName("thumbnailUrl")] string ThumbnailUrl);
}
