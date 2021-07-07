Fullstack Evaluation

.NET Core: http://bit.ly/2Q8YHOP
.NET (non-Core): http://bit.ly/2JP6lwW

A lot of this is covered in the link, but a couple points to highlight:
    • The exercise is to fix a broken timesheet application
    • This is not intended to be a timed exercise, though it can be done in as few as 2 hours
    • At a minimum, it should run.  However, points for creativity!
    • Requirements and Delivery are below
    • We’re aiming to see how you follow best practices
    • It is a way for our developers to see how you approach and solve a problem using code

## Steps to get the mockup running locally:

1. `git clone <this repository>`
2. Open in visual studio
3. hit F5

Requirements
- The code is a mess; fix it up so that it follows best practices as you know them.
- Implement one of the following stories:
- As a consultant, I want to be able to add a project to my timesheet without leaving the main time entry screen, so I can enter my time faster.
- As a manager, I want to ensure that people don t submit their time unless at least 40 hours are represented on the timesheet.
- As a manager, I want to be notified via email whenever a timesheet has been successfully submitted, so that I can approve the hours immediately. (note - the application doesn't actually have to send the email)

Delivery
Any approach is allowed, as long as it fits within the following constraints:

1. For the purpose of this challenge, authentication and authorization are not required
2. You may code the application in C# only.
3. The solution must run via Run (F5) in Visual Studio.
4. The solution must be turn-key. Any dependencies not included in .NET or already included in the solution must be included with the solution and configured to run correctly. The application _must_ run via Run (F5) in Visual Studio!
5. When emailing us the application, zip all of the solution source, but not the compiled output. Our email system will block executable files, though this is not the only reason for this step. We want to know that you can identify your applications output vs. source.
