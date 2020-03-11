#include <SoftwareSerial.h>
#include <LiquidCrystal.h>
SoftwareSerial sms(2, 3); // RX | TX
const int port1 = 8;
const int port2 = 9;
const int gsmpow = 4;
const int aCpow = 5;
const int buzz = 7;
int sensorValue = 0;
int i = 0;
String msg = "";
String cmd = "";
LiquidCrystal lcd(4, A1, A2, A3, A4, A5);
int find_text(String needle, String haystack);

void setup()
{
  pinMode(aCpow, INPUT_PULLUP);
  Serial.begin(2400);
  sms.begin(2400);

  pinMode(port1, OUTPUT);
  pinMode(port2, OUTPUT);
  pinMode(buzz, OUTPUT);
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
  sensorValue = analogRead(A0);
  Serial.println(sensorValue);

  if (sensorValue < 350)
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
  while (sms.available())
  {
    Serial.write(sms.read());
  }

  for (int i = 0; i < 2; i++)
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
  if (digitalRead(aCpow))
  {
    lcd.clear();
    lcd.setCursor(3, 0);
    lcd.print("Ac Power ON");
  }
  else
  {
    digitalWrite(buzz, HIGH);
    delay(1000);
    digitalWrite(buzz, LOW);

    lcd.clear();
    lcd.setCursor(1, 0);
    lcd.print("Ac Power OFF");
  }

  sensorValue = analogRead(A0);
  if (sensorValue < 350)
  {
    gsmPower();
    lcd.clear();
    lcd.setCursor(1, 1);
    lcd.print("GSM OFF");
  }
  else
  {
    lcd.setCursor(2, 1);
    lcd.print(">>  GSM ON  <<");
  }

  readSms();
  delay(300);

  while (Serial.available())
  {
    sms.write(Serial.read());
  }
}

void sendSmsOn()
{
  delay(1000);
  sms.print("AT+CMGF=1\r");

  while (sms.available())
  {
    Serial.write(sms.read());
  }
  delay(500);
  sms.println("AT + CMGS =\"+94771032246\"");
  while (sms.available())
  {
    Serial.write(sms.read());
  }
  delay(500);

  sms.println(",on,");
  sms.write(0x1A);
  sms.write(0x1A);
  lcd.clear();
  lcd.setCursor(1, 0);
  lcd.print("Send Reply ON");
  while (sms.available())
  {
    Serial.write(sms.read());
  }
  delay(500);

  sms.write(0x1A);
  while (sms.available())
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
  while (sms.available())
  {
    Serial.write(sms.read());
  }
  delay(500);

  sms.println("AT + CMGS =\"+94771032246\"");
  while (sms.available())
  {
    Serial.write(sms.read());
  }
  delay(500);
  sms.println(",off,");
  sms.write(0x1A);
  lcd.clear();
  lcd.setCursor(1, 0);
  lcd.print("Send Reply Off");
  while (sms.available())
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
  msg = sms.readString();
  int a = find_text("1*2#on", msg);
  Serial.print("POS");
  Serial.println(a);
  cmd = msg.substring(a, a + 6);
  Serial.println(cmd);

  if ((cmd.equals("1*2#on")))
  {
    digitalWrite(port1, HIGH);
    for (int i = 0; i < 100; i++)
    {
      digitalWrite(buzz, HIGH);
      delay(10);
      digitalWrite(buzz, LOW);
      delay(10);
    }
    lcd.clear();
    lcd.setCursor(1, 0);
    lcd.print("Power ON");
    delsms();
    sendSmsOn();
  }

  int b = find_text("1*2#ff", msg);
  Serial.print("POS");
  Serial.println(b);

  cmd = msg.substring(b, b + 6);
  Serial.println(cmd);
  if (cmd.equals("1*2#ff"))
  {
    digitalWrite(port1, LOW);
    // Serial.println("LED Off");
    for (int i = 0; i < 50; i++)
    {
      digitalWrite(buzz, HIGH);
      delay(10);
      digitalWrite(buzz, LOW);
      delay(10);
    }
    lcd.clear();
    lcd.setCursor(1, 0);
    lcd.print("POWER OFF");

    delsms();

    sendSmsOff();
  }


}

void delsms()
{
  sms.print("AT+CMGD=1");
  sms.write(0x0D);
  sms.write(0x0A);
  while (sms.available())
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
  delay(2000);
  digitalWrite(gsmpow, HIGH);
  delay(2000);
}

int find_text(String needle, String haystack) {
  int foundpos = -1;
  for (int i = 0; i <= haystack.length() - needle.length(); i++) {
    if (haystack.substring(i, needle.length() + i) == needle) {
      foundpos = i;
    }
  }
  return foundpos;
}


