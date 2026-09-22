# Bharat Rise — Complete Unity Mobile Game

Portrait mobile city-building strategy game for Unity 2022.3 LTS.

## Included
- Main Menu, City, Settings and Achievements
- 12 districts/buildings
- Economy, population, food, energy, happiness, XP and levels
- Year-by-year simulation and random city events
- Mission/progression system
- Persistent local save and reset
- Responsive mobile UI
- Automatic scene generation and Build Settings setup
- Android package configuration
- APK build menu
- GitHub Actions Android build workflow
- EditMode tests
- Release checklist

## Open
1. Clone/download the repository.
2. Open the repository root in Unity Hub with Unity 2022.3.62f1.
3. Let Unity import packages.
4. The editor creates missing scenes automatically.
5. Run Bharat Rise > Build All Scenes.
6. Run Bharat Rise > Configure Android.
7. Press Play from MainMenu.

## Android
Default package ID: com.bharatrise.game. Change it before release if needed.
For Google Play, configure your own signing keystore and build an AAB.

## CI
The workflow requires a UNITY_LICENSE GitHub secret and produces a test APK artifact.

## Release note
A store release still requires a real Unity Editor build, device QA, signing, store assets, privacy policy, and publisher credentials.
