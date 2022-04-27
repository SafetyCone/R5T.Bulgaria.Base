using System;

using R5T.T0064;


namespace R5T.Bulgaria
{
    [ServiceDefinitionMarker]
    public interface IDropboxDirectoryPathProvider : IServiceDefinition
    {
        string GetDropboxDirectoryPath();
    }
}
