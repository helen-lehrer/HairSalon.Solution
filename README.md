# Eau Claire's Hair Salon

#### An MVC Web Application 

#### By Helen Lehrer

## Description

 An MVC application for a hair salon that manages salon employees (stylists) and their clients. The user is able to add a list of stylists working at the salon and assign clients to that stylist. The stylists have specific specialties, so each client can only see (belong to) a single stylist (A one-to-many relationship). This application includes:

* A splash page with options to see all `Stylist`s, all `Client`s, or search for a specific `Stylist` or `Client`
* A `Stylist`s page that contains a link to a page with a form to create a new `Stylist`
* Clickable `Stylist` names that go to new page displaying the selected `Stylist` details and a dynamic list of their assigned `Client`s
* A `Client`s page that contains a link to a page with a form to create a new `Client`
* Clickable `Client` names that go to new page displaying the selected `Client` details
* All submissions have Edit, Delete, and Search functionality

Features:

* A splash page
* One-to-many database relationship
* Multiple controllers 
* Use of MySQL for database management
* GET and POST requests
* MVC routes follow RESTful conventions
* Search functionalities

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

#### Database Import/Configuration:

* Download, install, and configure [MySQL](https://dev.mysql.com/downloads/installer/) & [MySQL Workbench](https://dev.mysql.com/downloads/workbench/)

* In MySQL Workbench, In the Navigator>Administration window, select "Data Import/Restore"

* In Import Options, select "Import from Self-Contained File"

* In the field next to this, type "[directory repo was cloned into]/HairSalon.Solution/helen_lehrer.sql". 

* Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.

After you are finished with the above steps, reopen the Navigator > Schemas tab. Right click and select Refresh All. The database helen_lehrer will appear. Next, you will create an **appsettings.json** file.

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