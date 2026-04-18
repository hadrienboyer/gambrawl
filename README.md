# Gambrawl

A mobile game built with Unity 6.3 and Universal Render Pipeline (URP).

## Project Details

- **Engine**: Unity 6.3.0f1
- **Render Pipeline**: Universal Render Pipeline (URP) 17.0.3
- **Target Platforms**: Android & iOS
- **Project Type**: Mobile Game

## Project Structure

```
Assets/
├── Scenes/          # Game scenes
├── Scripts/         # C# scripts
├── Materials/       # Materials and shaders
├── Prefabs/         # Reusable game objects
├── Sprites/         # 2D sprites and textures
├── Textures/        # Texture assets
├── Audio/           # Sound effects and music
├── Settings/        # URP and project settings
└── Editor/          # Editor scripts

ProjectSettings/     # Unity project configuration
Packages/            # Package dependencies
```

## Features

- **Optimized for Mobile**: Configured with mobile-specific rendering settings
- **URP Pipeline**: Lightweight rendering optimized for performance
- **Multi-Platform**: Support for both Android (API 24+) and iOS (13.0+)
- **Quality Presets**: Low, Medium, and High quality settings

## Development Setup

1. Install Unity 6.3.0f1 or later
2. Clone this repository
3. Open the project in Unity Hub
4. The project will automatically download required packages

## Build Settings

### Android
- Minimum API Level: 24 (Android 7.0)
- Target API Level: 34 (Android 14)
- Scripting Backend: IL2CPP
- Architecture: ARMv7 + ARM64

### iOS
- Minimum iOS Version: 13.0
- Target SDK: Latest

## License

See [LICENSE](LICENSE) file for details.
