# _Identity Roles Template_

#### By: _**David Gamble**_

#### _Files, Code, and setup with comments for using Identity and Roles to add to projects._

## Technologies Used

* _C#_
* _.NET 6_
* _ASP.NET Core MVC 6_
* _Entity Framework Core_
* _MySql_
* _MS Tests_

## Description

_This is a template with code for Identity authorization and rolls.  The main branch has the basic code for registering users and logging in and out while the roles branch implements the use of roles.  Copy code to project to implement adding code to authroize where needed._

## Setup/Installation Requirements

* _Clone the repository to your desktop from: https://github.com/DavidDGamble/ASPNETIdentityRoles.Solution.git_
* _Create appsettings.json file in ASPNETIdentityRoles folder_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[database_name];uid=[USERNAME];pwd=[PASSWORD];"
  }
}
```
* _run dotnet commands below in PierresTreats_
```
dotnet restore
```
```
dotnet ef database update
```
```
dotnet watch run
```

## Known Bugs

* _No known issues_

## License

_Copyright (c) 2022 David Gamble_

_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._
