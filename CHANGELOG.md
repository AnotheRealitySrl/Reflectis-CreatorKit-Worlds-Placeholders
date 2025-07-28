# Release notes

## v2.0.0

### Changed

- Revised `InteractablePlaceholder` structure: 
  now there are three additional scripts `Manipulable`, `VisualScriptingInteractablePlaceholder` and `ContextualMenuPlaceholder`.
- Changed `DashboardFilter` values in `DashboardPlaceholder`.

### Added

- Added option in `ContextualMenuPlaceholder`.
- Added `ScriptDefineSysmbols` utility class to addin the string "REFLECTIS_CREATOR_KIT_WORLDS_PLACEHOLDERS".
- Added non collider option in `InteractablePlaceholder`.

### Fixed 

- Fixed minor issue in `POIPlaceholder`.
- Fixed minor issue in `CustomRPMVoiceHandler`.

## v1.1.0

### Added

- Add RPM placeholders for handling voice and eye blink

### Fixed

- Fixed `POIPlaceholder` initialization.
- Improved `EnvironmentalDashboard`, `POIPlaceholder` and `ChatBotPlaceholders` to simplify their structure.

### Removed 

- Removed `UnselectOnDestroy` reference from `InteractablePlaceholder`, since now the unselection on destroy is managed automatically.

## v1.0.0

- Initial release.