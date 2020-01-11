using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using Dealership.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dealership.Engine
{
    public sealed class DealershipEngine : IEngine
    {
        // Commands constants
        public const string InvalidCommand = "Invalid command!";
        
        public const string UserAlreadyExist = "User {0} already exist. Choose a different username!";
        public const string UserLoggedInAlready = "User {0} is logged in! Please log out first!";
        public const string UserRegisterеd = "User {0} registered successfully!";
        public const string UserNotLogged = "You are not logged! Please login first!";
        public const string NoSuchUser = "There is no user with username {0}!";
        public const string UserLoggedOut = "You logged out!";
        public const string UserLoggedIn = "User {0} successfully logged in!";
        public const string WrongUsernameOrPassword = "Wrong username or password!";
        public const string YouAreNotAnAdmin = "You are not an admin!";
        
        public const string CommentAddedSuccessfully = "{0} added comment successfully!";
        public const string CommentRemovedSuccessfully = "{0} removed comment successfully!";
        
        public const string VehicleRemovedSuccessfully = "{0} removed vehicle successfully!";
        public const string VehicleAddedSuccessfully = "{0} added vehicle successfully!";
        
        public const string RemovedVehicleDoesNotExist = "Cannot remove comment! The vehicle does not exist!";
        public const string RemovedCommentDoesNotExist = "Cannot remove comment! The comment does not exist!";
        
        public const string CommentDoesNotExist = "The comment does not exist!";
        public const string VehicleDoesNotExist = "The vehicle does not exist!";        

        private IDealershipFactory factory;
        private ICollection<IUser> users;
        private IUser loggedUser;

        public DealershipEngine(IDealershipFactory factory)
        {
            this.factory = factory;
            this.users = new List<IUser>();
            this.loggedUser = null;
        }

        public void Start()
        {
            var commands = this.ReadCommands();
            var commandResult = this.ProcessCommands(commands);
            this.PrintReports(commandResult);
        }

        public void Reset()
        {
            //this.factory = new DealershipFactory();
            this.users = new List<IUser>();
            this.loggedUser = null;
            var commands = new List<ICommand>();
            var commandResult = new List<string>();
            this.PrintReports(commandResult);
        }


        private IList<ICommand> ReadCommands()
        {
            var commands = new List<ICommand>();

            var currentLine = Console.ReadLine();

            while (!string.IsNullOrEmpty(currentLine))
            {
                var currentCommand = new Command(currentLine);
                commands.Add(currentCommand);

                currentLine = Console.ReadLine();
            }

            return commands;
        }

        private IList<string> ProcessCommands(IList<ICommand> commands)
        {
            var reports = new List<string>();

            foreach (var command in commands)
            {
                try
                {
                    var report = this.commandHandler.Handle(command);
                    reports.Add(report);
                }
                catch (Exception ex)
                {
                    reports.Add(ex.Message);
                }
            }

            return reports;
        }

        private void PrintReports(IList<string> reports)
        {
            var output = new StringBuilder();

            foreach (var report in reports)
            {
                output.AppendLine(report);
                output.AppendLine(new string('#', 20));
            }

            Console.Write(output.ToString());
        }

        private string ProcessSingleCommand(ICommand command)
        {
            
        }
    }
}
