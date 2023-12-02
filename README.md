# AnghamiRPC

AnghamiRPC is a simple application that allows you to integrate Anghami music information with Discord Rich Presence.

## Features

- Display the currently playing Anghami song on your Discord profile.
- Automatically updates your Discord status when you play different songs on Anghami.
  ![image](https://github.com/simplehima/AnghamiRPC/assets/54166348/89b9be96-ba58-4e1c-807e-1b2f5835ed03)

![image](https://user-images.githubusercontent.com/84229419/210231792-aaafecc6-7429-40c7-805f-fd0928601d4e.png)

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
   git clone https://github.com/simplehima/AnghamiRPC.git
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

1. Go to the [Releases](https://github.com/yourusername/AnghamiRPC/releases) page.
2. Download the latest release ZIP file.
3. Extract the contents.
4. Run the `AnghamiRPC.exe` executable.

### GUI Usage

1. Launch the AnghamiRPC application.
2. Enter your Discord Client ID in the provided textbox.
3. Click the "Browse" button to select the Anghami executable file (Anghami.exe).
4. Click the "Start" button to begin integrating Anghami with Discord.
5. Your Discord status will now reflect the currently playing Anghami song.

### Configuration

- You can change your Discord Client ID and Anghami executable path by modifying the settings in the AnghamiRPC application.

## Getting Started RPC-Script

### Installation Script

1. Clone the repository to your local machine.
   `git clone https://github.com/simplehima/AnghamiRPC.git`
2. Open the project in Visual Studio.
3. In **Line 141** Change with you `Client ID` from Discord Portal
4. In **Line 163** and **Line 170** replace `"C:\\Path\\To\\Anghami.exe"` with the actual path to the Anghami executable on your system.
5. Build the solution to restore the NuGet packages.
6. Run the program.

### Script Usage

1. Open the Anghami desktop app and start playing a song.
2. Run the AnghamiRPC program.
3. Your current song will be displayed on your Discord profile.

### Compatibility

This is compatible on **Windows, Mac and Linux**. Enjoy.

## Releases

Check out the [Releases](https://github.com/simplehima/AnghamiRPC/releases) page for pre-built executables. Download the latest release ZIP file, extract, and run `AnghamiRPC.exe`.

## Contributions

- Created By '[@Pronner]'
- GUI and Patches By '[@simplehima]'

### Troubleshooting

If you encounter any issues or errors, please check the following:

- Ensure that your Discord Client ID is correct.
- Verify that the selected Anghami executable path is accurate.
- Check for any error messages displayed in the AnghamiRPC application.

If you encounter an issue, you can report it to the [\***\*issues\*\***](https://github.com/simplehima/AnghamiRPC/issues) page, and I may or may not fix it.

## License

This project is licensed under the [MIT License](LICENSE).
