using MediatR;
using PhotoConsoleLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PhotoConsoleLibrary.Http.Queries
{
    public class PhotoApiQuery 
    {
        HttpClient _httpClient = new HttpClient();
        public async Task<List<PhotoApiResponse>> GetAlbums(int albumId)
        {
            await using Stream stream =
                await _httpClient.GetStreamAsync($"https://jsonplaceholder.typicode.com/photos?albumId={albumId}");
            List<PhotoApiResponse> list = await JsonSerializer.DeserializeAsync<List<PhotoApiResponse>>(stream, cancellationToken: new CancellationToken());


            return list ?? new();



        }
    }

}
