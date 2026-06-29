# Release notes

## v1.1.1

### Changed

- Moved `CustomRPMVoiceHandler` (and the `ReadyPlayerMe.Core` assembly reference) into a dedicated optional assembly (`Reflectis.CreatorKit.Worlds.Placeholders.RPM`) gated by a Define Constraint on `com.readyplayerme.core`. The Placeholders module now compiles **without** the ReadyPlayerMe SDK installed; the RPM voice handler is compiled in automatically only when `com.readyplayerme.core` is present (e.g. in the runtime player), so existing avatar lip-sync behaviour is preserved. The script GUID is unchanged, so existing references are not broken.

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