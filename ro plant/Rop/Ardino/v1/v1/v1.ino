
 
#include <SoftwareSerial.h>
SoftwareSerial sms(2,3); // RX | TX
const int buttonPin = 7; 
const int led=9;
const int power=10;
int buttonState = 0;
 int i =0;
 String msg="";
 String cmd="";
void setup() 
{
    Serial.begin(2400);
    sms.begin(2400); 
     pinMode(buttonPin, INPUT); 
     pinMode(led, OUTPUT);
     pinMode(power, OUTPUT);  
     delay(1000);
     gsmPower();
     delay(1000);
     sms.print("at+ifc=1\r");  
     
    // readSms();
     
      
   
}
 
void loop()
{
  
  //readSms();
   readSms();
         
          delay(300);
   if (sms.available())
    {  
      Serial.write(sms.read());
       
    }
    else
    {
       
      
    }
     if (Serial.available())
    {
        sms.write(Serial.read());
    }
    buttonState = digitalRead(buttonPin);
     if (buttonState == HIGH) {
          Serial.println("button on");
          //sendSms();
          delsms();
         
    }
    
    

}
void sendSms()
{
  delay(1000);
  sms.print("AT+CMGF=1\r");    
  if (sms.available())
    {  
        Serial.write(sms.read());
    }
  delay(500);
  Serial.println("1");
  sms.println("AT + CMGS =\"+94777548249\""); 
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
   
   
    // delay(500);
   //sms.println("AT+IFC=1");    
  // for(int i=0;i<20;i++)
 // { 
 // if (sms.available())
   // {  
      //  Serial.write(sms.read());
    //}
    
 // }
   
  //delay(500);
  // sms.println("AT+CMGF=1");    
   //for(int i=0;i<20;i++)
 // { 
 // if (sms.available())
   // {  
    //    Serial.write(sms.read());
    //}
    
 // }
  //delay(1000);
  sms.print("AT+CMGR=1");
 sms.write(0x0D);
sms.write(0x0A); 
msg=sms.readString();

cmd=msg.substring(75,81);

Serial.println(msg);
Serial.println(cmd.equals("1*2#on"));
  if((cmd.equals("1*2#on")))
  {
     digitalWrite(led,HIGH);
     Serial.println("LED On");
     delsms();
  }
  
  if(cmd.equals("1*2off"))
  {
     digitalWrite(led,LOW);
      Serial.println("LED Off");
      delsms();
  }

 //if(StringContains(msg.)>0)
 //{
 // 
   
 //}
 
 
 //for(int i=0;i<1000;i++)
//  {   
       // Serial.print((char)sms.read());
//}
  //delay(15000);
  // sms.println("AT+CMGD=1"); 
// for(int i=0;i<10;i++)
//{ 
 // if (sms.available())
  //  {  
    //  Serial.write(sms.read());
       
   // }
    
//}
     // delay(5000);
}

void delsms()
{
   sms.print("AT+CMGD=1");
   sms.write(0x0D);
   sms.write(0x0A); 
}


int find_text(String needle, String haystack) {
  int foundpos = -1;
  for (int i = 0; (i < haystack.length() - needle.length()); i++) {
    if (haystack.substring(i,needle.length()+i) == needle) {
      foundpos = i;
    }
  }
  return foundpos;
}


void gsmPower()
{
  digitalWrite(power, LOW);
  delay(1000);
  digitalWrite(power, HIGH);
  delay(5000);
}



