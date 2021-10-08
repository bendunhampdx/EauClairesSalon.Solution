# Hair Salon

#### A program that creates a webpage utilizing databases.

#### By Ben Dunham

## Technologies Used

* C#
* MSTest
* .NET
* ASP.NET Core
* LINQ
* MySQL

## Description

This program creates a site for a list of clients associated with a Hair Salon stylist. It utilizes Html helpers and creates a one-to-many relationship between the stylist and client classes.

## Setup/Installation Requirements

1. Install the [.NET framework](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net50).
2. If on MacOS, Install [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914) and [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391). If on Windows 10 download the [MySQL Web Installer](https://downloads.mysql.com/archives/get/p/25/file/mysql-installer-web-community-8.0.19.0.msi) and follow installation instructions.
3. During installation, note the password used for your server.
4. [Clone](https://github.com/bendunhampdx/EauClairesSalon.Solution) this repository from GitHub to your local machine.
5. Open the new directory.
6. Create a new file called "appsettings.json" in the HairSalon directory.
7. Input the following code into this file (noting where to insert your password):
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid=root;pwd={your password};"
  }
}
```
8. Open a new terminal instance in the EauClairesSalon.Solution/HairSalon directory.
9. Type "dotnet build" in the terminal, then after completion type "dotnet run" to start the program.
10. Open MySQL Workbench and connect to localhost:3306 at root.
11. Select Server > Data Import, Import from Self-Contained File and target hair_salon_dump in the HairSalon.Solution directory.
12. In the Default Schema to be Imported To box, click New, and create a Schema named hair_salon.
13. Select "Dump Structure Only" and click "Start Import"
14. To view, navigate to http://localhost:5000 or https://localhost:5001 in any web browser.

## Known Bugs

* _Upon saving an edited client, client is deleted_

## License

* [MIT License](https://opensource.org/licenses/MIT)