namespace FujiCodeMod;

using Celeste64;
using Celeste64.Mod;

using MonoMod.RuntimeDetour;

// FujiCodeMod is the entry point of your mod - extending from Fuji's GameMod class.
public class FujiCodeMod : GameMod
{
    // This template includes some common functions:
    public override void OnModLoaded()
    {
        // Ran when the mod is loaded.
    }

    public override void OnModUnloaded()
    {
        // Ran when the mod is unloaded.
    }

    public override void OnGameLoaded(Game game)
    {
        // Ran when the game has finished loading.
    }

    public override void Update(float deltaTime)
    {
        // Ran every frame.
    }
}
