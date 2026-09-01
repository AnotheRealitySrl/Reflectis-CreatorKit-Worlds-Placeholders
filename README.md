# Virtuademy-CreatorKit-Worlds-Placeholders

## `[MovedFrom]` on the runtime types — what it does, and what it does not

Every top-level runtime type carries
`[MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]`,
recording where it lived before the rename.

**It helps** a project whose scenes and prefabs still reference the old names: they
deserialise instead of coming back as missing scripts, which keeps a creator project
openable before its owner runs the rename migrator.

**It does not help AssetBundles.** Measured on 2026-09-01: with the attribute compiled
into the assembly and the editor recompiled, a world built before the rename still lost
every placeholder. A bundle records its components by assembly name in its own type
information and Unity resolves that against the loaded assemblies directly, without
consulting the attribute. Worlds published before the rename therefore have to be
rebuilt — see `docs/brand-rename-cutover.md` in the meta-repo.
