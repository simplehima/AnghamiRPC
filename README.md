
# AnghamiRPC

AnghamiRPC is a simple application that allows you to integrate Anghami music information with Discord Rich Presence.

## Features

- Display the currently playing Anghami song on your Discord profile.
- Automatically updates your Discord status when you play different songs on Anghami.
![image](https://github.com/simplehima/AnghamiRPC/assets/54166348/89b9be96-ba58-4e1c-807e-1b2f5835ed03)

## Getting Started

### Prerequisites

- **.NET Core Runtime**: Ensure that you have the .NET Core runtime installed on your machine. You can download it from [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).

#### Option 1: Build from Source

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
    
 #### Option 2: Download Release (Windows Only)

1. Go to the [Releases](https://github.com/yourusername/AnghamiRPC/releases) page.
2. Download the latest release ZIP file.
3. Extract the contents.
4. Run the `AnghamiRPC.exe` executable.


### Usage

1. Launch the AnghamiRPC application.
2. Enter your Discord Client ID in the provided textbox.
3. Click the "Browse" button to select the Anghami executable file (Anghami.exe).
4. Click the "Start" button to begin integrating Anghami with Discord.
5. Your Discord status will now reflect the currently playing Anghami song.


## Releases

Check out the [Releases](https://github.com/simplehima/AnghamiRPC/releases) page for pre-built executables. Download the latest release ZIP file, extract, and run `AnghamiRPC.exe`.

### Configuration

- You can change your Discord Client ID and Anghami executable path by modifying the settings in the AnghamiRPC application.

### Troubleshooting

If you encounter any issues or errors, please check the following:

- Ensure that your Discord Client ID is correct.
- Verify that the selected Anghami executable path is accurate.
- Check for any error messages displayed in the AnghamiRPC application.

## License

This project is licensed under the [MIT License](LICENSE).


---

