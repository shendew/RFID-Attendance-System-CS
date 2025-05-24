/*
 * -----------------------------------------------------------------------------------------
 *             MFRC522      Arduino       Arduino   Arduino    Arduino          Arduino
 *             Reader/PCD   Uno/101       Mega      Nano v3    Leonardo/Micro   Pro Micro
 * Signal      Pin          Pin           Pin       Pin        Pin              Pin
 * -----------------------------------------------------------------------------------------
 * RST/Reset   RST          9             5         D9         RESET/ICSP-5     RST
 * SPI SS      SDA(SS)      10            53        D10        10               10
 * SPI MOSI    MOSI         11 / ICSP-4   51        D11        ICSP-4           16
 * SPI MISO    MISO         12 / ICSP-1   50        D12        ICSP-1           14
 * SPI SCK     SCK          13 / ICSP-3   52        D13        ICSP-3           15
 */

#include <SPI.h>
#include <MFRC522.h>

#define SS_PIN 10
#define RST_PIN 9

#define restPin = 2;  // the number of the pushbutton pin
//#define buzzer = 7; //buzzer to arduino pin 9

MFRC522 rfid(SS_PIN, RST_PIN); // Instance of the class

// Init array that will store new NUID 
byte nuidPICC[4];

void setup() { 
  Serial.begin(9600);
  pinMode(2,INPUT_PULLUP);
  pinMode(7, OUTPUT); // Set buzzer - pin 9 as an output

  SPI.begin(); // Init SPI bus
  rfid.PCD_Init(); // Init MFRC522 

}
 
void loop() {

  if(digitalRead(2)){
    nuidPICC[0] = 0;
    nuidPICC[1] = 0;
    nuidPICC[2] = 0;
    nuidPICC[3] = 0;
  }

  // Reset the loop if no new card present on the sensor/reader. This saves the entire process when idle.
  if ( ! rfid.PICC_IsNewCardPresent())
    return;

  // Verify if the NUID has been readed
  if ( ! rfid.PICC_ReadCardSerial())
    return;

  MFRC522::PICC_Type piccType = rfid.PICC_GetType(rfid.uid.sak);

  // Check is the PICC of Classic MIFARE type
  if (piccType != MFRC522::PICC_TYPE_MIFARE_MINI &&  
    piccType != MFRC522::PICC_TYPE_MIFARE_1K &&
    piccType != MFRC522::PICC_TYPE_MIFARE_4K) {
    return;
  }

  if (rfid.uid.uidByte[0] != nuidPICC[0] || 
    rfid.uid.uidByte[1] != nuidPICC[1] || 
    rfid.uid.uidByte[2] != nuidPICC[2] || 
    rfid.uid.uidByte[3] != nuidPICC[3] ) {

    // Store NUID into nuidPICC array
    for (byte i = 0; i < 4; i++) {
      nuidPICC[i] = rfid.uid.uidByte[i];
    }
   
    
    printDec(rfid.uid.uidByte, rfid.uid.size);
    
  }
  

  // Halt PICC
  rfid.PICC_HaltA();

  // Stop encryption on PCD
  rfid.PCD_StopCrypto1();
  delay(2000)
}



void printHex(byte *buffer, byte bufferSize) {
  for (byte i = 0; i < bufferSize; i++) {
    Serial.print(buffer[i] < 0x10 ? " 0" : " ");
    Serial.print(buffer[i], HEX);
  }
}

void printDec(byte *buffer, byte bufferSize) {
  
  for (byte i = 0; i < bufferSize; i++) {
    Serial.print(buffer[i], DEC);
  }
  tone(7, 1000); // Send 1KHz sound signal...
  delay(1000);        // ...for 1 sec
  noTone(7);     // Stop sound...
  delay(1000);        // ...for 1sec
}
