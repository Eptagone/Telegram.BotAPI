# Tools

This folder contains an advanced script for code generation. It scrapes the [telegram bot api documentation](https://core.telegram.org/bots/api) to get all required information and generates the code for all models and extension methods for this library.

Feel free to use and/or modify the script for your own needs.

## Requirements

- .NET 8 or higher
- [dotnet-script](https://github.com/dotnet-script/dotnet-script)

## Usage

```bash
# Linux/Mac
main.csx
# or with output directory
main.csx <output-directory>

# Windows
dotnet script main.csx
# or with output directory
dotnet script main.csx <output-directory>
```

> **Note:** If you don't specify an output directory, the script will generate the code in a `publish` folder.
