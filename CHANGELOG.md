# Changelog
All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [2.0.3] - 2026-10-04

### Changed
- Standardized package identity and display name as `com.parkmindev.upm.sqlite.toolkit` / `ParkMinDev.UPM.SQLite.Toolkit`.
- Synchronized own-package dependency versions for this release; C# namespaces and assembly names remain unchanged.

## [2.0.2] - 2026-10-04

### Changed
- Renamed the repository to UPM-SQLite-Toolkit and updated repository links without changing the Unity package identity, namespaces, assemblies, or asset GUIDs.

## [2.0.1] - 2026-10-04

### Changed
- Moved repository links and dependency URLs to ParkMinDev while preserving the package identity.
- Replaced repository dependency metadata with parkmin-upm.json and aligned ParkMin dependency release versions.

## [2.0.0] - 2026-08-17

### Changed
- Changed synchronized observable list initialization to read records through `Query().ToList()`.

### Removed
- Removed the redundant `ReactiveSQLiteTable.ReadAll()` API. Use `Query().ToList()` instead.

## [1.0.1] - 2026-08-16

### Added
- Added PackageManager dependency metadata for `sqlite-net-pcl` and `ObservableCollections.R3`.

### Changed
- Restricted `package.json` dependencies to Unity Registry packages.

## [1.0.0] - 2026-08-16

### Added
- Added SQLite database, query, reactive table, synchronized observable list, record interface, and platform base-path implementations.
- Documented direct and transitive NuGet dependencies.

### Changed
- Changed the runtime namespace from `ParkMin.SQLiteToolkit` to `ParkMinPackages.SQLiteToolkit`.

## [0.1.0] - 2026-08-16

### Added
- Created the initial Unity package structure with Runtime and Editor assembly definitions.
