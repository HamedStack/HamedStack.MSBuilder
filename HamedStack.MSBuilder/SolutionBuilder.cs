using System.Text;
// ReSharper disable MemberCanBePrivate.Global

namespace HamedStack.MSBuilder;


/// <summary>
/// A class to generate Visual Studio solution (.sln) files.
/// </summary>
public class SolutionBuilder
{
    private readonly List<string> _projects = new();
    private readonly List<string> _folders = new();
    private readonly List<string> _nestedItems = new();
    private readonly Dictionary<string, List<string>> _globalSections = new();
    private string _visualStudioVersion = "16.0.28729.10";
    private string _minVisualStudioVersion = "10.0.40219.1";
    private string _formatVersion = "12.00";

    /// <summary>
    /// Creates a new SolutionBuilder instance.
    /// </summary>
    /// <returns>A new instance of SolutionBuilder.</returns>
    public static SolutionBuilder New() => new();

    /// <summary>
    /// Sets the Visual Studio version.
    /// <example>
    /// <code>
    /// builder.WithVisualStudioVersion("16.0.28729.10");
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="version">The version string.</param>
    /// <returns>The current SolutionBuilder instance.</returns>
    public SolutionBuilder WithVisualStudioVersion(string version)
    {
        _visualStudioVersion = version;
        return this;
    }

    /// <summary>
    /// Sets the minimum Visual Studio version.
    /// <example>
    /// <code>
    /// builder.WithMinimumVisualStudioVersion("10.0.40219.1");
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="version">The minimum version string.</param>
    /// <returns>The current SolutionBuilder instance.</returns>
    public SolutionBuilder WithMinimumVisualStudioVersion(string version)
    {
        _minVisualStudioVersion = version;
        return this;
    }

    /// <summary>
    /// Sets the format version of the solution file.
    /// <example>
    /// <code>
    /// builder.WithFormatVersion("12.00");
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="version">The format version string.</param>
    /// <returns>The current SolutionBuilder instance.</returns>
    public SolutionBuilder WithFormatVersion(string version)
    {
        _formatVersion = version;
        return this;
    }

    /// <summary>
    /// Adds a project to the solution.
    /// <example>
    /// <code>
    /// builder.AddProject("MyProject", "MyProject/MyProject.csproj");
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="name">The name of the project.</param>
    /// <param name="path">The relative path to the project file.</param>
    /// <param name="id">Optional GUID for the project.</param>
    /// <param name="typeId">Optional Type GUID of the project.</param>
    /// <returns>The current SolutionBuilder instance.</returns>
    public SolutionBuilder AddProject(string name, string path, Guid? id = null, Guid? typeId = null)
    {
        var projectId = id ?? Guid.NewGuid();
        var projectTypeId = typeId ?? new Guid("FAE04EC0-301F-11D3-BF4B-00C04F79EFBC");
        _projects.Add($"Project(\"{projectTypeId:B}\") = \"{name}\", \"{path}\", \"{projectId:B}\"");
        return this;
    }

    /// <summary>
    /// Adds a folder to the solution.
    /// <example>
    /// <code>
    /// builder.AddFolder("MyFolder");
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="name">The name of the folder.</param>
    /// <param name="id">Optional GUID for the folder.</param>
    /// <returns>The current SolutionBuilder instance.</returns>
    public SolutionBuilder AddFolder(string name, Guid? id = null)
    {
        var folderId = id ?? Guid.NewGuid();
        _folders.Add($"Project(\"{new Guid("2150E333-8FDC-42A3-9474-1A3956D46DE8"):B}\") = \"{name}\", \"{name}\", \"{folderId:B}\"");
        return this;
    }

    /// <summary>
    /// Adds a nested item to the solution.
    /// <example>
    /// <code>
    /// builder.AddNestedItem(parentGuid, nestedGuid);
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="parent">The parent GUID.</param>
    /// <param name="nested">The nested item GUID.</param>
    /// <returns>The current SolutionBuilder instance.</returns>
    public SolutionBuilder AddNestedItem(Guid parent, Guid nested)
    {
        _nestedItems.Add($"\t\t{nested:B} = {parent:B}");
        return this;
    }

    /// <summary>
    /// Adds a property to the GlobalSection of the solution.
    /// <example>
    /// <code>
    /// builder.AddToGlobalSection("SolutionProperties", "HideSolutionNode = FALSE");
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="sectionName">The name of the section.</param>
    /// <param name="content">The content line to add.</param>
    /// <returns>The current SolutionBuilder instance.</returns>
    public SolutionBuilder AddToGlobalSection(string sectionName, string content)
    {
        if (!_globalSections.ContainsKey(sectionName))
        {
            _globalSections[sectionName] = new List<string>();
        }
        _globalSections[sectionName].Add(content);
        return this;
    }

    /// <summary>
    /// Adds an arbitrary project property to the solution.
    /// <example>
    /// <code>
    /// builder.AddArbitraryProjectProperty(myGuid, "Debug|Any CPU.ActiveCfg", "Debug|Any CPU");
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="projectId">The project GUID.</param>
    /// <param name="propertyName">The name of the property.</param>
    /// <param name="propertyValue">The value of the property.</param>
    /// <returns>The current SolutionBuilder instance.</returns>
    public SolutionBuilder AddArbitraryProjectProperty(Guid? projectId = null, string? propertyName = null, string? propertyValue = null)
    {
        var actualProjectId = projectId ?? Guid.NewGuid();
        return AddToGlobalSection("ProjectConfigurationPlatforms", 
            $"{actualProjectId:B}: {propertyName} = {propertyValue}");
    }

    /// <summary>
    /// Builds the solution and saves it to the given file path.
    /// <example>
    /// <code>
    /// builder.Build("MySolution.sln");
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="filePath">The file path to save the solution to.</param>
    public void Build(string filePath)
    {
        var builder = Build();
        File.WriteAllText(filePath, builder.ToString());
    }

    private StringBuilder Build()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"Microsoft Visual Studio Solution File, Format Version {_formatVersion}");
        builder.AppendLine($"# Visual Studio Version {_visualStudioVersion}");
        builder.AppendLine($"# Minimum Visual Studio Version {_minVisualStudioVersion}");

        foreach (var project in _projects)
        {
            builder.AppendLine(project);
            builder.AppendLine("EndProject");
        }

        foreach (var folder in _folders)
        {
            builder.AppendLine(folder);
            builder.AppendLine("EndProject");
        }

        builder.AppendLine("Global");

        if (_nestedItems.Count > 0)
        {
            builder.AppendLine("\tGlobalSection(NestedProjects) = preSolution");
            foreach (var item in _nestedItems)
            {
                builder.AppendLine(item);
            }
            builder.AppendLine("\tEndGlobalSection");
        }

        foreach (var kvp in _globalSections)
        {
            builder.AppendLine($"\tGlobalSection({kvp.Key}) = postSolution");
            foreach (var line in kvp.Value)
            {
                builder.AppendLine($"\t\t{line}");
            }
            builder.AppendLine("\tEndGlobalSection");
        }

        builder.AppendLine("EndGlobal");
        return builder;
    }
}