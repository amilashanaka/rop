
 
#include <SoftwareSerial.h>
SoftwareSerial sms(2,3); // RX | TX
const int buttonPin = 7;  
int buttonState = 0;
void setup() 
{
    Serial.begin(2400);
    sms.begin(2400); 
     pinMode(buttonPin, INPUT); 
     
}

 
void loop()
{
  readSms();
   if (sms.available())
    {  
      Serial.write(sms.read());
       
    }
    buttonState = digitalRead(buttonPin);
     if (buttonState == HIGH) {
          Serial.println("button on");
          
          delay(2000);
    }

}
void sendSms()
{
  sms.print("AT+CMGF=1\r");    
  if (sms.available())
    {  
        Serial.write(sms.read());
    }
  delay(500);
  Serial.println("1");
  sms.println("AT + CMGS =\"+94772679088\""); 
   if (sms.available())
    {  
        Serial.write(sms.read());
    }  
  delay(500);
  Serial.write("2");
  sms.println(",on,");
  
   if (sms.available())
    {  
        Serial.write(sms.read());
    }
  delay(500);
  sms.write(0x1A);
  if (sms.available())
    {  
        Serial.write(sms.read());
    } 
  delay(500);
  Serial.write("send");
}

void readSms()
{
   String msg="";
  delay(500);
   sms.println("AT+CMGF=1");    
   for(int i=0;i<20;i++)
  { 
  if (sms.available())
    {  
        Serial.write(sms.read());
    }
    
    }
  delay(1000);
  sms.print("AT+CMGR=1"); 
 for(int i=0;i<1000;i++)
  { 
    if (sms.available())
      {  
        Serial.print((char)sms.read());
      }
    
  }
  delay(15000);
  // sms.println("AT+CMGD=1"); 
 for(int i=0;i<10;i++)
{ 
  if (sms.available())
    {  
      Serial.write(sms.read());
       
    }
    
}
      delay(5000);
}
