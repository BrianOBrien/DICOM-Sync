# DICOM Commander
## Asynchronous Dual-PACS Query

![Asynchronous query from two PACS](docs/images/dicom_commander_async_query.png)
![image](https://github.com/BrianOBrien/DICOM-Commander/docs/images/dicom_commander_async_query.png

**DICOM Commander** is a DICOM networking utility designed to **synchronize imaging studies between DICOM servers**.

It uses **C-FIND** to discover studies on a source system and **C-MOVE** to instruct that system to send studies **directly to a destination DICOM server**.  
DICOM Commander does **not** retrieve or store images locally.

## What DICOM Commander Does

- DICOM Verification (C-ECHO)
- Study and Series discovery using C-FIND
- Server-to-server synchronization using C-MOVE

## What DICOM Commander Does NOT Do

- No local image storage
- No C-GET retrieval
- No Modality Worklist (MWL)
- Not a PACS
- No persistent configuration file (currently)

## Core Design Principle

DICOM Commander treats DICOM operations as **remote execution**, not data ingestion.  
Pixel data always flows **between servers**, never through DICOM Commander itself.

## Documentation

Full documentation is available in the `docs/` folder and published via GitHub Pages.

Start here: `docs/index.md`

A cross-platform DICOM synchronization and query tool built using Xojo and dcmtk


### Features
- Dual PACS comparison (Left PACS vs. Right PACS)
- AE Management (AE Title, Hostname, Port, Echo)
- Query controls with global date range selector
- TreeView for browsing study/series data
- Sync actions:
  - Query Left
  - Query Right
  - Left → Right
  - Right ← Left
  - Sync
  - Pause

### Technology
- Cross-platform: Linux (Pi), macOS, Windows

### Status
This is an early UI skeleton — functionality will be implemented next.

---

## Building

