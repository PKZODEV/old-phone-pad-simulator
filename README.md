# 📱 Old Phone Pad Typing Simulation

A simple C# console app that simulates typing on old-school mobile phone keypads (like Nokia).  
The idea is: press the same digit multiple times to cycle through letters, just like before smartphones.

## 🎯 Features

- Old-style keypad mapping (2 = ABC, 3 = DEF, etc.)
- Supports multi-tap input
- `*` = backspace
- `#` = send / end
- space = separate same digit (pause)

## 🔢 Keypad Layout

1 → &,( 2 → ABC 3 → DEF
4 → GHI 5 → JKL 6 → MNO
7 → PQRS 8 → TUV 9 → WXYZ
0 → (space) * → backspace # → end

kotlin
Copy
Edit

## 🚀 How to Run

1. Make sure you have .NET 8.0 or newer
2. Clone or download this repo
3. Run this in terminal:

```bash
dotnet run
I just use Console.WriteLine() to test. You can add your own input later if needed.

📝 Example Usage
csharp
Copy
Edit
OldPhonePad("33#");                      // Output: "E"
OldPhonePad("227#");                     // Output: "B"
OldPhonePad("4433555 555666#");          // Output: "HELLO"
OldPhonePad("8 88777444666*664#");       // Output: "TURING"
🧠 How It Works
Press same key many times → pick character from that group

Use ' ' (space) → to separate same key

Use * to backspace one char (after translate)

Always end with # to process final sequence

🔧 Code Details (in short)
Used Dictionary<char, string> for key mapping

Used StringBuilder for output and buffer (faster than string concat)

Translate each group of same digit

Clear buffer after each group

Flush buffer before backspace

Not using try-catch or advanced stuff — just keep it simple and readable

Some parts can be cleaner, but I prefer this way because it’s easier to follow (for me and maybe for other devs too)

🧪 Basic Test Ideas
33# → E

7777# → S

44*33# → E (type H, backspace, then E)

222 2 22# → CAB

0000# → space

9 999 9999# → WZY

Thanks for reviewing this 🙏