using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace MarsRoverHeneghan.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarsRoverController : ControllerBase
    {

        public MarsRoverController()
        {
        }

        [HttpGet]
        public IActionResult Get([FromQuery] string apiKey, [FromQuery] DateTime date)
        {
            //rest API NASA Client
            var restClient = new RestClient("https://api.nasa.gov");

            //creating the Request. the string is the API call we want to make to the client.
            var request = new RestRequest("mars-photos/api/v1/rovers/curiosity/photos");

            //adding my parameters. They will end up like '?api_key=[key]&earth_date=[date]' in the final product.
            request.AddQueryParameter("api_key", apiKey.ToString());
            request.AddQueryParameter("earth_date", date.ToString(@"yyyy-MM-dd"));

            //when we use the get request, if we specify the type of variable we want it to become in <>, it will auto deserialize the data for you.
            var response = (restClient.Get<MarsRover>(request));

            //The serialized data is stored in Data. Since Photos is just a list of the Photos, I go ahead and just start at the list.
            var data = response.Data.Photos;

            //webclient used to download the file
            using (WebClient client = new WebClient())
            {
                foreach (var photo in data)
                {
                    //Before I was grabbing the image name so that angular knows what photo to access, but since that cannot work due to assets not being reloaded after inital runtime,
                    //this is no longer relevant. However, I decided to keep it in case you wanted to see where I wanted to go with this.
                    var split = photo.ImgSrc.Split("/");
                    var imageName = split[split.Length - 1];
                    photo.ImageName = "/assets/marsimages/" + imageName;

                    //this is where we download the file. I navigate to the assets/marsimages folder to download the files.
                    //I tried to do this asynchronously to save time but unfortunately this would not work, so it may take a few seconds.
                    client.DownloadFile(new Uri(photo.ImgSrc), System.AppDomain.CurrentDomain.BaseDirectory + "../../../ClientApp/src/assets/marsimages/" + imageName);
                }
            }

            return Ok(data);
        }
    }
}
