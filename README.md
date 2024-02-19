# ReminderApplication

ReminderApp is an API project that creates a meeting in the selected time period, in a vote made with the participation of the people they choose to vote, when a registered person wants to create a meeting or meeting.





## Requirements
- .Net 7 SDK
- MsSql
- Postman
- Entity Framework Core
## Loading

Enter the terminal.

To clone the project

```bash
  git clone https://github.com/kadirdemirkaya/ReminderApplication.git
```

You need to change the information in the .json file in the API layer according to your needs.

```bash
  appsettings.json
```

You need to enter in the persistence layer, create migrations and then save them.

```bash
  dotnet ef migrations add "your_migration_name"
  dotnet ef database update
```

Enter the API layer and then launch the project

```bash
  dotnet run
```

## Client Part of the Project is Located Here

- Project Client part is available in the link below.

[https://github.com/ugurakcaydev/Reminder](https://github.com/ugurakcaydev/Reminder)

  
## Features

- Authentication
    - Users' access to the API is controlled by a JWT-based authentication mechanism.
    - Can continue his session with RefreshToken.
- Error Handling and Logging
    - The application processes errors appropriately and returns meaningful error messages to the user.
    - Logs are saved to a file or other storage medium using the Serilog library.
- Tests
    - Integration tests are done with a real database connection
- Real-Time communication
    - With SignalR, notification, user count and tracking are carried out in real time.
- Picture
    - Can upload, update or fetch images for the user

    
    
## API Endpoints and Functionality
    
Meeting Controller:
- `GET api/Meeting/Create-Meeting`: Creates a meeting.
- `Get api/Meeting/Active-Meeting`: Gets the active meetings of the logged in person.
- `PUT api/Meeting/Disactive-Meeting-Update` : Cancel meeting
- `POST api/Meeting/Add-Vote-For-Meeting`: Invited users vote.
- `GET api/Meeting/Get-Single-Meeting-For-User`: Gets a single meeting information.

Comment Controller:
- `POST api/Comment/Create-Comment` : Creating comments
- `DELETE api/Comment/Delete-Comment` : Deleting comments
- `PUT api/Comment/Update-Comment` : Comment update
- `GET api/Comment/Get-All-Comment` : Getting all comments

User Controller:
- `POST api/User/Register-User`: Registering a user
- `POST api/User/Login-User`: Where users log in
- `DELETE api/User/Delete-User` : Delete user
- `GET api/User/Get-User-With-Token` : Obtaining user information with token
- `GET api/User/Refresh-Token` : Resresh token verification location
- `POST api/User/User-Image-Add`: Place to add images to the user
- `GET api/User/User-Image-Get`: Where the image of the logged in user is brought
