# DiskWakeUp

DiskWakeUp is a small C# console utility designed to keep your hard drive awake by regularly updating a temporary file.

## Why?

Some hard drives, such as Western Digital Black models, tend to spin down after a few minutes of inactivity. This can cause delays when accessing the disk. DiskWakeUp prevents that by simulating periodic activity.

## How It Works

The program creates (if it doesn't exist) a file named `WakeUp.tmp` in a specified folder and updates its last modified timestamp at regular intervals.

## Usage

```bash
DiskWakeUp.exe "path\to\drive" 60
