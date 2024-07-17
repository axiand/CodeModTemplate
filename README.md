### This is probably not the version of the template you're looking for.
### Go see FujiAPI/Code-Mod-Template

# Fuji Code Mod

Welcome to the Fuji Code Mod Template!

This template contains all the basic things needed to get started with Fuji modding, including the necessary references, a hot-reload-powered build config, and an entrypoint C# source file for getting started.

You can adjust this file to your needs after reading through it.

## Preparing for setup

Before you begin, please set an environment variable, `FujiDir`, pointing to the location of a valid Fuji installation. This is required for the build & dependency system to work, since they both pull/push files to this location.

Next, take a look at the `Dist/Fuji.json` file. Adjust the fields according to your needs.

Finally, in `FujiCodeMod.csproj`, change `AssemblyName` to the name of your mod.

## Releasing your mod

TODO: expand this part?

For now, all you need to know is that after running `dotnet build` or `dotnet publish`, either in your FujiDir's `Mods` directory or this project's `Dist` directory, you'll find a compiled version of your mod.

You should delete the `Dist/Libraries` folder before running the final build, as there may be old files left around.

You may now zip this dist folder and send it out to the world!

## Enjoy Modding!
