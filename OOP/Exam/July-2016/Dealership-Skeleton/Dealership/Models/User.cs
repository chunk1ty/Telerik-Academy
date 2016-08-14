namespace Dealership.Models
{
    using Common;
    using Common.Enums;
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class User : IUser
    {
        private const string UsernameProperty = "Username";
        private const string FirstNameProperty = "Firstname";
        private const string LastNameProperty = "Lastname";
        private const string PasswordProperty = "Password";

        private string userName;
        private string firstName;
        private string lastName;
        private string password;
        private Role role;
        private IList<IVehicle> vehicles;

        public User(string userName, string firstName, string lastName, string password, Role role)
        {
            this.userName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.role = role;
            this.Vehicles = new List<IVehicle>();

            this.FieldsValidation();
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
        }

        public Role Role
        {
            get
            {
                return this.role;
            }
        }

        public string Username
        {
            get
            {
                return this.userName;
            }
        }

        public IList<IVehicle> Vehicles
        {
            get
            {
                return this.vehicles;
            }
            private set
            {
                this.vehicles = value;
            }
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            Validator.ValidateNull(commentToAdd, string.Format(Constants.CommentCannotBeNull, commentToAdd));
            Validator.ValidateNull(vehicleToAddComment, string.Format(Constants.VehicleCannotBeNull, vehicleToAddComment));

            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            Validator.ValidateNull(vehicle, Constants.VehicleCannotBeNull);

            if (this.Role == Role.Admin)
            {
                throw new ArgumentException(Constants.AdminCannotAddVehicles);
            }

            if (this.Role == Role.Normal && this.Vehicles.Count >= Constants.MaxVehiclesToAdd)
            {
                throw new ArgumentException(string.Format(Constants.NotAnVipUserVehiclesAdd, Constants.MaxVehiclesToAdd));
            }

            this.Vehicles.Add(vehicle);
        }

        public string PrintVehicles()
        {
            var builder = new StringBuilder();

            var counter = 1;
            builder.AppendLine(string.Format("--USER {0}--", this.Username));

            if (this.Vehicles.Count <= 0)
            {
                builder.AppendLine("--NO VEHICLES--");
            }
            else
            {
                foreach (var vehicle in this.Vehicles)
                {
                    builder.AppendLine(string.Format("{0}. {1}", counter, vehicle.ToString()));
                    counter++;
                }
            }

            return builder.ToString().Trim();
        }

        public override string ToString()
        {
            return string.Format(Constants.UserToString, this.Username, this.FirstName, this.LastName, this.Role);
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            Validator.ValidateNull(commentToRemove, string.Format(Constants.CommentCannotBeNull, commentToRemove));
            Validator.ValidateNull(vehicleToRemoveComment, string.Format(Constants.VehicleCannotBeNull, vehicleToRemoveComment));

            if (this.Username != commentToRemove.Author)
            {
                throw new ArgumentException(Constants.YouAreNotTheAuthor);
            }

            vehicleToRemoveComment.Comments.Remove(commentToRemove);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            Validator.ValidateNull(vehicle, Constants.VehicleCannotBeNull);

            this.Vehicles.Remove(vehicle);
        }

        private void FieldsValidation()
        {
            Validator.ValidateNull(this.userName, string.Format(Constants.PropertyCannotBeNull, UsernameProperty));
            Validator.ValidateSymbols(this.userName, Constants.UsernamePattern, string.Format(Constants.InvalidSymbols, UsernameProperty));
            Validator.ValidateIntRange(this.userName.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, UsernameProperty, Constants.MinNameLength, Constants.MaxNameLength));

            Validator.ValidateNull(this.firstName, string.Format(Constants.PropertyCannotBeNull, FirstNameProperty));
            Validator.ValidateIntRange(this.firstName.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, FirstNameProperty, Constants.MinNameLength, Constants.MaxNameLength));

            Validator.ValidateNull(this.lastName, string.Format(Constants.PropertyCannotBeNull, LastNameProperty));
            Validator.ValidateIntRange(this.lastName.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, LastNameProperty, Constants.MinNameLength, Constants.MaxNameLength));

            Validator.ValidateNull(this.password, string.Format(Constants.PropertyCannotBeNull, PasswordProperty));
            Validator.ValidateSymbols(this.password, Constants.PasswordPattern, string.Format(Constants.InvalidSymbols, PasswordProperty));
            Validator.ValidateIntRange(this.password.Length, Constants.MinPasswordLength, Constants.MaxPasswordLength, string.Format(Constants.StringMustBeBetweenMinAndMax, PasswordProperty, Constants.MinPasswordLength, Constants.MaxPasswordLength));

        }
    }
}
