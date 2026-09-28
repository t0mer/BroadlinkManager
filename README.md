# BroadlinkManager

A C# application to learn and send IR/RF signals using Broadlink RM devices.

BroadlinkManager is a Windows Forms desktop app that finds Broadlink devices on your local
network and captures infrared codes from your remotes. It is built on a bundled copy of
[SharpBroadlink](https://github.com/ume05rw/SharpBroadlink), a C# port of
[python-broadlink](https://github.com/mjg59/python-broadlink).

> **Project status:** early work in progress. Only device discovery and IR learning work in the
> UI today. The **Send IR**, **Learn RF**, **Send RF** and **Cancel Learning** buttons are in the
> toolbar but do nothing yet. The SharpBroadlink library underneath already supports these
> operations (see [Using the library directly](#using-the-library-directly)).

## Table of contents

- [Features](#features)
- [Supported devices](#supported-devices)
- [Requirements](#requirements)
- [Installation](#installation)
- [Usage](#usage)
- [Output format](#output-format)
- [Using the library directly](#using-the-library-directly)
- [Project structure](#project-structure)
- [Known limitations](#known-limitations)
- [Credits](#credits)
- [Contributing](#contributing)
- [License](#license)

## Features

What the desktop app does today:

- **Scan** finds Broadlink devices on the local network with a UDP broadcast. Each device's
  type and IP address is shown in the output log.
- **Device selector.** Pick a discovered device from the toolbar drop-down. Its IP address is
  written to the log.
- **Learn IR** puts the selected RM / RM Pro device into learning mode, reads the captured
  code, and prints it to the log as hex.
- A colored, scrolling output log that shows each step.

The bundled SharpBroadlink library also supports sending IR/RF, RF frequency sweep and learning,
converting between Broadlink, Pronto and LIRC formats, and Wi-Fi setup of new devices. The app
UI does not use these yet.

<!-- TODO: screenshot -->

## Supported devices

The app's **Learn IR** action works with devices that SharpBroadlink sees as `Rm` or `Rm2Pro`.
From `SharpBroadlink/Devices/Factory.cs`:

| Type | Models |
|------|--------|
| `Rm` | RM2, RM Mini, RM Pro Phicomm, RM2 Home Plus, RM2 Home Plus GDT, RM Mini Shate |
| `Rm2Pro` (IR + RF) | RM2 Pro Plus, RM2 Pro Plus2, RM2 Pro Plus3, RM2 Pro Plus_300, RM2 Pro Plus BL, RM2 Pro Plus HYC, RM2 Pro Plus R1, RM2 Pro PP |

A scan also lists other Broadlink devices the library knows (SP1/SP2/SP3 smart plugs, A1,
MP1, Hysen, S1C, Dooya). You can't learn codes on them. Devices with a type ID that is not in
this table (for example newer RM4 models) are listed as `Unknown`, and **Learn IR**
does not support them.

## Requirements

- Windows with **.NET Framework 4.6.2** or later (the app targets `v4.6.2`).
- A Broadlink RM device on the same local network/subnet as the PC. It must already be set up
  on your Wi-Fi, because discovery uses a broadcast.
- To build: Visual Studio 2017 or later with the .NET desktop workload and .NET Core SDK
  support (SharpBroadlink targets .NET Standard 2.0; ConsoleTest targets .NET Core 2.0, which is end-of-life; ConsoleTest is not needed to run the app).
- **Syncfusion Essential Studio for Windows Forms 17.1.0.47.** The UI uses Syncfusion controls
  (`MetroForm`, `ToolStripEx`, and more), and these assemblies are not in the repository (see
  [Installation](#installation)).

## Installation

There are no published releases, so build from source.

1. Clone the repository:
   ```bash
   git clone https://github.com/t0mer/BroadlinkManager.git
   ```
2. Install Syncfusion Essential Studio for Windows Forms (version 17.1.0.47). The project
   references these assemblies from `BroadlinkManager\bin\Debug\`, which is gitignored:
   `Syncfusion.Grid.Base`, `Syncfusion.Grid.Windows`, `Syncfusion.Grid.Windows.XmlSerializers`,
   `Syncfusion.Licensing`, `Syncfusion.Shared.Base`, `Syncfusion.Shared.Windows`,
   `Syncfusion.SpellChecker.Base`, `Syncfusion.Tools.Base` and `Syncfusion.Tools.Windows`.
   Copy them into that folder, or change the references to point at your Syncfusion install.
   <!-- TODO: verify whether a Syncfusion license key is needed at runtime (no RegisterLicense call exists in the code) -->
3. Open `BroadlinkManager.sln` in Visual Studio and restore NuGet packages.
4. Set **BroadlinkManager** as the startup project, then build and run.

## Usage

1. Start **Broadlink Manager**.
2. Click **Scan**. The log shows `Searching for  devices...` and then each device found, for
   example `Rm (192.168.1.50:80)`. If nothing answers, you'll see `Device not found!`.
3. Choose your RM device in the toolbar drop-down.
4. Open **Commands** and click **Learn IR**.
5. Within about two seconds, point your remote at the Broadlink device and press the button you
   want to capture.
6. The learned code is printed to the log.

## Output format

The **Learn IR** action prints the **raw Broadlink packet** returned by the device. It is
formatted as uppercase hex, in groups of two bytes separated by spaces (for example
`2600 5000 ...`). The code calls the helper `Signals.ProntoBytes2String`, but the data is in
Broadlink format, not Pronto.

This is **not** the base64 format that Home Assistant's Broadlink integration expects. The app
does not export or save codes. They only appear in the log, so copy them from there.
SharpBroadlink has helpers for converting (`Signals.Broadlink2Pronto`,
`Signals.Broadlink2Lirc`, and the `ToBase64()` extension on `byte[]`).

## Using the library directly

`SharpBroadlink` is a .NET Standard 2.0 library you can use in your own code. A short example,
based on `ConsoleTest/Program.cs`:

```csharp
using System;
using System.Linq;
using System.Threading;
using SharpBroadlink;
using SharpBroadlink.Devices;

var devices = await Broadlink.Discover(1);          // timeout in seconds
var rm = (Rm)devices.First(d => d.DeviceType == DeviceType.Rm);
await rm.Auth();

// Learn an IR code (throws TaskCanceledException on timeout)
var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
byte[] code = await rm.LearnIRCommnad(cts.Token);

// Send it back
await rm.SendData(code);
```

`Rm2Pro` devices also expose `LearnRfCommand()`, `LearnRfFrequency()`, `SendRfData()` and
`CancelRfLearning()` for RF. `ConsoleTest` has more samples: discovery, auth, Wi-Fi setup, temperature readout,
IR learning and format conversion.

## Project structure

| Path | Description |
|------|-------------|
| `BroadlinkManager/` | Windows Forms desktop app (.NET Framework 4.6.2, Syncfusion UI) |
| `SharpBroadlink/` | Broadlink protocol library (.NET Standard 2.0): discovery, auth, device classes, signal conversion |
| `ConsoleTest/` | .NET Core 2.0 console app with sample and test calls into SharpBroadlink |
| `BroadlinkManager.sln` | Visual Studio solution with all three projects |

## Known limitations

- **Send IR**, **Learn RF**, **Send RF** and **Cancel Learning** are not yet wired to any
  action.
- Learned codes are not saved. They exist only in the output log.
- Learn IR waits a short, fixed time (about two seconds) for the button press and does not
  retry. If no code was captured, the action fails without a message in the log.
- Discovery uses a local broadcast, so devices on other subnets or VLANs are not found.

## Credits

- [SharpBroadlink](https://github.com/ume05rw/SharpBroadlink) by ume05rw (Do-Be's). The
  library in `SharpBroadlink/` is taken from that project, which is a C# port of
  python-broadlink. See its [license](https://github.com/ume05rw/SharpBroadlink/blob/master/LICENSE).
- [python-broadlink](https://github.com/mjg59/python-broadlink) by Matthew Garrett, the original
  protocol implementation.
- [Syncfusion Essential Studio](https://www.syncfusion.com/) for the Windows Forms UI controls.

## Contributing

Issues and pull requests are welcome. The easiest place to start is wiring the unused toolbar
buttons (Send IR, Learn RF, Send RF, Cancel Learning) to the SharpBroadlink methods above.

## License

This project is licensed under the Apache License 2.0. See [License](License).
