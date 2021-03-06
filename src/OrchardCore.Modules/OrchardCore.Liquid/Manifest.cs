using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Liquid",
    Author = ManifestConstants.OrchardCoreTeam,
    Website = ManifestConstants.OrchardCoreWebsite,
    Version = ManifestConstants.OrchardCoreVersion,
    Description = "The liquid module enables content items to have liquid syntax.",
    Dependencies = new[] { "OrchardCore.Contents", "OrchardCore.ShortCodes" },
    Category = "Content Management"
)]
