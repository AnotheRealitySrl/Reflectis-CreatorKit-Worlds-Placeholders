# Release notes

## Unreleased

Warrants a **major** bump at the next platform release: the removed public property and the flipped serialized default are both breaking for authored worlds.

### Changed
- `ManipulablePlaceholder.GizmosEnabled` is replaced by `GizmosDisabled`, with inverted meaning (breaking). Rotation and scale gizmos are now **enabled by default** and the flag turns them off. `PickablePlaceholder` sets `GizmosDisabled = true`, so pickables keep behaving as before.
- POI placeholders read their TMP text at runtime (`TitleText`, `HeaderText`, `BodyText`, `Text`), making the TMP the source of truth; the serialized field is kept as a fallback when the TMP is missing.

### Migration
- The serialized field was renamed **and** its meaning inverted, so the stored value cannot be carried over automatically. Every `ManipulablePlaceholder` already saved in a prefab, scene, or authored world reloads with `GizmosDisabled = false`, i.e. **gizmos on** — where the old default (`GizmosEnabled = false`) kept them off. Worlds that relied on the old default must tick the new flag to restore gizmo-free manipulation.
- Consumers assigning the old property (`placeholder.GizmosEnabled`) must switch to `!placeholder.GizmosDisabled`.

## v4.1.0

### Added
- Added the `OnWrongItemTriggerEnter` UnityEvent to `InventoryItemTriggerDetectorPlaceholder`, so authored worlds can react to the wrong inventory item entering the trigger.

## v4.0.0

### Changed
- Renamed the inventory system to the tool system across placeholders (breaking).

### Added
- New tool/inventory placeholders (consumable, draggable, wearable, slot count, general inventory system).
- Task UI placeholders (introduction callback, description key).
- `IEquippableSystem` and item-count display logic.
- Mobile platform options.

### Deprecated
- Old inventory placeholders marked obsolete in favour of the new tool placeholders.

### Fixed
- Various fixes on pickable and manipulable placeholders.

## v3.0.0

### Added
- Add various ready to use UI prefabs
- Add control manager and informative item placeholders

## v2.2.0

### Added

- Added `ReflectisChatbotPlaceholder` for chatbot with RAG.

## v2.1.0

### Added

- Added inventory placeholders.
- Add flag to select tenant envs in `CSceneChangerPlaceholder`.

## v2.0.1

### Fixed

- Remove unnecessary script `CustomRPMVoiceHandler` which included a wrong dependency to RPM package.

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
