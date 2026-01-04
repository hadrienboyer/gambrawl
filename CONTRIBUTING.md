# Contributing to Gambrawl

Thank you for your interest in contributing to Gambrawl!

## Development Environment

### Requirements
- Unity 6.3.0f1 or later
- Git
- For Android: Android SDK and NDK
- For iOS: Xcode (macOS only)

### Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/HadrienBoyer/gambrawl.git
   cd gambrawl
   ```

2. **Open in Unity**
   - Open Unity Hub
   - Click "Add" and select the cloned repository folder
   - Unity will automatically import all packages and configure the project

3. **Project Structure**
   - `Assets/Scenes/` - Game scenes
   - `Assets/Scripts/` - C# game scripts
   - `Assets/Settings/` - URP pipeline settings
   - See README.md for full structure

## Coding Standards

### C# Style Guidelines
- Use PascalCase for public methods and properties
- Use camelCase for private fields
- Prefix private fields with underscore (optional)
- Use meaningful variable names
- Add XML documentation comments for public APIs
- Follow Unity's C# coding conventions

### Unity Best Practices
- Use SerializeField for inspector-visible private fields
- Organize scripts in namespaces (use `Gambrawl` namespace)
- Cache component references in Awake() or Start()
- Use object pooling for frequently instantiated objects
- Profile your code regularly

## Mobile Optimization

### Performance Guidelines
- Target 60 FPS on mid-range devices
- Use URP's mobile-optimized shaders
- Minimize draw calls and overdraw
- Use texture atlases where possible
- Implement LOD (Level of Detail) for 3D models
- Profile on actual devices, not just the editor

### Testing
- Test on both Android and iOS devices
- Test on different screen sizes and aspect ratios
- Test on low-end, mid-range, and high-end devices
- Monitor frame rate, memory usage, and battery consumption

## Submitting Changes

### Pull Request Process
1. Create a feature branch from `main`
2. Make your changes
3. Test thoroughly on target platforms
4. Submit a pull request with a clear description
5. Wait for review and address any feedback

### Commit Messages
- Use clear, descriptive commit messages
- Start with a verb (Add, Fix, Update, Remove, etc.)
- Keep the first line under 72 characters
- Add details in the commit body if needed

Example:
```
Add player movement system with touch controls

- Implement touch-based movement
- Add configurable movement speed
- Support both touch and mouse input for testing
```

## Questions?

If you have questions or need help, please open an issue on GitHub.

Happy coding! 🎮
