# MarsRoverHeneghan

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 6.0.0.

Upon startup, you will be asked to input a date.

Once you select a date and hit Submit, the application will begin to download the images to ClientApp/src/app/assets/marsimages. 

I was originally intending to use these in the Angular application, until I realized the assets folder does not refresh after the initial ng-serve, so I use the img_src instead for the front end.

However, the images still appear in the folder specified above.

The front end is very simple. I wanted to work on it more, but due to complications with the Img_Src which ate up a lot of my time, I did not have any extra time to make it look nicer.

Last thing I want to note on this: I was having an issue where when I clicked on the button, despite it being typed as a button and I prevent propagation, it was refreshing the page as soon as the API
call was completed. I struggled to figure out the issue, but I eventually turned off live-reload, which fixed the issue, but if you make any changes and it doesn't reload, that is why.


Backend Explanations:

There are 2 Data Models, modeled after the NASA API. 

MarsRover: Holds a list of each photo

MarsRoverPhoto: Holds the general photo data, including the image itself

MarsRoverCamera: Holds info on the camera used to take the image

MarsRoverRover: Holds info on the rover used to take the image


Lastly, we have the MarsRoverController. Upon receiving the Get Request from the RestAPI, the Controller will proceed to set up an API Call to the NASA API via RestSharp.

RestSharp allows you to run API calls through C#. I decided upon this method because it was easier for me to save multiple images in C# than through angular/front end.


I have made comments whereever needed, but if there are any further questions, please let me know.

Thank you! Colleen Heneghan
