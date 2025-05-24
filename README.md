
# Smart Attendance System 

This is a mini IoT project that automates student attendance tracking using an Arduino Uno, RFID reader, buzzer, and MYSQL Database. It eliminates the need for manual attendance by detecting student ID cards and storing attendance records.



## ⚙️ Tech Stack

**Front-end:** WinForm, .Net, C#

**Back-end:** MYSQL, SSMS

**Hardware:** 
- **Arduino Uno** – Main microcontroller for connecting sensors
- **RFID Reader (RC522)** – For reading RFID tags (student ID cards)
- **RFID Tags** – Assigned to each student for identification
- **Buzzer** – Feedback signal when a tag is scanned
- **Breadboard & Jumper Wires**

## ⚙️ Features

- Automated attendance tracking
- Unique identification via RFID tags
- Audible confirmation with buzzer
- Compact and easy-to-install system

## 🛠️ How It Works

-  Student taps RFID tag on the RFID reader.
-  RFID reader reads the tag and verifies it.
-  A buzzer sounds to confirm a valid scan.
-  Attendance is marked and sent to MYSQL Database.
-  Duplicate entries are prevented (only one record per day per student)


## 📅 Future Enhancements
Software dashboard to visualize attendance

Email/SMS notifications to parents

Biometric + RFID multi-authentication

