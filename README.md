# Eau Claire's Hair Salon

#### An MVC Web Application 

#### By Helen Lehrer

## Description

 An MVC application for a hair salon that manages salon employees (stylists) and their clients. The user is able to add a list of stylists working at the salon and assign clients to that stylist. The stylists have specific specialties, so each client can only see (belong to) a single stylist (A one-to-many relationship). This application includes:

* A splash pages with options to see all stylists, all clients, or search for a specific stylist or client
* A Stylists page that contains a link to a page with a form to create a new `Stylist`.
* Clickable `Stylist` names that go to new page displaying the selected `Stylist` information and list of their assigned `Client`s.
* A Clients page that contains a link to a page with a form to create a new `Client`.
* Clickable `Client` names that go to new page displaying the selected `Client` information.
* All information has Edit, Delete, and Search functionality.

Features:

* A splash page
* One-to-many database relationship
* Multiple controllers 
* Use of MySQL for database management
* GET and POST requests
* MVC routes follow RESTful conventions
* Search order functionality

## Technologies Used

* .NET 5.0.401
* C#
* Git Bash
* MySQL & MySQL Workbench 8.0.30
* Entity Framework Core 5.0.0
* LINQ queries

## Setup/Installation Requirements

Enter this command into your terminal to clone the project: 
```bash
$ git clone https://github.com/helen-lehrer/HairSalon.Solution
```

Navigate from the root directory of the repo into the production folder `HairSalon`:
```bash
$ cd HairSalon
```

Restore dependencies and tools: 
```bash
$ dotnet restore
```

Compile the code: 
```bash
$ dotnet build
```

---

#### Follow these instructions to set up an **appsettings.json** file to add a database connection to the app:

Navigate from the root directory of the repo into the production folder `HairSalon`:
```bash
$ cd HairSalon
```

Create a file called **appsettings.json**: 
```bash
$ touch appsettings.json
```

Add the following code to the **appsettings.json** file: 
```bash
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=helen_lehrer;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```

* Make sure to insert your MySQL username and password into the  **appsettings.json**  connection string
* Note that the database will change based on the database you are connecting to and that uid and pwd may vary depending on your MySql configurations.

---

#### To run the application: 

Navigate from the root directory of the repo into the folder `HairSalon`:
```bash
$ cd HairSalon
```

Run the application:
```bash
$ dotnet run
```

## Known Bugs

* The search functionality is case sensitive

## License
[![License](https://img.shields.io/badge/License-BSD_3--Clause-blue.svg)](https://opensource.org/licenses/BSD-3-Clause)

&copy; _Copyright 2022 Helen Lehrer_