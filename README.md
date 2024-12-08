This is my first readme file
# **TaskTracker**

## **Description**

Task Tracker is simple CLI tool from roadmap.sh backend beginner projects. 
I chose it primarily to make my first steps in unit testing and finally I wanted to write my first readme.

Nothing really complicated, simple app that performs simple CRUD operations.

__________________________________________________________________________________________________________________________


## **Features **

- CRUD operations on task model.
- Data is read from Tasks.json file inside TaskTracker/TaskTracker/bin/Debug/net8.0.
- If file does not exists it is created and after every usage of an app it is overridden.
- Logic around tasks is unit test covered.

__________________________________________________________________________________________________________________________


## **Technologies used**

- Language: C#
- Framework: .NET 8
- Storage: JSON
- Project structure: Basic OOP approach

____________________________________________________________________________________________________________________________


## Run the app

```bash
git clone https://github.com/karppinski/TaskTracker.git

cd TaskTracker

dotnet run
```

_______________________________________________________________________________________________________________________________

# **Example Tasks.json**

```json
[
  {
    "Id": 1,
    "Description": "Complete the Task Tracker project",
    "Status": "toDo",
    "CreatedAt": "2024-12-08T12:00:00",
    "UpdatedAt": "2024-12-08T12:00:00"
  },
  {
    "Id": 2,
    "Description": "Review PRs",
    "Status": "inProgress",
    "CreatedAt": "2024-12-08T12:10:00",
    "UpdatedAt": "2024-12-08T12:15:00"
  }
]
```
__________________________________________________________________________________________________________________________________

# **License**

Let's be honest, it would be a crime if set other than Unlicence 

____________________________________________________________________________________________________________________________________

# **Future plans**

There are no future plans for this app, I wanted to write my first unit tests in my life and it's accomplished.

### **BUT**

### I am aware of things like
- Poor user input validation
- Processing inputs in most simple, exposed for a lot of errors way.
- Not enough error handlers
- And I could find a lot of other things

### However I need to proceed into next things and trying to make by roadmap.sh beginner project to be perfect, just wsn't my plan for it.

_____________________________________________________________________________________________________________________________________________

# **Task source**

https://roadmap.sh/projects/task-tracker
