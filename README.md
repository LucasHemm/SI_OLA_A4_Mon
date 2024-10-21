# SI_OLA_A4_Mon
Table of contents:
- [SI\_OLA\_A4\_Mon](#si_ola_a4_mon)
- [Solution](#solution)
- [DDD approcahes](#ddd-approcahes)
- [Running the project](#running-the-project)

# Solution
Our solution has been created in ASP.NET Core, using .NET 8, the solution is a rest api. 
Currently it's a monolith which has been built using DDD. We have used the models created in our ola 3 to create the rest api. 
# DDD approaches
We used the bounded context we created in our ola 3 based on the functional requirements. These have been implemented in the solution as their own domain directory. Reflecting on it now the directories and structure should be named context and not domain, as domains is a part of the bounded context.

However, we still managed to create the app based on each domain(bounded context), making sure that it was separated from the other domains. So the business logic and models and controllers are all in their own domain.
We didn't have time to seperate it out into microservices, but we have created the solution in a way that it can be easily done. We had planned to make the trailer domain(bounded context) into its own microservice, where we would also have a seperate database for it.

# Running the project
To run the project, fork the repository and clone it to your local machine. 
Make sure you have docker installed on your machine.
Then use the docker compose file in the project to set up both the app and database, using this command:

```bash
docker-compose up --build
```
