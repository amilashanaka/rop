#include <SoftwareSerial.h>
#include <LiquidCrystal.h>
#define Vref 4.95

SoftwareSerial sms(2,3); // RX | TX
const int port1=8;
const int port2=9;
const int gsmpow=10;
const int aCpow=5;
const int buzz=7;
int sensorValue = 0;
int sensorPHValue;
int m;
long sensorSum;
int i =0;
String msg="";
String cmd="";
LiquidCrystal lcd(4,13,A2,A3,A4,A5);
void setup() 
{
   for(int i=0; i<300; i++) 
      {
           digitalWrite(buzz, HIGH);
           delay(5);
           digitalWrite(buzz, LOW);
      }
     pinMode(aCpow, INPUT_PULLUP);
     Serial.begin(2400);
     sms.begin(2400); 

     pinMode(port1, OUTPUT);
     pinMode(port2, OUTPUT);
     pinMode(buzz,OUTPUT);
     pinMode(gsmpow, OUTPUT);  
     digitalWrite(gsmpow, HIGH);
     lcd.begin(16, 2);
     lcd.setCursor(5, 0);
     lcd.print("Welcome");
     delay(1000);
     lcd.clear();
     lcd.setCursor(1, 0);
     lcd.print("SMS Gatway");
     lcd.setCursor(5, 1);
     lcd.print("Starting..");
     delay(1000);
     lcd.clear();
     sensorPHValue = analogRead(A1);
     Serial.println(7-1000*(sensorPHValue-372)*Vref/59.16/1023);
     
     if(sensorValue<350)
     {
        gsmPower();
        lcd.clear();
        lcd.setCursor(1, 0);
        lcd.print("Power On GSM ");
     }
     else
     {
       Serial.println(sensorValue);
     }

     delay(1000);
     sms.print("at+ifc=1\r");
     while(sms.available())
    {  
        Serial.write(sms.read());
    }
      
      
    for(int i=0;i<3;i++)
     {
        lcd.clear();
       lcd.setCursor(1, 0);
       lcd.print("Clear MSG :");
       lcd.print(i);
      delsms();   
    }  

   
}
 
void loop()
{
 sensorPHValue = analogRead(A1);
     Serial.println(7-1000*(sensorPHValue-372)*Vref/59.16/1023);

     delay(2000);
//    lcd.clear();
//     lcd.setCursor(1, 0);
//     lcd.print("GSM  RO  PLANT");
//       lcd.setCursor(5, 1);
//     lcd.print("START");
//  sensorValue = analogRead(A0);
//     if(sensorValue<350)
//     {
//        gsmPower();
//        lcd.clear();
//        lcd.setCursor(1, 0);
//        lcd.print("Power On GSM ");
//     }
//    readSms();
  // if( digitalRead(aCpow))
   //{
    // Serial.println( "Ac Power ON ");
    // lcd.clear();
    // lcd.setCursor(1, 0);
    // lcd.print("Ac Power OK");  
   //}
  // else
  // {
    // Serial.println( "Ac Power OFF");
      

         // lcd.clear();
         // lcd.setCursor(1, 0);
         // lcd.print("Ac Power OFF"); 
  // }
 
// 
//   delay(300);
//     while(Serial.available())
//    {
//        sms.write(Serial.read());
//    }
}
void sendSmsOn()
{
  delay(1000);
  sms.print("AT+CMGF=1\r");    
  while(sms.available())
    {  
        Serial.write(sms.read());
    }
  delay(500);
  sms.println("AT + CMGS =\"+94769840923\""); 
   while(sms.available())
    {  
        Serial.write(sms.read());
    }  
  delay(500);
  sms.println(",on,");
  lcd.clear();
  lcd.setCursor(1, 0);
  lcd.print("Send Reply ON"); 
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
void sendSmsOff()
{
  delay(1000);
  sms.print("AT+CMGF=1\r");    
  if (sms.available())
    {  
        Serial.write(sms.read());
    }
  delay(500); 
  sms.println("AT + CMGS =\"+94769840923\""); 
   while(sms.available())
    {  
        Serial.write(sms.read());
    }  
  delay(500);
  sms.println(",off,");
  sms.write(0x1A);
  lcd.clear();
  lcd.setCursor(1, 0);
  lcd.print("Send Reply Off"); 
  while(sms.available())
    {  
        Serial.write(sms.read());
    }
  delay(500);
 
  if (sms.available())
    {  
        Serial.write(sms.read());
    } 
  delay(500);
  Serial.write("send");
}
void readSms()
{
    sms.print("AT+CMGR=1");
    sms.write(0x0D);
    sms.write(0x0A); 
    msg=sms.readString();
   // Serial.println(msg);
    cmd=msg.substring(73,79);
    Serial.println(cmd);
  if((cmd.equals("1*2#on")))
  {
     digitalWrite(port1,HIGH);
     Serial.println("LED On");
     lcd.clear();
     lcd.setCursor(1, 0);
     lcd.print("Power ON");
     delsms();
     sendSmsOn();

      for(int i=0; i<800; i++) 
      {
           digitalWrite(buzz, HIGH);
           delay(5);
           digitalWrite(buzz, LOW);
      }

       lcd.clear();
     lcd.setCursor(1, 0);
     lcd.print("Power ON");
  }
  
  if(cmd.equals("1*2#ff"))
  {
      digitalWrite(port1,LOW);
      Serial.println("LED Off");
      lcd.clear();
      lcd.setCursor(1, 0);
      lcd.print("POWER OFF");
      delsms();
      sendSmsOff();

      
      for(int i=0; i<20; i++) 
      {
           digitalWrite(buzz, HIGH);
           delay(5);
           digitalWrite(buzz, LOW);
      }

      lcd.clear();
      lcd.setCursor(1, 0);
      lcd.print("POWER OFF");

      delay(3000);
      
      for(int i=0; i<20; i++) 
      {
           digitalWrite(buzz, HIGH);
           delay(5);
           digitalWrite(buzz, LOW);
      }
  }

   

}

void delsms()
{
   sms.print("AT+CMGD=1");
   sms.write(0x0D);
   sms.write(0x0A);
   while(sms.available())
    {  
        Serial.write(sms.read());
    }

    Serial.println("dell sms");
    delay(1000); 
}



void gsmPower()
{
  delay(1000);
  digitalWrite(gsmpow, LOW);
  delay(1000);
  digitalWrite(gsmpow, HIGH);
  delay(2000);
}



