# Carlabs Fullstack Technical Test

The objective of this challenge is to create a SPA of a restaurant app that allows user to place some orders and review them. 

## Technical Description

This project was made with .NET Core as backend language and React/Angular as frontend language. As the requirements says, the frontend is totally decoupled from the backend. 

I chose to do the frontend twice, using Angular first and then trying to rebuild it with React. In that moment, I felt more confortable with Angular, so I chose Angular, but I really wanted to improve my skills in React, so I'm currently rebuiliding the same frontend in React. 

Folders explanation:

     - Backend: A .NET Core Web API that provides a RESTFULL API. Currently in version 3.1.
     - Frontend: 
           - restaurant-angular: frontend based in Angular. Currently in version 11. 
           - restaurant-react: frontend based in ReactJS. Currently in version 17. 

## Enhancements

Since it's a challenge application, it's not totally ready. And if in some moment it would go for production, a few improvements would be necessary, like:

 - It's currently using a in-memory database, so it would be necessary to change it to a relational or non-relation database
 - Add a lot of features, like: tables control, payment gateway, customers control, inventory control, employees control and so on
 - A mobile app for users
 - An admin plataform
 - If more developers were going to work in the project, it would be good to use Docker. 

## Running

 - To run this application, in both parts (frontend and backend), you will basically need to install two packages:
      - NodeJS v13+
      - .NET Core SDK v3+
      - Also, would be good a Visual Studio with web development configuration

### Frontend

#### Angular

     - Open the angular project in some text editor, or direct in the terminal.
        - If in terminal, navigate to carlabs-fullstack-technical-test folder
           - then use the following commands:
              $ cd frontend/restaurant-angular
     - Then you need to install the dependencies: 
        - npm install
     - After installing the packages, you can start the application with 
        - ng serve 
     - Navigate to http://localhost.com/4200
      
#### React

     - Open the react project in some text editor, or direct in the terminal.
        - If in terminal, navigate to carlabs-fullstack-technical-test folder
           - then use the following commands:
              $ cd frontend/restaurant-react
     - Then you need to install the dependencies: 
        - npm install
     - After installing the packages, you can start the application with 
        - npm start
     - Navigate to http://localhost:3000

### Backend

     - Open your terminal and navigate to the carlabs-fullstack-technical-test folder
     - Then use the following commands:
       - cd backend
     - Install .NET packages
       - dotnet restore
     - Run the backend
       - dotnet run
     - Navigate to https://localhost:44311/swagger/index.html