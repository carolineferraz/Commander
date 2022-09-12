using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command {Id=1, HowTo="Cut Bread", Line="Get a Knife", Platform="knife & chopping board"},
                new Command {Id=2, HowTo="Make cup of tea", Line="Place teabag in cup", Platform="Kettle & Cup"}
            };
        }

        public Command GetCommandById(int Id)
        {
            return new Command {Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"};
        }
    }
}