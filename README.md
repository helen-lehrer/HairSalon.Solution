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

Navigate from the root directory of the repo into the folder `HairSalon`:
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

#### Follow these instructions to set up **MSTest**:

Navigate from the root directory of the repo to folder `VendorTracker.Tests`: 
```bash
$ cd VendorTracker.Tests
```

Download & install **MSTest**: 
```bash
$ dotnet restore
```

To run **MSTest**, type this into your command line while you are inside of the VendorTracker.Tests folder: 
```bash
$ dotnet test
```

---

#### To run the application: 

Navigate from the root directory of the repo into the folder `VendorTracker`:
```bash
$ cd VendorTracker
```

Run the application:
```bash
$ dotnet run
```

## Known Bugs

* While using the search order functionality, if the title doesn't exist, the application breaks

## License
[![License](https://img.shields.io/badge/License-BSD_3--Clause-blue.svg)](https://opensource.org/licenses/BSD-3-Clause)

&copy; _Copyright 2022 Helen Lehrer_