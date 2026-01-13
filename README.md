# yureteruWPF

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE) ![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white) ![WPF](https://img.shields.io/badge/WPF-%20-blueviolet) ![Windows](https://img.shields.io/badge/Platform-Windows-0078D6?logo=windows&logoColor=white)

EN | 日本語

## Table of contents | 目次
- [English](#english)
  - [Overview](#overview)
  - [Features](#features)
  - [Requirements](#requirements)
  - [Setup & Run](#setup--run)
  - [Publish (Create distributables)](#publish-create-distributables)
  - [Dependencies (partial)](#dependencies-partial)
  - [License](#license)
  - [Author](#author)
  - [Notes](#notes)
  - [Screenshots](#screenshots)
- [日本語](#日本語)
  - [概要](#概要)
  - [機能](#機能)
  - [動作環境](#動作環境)
  - [セットアップ & 実行](#セットアップ--実行)
  - [配布バイナリの作成（Publish）](#配布バイナリの作成publish)
  - [依存パッケージ（一部）](#依存パッケージ一部)
  - [ライセンス](#ライセンス)
  - [著者](#著者)
  - [開発メモ](#開発メモ)
  - [スクリーンショット](#スクリーンショット)

## English
A .NET/WPF implementation of "yureteru". This is a Windows-only desktop application.

### Overview
- GUI app built with WPF (.NET 10)
- MVVM using CommunityToolkit.Mvvm
- Charts via LiveChartsCore (SkiaSharp)

### Features
- Real-time charting with LiveChartsCore
- Audio input via NAudio (e.g., device capture)
- Serial port I/O via System.IO.Ports
- MVVM-first architecture with DI
### Requirements
- Windows 10/11
- .NET SDK 10.0+ to build
  - For runtime only: .NET Desktop Runtime 10.0+
- Optional: Visual Studio with ".NET desktop development" workload, or the `dotnet` CLI

### Setup & Run
NuGet packages are restored automatically during build.

```powershell
dotnet build -c Release
dotnet run --project YureteruWPF.csproj
```

### Publish (Create distributables)
The following creates a framework-dependent package. Adjust `-r win-x64` or use `--self-contained true` as needed.

```powershell
dotnet publish YureteruWPF.csproj -c Release -r win-x64 --self-contained false -o publish
```

Self-contained (no runtime required) example:

```powershell
dotnet publish YureteruWPF.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:PublishReadyToRun=true -o publish-sc
```

Note: Trimming is not enabled by default; enabling trimming can break WPF apps due to reflection. Test thoroughly if you add `-p:PublishTrimmed=true`.

Artifacts are placed under `publish/` or `publish-sc/`.

### Dependencies (partial)
- CommunityToolkit.Mvvm 8.2.2
- LiveChartsCore.SkiaSharpView.WPF 2.0.0-rc3.3
- Microsoft.Extensions.DependencyInjection 9.0.0
- NAudio 2.2.1
- System.IO.Ports 9.0.0

See `YureteruWPF.csproj` for the full, authoritative list.

### License
MIT License. See `LICENSE`.

### Author
halka

### Notes
- WPF-based: Windows only.
- When upgrading .NET, verify `TargetFramework` (current: `net10.0-windows`).

### Screenshots
TBD (add images under `docs/images/` and reference them here).

---

## 日本語
.NET/WPF 版の「yureteru」です。Windows 専用のデスクトップアプリとして実装しています。

### 概要
- WPF (.NET 10) を使用した GUI アプリ
- MVVM (CommunityToolkit.Mvvm) 採用
- グラフ描画に LiveChartsCore (SkiaSharp) を利用

### 機能
- LiveChartsCore によるリアルタイムグラフ
- NAudio による音声入力（デバイスキャプチャ 等）
- System.IO.Ports によるシリアルポート入出力
- DI を用いた MVVM ファーストな構成
### 動作環境
- Windows 10/11
- .NET SDK 10.0 以降（ビルド用）
  - 実行のみの場合は .NET デスクトップ ランタイム 10.0 以降
- （任意）Visual Studio + 「.NET デスクトップ開発」ワークロード、または `dotnet` CLI

### セットアップ & 実行
NuGet パッケージはビルド時に自動で復元されます。

```powershell
dotnet build -c Release
dotnet run --project YureteruWPF.csproj
```

### 配布バイナリの作成（Publish）
以下はランタイム共有（framework-dependent）パッケージの例です。必要に応じて `-r win-x64` や `--self-contained true` に変更してください。

```powershell
dotnet publish YureteruWPF.csproj -c Release -r win-x64 --self-contained false -o publish
```

自己完結（ランタイム不要）の例:

```powershell
dotnet publish YureteruWPF.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:PublishReadyToRun=true -o publish-sc
```

注意: 既定でトリミングは有効化していません。`-p:PublishTrimmed=true` を追加すると反射の影響で WPF アプリが動作しなくなる可能性があります。適用時は十分に検証してください。

出力物は `publish/` または `publish-sc/` 配下に生成されます。

### 依存パッケージ（一部）
- CommunityToolkit.Mvvm 8.2.2
- LiveChartsCore.SkiaSharpView.WPF 2.0.0-rc3.3
- Microsoft.Extensions.DependencyInjection 9.0.0
- NAudio 2.2.1
- System.IO.Ports 9.0.0

正確な情報は `YureteruWPF.csproj` を参照してください。

### ライセンス
MIT License。`LICENSE` を参照してください。

### 著者
halka

### 開発メモ
- 本プロジェクトは WPF のため Windows 専用です。
- .NET のメジャーアップデートに追随する際は `TargetFramework` を確認してください（現在: `net10.0-windows`）。

### スクリーンショット
準備中（`docs/images/` 配下に画像を追加して参照してください）。
