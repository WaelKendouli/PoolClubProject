# Pool Club Timer & Billing System

A sophisticated Windows Forms application built with C# and the .NET Framework. This system manages pool table sessions by tracking play time, calculating fees in real-time, and notifying players with a detailed summary at the end of each game through custom C# events.

## Features

- **Real-Time Session Tracking:** Accurately tracks the duration of each pool game in hours, minutes, and seconds.
- **Dynamic Cost Calculation:** Automatically calculates the total fees based on a configurable hourly rate.
- **Event-Driven Architecture:** Utilizes custom C# events to decouple the timer logic from the UI, promoting clean and maintainable code.
- **Modular User Controls:** Key components like the timer display and control buttons are built as reusable User Controls.
- **Player Notification:** Upon game completion, a clear event-driven message box informs players of:
    - Total Play Time (formatted as HH:MM:SS)
    - Total Play Time in Seconds
    - Applied Hourly Rate
    - Total Fees Incurred

## Technology Stack

- **Language:** C#
- **Framework:** .NET Framework (WinForms)
- **Key Concepts:** User Controls, Custom Events, Event Handlers, DateTime Manipulation

## How It Works

1.  **Start a Session:** A player starts the timer for their game.
2.  **Live Calculation:** The backend timer logic runs, continuously calculating the elapsed time and updating the total fee.
3.  **End a Session:** The player ends the game.
4.  **Event Trigger:** Ending the game raises a custom event (e.g., `GameEnded`).
5.  **Notification:** A subscriber to this event (e.g., the main form) catches it and displays a summary popup with all the session details.
6.  **Reset:** The system resets, ready for the next game.

## Getting Started

### Prerequisites

- Windows OS
- .NET Framework (version 4.7.2 or higher recommended)
- An IDE like Visual Studio 2019/2022

### Installation & Running

1.  Clone or download this repository.
2.  Open the solution file (`PoolClub.sln`) in Visual Studio.
3.  Build the solution (`Ctrl + Shift + B`).
4.  Run the project (`F5`).
