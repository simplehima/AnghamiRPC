# AnghamiRPC

AnghamiRPC is a simple application that allows you to integrate Anghami music information with Discord Rich Presence.


## OLD GUI Features

- Display the currently playing Anghami song on your Discord profile.
- Automatically updates your Discord status when you play different songs on Anghami.
  ![image](https://github.com/simplehima/AnghamiRPC/assets/54166348/89b9be96-ba58-4e1c-807e-1b2f5835ed03)

![image](https://user-images.githubusercontent.com/84229419/210231792-aaafecc6-7429-40c7-805f-fd0928601d4e.png)

## Getting Started OLD RPC-GUI

### Requirements

- Windows operating system
- Anghami desktop app
- Discord account

### Prerequisites

- **.NET Core Runtime**: Ensure that you have the .NET Core runtime installed on your machine. You can download it from [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).

#### OLD GUI: Download Release (Windows Only)

1. Go to the [Releases](https://github.com/simplehima/AnghamiRPC/releases) page.
2. Download the latest release ZIP file.
3. Extract the contents.
4. Run the `AnghamiRPC.exe` executable.



## New GUI Source Features

- Display the currently playing Anghami song on your Discord profile.
- Automatically updates your Discord status when you play different songs on Anghami.

![image](https://github.com/voidZiAD/AnghamiRPC/assets/84229419/0a565c12-0396-4380-ae25-b2348b96a3fd)

![image](https://github.com/voidZiAD/AnghamiRPC/assets/84229419/db838260-b750-46c6-a95d-5b7588050078)


## Getting Started RPC-GUI

### Requirements

- Windows operating system
- Anghami desktop app
- Discord account

### Prerequisites

- **.NET Core Runtime**: Ensure that you have the .NET Core runtime installed on your machine. You can download it from [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).

#### Option 1 GUI: Build from Source

1. Clone the repository to your local machine.

   ```bash
   git clone https://github.com/voidZiAD/AnghamiRPC.git
   ```

2. Build the application using the .NET CLI.

   ```bash
   cd AnghamiRPC
   dotnet build
   ```

3. Run the application.

   ```bash
   dotnet run

   ```

#### Option 2 GUI: Download Release (Windows Only)

1. Go to the [Releases](https://github.com/voidZiAD/AnghamiRPC/releases) page.
2. Download the latest release ZIP file.
3. Extract the contents.
4. Run the `AnghamiRPC.exe` executable.

### GUI Usage

1. Launch the AnghamiRPC application.
2. Enter your Discord Client ID in the provided textbox.
3. Click "Login".
4. Your Discord status will now reflect the currently playing Anghami song.

## Getting Started RPC-Script

### Installation Script

1. Clone the repository to your local machine.
   `git clone https://github.com/voidZiAD/AnghamiRPC.git`
2. Open the project in Visual Studio.
3. Build the solution to restore the NuGet packages.
4. Run the program.

### Script Usage

1. Open the Anghami desktop app and start playing a song.
2. Run the AnghamiRPC program.
3. Your current song will be displayed on your Discord profile.

### Compatibility

Versions after Console are only compatible on Windows & Linux (Can be run on Linux using Wine App), Versions before GUI Update are compatible on Windows & Mac & Linux.

## Releases

Check out the [Releases](https://github.com/voidZiAD/AnghamiRPC/releases) page for pre-built executables. Download the latest release ZIP file, extract, and run `AnghamiRPC.exe`.

## Contributions

Created By [@ZiAD](https://github.com/voidZiAD/)

Previous GUI and Patches By [@simplehima](https://github.com/simplehima/)

New GUI by [@ZiAD](https://github.com/voidZiAD/)

### Troubleshooting

If you encounter any issues or errors, please check the following:

- Ensure that your Discord Client ID is correct.
- Verify that Anghami is open and installed on your PC.
- Check for any error messages displayed in the AnghamiRPC application.

If you encounter an issue, you can report it to the **[issues](https://github.com/simplehima/AnghamiRPC/issues)** page, and I may or may not fix it.

## License

This project is licensed under the [MIT License](LICENSE).
