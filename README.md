# MovieDetailsWebsite 🎬

An [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet) web application that allows users to browse detailed movie information and add new movies to the list using **The Movie Database (TMDB)** API. This project showcases the integration of modern web development technologies, working with external APIs, and building intuitive user interfaces for a seamless movie-browsing experience.

---

## Features
- **View Movie Details**: Browse through a collection of popular movies, with information including release date, movie poster, and title.
- **Add Movies**: Easily add movies by entering the TMDB movie ID, and fetch their details dynamically from the TMDB API.
- **Dynamic Data Retrieval**: All movie data is fetched live from the TMDB API, ensuring that the latest movie information is displayed.

---

## Screenshots

### Home Page
The homepage displays a grid of movies with their posters, titles, and release dates, giving users a quick overview of available movies.

![Movies Homepage](https://github.com/surajkumar04sk/projectimage/blob/main/home.png)

### Add a Movie
Users can add new movies to the list by entering the movie's ID from TMDB. Once the ID is provided, the app fetches the movie’s details and updates the homepage.

![Add Movie Page](https://github.com/surajkumar04sk/projectimage/blob/main/addmovie.png)

---

## Technologies Used

- **ASP.NET Core**: For building the backend logic and handling API calls.
- **Entity Framework Core**: To manage database interactions.
- **TMDB API**: To fetch movie details dynamically.
- **HTML/CSS/JavaScript**: For designing the front-end interface.
- **SQL Server**: For data storage.

---

## Setup Instructions

To run this project locally:

1. Clone this repository:
   ```bash
   git clone https://github.com/surajkumar04sk/MovieDetailsWebsite.git

2. Open the project in **Visual Studio**.

3. Add your **TMDB API key** in the `appsettings.json` file:
   ```json
   {
     "TMDBApiKey": "your-tmdb-api-key-here"
   }
   
4. Update your database connection string in `appsettings.json` file:
   ```json
   {
     "ConnectionStrings": {
       "MovieDetailsDB": "Your database connection string here"
     } 
   } 
   
5. Build and run the project.

---

## API Key Usage
This project uses **The Movie Database (TMDB)** API to retrieve up-to-date movie information. You’ll need to sign up on [TMDB](https://www.themoviedb.org/) and obtain an API key to use the service.

---

## Why This Project?
This project highlights:

- Building a **full-stack ASP.NET Core** application.
- Integrating external APIs (**TMDB API**) for real-time data.
- Using **Entity Framework Core** for database management.
- Creating **dynamic, responsive web interfaces** using HTML, CSS, and JavaScript.

