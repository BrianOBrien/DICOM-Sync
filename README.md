# DICOM Commander

**DICOM Commander** is a DICOM networking utility designed to **synchronize imaging studies between DICOM servers**.

It uses **C-FIND** to discover studies on a source system and **C-MOVE** to instruct that system to send studies **directly to a destination DICOM server**.  
DICOM Commander does **not** retrieve or store images locally.

---

## Asynchronous Dual-PACS Query (First Success)

The screenshot below shows **DICOM Commander** performing an **asynchronous C-FIND** against two independent PACS endpoints.  
Results are displayed **side-by-side** without UI blocking, validating the core async query architecture.

![Asynchronous dual-PACS query](docs/images/DicomCommander.png)

---

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

---

## Features

- Dual PACS comparison (Left PACS vs. Right PACS)
- Independent async queries per PACS
- AE Management (AE Title, Hostname, Port, Echo)
- Query controls with global date range selector
- Hierarchical TreeView for Study → Series browsing
- Sync actions:
  - Query Left
  - Query Right
  - Left → Right
  - Right ← Left
  - Sync
  - Pause

---

## Technology

- Built with **Xojo**
- Uses **dcmtk** for DICOM networking
- Cross-platform:
  - Linux (Raspberry Pi)
  - macOS
  - Windows

---

## Documentation

Full documentation is available in the `docs/` folder and published via GitHub Pages.

Start here: `docs/index.md`

---

## Status

This project is in active development.

- Core UI and async query model implemented
- Diffing, sync-state overlays, and automation are in progress

---

## Building

(Build instructions to be added)

