# Tournament Tracker

## Project Summary:
- Tournament Tracker is a Winforms application that allows users to create and play through elimination-style tournaments.
- It allows users to create team members, teams, prizes, and then proceeds to randomize the rounds and matchups to create a tournament.
- Technology used:SQL Database, Text File Storage, Dapper, Linq, Interfaces, Emailing from C#, Custom Events

## Database

- Diagram 
![screencapture-localhost-14014-Celebrity-List-2022-07-27-13_07_22](https://github.com/sowndv02/TournamentTracker/blob/157c37aee9f5792f009e45f84aaf3ede74c488d2/images/Screenshot%202023-08-03%20141934.png)
- Procedure
![screencapture-localhost-14014-Celebrity-List-2022-07-27-13_07_22](https://github.com/sowndv02/TournamentTracker/blob/157c37aee9f5792f009e45f84aaf3ede74c488d2/images/Screenshot%202023-08-03%20142011.png)

## UI
- Create Prize

![screencapture-localhost-14014-Celebrity-List-2022-07-27-13_07_22](https://github.com/sowndv02/TournamentTracker/blob/157c37aee9f5792f009e45f84aaf3ede74c488d2/images/Screenshot%202023-08-03%20142157.png)

- Create Team
![screencapture-localhost-14014-Celebrity-List-2022-07-27-13_07_22](https://github.com/sowndv02/TournamentTracker/blob/157c37aee9f5792f009e45f84aaf3ede74c488d2/images/Screenshot%202023-08-03%20142223.png)
- Create Tournament
![screencapture-localhost-14014-Celebrity-List-2022-07-27-13_07_22](https://github.com/sowndv02/TournamentTracker/blob/157c37aee9f5792f009e45f84aaf3ede74c488d2/images/Screenshot%202023-08-03%20142240.png)
- Dashboard
![screencapture-localhost-14014-Celebrity-List-2022-07-27-13_07_22](https://github.com/sowndv02/TournamentTracker/blob/157c37aee9f5792f009e45f84aaf3ede74c488d2/images/Screenshot%202023-08-03%20142259.png)
- View Tournament
![screencapture-localhost-14014-Celebrity-List-2022-07-27-13_07_22](https://github.com/sowndv02/TournamentTracker/blob/157c37aee9f5792f009e45f84aaf3ede74c488d2/images/Screenshot%202023-08-03%20142357.png)
- View Tournament Result
![screencapture-localhost-14014-Celebrity-List-2022-07-27-13_07_22](https://github.com/sowndv02/TournamentTracker/blob/157c37aee9f5792f009e45f84aaf3ede74c488d2/images/Screenshot%202023-08-03%20142450.png)

# Demo 

[![Watch the video](https://github.com/sowndv02/TournamentTracker/blob/157c37aee9f5792f009e45f84aaf3ede74c488d2/images/Screenshot%202023-08-03%20143905.png)](https://www.youtube.com/embed/bUYA4_HZup0")


# Note
- The tournament matches the number of teams that are multiples of 2: 2, 4, 8, 16, 32.....
- If there is a number of teams other than a multiple of 2, the extra teams will be randomly eliminated
- The order of the tournament should be random.
- Matches are not scheduled
- In order for the following rounds to start, the previous rounds must be completed
- Scores are stored or the winning team has a score of 1 and the losing team has a score of 0
- The data is stored in the database and backed up by a csv file
- Emails are sent to the winning team and the team with the schedule

## Contributing

Contributions are always welcome!

## Support

For support, email <sondv.work.dev@gmail.com>
