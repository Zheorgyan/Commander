using Commander.Models;
using System;
using System.Collections.Generic;

namespace Commander.Data
{
    public class MockCommanderRepository : ICommanderRepository
    {
        public void CreateCommmand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" },
                new Command { Id = 1, HowTo = "Cut bread", Line = "Get a knife", Platform = "Knife & chopping board" },
                new Command { Id = 2, HowTo = "Make cup of tea", Line = "Place teabab in cup", Platform = "Kettle & cup" }
            };

            return commands;
        }
        
        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
