# osu! Beatmap Packager

The osu Beatmap Packager is a specialized Windows Forms application designed for osu! players and enthusiasts. This tool simplifies the process of sharing your osu! beatmaps with friends or the community. By generating a custom PowerShell script directly from your osu! Songs folder, the Packager enables the recipient to download all shared beatmaps effortlessly into a specified directory.

## Key Features:
- **User-Friendly Interface:** The MainForm interface provides a straightforward and intuitive way for users to select their osu! Songs folder and initiate the packaging process.
- **Automatic PowerShell Script Creation:** Upon execution, the application automatically generates a downloadMaps.ps1 script in the application's base directory. This script contains commands to download the shared beatmaps into the same directory as the script.
- **Efficient Beatmap Sharing:** Instead of manually sharing each beatmap file, users can share a single PowerShell script. This approach streamlines the sharing process and ensures that the recipient can easily download all shared beatmaps.
- **Smart Beatmap Handling:** The program intelligently checks for existing beatmap files in the output directory to avoid unnecessary downloads. It only includes commands for beatmaps that are not already present.
- **Dynamic Feedback:** Throughout the process, the application provides real-time feedback to the user. This includes messages about the progress of the PowerShell script creation and any potential errors that may occur.

## Getting Started:
1. **Prerequisites:** Ensure that you have .NET 8 installed on your Windows machine.
2. **Download and Installation:** Clone or download this repository, and run the BeatmapPackager.exe application.
3. **Selecting the osu! Songs Folder:** Use the interface to navigate and select your osu! Songs folder.
4. **Generating the Script:** Press the execute button to generate the downloadMaps.ps1 PowerShell script.
5. **Sharing and Using the Script:** Share the generated PowerShell script with the intended recipient. They will need to run the script in PowerShell to download the shared beatmaps.
## Note:
This application is developed by the osu! community and is not officially affiliated with osu!

Feel free to contribute, report issues, or suggest improvements to the osu Beatmap Packager through this GitHub repository.
