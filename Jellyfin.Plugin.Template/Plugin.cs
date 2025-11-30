using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using System;

namespace Jellyfin.Plugin.MetadataExporter
{
    public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        public override string Name => "MetadataExporter";
        public override string Description => "Exports metadata and images to JSON & image files.";

        public override Guid Id => Guid.Parse("5d7b2748-b715-4b45-80d8-cb098b4e90df");

        public Plugin() : base() { }
    }

    public class PluginConfiguration : BasePluginConfiguration
    {
        public string ExportPath { get; set; } = "/metadata_exports";
    }
}
