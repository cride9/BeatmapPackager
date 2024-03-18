- [Key Features](#Key_Features)
- [Getting Started](#Getting_Started)
- [Troubleshooting](#Troubleshooting)
- [Note](#Note)

# osu! Beatmap Packager
The osu! Beatmap Packager is a specialized Windows Forms application designed for osu! players and enthusiasts. This tool simplifies the process of sharing your osu! beatmaps with friends or the community by generating a custom script directly from your osu! Songs folder, enabling the recipient to download all shared beatmaps effortlessly into a specified directory.

## Key Features:
- **User-Friendly Interface:** The MainForm interface provides a straightforward and intuitive way for users to select their osu! Songs folder and initiate the packaging process.

- **Automatic Script Creation: **Upon execution, the application can automatically generate either a PowerShell script (downloadMaps.ps1) or a custom pack file (downloadMaps.pack) in the application's base directory, based on the user's choice. These scripts contain commands or data to download the shared beatmaps.

- **Efficient Beatmap Sharing:** Instead of manually sharing each beatmap file, users can share a single script or pack file. This approach streamlines the sharing process and ensures that the recipient can easily download all shared beatmaps.

- **Smart Beatmap Handling:** The program intelligently checks for existing beatmap files in the output directory to avoid unnecessary downloads, only including commands or data for beatmaps that are not already present.

- **Dynamic Feedback:** The application provides real-time feedback to the user through a progress bar, indicating the progress of the script or pack file creation and any potential errors that may occur.

- **Multiple Script Options:** Users can choose to generate either a PowerShell script for individual download commands or a custom .pack file for a more efficient, multithreaded download experience.

- **Progress Bar Visualization:** Added a progress bar that visually represents the current packaging and downloading phases, enhancing user engagement and understanding of the process.

## Getting Started:
1. **Prerequisites: **Ensure that you have .NET 8 installed on your Windows machine.
2. **Download and Installation:** Clone or download this repository, and run the BeatmapPackager.exe application.
3. **Selecting the osu! Songs Folder:** Use the interface to navigate and select your osu! Songs folder.
4. **Generating the Script or Pack File: **Press the execute button to generate the downloadMaps.ps1 PowerShell script or downloadMaps.pack file based on your selection.
5. **Sharing and Using the Script or Pack File:** Share the generated script or pack file with the intended recipient. They will need to run the script in PowerShell or use the application to process the pack file and download the shared beatmaps.

## Troubleshooting:
- **Maps Causing Errors:** Please be aware that maps containing no video attribute may cause errors during the packaging or downloading process. If you encounter such an issue, consider removing these maps from your selection or manually download the video version.

## Note:
This application is developed by the osu! community and is not officially affiliated with osu!

Feel free to contribute, report issues, or suggest improvements to the osu! Beatmap Packager through this GitHub repository.