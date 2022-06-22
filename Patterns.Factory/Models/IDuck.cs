using Patterns.Factory.VoiceServices;

namespace Patterns.Factory.Models
{
    internal interface IDuck
    {
        string Name { get; set; }
        string StarSign { get; set; }
        IVoice Voice { get; set; }
    }
}