using Reqnroll.TestProjectGenerator.FilesystemWriter;

namespace Reqnroll.TestProjectGenerator.Dotnet
{
    public partial class NewCommandBuilder
    {
        private readonly IOutputWriter _outputWriter;
        private readonly NetCoreSdkInfo _sdk;

        public NewCommandBuilder(IOutputWriter outputWriter, NetCoreSdkInfo sdk)
        {
            _outputWriter = outputWriter;
            _sdk = sdk;
        }

        internal static NewCommandBuilder Create(IOutputWriter outputWriter, NetCoreSdkInfo sdk) => new NewCommandBuilder(outputWriter, sdk);

        public NewSolutionCommandBuilder Solution() => new StubNewSolutionCommandBuilder(_outputWriter, _sdk);

        public NewProjectCommandBuilder Project() => new StubNewProjectCommandBuilder(_outputWriter, _sdk);
    }
}
